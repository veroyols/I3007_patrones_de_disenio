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
			
			//EJERCICIO7
			Pila pila = new Pila ();
			Cola cola = new Cola ();
			
			ColeccionMultiple multiple = new ColeccionMultiple (pila, cola);
			
//			Console.WriteLine(">> Metodo llenar: ");
//			llenar(pila);
//			llenar(cola);
//
//			imprimir(pila);
//			imprimir(cola);
//			
//			Console.WriteLine("\n------------PILA-----------"); 			
//			informar(pila);
//			Console.WriteLine("\n------------COLA-----------"); 
//			informar(cola); 
//			Console.WriteLine("\n-------------CM-------------"); 
//			informar(multiple);
				
			Console.WriteLine(">> Metodo llenar: ");
			llenarPersonas(pila);
			llenarPersonas(cola);
			imprimirPersonas(pila);
			imprimirPersonas(cola);
			informar(multiple);
//			Console.WriteLine(multiple.pila.Elementos[0].GetType());
			Console.Write("\n Press any key to continue . . . ");
			Console.ReadKey(true);
		}

		public static void informar (Coleccionable coleccionable) { //EJERCICIO6 / EJERCICIO13 informar coleccion de personas
			if (((coleccionable).GetType()).Equals(new ColeccionMultiple().GetType()) ) { //es coleccion
				if ((((ColeccionMultiple)coleccionable).pila.Elementos[0].GetType()).Equals(new Numero().GetType())) //es numero
					Numero.informar(coleccionable);
				if ((((ColeccionMultiple)coleccionable).pila.Elementos[0].GetType()).Equals(new Persona().GetType())) //persona
					Persona.informar(coleccionable);
			} 
			if (((coleccionable).GetType()).Equals(new Pila().GetType()) ) { //es pila
				if ((((Pila)coleccionable).Elementos[0].GetType()).Equals(new Numero().GetType())) //es numero
					Numero.informar(coleccionable);
				if ((((Pila)coleccionable).Elementos[0].GetType()).Equals(new Persona().GetType())) //persona
					Persona.informar(coleccionable);
			}
			if (((coleccionable).GetType()).Equals(new Cola().GetType()) ) { //es cola
				if ((((Cola)coleccionable).Elementos[0].GetType()).Equals(new Numero().GetType())) //es numero
					Numero.informar(coleccionable);
				if ((((Cola)coleccionable).Elementos[0].GetType()).Equals(new Persona().GetType())) //persona
					Persona.informar(coleccionable);
			}
		}
		
		public static void llenar(Coleccionable coleccionable){ //EJERCICIO5
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
		
		public static void imprimir(Coleccionable coleccionable) {
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
	}
}