/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 29/5/2021
 * Hora: 13:36
 * Implemente un adaptador para la clase Alumno que pueda comportarse como un Student 
 */
using System;

namespace Practica5 {

	public class AdaptadorDeStudent : Student { //redirige las peticiones a Alumno
		private IAlumno iAlumno;
		public IAlumno getAlumno {
			get { return iAlumno; }
			set { iAlumno = value; }
		}
		public AdaptadorDeStudent (IAlumno iAlumno) {
			this.iAlumno = iAlumno;
		}
		public string getName() {
			return iAlumno.getNombre();
		}
		public int getScore() {
			return iAlumno.getCalificacion();
		}
		public int yourAnswerIs(int question) {
			return iAlumno.responderPregunta(question);
		}
		public void setScore(int score) {
			iAlumno.setCalificacion(score);
		}
		public string showResult() {
			return iAlumno.mostrarCalificacion();
		}			
		public bool equals(Student student) {
			IAlumno alumno2 = new Alumno (student.getName(),student.getScore());
			return this.iAlumno.sosIgual(alumno2);
		}
		public bool lessThan(Student student) {
			IAlumno alumno2 = new Alumno (student.getName(),student.getScore());
			return this.iAlumno.sosMenor(alumno2);
		}
		public bool greaterThan(Student student) {
			IAlumno alumno2 = new Alumno (student.getName(),student.getScore());
			
			return this.iAlumno.sosMayor(alumno2);
		}
		public override string ToString() {
			return string.Format("[AdaptadorDeStudent Alumno={0}]", iAlumno);
		}
	}
}
