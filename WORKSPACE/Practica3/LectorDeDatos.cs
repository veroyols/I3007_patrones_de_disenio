/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 25/5/2021
 * Hora: 19:26
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica3 {
	
	public class LectorDeDatos {
		
		/*numeroPorTeclado()  devuelve un número leído por teclado*/
		public int numeroPorTeclado () {
			Console.WriteLine("Ingrese un numero");
			return int.Parse(Console.ReadLine());
		}
		/*stringPorTeclado()  devuelve un string leído por teclado*/
		public string stringPorTeclado () {
			Console.WriteLine("Ingrese un string");
			return Console.ReadLine();
		}
		
		public LectorDeDatos() {}
		
	}
}
