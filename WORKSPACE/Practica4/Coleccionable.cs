/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 14/4/2021
 * Hora: 21:26
 * 
 */
using System;

namespace Practica4 {
	
	public interface Coleccionable<Comparable> { //objetos que almacenan comparables
		int cuantos(); 
		Comparable minimo(); 
		Comparable maximo(); 
		void agregar(Comparable objeto); 
		bool contiene(Comparable objeto); 
		Iterador crearIterador();	
	}
}
