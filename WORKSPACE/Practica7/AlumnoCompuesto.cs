/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 16/6/2021
 * Hora: 21:57
 * 
 */
using System;
using System.Collections.Generic;

namespace Practica7 {
	
	public class AlumnoCompuesto : IAlumno{
		private List<IAlumno> hijos;
		
		public AlumnoCompuesto() {
			this.hijos = new List<IAlumno>();
		}
		public void agregarHijo (IAlumno hijo) {
			hijos.Add(hijo);
		}
		public virtual int responderPregunta(int pregunta) {
			int rta;
			int [] arreglo = new int[3] {0,0,0};
			
			for (int i = 0; i < hijos.Count; i++) {
				rta = hijos[i].responderPregunta(pregunta);
				if (rta == 1) arreglo[0]++;
				if (rta == 2) arreglo[1]++;
				if (rta == 3) arreglo[2]++;
			}
			int max = -1;
			for (int i = 0; i < 3; i++) {
				if (arreglo[i]>max) max = arreglo[i];
			}
			return max;
		} //devuelve la respuesta más votada por todos los componentes-hijos del compuesto
		
		public virtual string mostrarCalificacion() {
			foreach (IAlumno alumnoComp in hijos) {
				alumnoComp.mostrarCalificacion();
			}
			return ""; //le envía el mismo mensaje a todos los componentes-hijos del compuesto.
		}
		public virtual int getLegajo() {		
			return 0;
		}
		public virtual int getCalificacion() {
			return 0;
		}
		public virtual void setCalificacion(int calificacion) {
			foreach (IAlumno alumnoComp in hijos) {
				alumnoComp.setCalificacion(calificacion);
			}
			return; // setea la calificación a todos los componentes-hijos del compuesto.
		}
		public virtual string getNombre() {
			foreach (IAlumno alumnoComp in hijos) {
				alumnoComp.getNombre();
			}
			return "";//getNombre: devuelve el nombre y apellido de todos los componentes-hijos del compuesto.
		}
		public virtual bool sosIgual(Comparable objeto) {
			bool igual = false;
			foreach (IAlumno alumnoComp in hijos) {
				if (alumnoComp.sosIgual(objeto)) {
					igual =true;
				}
			}
			return igual;//sosIgual: devuelve true si existe un componente-hijo que sea igual al Alumno recibido por parámetro.
		}
		public virtual bool sosMenor(Comparable objeto) {
			bool menor = true;
			foreach (IAlumno alumnoComp in hijos) {
				if ( (alumnoComp.sosMayor(objeto)) || (!alumnoComp.sosIgual(objeto)) ) {
					menor = false;
				}
			}
			return menor;//sosMenor: devuelve true si todos los componentes-hijos son más chicos que el Alumno recibido por parámetro.
		}
		public virtual bool sosMayor(Comparable objeto) {
			bool mayor = true;
			foreach (IAlumno alumnoComp in hijos) {
				if ( (alumnoComp.sosMenor(objeto)) || (!alumnoComp.sosIgual(objeto)) ) {
					mayor = false;
				}
			}
			return mayor;//sosMayor: devuelve true si todos los componentes-hijos son más grandes que el Alumno recibido por parámetro
		}
	}
}
