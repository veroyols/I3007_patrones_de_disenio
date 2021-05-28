/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 26/5/2021
 * Hora: 19:58
 * 
 */
using System;
using System.Collections.Generic;

namespace _Observer {
	
	public interface Observador { 
		void actualizar(Observado observado, int monto); //ventas 
	} //gerente

	public interface Observado { 
		void agregarObservador(Observador observador);
		void notificar(int monto); //jornada de ventas
		//list
	} //vendedor	

	public class Gerente : Observador  {
		
		public List<Observado> mejores = new List<Observado>();
		
		public void actualizar(Observado VendObservado, int monto){
			this.venta(monto,((Vendedor)VendObservado)); 
		}
		
		public void cerrar () { 
			Console.WriteLine("MEJORES VENDEDORES");
		}
		
		public void venta (int monto, Vendedor vendedor) {
			if (monto > 5000) {
				if ((mejores.Count == 0) || (!mejores.Contains(vendedor))) {
					mejores.Add(vendedor);
				}
				vendedor.aumentaBonus();
			}
		}	
	}

	public class Vendedor : Observado { 
		
		private int sueldoBasico;
		private double bonus;
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
		
		public int getSueldoBasico {
			get { return sueldoBasico;}
			set { sueldoBasico = value;}
		} 
		public double getBonus {
			get { return bonus;}
			set { bonus = value;}
		}		
	}
}