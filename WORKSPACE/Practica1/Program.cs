/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 14/4/2021
 * Hora: 20:26
 * 
 */
using System;
using System.Collections.Generic;

namespace Practica1
{
	class Program
	{
		private static Random unicoRandomGlobal = new Random(); 	/*La forma más segura de generar valores random únicos es crear una única   
																	instancia en la clase Program. Eventualmente se puede pasar esa instancia  
																	como parámetro a la clase que necesite elegir valores únicos. */
		public static void Main(string[] args) {	
			// TODO: Implement Functionality Here
			
			/*Ejercicio09*/
			Pila pilaNum = new Pila ();
			Cola colaNum = new Cola ();
			ColeccionMultiple multipleNum = new ColeccionMultiple (pilaNum, colaNum);
			llenarNumeros (pilaNum);
			llenarNumeros (colaNum);			
			informarGeneral(pilaNum);
			informarGeneral(colaNum); 
			informarGeneral(multipleNum);
			Console.ReadKey(true);
			Console.Clear();
			
			/*Ejercicio 13*/			
			Pila pilaPer = new Pila ();
			Cola colaPer = new Cola ();
			ColeccionMultiple multiplePer = new ColeccionMultiple (pilaPer, colaPer);
			llenarPersonas (pilaPer);
			llenarPersonas (colaPer);			
			informarGeneral(pilaPer);
			informarGeneral(colaPer); 
			informarGeneral(multiplePer);
			Console.ReadKey(true);
			Console.Clear();
			
			/*Ejercicio 17*/
			Pila pilaAl= new Pila ();
			Cola colaAl = new Cola ();
			ColeccionMultiple multipleAl = new ColeccionMultiple (pilaAl, colaAl);
			llenarAlumnos (pilaAl);
			llenarAlumnos (colaAl);			
			informarGeneral(pilaAl);
			informarGeneral(colaAl); 
			informarGeneral(multipleAl);
			
			Console.Write("\n Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static void informarGeneral (Coleccionable<Comparable> coleccionable) { //EJERCICIO6 / EJERCICIO13 informar coleccion de personas/numeros/alumnos
			Console.WriteLine("----------INFORME----------");
			Console.WriteLine("La {0} posee {1} elementos.", coleccionable.ToString(), coleccionable.cuantos());
			Console.WriteLine("Minimo >> " + (coleccionable.minimo()));
			Console.WriteLine("Maximo >> " + (coleccionable.maximo()));	
			
			if (((coleccionable.minimo()).GetType().Equals((new Persona()).GetType())) || ((coleccionable.minimo()).GetType().Equals((new Alumno()).GetType())))
				Persona.compararPorConsola(coleccionable); //ok
			if ((coleccionable.minimo()).GetType().Equals((new Numero()).GetType()))
				Numero.compararPorConsola(coleccionable); //ok
		}
		
		public static void llenarNumeros(Coleccionable<Comparable> coleccionable){ //EJERCICIO5
			for (int i = 0; i < 20; i++) {
				coleccionable.agregar(new Numero (unicoRandomGlobal.Next(1,99)));
			}
		}	
				
		public static void llenarPersonas(Coleccionable<Comparable> coleccionable){ //EJERCICIO12
			List<string> lista = new List<string> (20) {"Luz","Mar","Bea","Ana","Ema","Jua","Ale","Joa","Roy","Noe",
														"Ian","Paz","Sol","Luca","Car","Dem","Enzo","Ve","Gra","Deb",};
			for (int i = 0; i < 20; i++) { //nombre, dni
				coleccionable.agregar(new Persona (lista[(unicoRandomGlobal.Next(1,99))%20], (unicoRandomGlobal.Next(12000000,50000000))));
			}
		}		

		public static void llenarAlumnos(Coleccionable<Comparable> coleccionable){ //EJERCICIO12
			List<string> lista = new List<string> (20) {"Luz","Mar","Bea","Ana","Ema","Jua","Ale","Joa","Roy","Noe",
														"Ian","Paz","Sol","Luca","Car","Dem","Enzo","Ve","Gra","Deb",};
			for (int i = 0; i < 20; i++) { //nombre, dni
				coleccionable.agregar(new Alumno (lista[(unicoRandomGlobal.Next(1,99))%20],
				                                  (unicoRandomGlobal.Next(12000000,50000000)) ,
				                                  i+1,
				                                  (unicoRandomGlobal.Next(1,10))));
			}
		}
	}
}
