/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 5/5/2021
 * Hora: 23:09
 * 
 */
using System;

namespace Practica7 {

	public class ClaveValor : Comparable { 
	 		
		public static int contador = 0; //clave unica por defecto
		private Comparable clave; //id
		private Object valor;
		private EstrategiaDeComparacion estrategia = new PorDni();
		
		public EstrategiaDeComparacion getEstrategia {
			get { return estrategia;}
			set { estrategia = value;}
		}	
		
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

		public ClaveValor() {
			this.clave = new Numero(contador);
			ClaveValor.contador++;			
		} //para P3 E4

		//IComparable
		public bool sosIgual(Comparable objeto) {	
			return estrategia.sosIgual(objeto, this); 
		}
		
		public bool sosMenor(Comparable objeto) {
			return estrategia.sosMenor(objeto, this); 
		}
		
		public bool sosMayor(Comparable objeto) {
			return estrategia.sosMayor(objeto, this); 
		}
		

		public override string ToString() {
			return string.Format("{0}) Valor={1}",clave,valor);
		}
	}
}
