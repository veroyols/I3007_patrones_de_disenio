/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 25/5/2021
 * Hora: 19:16
 * 
 */
using System;

namespace Practica3 {
	
	class Program {
		
		public static void Main(string[] args) {
							
//			Informe.informar(diccionario, queComparable);//diccionario.contiene(comparable) devuelve false		
	
			Coleccionable<Comparable> coleccion = new Pila();
			int opción_para_crear_vendedores = 3;
			llenar(coleccion, opción_para_crear_vendedores);
			Gerente gerente = new Gerente();
			//hacer que gerente sea observador de todos los vendedores
			//gerente.agregarObservado(vendedor);
			jornadaDeVentas(coleccion);
			gerente.cerrar();
			imprimirElementos(gerente.getMejores);
						
			Console.WriteLine("...");
			Console.ReadKey(true);
		}		

		public static void llenar(Coleccionable<Comparable> coleccion, int queComparable){ 
			Iterador iteradorDeColeccion = coleccion.crearIterador();
			for (int i = 0; i < 20; i++) { //E6
				coleccion.agregar(FabricaDeComparables.crearAleatorio(queComparable));
				iteradorDeColeccion.siguiente();			
			}
		}//E7
		
		
		public static void imprimirElementos (Coleccionable<Comparable> coleccionable) {
			Console.WriteLine("------------------------"); 		
			Console.WriteLine("---Imprimir Elementos---");
			Iterador IteradorDeColeccion = coleccionable.crearIterador();
			Console.WriteLine("Imprimir {0} ",coleccionable);
			while(!IteradorDeColeccion.fin()){
				Console.WriteLine(IteradorDeColeccion.actual());
				IteradorDeColeccion.siguiente();
			}
		}
		
		public static void imprimirMejorPromedio (Coleccionable<Comparable> coleccionable) {
			cambiarEstrategia(coleccionable, new PorPromedio());
			Console.WriteLine("-----------------------"); 
			Console.WriteLine("---Mejores Promedios---");
			Iterador IteradorDeColeccion = coleccionable.crearIterador();
			Console.WriteLine("Imprimir {0} ",coleccionable);
			while(!IteradorDeColeccion.fin()){
				if (((Alumno)IteradorDeColeccion.actual()).sosMayor(new Alumno("",0,0,7 ) ) ) {
					Console.WriteLine(IteradorDeColeccion.actual());
				}
				IteradorDeColeccion.siguiente();
			}
		}		
		public static void cambiarEstrategia (Coleccionable<Comparable> coleccion, EstrategiaDeComparacion estrategia) {
			Iterador IteradorDeColeccion = coleccion.crearIterador();
			while(!IteradorDeColeccion.fin()){
				((Persona)IteradorDeColeccion.actual()).getEstrategia = estrategia;
				IteradorDeColeccion.siguiente();
			}	
		}
		public static void jornadaDeVentas (Coleccionable<Comparable> vendedores) {
			for (int i = 0; i < 20; i++) {
				Gerente.ventas(vendedores);
			}
		}
	}
}