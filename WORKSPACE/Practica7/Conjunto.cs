/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 5/5/2021
 * Hora: 21:08
 * 
 */
using System;
using System.Collections.Generic;
	
namespace Practica7 {
	
	public class Conjunto :  Coleccion, Coleccionable<Comparable>, Iterable { // (abstract class Coleccion : <<Ordenable>>)
		
		private List<Comparable> elementos;
	
		public List<Comparable> Elementos { 
			set { elementos = value; } 
			get { return elementos; } 
		}		
		
		public Conjunto() {
			elementos = new List<Comparable>();
			}
	
		//Iterable
		public Iterador crearIterador() {
			return new IteradorDeConjunto(this);
		}	
		
		public bool pertenece (Comparable comparable) { 
			if (elementos == null ) {
				return false;
			}
			if (elementos.Contains(comparable))  //
					return true; 
			return false;
		}
		public bool Empty () {
			bool vacia = false;
			if (cuantos() == 0) {
				vacia = true;
			}
			return vacia;
		}

		//IColeccionable
		public void agregar (Comparable cv) { //sin repeticion
			if (pertenece(cv)) {
				Console.WriteLine("El elemento ya pertenece a la coleccion.");
				return;
			}
			if (Empty()) orden1.ejecutar();
			orden2.ejecutar((Comparable) (((ClaveValor)cv).getvalor) );
			elementos.Add(cv);
			if (elementos.Count == 40) orden3.ejecutar();				
//			Console.WriteLine("El elemento ha sido agregado a la coleccion. ");
			return;
		}
	
		public int cuantos() {
			return elementos.Count;
		}
		
		public Comparable minimo() {
			Comparable min = elementos[0];
			for (int i = 0; i < cuantos(); i++) {
				if ((elementos[i]).sosMenor(min) ) {
					min = elementos[i];
				}
			}
			return min;
		}
		
		public Comparable maximo() {
			Comparable max = elementos[0];
			for (int i = 0; i < cuantos(); i++) {
				if ((elementos[i]).sosMayor(max) ) {
					max = elementos[i];
				}
			}
			return max;
		}
			
		public bool contiene(Comparable objeto) {
			bool cont = false;
			foreach (Comparable element in elementos) {
				if (element.sosIgual(objeto))
					cont = true;
				}
			return cont; 
		}

		public override string ToString() {
			return string.Format("Conjunto");
		}
	}
}
