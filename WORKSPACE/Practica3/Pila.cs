/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 14/4/2021
 * Hora: 21:34
 * 
 */
using System;
using System.Collections.Generic;

namespace Practica3 {
	
	public class Pila : Coleccionable<Comparable>, Iterable { //LIFO
		
		private List<Comparable> elementos;
	
		public List<Comparable> Elementos { //declara propiedad pública
			set { elementos = value; } //se ejecuta al escribir
			get { return elementos; } //se ejecuta al leer 
		}
	
		public Pila() {
			elementos = new List<Comparable>();  
		}
				
		//Iterable
		public Iterador crearIterador() {
			return new IteradorDePila(this);
		}
		
		//coleccionable
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
			return string.Format("Pila");
		}
	}
}
