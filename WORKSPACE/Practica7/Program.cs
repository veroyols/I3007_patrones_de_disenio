/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 20/6/2021
 * Hora: 15:09
 * 
 */
using System;
using System.IO;

namespace Practica7 {
	
	class Program {
		
		public static void Main(string[] args) {
			
			Console.WriteLine("Hello World!");
				
			ObtenerDatos datos = new ObtenerDatos();			
			Console.WriteLine(datos.getManejador.stringDesdeArchivo(19));
			
			Pila pila = new Pila();
			Aula aula = new Aula();
			pila.setOrdenInicio(new OrdenInicio(aula));
			pila.setOrdenLlegaAlumno(new OrdenLlegaAlumno(aula));
			pila.setOrdenAulaLlena(new OrdenAulaLlena(aula));
			llenarDesdeArchivo(pila,1); // 1 = alumnos
			
			Console.WriteLine("IMPRIMIR PILA");
			foreach (Alumno element in pila.Elementos) {
				Console.WriteLine(element);
			}
			
//			GuardarPila(pila); //nuevo.txt
				
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static void GuardarPila (Coleccionable<Comparable> coleccion) {
			StreamWriter archivo = new StreamWriter("nuevo.txt", true);
			Iterador itera = coleccion.crearIterador();
			while (!itera.fin()) {
				archivo.WriteLine(itera.actual());
				itera.siguiente();				
			}
			archivo.Close();			
		}
		
		public static void llenarDesdeArchivo(Coleccionable<Comparable> coleccion, int queComparable){ //0 AlEst, 1Al, 2Num, 3Vend
			Iterador iteradorDeColeccion = coleccion.crearIterador();
			for (int i = 0; i < 20; i++) { //E6
				Comparable a = FabricaDeComparables.crearPorArchivo(queComparable, i);
				coleccion.agregar(a);
				Console.WriteLine(a);
			}
		}	
		public static void llenar(Coleccionable<Comparable> coleccion, int queComparable){ //0 AlEst, 1Al, 2Num, 3Vend
			Iterador iteradorDeColeccion = coleccion.crearIterador();
			for (int i = 0; i < 20; i++) { //E6
				Comparable a = FabricaDeComparables.crearAleatorio(queComparable);
				coleccion.agregar(a);
				Console.WriteLine(a);
				iteradorDeColeccion.siguiente();		
			}
		}		
	}
}