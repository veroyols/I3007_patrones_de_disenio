/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 5/6/2021
 * Hora: 23:55
 * 
 */
using System;

namespace Practica5 {
	
	public class AlumnoProxy : IAlumno, Comparable {
		
		private Alumno alumnoReal = null;
		
		private string nombre;
		private int calificacion;		
		private int legajo;
		private GeneradorDeDatosAleatorio generador = new GeneradorDeDatosAleatorio();
		
		public AlumnoProxy () {
			this.nombre = generador.stringAleatorio(4);
			this.calificacion = generador.numeroAleatorio(10);
			this.legajo = generador.numeroAleatorio(9999);
		}
		
		public int responderPregunta(int pregunta) {
				if (alumnoReal != null) {
					return alumnoReal.responderPregunta(pregunta);	
			}
			else {
				alumnoReal = new Alumno(nombre, legajo, calificacion);
				Console.WriteLine("crear alumno");
				return alumnoReal.responderPregunta(pregunta);
			}
		}
		public string mostrarCalificacion() {
			return nombre + " " + calificacion;
		}
		public int getLegajo() {
			return legajo;
		}
		public int getCalificacion() {
			return calificacion;
		}
		public void setCalificacion(int calificacion) {
			this.calificacion = calificacion;
			return;
		}
		public string getNombre() {
			return nombre;
		}
		public bool sosIgual(Comparable objeto) {
			return alumnoReal.sosIgual(objeto);
		}
		public bool sosMenor(Comparable objeto) {
			return alumnoReal.sosIgual(objeto);
		}
		public bool sosMayor(Comparable objeto) {
			return alumnoReal.sosIgual(objeto);
		}	
	}
}

