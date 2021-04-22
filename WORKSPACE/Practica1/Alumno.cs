/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 18/4/2021
 * Hora: 16:32
 * 
getLegajo  Devuelve la variable legajo
getPromedio  Devuelve la variable promedio */
using System;

namespace Practica1
{
	public class Alumno : Persona { //Ejercicio15
		private int legajo;
		private double promedio;
		private estrategiaDeComparacion estrategia;
		
		public int getLegajo {
			get { return legajo;}
			set { legajo = value;}
		}

		public double getPromedio {
			get { return promedio;}
			set { promedio = value;}
		}
		
		public estrategiaDeComparacion getEstrategia {
			get { return estrategia; }
		}

		public Alumno() {}
		
		public Alumno (int dni) : base (dni) {}		

		public Alumno(string n , int d, int l, double p) : base (n,d) {
			this.legajo = l;
			this.promedio = p;
			estrategia = new PorNombre();
		}

		public bool comparar (Comparable comparable) {
			return estrategia.comparar(comparable);
		}
		
		public override string ToString() {
			return string.Format(">> Legajo N{0} - Alumnx = {1}	DNI {2} (Promedio = {3})", legajo, getNombre, getDni, promedio);
		}
		
	}
}
