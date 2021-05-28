/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 28/5/2021
 * Hora: 19:35
 * 
 */
using System;

namespace Practica4 {
	
	class Program {
		
		public static void Main(string[] args) {
			
			Console.WriteLine("Hello World!");
			
			Alumno alumno = new Alumno("Maria", 11111111,1000,9);
			Console.WriteLine(alumno.mostrarCalificación());
			
			for (int i = 0; i < 20; i++) {
				Console.WriteLine(alumno.responderPregunta(2));
			}
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}