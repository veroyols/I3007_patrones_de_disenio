/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 20/6/2021
 * Hora: 15:43
 * 
 */
using System;

namespace Chain_of_responsability {
	
	public class Program {
				
		public static void Main(string[] args)	{
			Manejador m = crearCadenaDeResponsabilidades();
			
			Evento e = new Evento(m);			
			e.hacerFiesta();
			
			Console.Write("Programa finalizado correctamente.");
			Console.ReadKey(true);
		}
		
		private static Manejador crearCadenaDeResponsabilidades(){
			Manejador m = new Gasista(null);
			m = new Electricista(m);
			m = new Carpintero(m);
			m = new Bombero(m);
			return m;
		}	
	}
}