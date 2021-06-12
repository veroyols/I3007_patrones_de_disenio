/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 21/4/2021
 * Hora: 21:52
 * 
 */
using System;

namespace Practica5 { 
	
	public interface EstrategiaDeComparacion{ //obj,this
		bool sosIgual(Comparable objeto, Comparable objeto2);
		bool sosMayor(Comparable objeto, Comparable objeto2);
		bool sosMenor(Comparable objeto, Comparable objeto2);
	}
	public class PorCalificacion : EstrategiaDeComparacion {	
		public bool sosIgual(Comparable objeto, Comparable objeto2) { 
			bool igual = false;
			if (((IAlumno)objeto).getCalificacion() == ((IAlumno)objeto2).getCalificacion())
				igual = true;
			return igual;
		}
		public bool sosMayor(Comparable objeto, Comparable objeto2) { //O2 es mayor que O1
			bool mayor = false;
			if (((IAlumno)objeto).getCalificacion() < ((IAlumno)objeto2).getCalificacion())
				mayor = true;
			return mayor;
		}
		public bool sosMenor(Comparable objeto, Comparable objeto2) { //O2 es menor que O1
			bool menor = false;
			if (((IAlumno)objeto).getCalificacion() > ((IAlumno)objeto2).getCalificacion())
				menor = true;
			return menor;
		}
		public override string ToString() {
			return "Calificacion";
		}
	}	
	public class PorNombre : EstrategiaDeComparacion {
		public bool sosIgual(Comparable objeto, Comparable objeto2) { 
			bool igual = false;
			if (((Persona)objeto).getNombre() == ((Persona)objeto2).getNombre())
				igual = true;
			return igual;
		}
		public bool sosMayor(Comparable objeto, Comparable objeto2) { 
			bool mayor = false;
			if (((Persona)objeto).getNombre().CompareTo( ((Persona)objeto2).getNombre() )<0)
				mayor = true;
			return mayor;
		}
		public bool sosMenor(Comparable objeto, Comparable objeto2) { 
			bool mayor = false;
			if (((Persona)objeto).getNombre().CompareTo( ((Persona)objeto2).getNombre() )>0)
				mayor = true;
			return mayor;
		}
		public override string ToString() {
			return "Nombre";
		}
	}
		
	public class PorDni : EstrategiaDeComparacion {
		public bool sosIgual(Comparable objeto, Comparable objeto2) { 
			bool igual = false;
			if (((Persona)objeto).getDni == ((Persona)objeto2).getDni)
				igual = true;
			return igual;
		} 
		public bool sosMayor(Comparable objeto, Comparable objeto2) { //obj,this
			bool mayor = false;
			if (((Persona)objeto).getDni < ((Persona)objeto2).getDni)
				mayor = true;
			return mayor;
		}//O2 es mayor que O1
		public bool sosMenor(Comparable objeto, Comparable objeto2) { 
			bool menor = false;
			if (((Persona)objeto).getDni > ((Persona)objeto2).getDni)
				menor = true;
			return menor;
		}
		public override string ToString() {
			return "Dni";
		}
	}
	
	public class PorLegajo : EstrategiaDeComparacion {
		public bool sosIgual(Comparable objeto, Comparable objeto2) { 
			bool igual = false;
			if (((Alumno)objeto).getLegajo() == ((Alumno)objeto2).getLegajo())
				igual = true;
			return igual;
		}
		public bool sosMayor(Comparable objeto, Comparable objeto2) { //O2 es mayor que O1
			bool mayor = false;
			if (((Alumno)objeto).getLegajo() < ((Alumno)objeto2).getLegajo())
				mayor = true;
			return mayor;
		}
		public bool sosMenor(Comparable objeto, Comparable objeto2) { //O2 es menor que O1
			bool menor = false;
			if (((Alumno)objeto).getLegajo() > ((Alumno)objeto2).getLegajo())
				menor = true;
			return menor;
		}
		public override string ToString() {
			return "Legajo";
		}
	}
	
	public class PorPromedio : EstrategiaDeComparacion {	
		public bool sosIgual(Comparable objeto, Comparable objeto2) { 
			bool igual = false;
			if (((Alumno)objeto).getPromedio == ((Alumno)objeto2).getPromedio)
				igual = true;
			return igual;
		}
		public bool sosMayor(Comparable objeto, Comparable objeto2) { //O2 es mayor que O1
			bool mayor = false;
			if (((Alumno)objeto).getPromedio < ((Alumno)objeto2).getPromedio)
				mayor = true;
			return mayor;
		}
		public bool sosMenor(Comparable objeto, Comparable objeto2) { //O2 es menor que O1
			bool menor = false;
			if (((Alumno)objeto).getPromedio > ((Alumno)objeto2).getPromedio)
				menor = true;
			return menor;
		}
		public override string ToString() {
			return "Promedio";
		}
	}
	
	public class PorBonus : EstrategiaDeComparacion {	
		public bool sosIgual(Comparable objeto, Comparable objeto2) { 
			bool igual = false;
			if (((Vendedor)objeto).getBonus == ((Vendedor)objeto2).getBonus)
				igual = true;
			return igual;
		}
		public bool sosMayor(Comparable objeto, Comparable objeto2) { //O2 es mayor que O1
			bool mayor = false;
			if (((Vendedor)objeto).getBonus < ((Vendedor)objeto2).getBonus)
				mayor = true;
			return mayor;
		}
		public bool sosMenor(Comparable objeto, Comparable objeto2) { //O2 es menor que O1
			bool menor = false;
			if (((Vendedor)objeto).getBonus > ((Vendedor)objeto2).getBonus)
				menor = true;
			return menor;
		}
		public override string ToString() {
			return "Bonus";
		}
	}	
}
