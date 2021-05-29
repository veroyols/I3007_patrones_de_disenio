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
		
		public AlumnoMuyEstudioso() {}
		
		public override int responderPregunta(int pregunta) {
			return 3;
		}//E2
	}
}
