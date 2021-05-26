/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 5/5/2021
 * Hora: 23:09
 * 
 */
using System;

namespace Practica3 {

	public class ClaveValor : Comparable { 
	 		
		public static int contador = 0; //clave unica por defecto
		private Comparable clave; //id
		private Object valor;
		
		public Comparable getClave {
			set {clave = value;}
			get {return clave;}
		}
		
		public Object getvalor {
			set { valor = value; }
			get { return valor;  }
		}
		
		public ClaveValor(Object valor) {
			this.clave = new Numero(contador);
			this.valor = valor;
			ClaveValor.contador++;			
		}

		//IComparable
		public bool sosIgual(Comparable objeto) {	
			return false;
		}
		
		public bool sosMenor(Comparable objeto) {
			return false;
		}
		
		public bool sosMayor(Comparable objeto) {
			return false;
		}
		
		public void compararPorConsola (Coleccionable<Comparable> coleccionable) {
			return;
		}
		
		public override string ToString() {
			return string.Format("Valor={0}", valor);
		}
	}
}
