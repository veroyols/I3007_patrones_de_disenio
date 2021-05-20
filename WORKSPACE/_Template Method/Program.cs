/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 19/5/2021
 * Hora: 20:40
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace _Template_Method {
	
	class Program {
		
		public static void Main(string[] args) {
		
			Console.WriteLine("********************");			
			Console.WriteLine("* Cumpleaños de 15 *");
			Console.WriteLine("********************");			
			Evento e1 = new CumpleDe15();
			e1.hacerFiesta();
			Console.WriteLine("------------------------------------------\n\n");			
			
			Console.WriteLine("**************");			
			Console.WriteLine("* Casamiento *");
			Console.WriteLine("**************");						
			Evento e2 = new Casamiento();
			e2.hacerFiesta();
			Console.WriteLine("------------------------------------------\n\n");			
			
			Console.Write("Programa finalizado correctamente.");
			Console.ReadKey(true);
		}
	}
}