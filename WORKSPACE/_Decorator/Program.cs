/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 31/5/2021
 * Hora: 01:30
 * 
 */
using System;

namespace _Decorator {
	
	public class Program {
				
		public static void Main(string[] args)	{
			IPaqueteTuristico pt = crearPaqueteTuristicoConAlquilerDeAutoYPasajeDeAvion();
			
			Console.WriteLine("El paquete vale " + pt.precio());
			Console.WriteLine("Consultando disponibilidad ... ");
			if(pt.consultarDisponibilidad())
				pt.reservar();
			else
				Console.WriteLine("El paquete no está disponible");
			
			Console.Write("Programa finalizado correctamente.");
			Console.ReadKey(true);
		}
		
		private static IPaqueteTuristico crearPaqueteTuristico(){
			return new PaqueteTuristico(2, 6, 80);
		}
		
		private static IPaqueteTuristico crearPaqueteTuristicoConAlquilerDeAuto(){
			IPaqueteTuristico pt = crearPaqueteTuristico();
			return new AlquilerDeAuto(60, pt);
		}
		
		private static IPaqueteTuristico crearPaqueteTuristicoConAlquilerDeAutoYPasajeDeAvion(){
			IPaqueteTuristico pt = crearPaqueteTuristicoConAlquilerDeAuto();
			return new PasajeDeAvion(3000, pt);
		}
	}
}