/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 5/5/2021
 * Hora: 23:28
 * 
clase ClaveValor, las cuales son creadas en el método agregar y valorDe.
 */
using System;

namespace Practica2 {

	public class Diccionario : Coleccionable<Comparable>, Iterable { //E4 
		
		private Conjunto conjunto = new Conjunto();
		
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
		
		//E5 - IColeccionable
		public int cuantos() { //cdad de elem
			return conjunto.cuantos();
		}

		public bool contiene(Comparable objeto) { //ref a valores
			return conjunto.contiene(objeto);
		}	
		
		public Comparable minimo() { //ref a valores
			Comparable alucno = (Comparable)valorDe(new Numero(0));
			
			for (int i = 0; i < ClaveValor.contador; i++) {
				if ( ((Comparable)valorDe(new Numero(i))).sosMenor(alucno) ){
					alucno = (Comparable)valorDe(new Numero(i)); //diccionario.valorDe(C) --> V
				}
			}
			return alucno;
		}
		
		public Comparable maximo() { //ref a valores
			Comparable alucno = (Comparable)valorDe(new Numero(0));
			
			for (int i = 0; i < ClaveValor.contador; i++) {
				if ( ((Comparable)valorDe(new Numero(i))).sosMayor(alucno) ){
					alucno = (Comparable)valorDe(new Numero(i)); 
				}
			}
			return alucno;
		}

		public void agregar(Comparable valor) { 
			conjunto.agregar(new ClaveValor(valor));
			return;
		}

		public void agregar(Object valor) { /* agrega la clave-valor al diccionario. Si la clave existe, reemplaza el valor asociado?*/
			conjunto.Elementos.Add(new ClaveValor(valor));
			return;
		}		
		
		
		public Object valorDe(Comparable clave) { /*valor asociada a la clave recibida / null si la clave no existe. clave id*/
			for (int i = 0; i < conjunto.Elementos.Count; i++) {
				if (((ClaveValor)(conjunto.Elementos[i])).getClave.sosIgual(clave)) {
					//Console.WriteLine(((ClaveValor)(conjunto.Elementos[i])).getvalor);
					return ((ClaveValor)(conjunto.Elementos[i])).getvalor;
				}
			}
			Console.WriteLine("No se encuentra la clave. ");
			return null;
		}	

		public override string ToString()
		{
			return string.Format("Diccionario");
		}
		
	}
}

