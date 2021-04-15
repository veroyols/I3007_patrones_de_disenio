/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 14/4/2021
 * Hora: 20:26
 * 
 */
using System;

namespace Practica1
{
	class Program
	{
		public static void Main(string[] args) {	
			// TODO: Implement Functionality Here
			
			Numero x = new Numero (3);
			Numero y = new Numero (5);
			
			Console.WriteLine("x={0} es igual que y={1}? {2}",x.getValor,y.getValor,x.sosIgual(y));
			Console.WriteLine("x={0} es menor que y={1}? {2}",x.getValor,y.getValor,x.sosMenor(y));
			Console.WriteLine("x={0} es mayor que y={1}? {2}",x.getValor,y.getValor,x.sosMayor(y));
			
			Pila pila = new Pila ();
			pila.agregar(x);
			pila.agregar(y);
			
			Console.WriteLine("La pila tiene {0} elementos.", pila.cuantos());
			Console.WriteLine("La pila contiene al valor {0}? {1}",x.getValor , pila.contiene(x));

			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}