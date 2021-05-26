/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 25/5/2021
 * Hora: 19:16
 * 
 */
using System;

namespace Practica3
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			GeneradorDeDatosAleatorio generador = new GeneradorDeDatosAleatorio();
			

			
			Console.Write(generador.stringAleatorio(99999));
			Console.ReadKey(true);
		}
	}
}