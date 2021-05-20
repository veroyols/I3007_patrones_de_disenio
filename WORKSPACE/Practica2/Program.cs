/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 27/4/2021
 * Hora: 22:44
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Practica2 {
	
	class Program {
		
		private static Random unicoRandomGlobal = new Random(); 	

		public static void Main(string[] args) {
			
			//E10
			EstrategiaDeComparacion estrategia = new PorDni();
			
			Pila pila = new Pila();
			Cola cola = new Cola();
			Conjunto conjunto = new Conjunto();
			Diccionario diccionario = new Diccionario();
			llenarAlumnos(pila, estrategia);
			llenarAlumnos(cola, estrategia);
			llenarAlumnos(conjunto, estrategia);
			llenarAlumnos(diccionario, estrategia);
			
			cambiarEstrategia(pila, new PorLegajo());
			Console.WriteLine(((Alumno)pila.minimo()).getEstrategia);
			imprimirElementos(pila);
			Console.ReadKey(true);
			
			Console.Clear();			
			cambiarEstrategia(cola, new PorLegajo());
			imprimirElementos(cola);
			Console.ReadKey(true);
			
			Console.Clear();
			cambiarEstrategia(conjunto, new PorLegajo());
			imprimirElementos(conjunto);
			Console.ReadKey(true);
			
			Console.Clear();
			//cambiarEstrategia(diccionario, new PorPromedio()); ERROR
			imprimirElementos(diccionario);
			Console.ReadKey(true);
			
			Console.Clear();
			ColeccionMultiple coleccionAl = new ColeccionMultiple (pila,cola);
			cambiarEstrategia(coleccionAl, new PorLegajo());
			imprimirMejorPromedio(coleccionAl); //E13

//			Diccionario diccionario = new Diccionario ();
//			diccionario.agregar(new Alumno ("Maria",50885165,1000,8.3, estrategia )); //nom, dni, legajo, promedio
//			Console.WriteLine(diccionario.valorDe(new Numero(20))); //diccionario.valorDe(C) --> V (devuelve Maria)	
			
			Console.Write("\n	. . . ");
			Console.ReadKey(true);
		}

		public static void llenarAlumnos(Coleccionable<Comparable> coleccionable, EstrategiaDeComparacion estrategia){ //EJERCICIO2
			List<string> lista = new List<string> (20) {"Luz","Mar","Bea","Ana","Ema","Jua","Ale","Joa","Roy","Noe",
														"Ian","Paz","Sol","Luca","Car","Dem","Enzo","Ve","Gra","Deb",};
			for (int i = 0; i < 20; i++) { //nombre, dni
				coleccionable.agregar(new Alumno (lista[(unicoRandomGlobal.Next(1,99))%20], //nombre
				                                  (unicoRandomGlobal.Next(12000000,50000000)) , //dni
				                                  i+1, //legajo
				                                  ((double)(unicoRandomGlobal.Next(1,1000))/100),// promedio
				                                  estrategia)); //estrategia
			}
		}

		public static void informarGeneral (Coleccionable<Comparable> coleccionable) { //EJERCICIO2
			Console.WriteLine("----------INFORME----------");
			Console.WriteLine("La {0} posee {1} elementos.", coleccionable.ToString(), coleccionable.cuantos());
			Console.WriteLine("Minimo >> " + (coleccionable.minimo()));
			Console.WriteLine("Maximo >> " + (coleccionable.maximo()));	
			(coleccionable.minimo()).compararPorConsola(coleccionable); //Falta Cargar Alumno por consola, compara con el minimo
		}
		
		public static void imprimirElementos (Coleccionable<Comparable> coleccionable) {
			Console.WriteLine("------------------------"); //EJERCICIO 6		
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
		
		public static void cambiarEstrategia (Coleccionable<Comparable> coleccion, EstrategiaDeComparacion estrategia) { //EJERCICIO 9
			Iterador IteradorDeColeccion = coleccion.crearIterador();
			while(!IteradorDeColeccion.fin()){
				((Alumno)IteradorDeColeccion.actual()).getEstrategia = estrategia;
				IteradorDeColeccion.siguiente();
			}	
		}
	}
}