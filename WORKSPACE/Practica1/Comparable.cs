/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 14/4/2021
 * Hora: 20:26
 * 

Ejercicio 1
Implemente la siguiente interface 
Comparable
Nota: asumiremos que el elemento que recibe el mensaje y el objeto recibido por parámetro son del “mismo tipo”. */

using System;

namespace Practica1 {

	public interface Comparable { //objeto que sabe compararse con otro objeto de su “mismo tipo”
		bool sosIgual(Comparable objeto);
		bool sosMenor(Comparable objeto);
		bool sosMayor(Comparable objeto);
		void compararPorConsola (Coleccionable<Comparable> coleccionable);
	}
}
