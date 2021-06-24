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
				
//			ObtenerDatos datos = new ObtenerDatos();			
//			Console.WriteLine(datos.getManejador.stringDesdeArchivo(19));
			
			Pila pila = new Pila();
			Aula aula = new Aula();
			pila.setOrdenInicio(new OrdenInicio(aula));
			pila.setOrdenLlegaAlumno(new OrdenLlegaAlumno(aula));
			pila.setOrdenAulaLlena(new OrdenAulaLlena(aula));
			
			llenarDesdeArchivo(pila,0); // 1 = alumnos
//			llenar(pila,0);
			
			Console.WriteLine("IMPRIMIR PILA");
			foreach (Alumno element in pila.Elementos) {
				Console.WriteLine(element);
			}
			Console.ReadKey(true);
			
			Console.WriteLine("GUARDAR PILA");
			GuardarPila(pila); //nuevo.txt
				
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static void GuardarPila (Coleccionable<Comparable> coleccion) {
			StreamWriter archivo = new StreamWriter("nuevo.txt", false);
			Iterador itera = coleccion.crearIterador();		
			for (int i = 0; i < coleccion.cuantos(); i++) {
				archivo.WriteLine(itera.actual());
				itera.siguiente();
			}
			archivo.Close();			
		}
		
		public static void llenarDesdeArchivo(Coleccionable<Comparable> coleccion, int queComparable){ //0 AlEst, 1Al, 2Num, 3Vend
			Iterador iteradorDeColeccion = coleccion.crearIterador();
			int i = 0;
			Comparable a = FabricaDeComparables.crearPorArchivo(queComparable, i++);
			while (a !=null) {
				coleccion.agregar(a);
				Console.WriteLine(a);
				a = FabricaDeComparables.crearPorArchivo(queComparable, i++);
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