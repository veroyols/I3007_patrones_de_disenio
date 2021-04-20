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
			informar(pilaNum);
			informar(colaNum); 
			informar(multipleNum);
			Console.ReadKey(true);
			
			/*Ejercicio 13*/			
			Pila pilaPer = new Pila ();
			Cola colaPer = new Cola ();
			ColeccionMultiple multiplePer = new ColeccionMultiple (pilaPer, colaPer);
			llenarPersonas (pilaPer);
			llenarPersonas (colaPer);			
			informar(pilaPer);
			informar(colaPer); 
			informar(multiplePer);
			Console.ReadKey(true);
			
			/*Ejercicio 17*/
			Pila pilaAl= new Pila ();
			Cola colaAl = new Cola ();
			ColeccionMultiple multipleAl = new ColeccionMultiple (pilaAl, colaAl);
			llenarAlumnos (pilaAl);
			llenarAlumnos (colaAl);			
			informar(pilaAl);
			informar(colaAl); 
			informar(multipleAl);

			Console.Write("\n Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static void informar (Coleccionable coleccionable) { //EJERCICIO6 / EJERCICIO13 informar coleccion de personas/numeros/alumnos
			Console.WriteLine("----------INFORME----------");
			Console.WriteLine("La {0} posee {1} elementos.", coleccionable.ToString(), coleccionable.cuantos());
			Console.WriteLine("Minimo >> " + (coleccionable.minimo()));
			Console.WriteLine("Maximo >> " + (coleccionable.maximo()));
		}
		
		public static void llenarNumeros(Coleccionable coleccionable){ //EJERCICIO5
			for (int i = 0; i < 20; i++) {
				coleccionable.agregar(new Numero (unicoRandomGlobal.Next(1,99)));
			}
			Console.WriteLine("Se ha llenado la coleccion. ");
		}	
				
		public static void llenarPersonas(Coleccionable coleccionable){ //EJERCICIO12
			List<string> lista = new List<string> (20) {"Luz","Mar","Bea","Ana","Ema","Jua","Ale","Joa","Roy","Noe",
														"Ian","Paz","Sol","Luca","Car","Dem","Enzo","Ve","Gra","Deb",};
			for (int i = 0; i < 20; i++) { //nombre, dni
				coleccionable.agregar(new Persona (lista[(unicoRandomGlobal.Next(1,99))%20], (unicoRandomGlobal.Next(12000000,50000000))));
			}
			Console.WriteLine("Se ha llenado la coleccion. ");
		}		

		public static void llenarAlumnos(Coleccionable coleccionable){ //EJERCICIO12
			List<string> lista = new List<string> (20) {"Luz","Mar","Bea","Ana","Ema","Jua","Ale","Joa","Roy","Noe",
														"Ian","Paz","Sol","Luca","Car","Dem","Enzo","Ve","Gra","Deb",};
			for (int i = 0; i < 20; i++) { //nombre, dni
				coleccionable.agregar(new Alumno (lista[(unicoRandomGlobal.Next(1,99))%20],
				                                  (unicoRandomGlobal.Next(12000000,50000000)) ,
				                                  i+1,
				                                  (unicoRandomGlobal.Next(0,10))));
			}
			Console.WriteLine("Se ha llenado la coleccion. ");
		}

		public static void imprimirNumeros(Coleccionable coleccionable) {
			if ((coleccionable.GetType()).Equals(new Pila().GetType())) { //comparo si es pila
				Console.WriteLine("Valores de la Pila: ");
				for (int i = 0; i < coleccionable.cuantos(); i++) {
					int a = ((Numero)((Pila)coleccionable).Elementos[i]).getValor; //para pila
					Console.Write(a + " - ");
				}			
			}
			else {
				Console.WriteLine("Valores de la Cola: ");
				for (int i = 0; i < coleccionable.cuantos(); i++) {
					int a = ((Numero)((Cola)coleccionable).Elementos[i]).getValor; 
					Console.Write(a + " - ");
				}	
			}
		}
		public static void imprimirPersonas(Coleccionable coleccionable) {
			if ((coleccionable.GetType()).Equals(new Pila().GetType())) { //comparo si es pila
				Console.WriteLine("Personas en la Pila: ");
				for (int i = 0; i < coleccionable.cuantos(); i++) 
					Console.WriteLine(((Persona)((Pila)coleccionable).Elementos[i]).getNombre + ">> " + ((Persona)((Pila)coleccionable).Elementos[i]).getDni);			
			}
			else {
				Console.WriteLine("Personas en la Cola: ");
				for (int i = 0; i < coleccionable.cuantos(); i++) 
					Console.WriteLine(((Persona)((Cola)coleccionable).Elementos[i]).getNombre + ">> " + ((Persona)((Cola)coleccionable).Elementos[i]).getDni);			
			}
		}
		public static void imprimirAlumnos(Coleccionable coleccionable) {
			if ((coleccionable.GetType()).Equals(new Pila().GetType())) { //comparo si es pila
				Console.WriteLine("Alumnos en la Pila: ");
				for (int i = 0; i < coleccionable.cuantos(); i++) {
					Console.WriteLine(((Alumno)((Pila)coleccionable).Elementos[i]).getNombre + 
					                  " 	DNI N: " + ((Alumno)((Pila)coleccionable).Elementos[i]).getDni + 
					                  "		Legajo: " + ((Alumno)((Pila)coleccionable).Elementos[i]).getLegajo + 
					                 "		Promedio: " + ((Alumno)((Pila)coleccionable).Elementos[i]).getPromedio) ;
				}
			}
			
			else {
				Console.WriteLine("Alumnos en la Cola: ");
				for (int i = 0; i < coleccionable.cuantos(); i++) {
					Console.WriteLine(((Alumno)((Cola)coleccionable).Elementos[i]).getNombre + 
					                  "	DNI N: " + ((Alumno)((Cola)coleccionable).Elementos[i]).getDni +
										"		Legajo: " + ((Alumno)((Cola)coleccionable).Elementos[i]).getLegajo +
										"		Promedio: " + ((Alumno)((Cola)coleccionable).Elementos[i]).getPromedio) ;
				}
			}
		}
	}
}
