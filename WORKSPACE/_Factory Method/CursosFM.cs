/*
 * Created by SharpDevelop.
 * User: Waldo
 * Date: 02/05/2019
 * Time: 15:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace _Factory_Method
{
	public class Profesor{ 	}
	
	public class ProfesorLocal : Profesor { 	}
	public class ProfesorVisitante : Profesor { 	}
	public class ProfesorSuplente : Profesor { 	}
	
	public class Alumno{  }
	
	public class Curso{
		private Profesor profesor;
		private List<Alumno> alumnos;
		
		public Curso(Profesor p, List<Alumno> a){
			profesor = p;
			alumnos = a;
		}
	}
	
	public class DepartamentoDeAlumnos{
		
		// Variante 1: El propio método elige que crear
		public static Curso crearCurso1(List<Alumno> alumnos){
			Profesor p = FabricaDeProfesores.crearProfesor(FabricaDeProfesores.SUPLENTE);
			return new Curso(p, alumnos);
		}
		
		// Variante 2: La fábrica se setea fuera del método que pide la creación de los objetos
		public static Curso crearCurso2(List<Alumno> alumnos){
			Profesor p = FabricaDeProfesores.crearProfesorPreseteado();
			return new Curso(p, alumnos);
		}
		
		// Variante 3: Se trabaja con una fábrica concreta
		public static Curso crearCurso3(List<Alumno> alumnos, FabricaDeProfesores fabrica){
			Profesor p = fabrica.crearProfesor();
			return new Curso(p, alumnos);
		}
	}
}
