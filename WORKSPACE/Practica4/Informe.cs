/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 26/5/2021
 * Hora: 19:39
 * 
 */
using System;

namespace Practica4 {
	
	public class Informe {
		
		public static void informar (Coleccionable<Comparable> coleccionable, int queComparable) { 
			Console.WriteLine("----------INFORMAR----------");
			Console.WriteLine("La {0} posee {1} elementos.", coleccionable.ToString(), coleccionable.cuantos());
			Console.WriteLine("Minimo >> " + (coleccionable.minimo()));
			Console.WriteLine("Maximo >> " + (coleccionable.maximo()));	
			Comparable comparable = FabricaDeComparables.crearPorTeclado(queComparable);
			if (coleccionable.contiene(comparable)) {
				Console.WriteLine("El elemento leído está en la colección");
			}
			else {
				Console.WriteLine("El elemento leído NO está en la colección");
			}
		}//E6
	}
}
