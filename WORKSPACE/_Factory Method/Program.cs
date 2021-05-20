/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 20/5/2021
 * Hora: 00:44
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace _Factory_Method {
	
	public class Program {
				
		public static void Main(string[] args) {
			// Inicialización
			
			List<Alumno> alumnos = new List<Alumno>();
			
			for(int x = 0; x < 5; x++)
				alumnos.Add(new Alumno());
				
			//  Creación del curso
			
			// Variante 1: el propio método elige que crear
			Curso curso1 = DepartamentoDeAlumnos.crearCurso1(alumnos);
			
			// Variante 2: la fábrica se setea fuera del método que pide la creación de los objetos
			FabricaDeProfesores.profesorPorDefecto = FabricaDeProfesores.VISITANTE;
			Curso curso2 = DepartamentoDeAlumnos.crearCurso2(alumnos);
			
			// Variante 3: Se trabaja con una fábrica concreta
			Curso curso3 = DepartamentoDeAlumnos.crearCurso3(alumnos, new FabricaDeProfesorSuplente());
			
			Console.Write("Programa finalizado correctamente.");
			Console.ReadKey(true);
		}	
	}
}