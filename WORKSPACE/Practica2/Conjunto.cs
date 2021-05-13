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
	
	public class Conjunto :  Coleccionable<Comparable> { //lista de elementos sin repeticion
		
		private List<Comparable> elementos;
	
		public List<Comparable> Elementos { 
			set { elementos = value; } 
			get { return elementos; } 
		}

		public Conjunto() {
			elementos = new List<Comparable>();
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
			
		public bool contiene(Comparable objeto) {
			return false;
		}		
	}
}
