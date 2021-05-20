/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 18/5/2021
 * Hora: 23:55
 * 
Interface Iterable. 
La deben implementar  
objetos que posean un 
iterador para iterar sobre 
sus elementos */

using System;
namespace Practica2 { 
	
	public interface Iterable { //E6 pila, cola, coleccionMultiple, Conjunto
		Iterador crearIterador();
	}
	
	public interface Iterador { 
		Comparable primero();
		void siguiente();
		bool fin();
		Comparable actual (); //?
	}
	
	public class IteradorDePila : Iterador {
		private Pila pila; //?
		private int indice;
		
		public IteradorDePila (Iterable pila) {
			this.pila = (Pila)pila;
			this.indice = 0;
		}
				
		public Comparable primero() {
			int ultimo = pila.cuantos() - 1;
			return pila.Elementos[ultimo];
		}
		
		public void siguiente() {
			indice++;
		}
		public bool fin() {
			bool vacio = false;
			if (indice >= pila.cuantos()) {
				vacio = true;
			}
			return vacio;
		}
		public Comparable actual () {
			int ultimo = pila.cuantos() - 1;
			return pila.Elementos[ultimo - indice];
		}
	}

	public class IteradorDeCola : Iterador {
		private Cola cola; //?
		private int indice;
		
		public IteradorDeCola (Iterable cola) {
			this.cola = (Cola)cola;
			this.indice = 0;
		}
				
		public Comparable primero() {
			return cola.Elementos[indice];
		}
		
		public void siguiente() {
			indice++;
		}
		public bool fin() {
			bool vacio = false;
			if (indice >= cola.cuantos()) {
				vacio = true;
			}
			return vacio;
		}
		public Comparable actual () {
			return cola.Elementos[indice];
		}
	}

	public class IteradorDeColeccionMultiple : Iterador {
		private ColeccionMultiple coleccion; 
		private Iterador dePila;
		private Iterador deCola;
		
		public IteradorDeColeccionMultiple (Iterable coleccion) {
			this.coleccion = (ColeccionMultiple)coleccion;
			this.dePila = new IteradorDePila(this.coleccion.pila);
			this.deCola = new IteradorDeCola(this.coleccion.cola);
		}
				
		public Comparable primero() {
			if (!dePila.fin()) {
				return dePila.primero(); 
			}
			return deCola.primero();
		}
		
		public void siguiente() {
			if (!dePila.fin()) {
				dePila.siguiente();
			}
			else {
				deCola.siguiente();
			}
		}
		
		public bool fin() {
			bool vacio = false;
			if (dePila.fin() && deCola.fin() ) {
				vacio = true;
			}
			return vacio;
		}
		
		public Comparable actual () {
			if (!dePila.fin()) {
				return dePila.actual(); 
			}
			return deCola.actual();		
		}
	}
	
	public class IteradorDeConjunto : Iterador {
		private Conjunto conjunto; //?
		private int indice;
		
		public IteradorDeConjunto (Iterable conjunto) {
			this.conjunto = (Conjunto)conjunto;
			this.indice = 0;
		}
				
		public Comparable primero() {
			return conjunto.Elementos[indice];
		}
		
		public void siguiente() {
			indice++;
		}
		public bool fin() {
			bool vacio = false;
			if (indice >= conjunto.cuantos()) {
				vacio = true;
			}
			return vacio;
		}
		public Comparable actual () {
			return conjunto.Elementos[indice];
		}
	}

	public class IteradorDeDiccionario : Iterador { //No cambia la estrategia
		private Diccionario diccionario; 
		private Iterador deConjunto;
		//private int indice;		
		
		public IteradorDeDiccionario (Iterable diccionario) {
			this.diccionario = (Diccionario)diccionario;
			this.deConjunto = new IteradorDeConjunto(this.diccionario.Conjunto);
			//this.indice = 0;
		}
				
		public Comparable primero() {
			return deConjunto.primero();
			//return (Comparable)diccionario.valorDe(new Numero(indice));
		}
		
		public void siguiente() {
			deConjunto.siguiente();
			//indice++;
		}
		
		public bool fin() {
			return deConjunto.fin();
		}
		
		public Comparable actual () {
			return deConjunto.actual();
			//return (Comparable)diccionario.valorDe(new Numero(indice));
		}
	}
}
