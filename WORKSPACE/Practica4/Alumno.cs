/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 18/4/2021
 * Hora: 16:32
 * 
*/
using System;

namespace Practica4 {
	
	public class Alumno : Persona, IAlumno { 
		
		private int legajo = 100;
		private double promedio;
		private int calificacion;

		public double getPromedio {
			get { return promedio;}
			set { promedio = value;}
		}	
		public Alumno() : base () { // aleatorios para ejercicio 4
			this.estrategia = new PorCalificacion();
			this.promedio = (base.getGenerador.numeroAleatorio(1000))/100.00;
			legajo++;
		}
		public Alumno(string n , int d, double p) : base (n,d) {
			legajo++;
			this.promedio = p;
		}
		public Alumno(string nombre , int calificacion) : base (nombre) {
			this.calificacion = calificacion;
			this.estrategia = new PorNombre();
		} // para E3
		
		public virtual int responderPregunta(int pregunta) {
			int respuesta = base.getGenerador.numeroAleatorio(2);
			return respuesta +1;
		}//E1
		public string mostrarCalificacion() {	
			return nombre +" "+ calificacion; 
		}//E1 
		public int getLegajo() {
			return legajo;
		}
		public int getCalificacion() {
			return this.calificacion;
		}
		public void setCalificacion(int calificacion) {
			this.calificacion = calificacion;
		}
		
		
		public override string ToString() {
			return string.Format(">> Id{0} {1} DNI {2} (Nota: {3}) - Compara por {4} = {5}", legajo, getNombre(), getDni, promedio, estrategia, calificacion);
		}
	}		
}
