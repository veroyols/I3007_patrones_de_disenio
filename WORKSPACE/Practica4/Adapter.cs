/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 29/5/2021
 * Hora: 13:36
 * Implemente un adaptador para la clase Alumno que pueda comportarse como un Student 
 */
using System;

namespace Practica4 {

	public class AdaptadorDeStudent : Student { //redirige las peticiones a Alumno
		public Alumno alumno;
		
		public AdaptadorDeStudent () {
			alumno = new Alumno (alumno.getNombre, alumno.getDni, alumno.getLegajo, alumno.getPromedio, alumno.getEstrategia);
		}
		public string getName() {
			return alumno.getNombre;	
		}
		public int yourAnswerIs(int question) {
			return alumno.responderPregunta(question);
		}
		public void setScore(int score) {
			alumno.getCalificacion = score;
		}
		public string showResult() {
			return alumno.mostrarCalificacion() ;
		}		
		public bool equals(Student student) {
			return alumno.sosIgual(student);
		}
		public bool lessThan(Student student) {
			return alumno.sosMenor(student);
		}
		public bool greaterThan(Student student) {
			return alumno.sosMayor(student);
		}
	}
}
