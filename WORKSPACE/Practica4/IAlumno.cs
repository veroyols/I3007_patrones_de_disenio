/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 29/5/2021
 * Hora: 14:22
 * 
 */
using System;

namespace Practica4 {
	
	public interface IAlumno : Comparable {
		int responderPregunta(int pregunta);
		string mostrarCalificacion();
		int getLegajo();
		int getCalificacion();
		void setCalificacion(int calificacion);
		string getNombre();
	}	
}
