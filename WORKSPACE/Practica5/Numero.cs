/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 14/4/2021
 * Hora: 20:39
 * 
 */
using System;

namespace Practica5 {
	
	public class Numero : Comparable { //Haga que la clase Numero implemente la interface Comparable
		
		private int valor;
		
		public Numero(int v) {
			this.valor = v;
		}
		
		public Numero() {}
		
		public int getValor { 
			get {return valor; }
			set {valor = value; }
		}

		public bool sosIgual(Comparable objeto) {
			bool igual = false;
			if (valor == ((Numero)objeto).getValor) {
				igual = true;
			}
			return igual;
		}

		public bool sosMenor(Comparable objeto) {
			bool menor = false;
			if (valor < ((Numero)objeto).getValor) {
				menor = true;
			}
			return menor;
		}

		public bool sosMayor(Comparable objeto) {
			bool mayor = false;
			if (valor > ((Numero)objeto).getValor) {
				mayor = true;
			}
			return mayor;
		}

		public override string ToString() {
			return string.Format(">> Numero = {0}", valor);
		}	
	}
}
