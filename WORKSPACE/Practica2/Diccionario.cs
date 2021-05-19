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

	public class Diccionario : Coleccionable<Comparable> { //E4 
		
		private Conjunto conjunto;
		
		public Conjunto Conjunto {
			set { conjunto = value; }
			get { return conjunto; }
		}
				
		public Diccionario() {
			this.conjunto = new Conjunto ();
		}
		
		public Diccionario(Conjunto conjunto) {
			this.conjunto = conjunto;
		}
		
		//E5 - IColeccionable
		/*minimo, máximo y contiene deben hacer referencia a los valores*/

		public int cuantos() {
			return 1;
		}
		
		public Comparable minimo() {
			Comparable num = new Numero();
			return num;
		}
		
		public Comparable maximo() {
			Comparable num = new Numero();
			return num;
		}

		public void agregar(Comparable valor) { /* agrega la clave-valor al diccionario. Si la clave existe, reemplaza el valor asociado.*/
			conjunto.agregar(new ClaveValor(valor));
			return;
		}

		public void agregar(Object valor) { /* agrega la clave-valor al diccionario. Si la clave existe, reemplaza el valor asociado.*/
			conjunto.Elementos.Add(new ClaveValor(valor));
			return;
		}		
		
		
		public Object valorDe(Comparable clave) { /*valor asociada a la clave recibida / null si la clave no existe. clave id*/
			for (int i = 0; i < conjunto.Elementos.Count; i++) {
				if (((ClaveValor)(conjunto.Elementos[i])).getClave.sosIgual(clave)) {
					Console.WriteLine(((ClaveValor)(conjunto.Elementos[i])).getvalor);
					return ((ClaveValor)(conjunto.Elementos[i])).getvalor;
				}
			}
			Console.WriteLine("No se encuentra la clave. ");
			return null;
		}
		
		public bool contiene(Comparable objeto) {
			return false;
		}			
	}
}

