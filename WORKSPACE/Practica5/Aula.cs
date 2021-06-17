/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 15/6/2021
 * Hora: 22:28
 * 
 */
using System;

namespace Practica5 {
	
	public class Aula {
		private Teacher teacher;
		
		public void comenzar() {
			Console.WriteLine("Comenzar");
			teacher = new Teacher();
			return;
		}
		
		public void nuevoAlumno (IAlumno alumno) { //(Alumno)
			AdaptadorDeStudent student = new AdaptadorDeStudent(alumno);
			teacher.goToClass(student);
			return;
		}
		
		public void claseLista () {
			teacher.teachingAClass();
		}
		public Aula() { }
		
	}
}
