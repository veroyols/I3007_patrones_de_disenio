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
			
			Pila pilaAl = new Pila();
			EstrategiaDeComparacion estrategia = new PorDni();
			Cola colaAl = new Cola();
			ColeccionMultiple coleccionAl = new ColeccionMultiple (pilaAl,colaAl);
			llenarAlumnos(colaAl, estrategia);
			llenarAlumnos(pilaAl, estrategia);
//			informarGeneral(coleccionAl);
			
		
			Diccionario diccionario = new Diccionario ();
			diccionario.agregar(new Alumno ("Maria"));
			diccionario.valorDe(new Numero(0));
			
						
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}

		public static void llenarAlumnos(Coleccionable<Comparable> coleccionable, EstrategiaDeComparacion estrategia){ //EJERCICIO2
			List<string> lista = new List<string> (20) {"Luz","Mar","Bea","Ana","Ema","Jua","Ale","Joa","Roy","Noe",
														"Ian","Paz","Sol","Luca","Car","Dem","Enzo","Ve","Gra","Deb",};
			for (int i = 0; i < 20; i++) { //nombre, dni
				coleccionable.agregar(new Alumno (lista[(unicoRandomGlobal.Next(1,99))%20], //nombre
				                                  (unicoRandomGlobal.Next(12000000,50000000)) , //dni
				                                  i+1, //legajo
				                                  ((unicoRandomGlobal.Next(1,1000))/100),// promedio
				                                  estrategia)); //estrategia
			}
		}

		public static void informarGeneral (Coleccionable<Comparable> coleccionable) { //EJERCICIO2
			Console.WriteLine("----------INFORME----------");
			Console.WriteLine("La {0} posee {1} elementos.", coleccionable.ToString(), coleccionable.cuantos());
			Console.WriteLine("Minimo >> " + (coleccionable.minimo()));
			Console.WriteLine("Maximo >> " + (coleccionable.maximo()));	
			(coleccionable.minimo()).compararPorConsola(coleccionable);
		}
	}
}