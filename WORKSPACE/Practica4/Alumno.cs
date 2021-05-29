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
		
		private int legajo;
		private double promedio;
		private int calificacion;
		private GeneradorDeDatosAleatorio generador = new GeneradorDeDatosAleatorio();
		
		public int getLegajo {
			get { return legajo;}
			set { legajo = value;}
		} 
		public double getPromedio {
			get { return promedio;}
			set { promedio = value;}
		}	
		public int getCalificacion {
			get { return calificacion;}
			set { calificacion = value;}
		}

		public Alumno() {}

		public Alumno(string n , int d, int l, double p) : base (n,d) {
			this.legajo = l;
			this.promedio = p;
		}
//		public Alumno(string n , int d, int l, double p, EstrategiaDeComparacion e) : base (n,d,e) {
//			this.legajo = l;
//			this.promedio = p;
//			this.estrategia = e;
//		}
		
		public virtual int responderPregunta(int pregunta) {
			int respuesta = generador.numeroAleatorio(2);
			return respuesta +1;
		}//E1
		public string mostrarCalificacion() {	
			return nombre +"	"+ calificacion;
		}//E1
		public override string ToString() {
			return string.Format(">> Id{0} {1} DNI {2} (Nota: {3}) - Compara por {4}", legajo, getNombre, getDni, promedio, estrategia);
		}
	}		
}
