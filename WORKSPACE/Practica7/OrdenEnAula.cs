/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 15/6/2021
 * Hora: 22:39
 * 
 */
using System;

namespace Practica7 { //E5 E6 E7 E8

	public interface OrdenEnAula1 {
		void ejecutar();
	}
	public interface OrdenEnAula2 {	
		void ejecutar(Comparable comparable);
	}
	
	public class OrdenInicio : OrdenEnAula1 {
		public Aula aula;
		public OrdenInicio (Aula aula) {
			this.aula = aula;
		}		
		public void ejecutar(){
			Console.WriteLine("Inicio");
			this.aula.comenzar();
		}
	}	
	public class OrdenAulaLlena : OrdenEnAula1 {
		public Aula aula;
		public OrdenAulaLlena (Aula aula) {
			this.aula = aula;
		}
		public void ejecutar(){
			Console.WriteLine("Aula Llena.");
			this.aula.claseLista();
		}
	}

	public class OrdenLlegaAlumno : OrdenEnAula2 {
		private Aula aula;		
		public OrdenLlegaAlumno (Aula aula) {
			this.aula = aula;
		}
		public void ejecutar(Comparable comparable){
			Console.WriteLine("Llega Alumno : {0}", comparable);
			aula.nuevoAlumno((IAlumno)comparable);
		}
	}		
}
