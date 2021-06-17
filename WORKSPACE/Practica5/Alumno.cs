/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 18/4/2021
 * Hora: 16:32
 * 
*/
using System;

namespace Practica5 {
	
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
			this.promedio = (base.getGenerador.numeroAleatorio(1000))/100.00;
			this.legajo = num;
			num++;
		}
		public Alumno(string nombre, int legajo, int calificacion, EstrategiaDeComparacion estrategia) : base (nombre) { // proxy
			this.estrategia = estrategia;
			this.promedio = (base.getGenerador.numeroAleatorio(1000))/100.00;
			this.legajo = legajo;
			this.calificacion = calificacion;
			this.nombre = nombre;
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
		
		public override bool sosIgual(Comparable objeto) { 
			return estrategia.sosIgual(objeto, this); 
		}

		public override bool sosMenor(Comparable objeto) { 
			return estrategia.sosMenor(objeto, this);
		}

		public override bool sosMayor(Comparable objeto) { 
			return estrategia.sosMayor(objeto, this);
		}
		
		public override string ToString() {
			return string.Format(">> Id{0} {1} DNI {2} (Nota: {3}) - Compara por {4} = {5}", legajo, getNombre(), getDni, promedio, estrategia, calificacion);
		}
	}		
}
