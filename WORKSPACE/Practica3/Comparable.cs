/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 14/4/2021
 * Hora: 20:26
 */

using System;

namespace Practica3 {

	public interface Comparable { //objeto que sabe compararse con otro objeto de su “mismo tipo”
		bool sosIgual(Comparable objeto);
		bool sosMenor(Comparable objeto);
		bool sosMayor(Comparable objeto);
		void compararPorConsola (Coleccionable<Comparable> coleccionable);
	}
}
