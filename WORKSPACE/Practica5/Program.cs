/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 2/6/2021
 * Hora: 03:42
 * 
 */
using System;
using System.IO;
using System.Collections.Generic;

namespace Practica5 {
	
	class Program {
		public static void Main(string[] args) {
			
			Console.WriteLine("Hello World!");
			
//			StreamWriter archivo = new StreamWriter("nuevo.txt", true);
//			archivo.WriteLine("Nuevo renglon\n");
//			archivo.Close();	
			
			StreamReader leerArchivo = new StreamReader("nuevo.txt");
				int num = 0;
			
			while ((leerArchivo.Peek ()) > -1){
				Console.WriteLine(num + leerArchivo.ReadLine());
				num++;
			}
			leerArchivo.Close();
									
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static void leerArchivo () {
			
		}
	}
}