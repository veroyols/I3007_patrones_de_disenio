/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 21/4/2021
 * Hora: 21:52
 * 
 */
using System;

namespace Practica2 { /*Ejercicio1: Implemente cuatro estrategias de comparación para la clase Alumno.*/
	
	public interface EstrategiaDeComparacion{ //obj,this
		bool sosIgual(Comparable objeto, Comparable objeto2);
		bool sosMayor(Comparable objeto, Comparable objeto2);
		bool sosMenor(Comparable objeto, Comparable objeto2);
	}
	
	public class PorNombre : EstrategiaDeComparacion { //Ejercicio1
		
		public bool sosIgual(Comparable objeto, Comparable objeto2) { 
			bool igual = false;
			if (((Alumno)objeto).getNombre == ((Alumno)objeto2).getNombre)
				igual = true;
			return igual;
		}

		public bool sosMayor(Comparable objeto, Comparable objeto2) { 
			return false;
		} //false

		public bool sosMenor(Comparable objeto, Comparable objeto2) { 
			return false;
		} //false
	}
		
	public class PorDni : EstrategiaDeComparacion {
		
		public bool sosIgual(Comparable objeto, Comparable objeto2) { 
			bool igual = false;
			if (((Alumno)objeto).getDni == ((Alumno)objeto2).getDni)
				igual = true;
			return igual;
		} 

		public bool sosMayor(Comparable objeto, Comparable objeto2) { //obj,this
			bool mayor = false;
			if (((Alumno)objeto).getDni < ((Alumno)objeto2).getDni)
				mayor = true;
			return mayor;
		}//O2 es mayor que O1

		public bool sosMenor(Comparable objeto, Comparable objeto2) { //O2 es menor que O1
			bool menor = false;
			if (((Alumno)objeto).getDni > ((Alumno)objeto2).getDni)
				menor = true;
			return menor;
		}
	}
	
	public class PorLegajo : EstrategiaDeComparacion {
		
		public bool sosIgual(Comparable objeto, Comparable objeto2) { 
			bool igual = false;
			if (((Alumno)objeto).getLegajo == ((Alumno)objeto2).getLegajo)
				igual = true;
			return igual;
		}

		public bool sosMayor(Comparable objeto, Comparable objeto2) { //O2 es mayor que O1
			bool mayor = false;
			if (((Alumno)objeto).getLegajo < ((Alumno)objeto2).getLegajo)
				mayor = true;
			return mayor;
		}

		public bool sosMenor(Comparable objeto, Comparable objeto2) { //O2 es menor que O1
			bool menor = false;
			if (((Alumno)objeto).getLegajo > ((Alumno)objeto2).getLegajo)
				menor = true;
			return menor;
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
	}
}
