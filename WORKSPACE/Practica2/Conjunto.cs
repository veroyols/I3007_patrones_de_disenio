/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 5/5/2021
 * Hora: 21:08
 * 
 */
using System;
using System.Collections.Generic;
	
namespace Practica2 {
	
	public class Conjunto :  Coleccionable<Comparable>, Iterable { //lista de elementos sin repeticion
		
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
		
		public bool pertenece (Comparable comparable) { //E3
			if (elementos == null ) {
				return false;
			}
			if (elementos.Contains(comparable))  //
					return true; 
			return false;
		}

		//IColeccionable
		public void agregar (Comparable comparable) { //E3 (obj)
			if (pertenece(comparable)) {
				Console.WriteLine("El elemento ya pertenece a la coleccion.");
				return;
			}
			elementos.Add(comparable);
			Console.WriteLine("El elemento ha sido agregado a la coleccion. ");
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
