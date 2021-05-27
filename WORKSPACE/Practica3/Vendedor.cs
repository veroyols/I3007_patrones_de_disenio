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
	
	public class Vendedor : Persona { 
		
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
		
//		public void actualizar(this) {
//			return;
//		}		
		
		public void venta (int monto) {
			Console.WriteLine("Ha vendido ${0}",monto);
		}
		
		public void aumentaBonus () {
			bonus+=0.1;	
		}				
		
		public override string ToString() {
			return string.Format(">> {0} DNI {1} (Sueldo ${2}, Bonus: {3}) - Compara por {4}", getNombre, getDni, sueldoBasico, bonus, estrategia);
		}
	}		
}
