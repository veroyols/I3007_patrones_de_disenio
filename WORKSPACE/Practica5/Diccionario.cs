/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 5/5/2021
 * Hora: 23:28
 * 
clase ClaveValor, las cuales son creadas en el método agregar y valorDe.
 */
using System;

namespace Practica5 {

	public class Diccionario : Ordenable, Coleccionable<Comparable>, Iterable { 
		
		private Conjunto conjunto = new Conjunto();
		
		//Ordenable
		public void setOrdenInicio(OrdenEnAula1 o) {			
			conjunto.setOrdenInicio (o);
			return; 
		}
		public void setOrdenLlegaAlumno(OrdenEnAula2 o) {
			conjunto.setOrdenLlegaAlumno (o);
			return; 
		}
		public void setOrdenAulaLlena(OrdenEnAula1 o) {
			conjunto.setOrdenAulaLlena (o);
			return; 
		}
		public void agregar(Comparable valor) { 
			conjunto.agregar(new ClaveValor(valor));
			return;
		}		
		
		public Conjunto Conjunto {
			set { conjunto = value; }
			get { return conjunto; }
		}
				
		public Diccionario() {
//			this.conjunto = new Conjunto ();
		}
		
		public Diccionario(Conjunto conjunto) {
			this.conjunto = conjunto;
		}
		
		//Iterable
		public Iterador crearIterador() {
			return new IteradorDeDiccionario(this);
		}		
		
		//IColeccionable
		public int cuantos() { 
			return conjunto.cuantos();
		}

		public bool contiene(Comparable objeto) { 
			return conjunto.contiene(objeto);//TODO
		}	
		
		public Comparable minimo() { 
			Comparable alucno = (Comparable)valorDe(new Numero(0));
			for (int i = 0; i < ClaveValor.contador; i++) {
				if ( ((Comparable)valorDe(new Numero(i))).sosMenor(alucno) ){
					alucno = (Comparable)valorDe(new Numero(i)); 
				}
			}
			return alucno;
		}
		
		public Comparable maximo() { 
			Comparable alucno = (Comparable)valorDe(new Numero(0));		
			for (int i = 0; i < ClaveValor.contador; i++) {
				if ( ((Comparable)valorDe(new Numero(i))).sosMayor(alucno) ){
					alucno = (Comparable)valorDe(new Numero(i)); 
				}
			}
			return alucno;
		}
				
		public Object valorDe(Comparable clave) { 
			for (int i = 0; i < conjunto.Elementos.Count; i++) {
				if (((ClaveValor)(conjunto.Elementos[i])).getClave.sosIgual(clave)) {
					return ((ClaveValor)(conjunto.Elementos[i])).getvalor;
				}
			}
			Console.WriteLine("No se encuentra la clave. ");
			return null;
		}	

		public override string ToString() {
			return string.Format("Diccionario");
		}
	}
}

