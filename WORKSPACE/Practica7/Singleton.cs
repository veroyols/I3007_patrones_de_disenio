/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 21/6/2021
 * Hora: 00:16
 * 
 */
using System;

namespace Practica7 {
	
	public class Singleton {
		
		private static Singleton unico = null;
		
		public static Singleton getUnico {
			get { return unico; }
		}
		
		private Singleton() {}
		
		public static Singleton getInstance () {
			if (unico == null) unico = new Singleton();
			return unico;
		}
	}
}
