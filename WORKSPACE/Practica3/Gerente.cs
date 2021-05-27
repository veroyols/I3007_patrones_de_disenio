/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 26/5/2021
 * Hora: 19:02
 * 
 */
using System;
using System.Collections.Generic;

namespace Practica3 {
	
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
		
		private List<Observado> observados = new List<Observado>();
		
		public void quitarObservado(Observado observado) {
			observados.Remove(observado);
		}
		
		public void agregarObservado(Observado observado) {
			observados.Add(observado);
		}
		
		public void notificar() {
			return; //jornada de ventas
		}

		
		public static void ventas (Coleccionable<Comparable> vendedores) {
			Iterador iteradorDeColeccion = vendedores.crearIterador();
			GeneradorDeDatosAleatorio generador = new GeneradorDeDatosAleatorio();
			Gerente gerente = new Gerente();
			while(!iteradorDeColeccion.fin()){
				int monto = generador.numeroAleatorio(6999);
				((Vendedor)iteradorDeColeccion.actual()).venta(monto+1);
				gerente.venta(monto,((Vendedor)iteradorDeColeccion.actual()));
				iteradorDeColeccion.siguiente();
			}
		}
	}
}
