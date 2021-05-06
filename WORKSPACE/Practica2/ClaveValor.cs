/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 5/5/2021
 * Hora: 23:09
 * 
 */
using System;

namespace Practica2 {
	
	public class ClaveValor { //Clase auxiliar de Diccionario
	
		private Comparable clave;
		private Numero valor;
		
		public Comparable getClave {
			set {clave = value;}
			get {return clave;}
		}
		
		public Numero getvalor {
			set { valor = value; }
			get { return valor;  }
		}
		public ClaveValor() {}
	}
}
