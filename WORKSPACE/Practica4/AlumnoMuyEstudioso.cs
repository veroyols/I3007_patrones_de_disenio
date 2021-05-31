/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 29/5/2021
 * Hora: 12:45
 * 
 */
using System;

namespace Practica4 {
	
	public class AlumnoMuyEstudioso : Alumno {
		
		public AlumnoMuyEstudioso() : base () {
		}
		
		public override int responderPregunta(int pregunta) {
			return pregunta % 3;
		}//E2
	}
}
