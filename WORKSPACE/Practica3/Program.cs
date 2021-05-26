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
			
			GeneradorDeDatosAleatorio generador = new GeneradorDeDatosAleatorio();
			Console.WriteLine("Genera el string aleatorio '{0}'",generador.stringAleatorio(5));
			
			LectorDeDatos lector = new LectorDeDatos ();
			Console.WriteLine("Ingrese un numero");			
			lector.numeroPorTeclado();
			
			Comparable comparable = FabricaDeComparables.crearPorTeclado();
			Console.WriteLine(comparable);
			Console.WriteLine("...");
			Console.ReadKey(true);
		}
	}
}