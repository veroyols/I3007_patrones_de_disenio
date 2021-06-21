/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 21/6/2021
 * Hora: 00:16
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica7
{
	/// <summary>
	/// Description of Singleton.
	/// </summary>
	public sealed class Singleton
	{
		private static Singleton instance = new Singleton();
		
		public static Singleton Instance {
			get {
				return instance;
			}
		}
		
		private Singleton()
		{
		}
	}
}
