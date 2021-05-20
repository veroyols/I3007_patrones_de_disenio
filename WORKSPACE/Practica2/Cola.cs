/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 15/4/2021
 * Hora: 22:00
 * 
 */
using System;
using System.Collections.Generic;

namespace Practica2 {

	public class Cola : Coleccionable<Comparable>, Iterable { //FIFO
		
		private List<Comparable> elementos;
	
		public List<Comparable> Elementos {
			set { elementos = value; }
			get { return elementos; }  
		}
	
		public Cola () {
			elementos = new List<Comparable>();  
		}
		
		//Iterable
		public Iterador crearIterador() {
			return new IteradorDeCola(this);
		}		
		
		//Coleccionable
		public int cuantos() { 
			return elementos.Count;
		}

		public bool Empty () {
			bool vacia = false;
			if (cuantos() == 0) {
				vacia = true;
			}
			return vacia;
		}
				
		public Comparable minimo() {
			if (Empty()) {
				return null;
			}
			Comparable min = elementos[0];
			for (int i = 0; i < cuantos(); i++) {
				if ((elementos[i]).sosMenor(min) ) {
					min = elementos[i];
				}
			}
			return min; 
		}
		
		public Comparable maximo() { 
			if (Empty()) { //validacion
				return null;
			}
			Comparable max = elementos[0];
			for (int i = 0; i < cuantos(); i++) {
				if ((elementos[i]).sosMayor(max) ) {
					max = elementos[i];
				}
			}
			return max; 
		}		
	
		public void agregar(Comparable objeto) {
			elementos.Add(objeto);	
		}

		public bool contiene(Comparable objeto) { //verdadero si el parámetro pertenece
			bool cont = false;
			
			foreach (Comparable element in elementos) {
				if (element.sosIgual(objeto))
					cont = true;
				}
			return cont; 
		}

		public override string ToString() {
			return string.Format("Cola");
		}		
	}
}
