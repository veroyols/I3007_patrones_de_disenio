/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 29/5/2021
 * Hora: 12:45
 * 
 */
using System;

namespace Practica5 {
	
	public class AlumnoMuyEstudioso : Alumno, IAlumno {
		
		public AlumnoMuyEstudioso() : base () {}
		
		public AlumnoMuyEstudioso(string n, int l, int c) : base (n,l,c) {}
		
		public override int responderPregunta(int pregunta) {
			return pregunta % 3;
		}//E2
	}
}
