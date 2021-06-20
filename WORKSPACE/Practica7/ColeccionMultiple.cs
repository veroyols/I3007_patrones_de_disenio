/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 16/4/2021
 * Hora: 17:07
 * 
 */
using System;
using System.Collections.Generic;

namespace Practica7 {
	
	public class ColeccionMultiple : Coleccion, Coleccionable<Comparable>, Iterable  {  // (abstract class Coleccion : <<Ordenable>>)
	
		public Pila pila;
		public Cola cola;

		public ColeccionMultiple(Pila p, Cola c) {
			this.pila = p;
			this.cola = c;
		}
		
		public ColeccionMultiple() {
			pila = new Pila();
			cola = new Cola();
		}

		//Iterable
		public Iterador crearIterador() {
			return new IteradorDeColeccionMultiple(this);
		}		
		
		//Coleccionable
		public int cuantos() {
			return pila.cuantos() + cola.cuantos();
		}
		
		public Comparable minimo() { 
			if ((pila.cuantos() == 0) & (cola.cuantos() == 0)) {
				return null;
			}
			if (pila.cuantos() == 0) {
				return cola.minimo();
			}
			if (cola.cuantos() == 0) {
				return pila.minimo();
			}			
			if ((pila.minimo()).sosMenor(cola.minimo()) ) {
				return pila.minimo(); 
			}
			return cola.minimo();
		}
		
		public Comparable maximo() { 
			if ((pila.cuantos() == 0) && (cola.cuantos() == 0)) {
				return null;
			}
			if (pila.cuantos() == 0) {
				return cola.maximo();
			}
			if (cola.cuantos() == 0) {
				return pila.maximo();
			}			
			if ((pila.maximo()).sosMayor(cola.maximo()) ) {
				return pila.maximo(); 
			}
			return cola.maximo();
		}
		
		public void agregar(Comparable objeto) { 
			if (pila.Empty() && cola.Empty())
				orden1.ejecutar();
			
			if (pila.cuantos() < 20) {
				orden2.ejecutar(objeto);
				pila.Elementos.Add(objeto);	
			}
			else {			
				orden2.ejecutar(objeto);
				cola.Elementos.Add(objeto);	
			}
			
			if ((pila.cuantos() == 20) && (cola.cuantos() == 20)) {
				orden3.ejecutar();
			}
			return;
		}
		public bool contiene(Comparable objeto) {
			bool cont = false;
			if (pila.contiene(objeto) || cola.contiene(objeto) ) {
				cont = true;
			}
			return cont;
		}		
		
		public override string ToString() {
			return string.Format("Coleccion Multiple");
		}	
	}
}
