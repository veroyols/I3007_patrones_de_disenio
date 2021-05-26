/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 18/4/2021
 * Hora: 16:32
 * 
*/
using System;

namespace Practica3 {
	
	public class Alumno : Persona { 
		
		private int legajo;
		private double promedio;
		private EstrategiaDeComparacion estrategia = new PorDni();
		
		public int getLegajo {
			get { return legajo;}
			set { legajo = value;}
		} 
		public double getPromedio {
			get { return promedio;}
			set { promedio = value;}
		}	
		public EstrategiaDeComparacion getEstrategia {
			get { return estrategia; }
			set { estrategia = value;}
		}

		public Alumno() {}

		public Alumno(string nombre) {
			this.getNombre = nombre;
		}
		
		public Alumno(string n , int d, int l, double p) : base (n,d) {
			this.legajo = l;
			this.promedio = p;
		}
	
		public Alumno(string n , int d, int l, double p, EstrategiaDeComparacion e) : base (n,d) {
			this.legajo = l;
			this.promedio = p;
			this.estrategia = e;
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
			return string.Format(">> Id{0} {1} DNI {2} (Nota: {3}) - Compara por {4}", legajo, getNombre, getDni, promedio, estrategia);
		}
	}		
}
