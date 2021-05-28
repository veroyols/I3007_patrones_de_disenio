/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 26/5/2021
 * Hora: 17:28
 * 
 */
using System;
using System.Collections.Generic;

namespace Practica3 {
	
	public class Vendedor : Persona, Observado { 
		
		private int sueldoBasico;
		private double bonus;
		
		public int getSueldoBasico {
			get { return sueldoBasico;}
			set { sueldoBasico = value;}
		} 
		public double getBonus {
			get { return bonus;}
			set { bonus = value;}
		}	
		public Vendedor() {
			this.estrategia = new PorBonus();
		}	
		public Vendedor(string n , int d, int s) : base (n,d) {
			this.sueldoBasico = s;
			this.bonus = 1;
			this.estrategia = new PorBonus();
		}
		//observer
		public List<Observador> observadores = new List<Observador>();		
		public void agregarObservador(Observador observador){
			observadores.Add(observador);
		}
		public void notificar(int monto) {
			foreach (Observador o in observadores) {
				o.actualizar(this, monto);
			} 
		}		
		
		public void venta (int monto) {
			Console.WriteLine("Ha vendido ${0}",monto);
			this.notificar(monto);
		}
		
		public void aumentaBonus () {
			bonus+=0.1;	
		}				
		
		public override string ToString() {
			return string.Format(">> {0} DNI {1} (Sueldo ${2}, Bonus: {3}) - Compara por {4}", getNombre, getDni, sueldoBasico, bonus, estrategia);
		}
	}		
}
