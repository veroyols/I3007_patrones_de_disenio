/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 25/5/2021
 * Hora: 19:26
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica5 {
	
	public class LectorDeDatos {
		
		/*numeroPorTeclado()  devuelve un número leído por teclado*/
		public int numeroPorTeclado () {
			return int.Parse(Console.ReadLine());
		}//E3
		
		/*stringPorTeclado()  devuelve un string leído por teclado*/
		public string stringPorTeclado () {
			return Console.ReadLine();
		}//E3
		
		public LectorDeDatos() {}
		
	}
}
