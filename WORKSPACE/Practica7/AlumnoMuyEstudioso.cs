/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 29/5/2021
 * Hora: 12:45
 * 
 */
using System;

namespace Practica7 {
	
	public class AlumnoMuyEstudioso : Alumno {
		
		public AlumnoMuyEstudioso() : base () {}
		public AlumnoMuyEstudioso(string nombre, int dni, int prom, EstrategiaDeComparacion e) : base (nombre, dni,prom,e) {}
		public AlumnoMuyEstudioso(int legajo, string nombre, int dni, double promedio, int calificacion) : base (legajo,nombre,dni,promedio,calificacion) {}
		public AlumnoMuyEstudioso(string n, int l, int c) : base (n,l,c) {}
		
		public override int responderPregunta(int pregunta) {
			return pregunta % 3;
		}//E2
	}
}
