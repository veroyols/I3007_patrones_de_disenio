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

		public int getLegajo {
			get { return legajo;}
			set { value = legajo;}
		}

		public double getPromedio {
			get { return promedio;}
			set { value = promedio;}
		}
		
		public Alumno(string n , int d, int l, double p) : base (n,d) {
			this.legajo = l;
			this.promedio = p;
		}

		public Alumno() {}
		
		public override bool sosIgual (Comparable objeto) {
			bool igual = false;
			if (getDni == ((Alumno)objeto).getDni) {
				igual = true;
			}
			return igual;
		}
		public override bool sosMenor(Comparable objeto) {
			bool menor = false;
			if (getDni < ((Alumno)objeto).getDni) {
				menor = true;
			}
			return menor;
		}

		public override bool sosMayor(Comparable objeto) {
			bool mayor = false;
			if (getDni > ((Alumno)objeto).getDni) {
				mayor = true;
			}
			return mayor;
		}		
	}
}
