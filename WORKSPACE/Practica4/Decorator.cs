/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 31/5/2021
 * Hora: 01:36
 * 
 */
using System;

namespace Practica4 {

	public abstract class DecoradorDeAlumno : IAlumno {
		
		protected IAlumno decorador;
		
		public DecoradorDeAlumno(IAlumno iAlumno){
			this.decorador = iAlumno;
		}	
		public virtual int responderPregunta(int pregunta) {
			return decorador.responderPregunta(pregunta);
		}
		public virtual string mostrarCalificacion() {
			return decorador.mostrarCalificacion();
		}
		public int getLegajo() {
			return this.decorador.getLegajo();
		}
		public int getCalificacion() {
			return this.decorador.getCalificacion();
		}
		public void setCalificacion(int calificacion) {
			this.decorador.setCalificacion(calificacion);
		}
		public string getNombre() {
			return this.decorador.getNombre();
		}
		public bool sosIgual(Comparable objeto) {
			return this.decorador.sosIgual(objeto);
		}
		public bool sosMenor(Comparable objeto){
			return this.decorador.sosMenor(objeto);
		}
		public bool sosMayor(Comparable objeto){
			return this.decorador.sosMayor(objeto);
		}
		
	}
	
	public class DecoradoConLegajo : DecoradorDeAlumno  {
		public DecoradoConLegajo(IAlumno iAlumno) : base (iAlumno){
		}
		public override string mostrarCalificacion() {
			return decorador.getNombre()+"("+decorador.getLegajo()+") "+decorador.getCalificacion();
		}
	} //Ratón Pérez (12345/6) 6
	public class DecoradoConLetras : DecoradorDeAlumno  {
		public DecoradoConLetras(IAlumno iAlumno) : base (iAlumno){}
		public override string mostrarCalificacion() {
			int nota = decorador.getCalificacion();
			string letras;
			switch (nota) {
				case 0:
					letras = "(cero)";
					break;
				case 1:
					letras = "(uno)";
					break;
				case 2:
					letras = "(dos)";
					break;
				case 3:
					letras = "(tres)";
					break;
				case 4:
					letras = "(cuatro)";
					break;
				case 5:
					letras = "(cinco)";
					break;
				case 6:
					letras = "(seis)";
					break;
				case 7:
					letras = "(siete)";
					break;
				case 8:
					letras = "(ocho)";
					break;
				case 9:
					letras = "(nueve)";
					break;
				case 10:
					letras = "(diez)";
					break;
				default:
					letras = "(desconocido)";
					break;
			}
			return decorador.mostrarCalificacion()+letras;
		}
	} //Ratón Pérez 6 (SEIS)

	public class DecoradoConDescripcion : DecoradorDeAlumno  {
		public DecoradoConDescripcion(IAlumno iAlumno) : base (iAlumno){}
		public override string mostrarCalificacion() {
			int nota = decorador.getCalificacion();
			string descripcion;
			if (nota >= 7) {
				descripcion = " (PROMOCIONA)";
			}
			if (nota >= 4 && nota < 7) {
				descripcion = " (APROBADO)";
			}
			else {
				descripcion = " (DESAPROBADO)";
			}
			
			return decorador.mostrarCalificacion()+descripcion;
		}
	} //Ratón Pérez 6 (APROBADO)

	public class DecoradoConAsteriscos : DecoradorDeAlumno  {
		public DecoradoConAsteriscos(IAlumno iAlumno) : base (iAlumno){}
		public override string mostrarCalificacion() {
			int cant = decorador.mostrarCalificacion().Length;
			string asteriscos = new String ('*',cant+4);
			return asteriscos+"\n* "+decorador.mostrarCalificacion()+" * \n" + asteriscos;
		}
	} //*****
	public class DecoradoConPosicion : DecoradorDeAlumno  { 
		private int posicion;
		public DecoradoConPosicion(IAlumno iAlumno, int pos) : base (iAlumno){
			this.posicion = pos;
		}
		public override string mostrarCalificacion() {
			return posicion+") "+decorador.mostrarCalificacion();
		}
	} //numero de orden
}
