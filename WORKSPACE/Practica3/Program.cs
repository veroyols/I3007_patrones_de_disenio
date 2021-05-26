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
				
			Pila pilaDeComparables = new Pila();
			Console.WriteLine("Llenar pila con: \n(1)ALUMNO \n(2)PERSONA \n(3)NUMERO \n(4)CLAVEVALOR");
			int queComparable = int.Parse(Console.ReadLine());
			llenar(pilaDeComparables, queComparable);
			informar(pilaDeComparables, queComparable);
			imprimirElementos(pilaDeComparables);
			Console.WriteLine("...");
			Console.ReadKey(true);
		}		

		public static void llenar(Coleccionable<Comparable> coleccionable, int queComparable){ 
			for (int i = 0; i < 20; i++) {
				coleccionable.agregar(FabricaDeComparables.crearAleatorio(queComparable));
			}
		}//E6
		
		public static void informar (Coleccionable<Comparable> coleccionable, int queComparable) { 
			Console.WriteLine("----------INFORME----------");
			Console.WriteLine("La {0} posee {1} elementos.", coleccionable.ToString(), coleccionable.cuantos());
			Console.WriteLine("Minimo >> " + (coleccionable.minimo()));
			Console.WriteLine("Maximo >> " + (coleccionable.maximo()));	
			Comparable comparable = FabricaDeComparables.crearPorTeclado(queComparable);
			if (coleccionable.contiene(comparable)) {
				Console.WriteLine("El elemento leído está en la colección");
			}
			else {
				Console.WriteLine("El elemento leído NO está en la colección");
			}
		}//E6
		
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
				((Alumno)IteradorDeColeccion.actual()).getEstrategia = estrategia;
				IteradorDeColeccion.siguiente();
			}	
		}		
	}
}