/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 26/5/2021
 * Hora: 19:02
 * 
 */
using System;
using System.Collections.Generic;

namespace Practica7 {
	
	public class Gerente : Observador  {
		
		private Coleccionable<Comparable> mejores = new Pila();
		public Coleccionable<Comparable> getMejores {
			get { return mejores;}
			set { mejores = value;}
		} 
		
		public void cerrar () { //se ejecuta al final del día
			Console.WriteLine("\n------MEJORES VENDEDORES------");
			Informe.informar(mejores, 3); //3:vendedor
		}
		
		public void venta (int monto, Vendedor vendedor) {
			if (monto > 5000) {
				if ((mejores.cuantos() == 0) || (!mejores.contiene(vendedor))) {
					mejores.agregar(vendedor);
				}
				vendedor.aumentaBonus();
			}
		}
		public Gerente() {}
		
		public void actualizar(Observado VendObservado, int monto){
			this.venta(monto,((Vendedor)VendObservado)); 
		}
	}
}
