/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 16/6/2021
 * Hora: 19:36
 * 
 */
using System;

namespace Practica6 {
	
	public abstract class Coleccion :  Ordenable {
		protected OrdenEnAula1 orden1, orden3;
		protected OrdenEnAula2 orden2;
		
		//Ordenable
		public void setOrdenInicio(OrdenEnAula1 o) {			
			this.orden1 = o;
			return; 
		}
		public void setOrdenLlegaAlumno(OrdenEnAula2 o) {
			this.orden2 = o;
			return; 
		}
		public void setOrdenAulaLlena(OrdenEnAula1 o) {
			this.orden3 = o;
			return; 
		}
		
	}
}
