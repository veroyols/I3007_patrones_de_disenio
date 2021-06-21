/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 18/4/2021
 * Hora: 16:32
 * 
*/
using System;

namespace Practica7 {
	
	public class Alumno : Persona, IAlumno { 
		private static int num = 100;
		private int legajo;
		private double promedio;
		private int calificacion;

		public double getPromedio {
			get { return promedio;}
			set { promedio = value;}
		}	
		public Alumno() : base () {
			this.estrategia = new PorCalificacion();
			this.promedio = (base.getDatos.getManejador.numeroAleatorio(1000))/100.00;
			this.legajo = num;
			num++;
		}
		public Alumno(string nombre, int legajo, int calificacion, EstrategiaDeComparacion estrategia) : base (nombre) { // proxy
			this.estrategia = estrategia;
			this.promedio = (base.getDatos.getManejador.numeroAleatorio(1000))/100.00;
			this.legajo = legajo;
			this.calificacion = calificacion;
			this.nombre = nombre;
		}
		public Alumno( int legajo, string nombre, int dni, double promedio, int calificacion) : base (nombre,dni) { // proxy
			this.legajo = legajo;
			this.estrategia = new PorCalificacion();
			this.promedio = promedio;
			this.calificacion = calificacion;
		}		
		
		public Alumno(string n , int d, double p) : base (n,d) {
			this.promedio = p;
			this.legajo = num;
			num++;
		}
		public Alumno(string nombre , int calificacion) : base (nombre) {
			this.calificacion = calificacion;
			this.estrategia = new PorCalificacion();
			this.legajo = num;
			num++;
		} // para E3
		
		public virtual int responderPregunta(int pregunta) {
			int respuesta = base.getDatos.getManejador.numeroAleatorio(2);
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
		
		public override bool sosIgual(Comparable objeto) { 
			return estrategia.sosIgual(objeto, this); 
		}

		public override bool sosMenor(Comparable objeto) { 
			return estrategia.sosMenor(objeto, this);
		}

		public override bool sosMayor(Comparable objeto) { 
			return estrategia.sosMayor(objeto, this);
		}
		public void agregarHijo(IAlumno hijo) {
			return;
		}
		
		public override string ToString() {
			return string.Format("{0} {1} {2} {3} {4}", legajo, getNombre(), getDni, promedio, calificacion);
		}
	}		
}
