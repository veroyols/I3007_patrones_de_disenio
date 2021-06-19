/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 16/6/2021
 * Hora: 21:50
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Practica6 {
	
	class Program {
		
		public static void Main(string[] args) {
			
			Console.WriteLine("Hello World!");
//			Teacher teacher = new Teacher ();
//				
//			IAlumno composite = new AlumnoCompuesto();
//			composite.agregarHijo(new AlumnoProxy());
//			composite.agregarHijo(new AlumnoProxy());
//			composite.agregarHijo(new AlumnoProxy());
//			composite.agregarHijo(new AlumnoProxy());
//			composite.agregarHijo(new AlumnoProxy());
//			teacher.goToClass(new AdaptadorDeStudent(composite));
//			teacher.teachingAClass();
			
			Persona j1 = new Persona();
			Persona j2 = new Persona();
			Console.WriteLine("1 {0} \n2 {1}",j1,j2);
			
			Template_Method template = new JuegoDeCartas();
			
			Persona ganador = template.pasos(j1,j2);
			Console.WriteLine("El ganador es {0}", ganador);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}