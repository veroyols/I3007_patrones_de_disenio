/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 20/6/2021
 * Hora: 15:09
 * 
 */
using System;

namespace Practica7 {
	
	class Program {
		
		public static void Main(string[] args) {
			
			Console.WriteLine("Hello World!");
				
			ObtenerDatos datos = new ObtenerDatos();			
			Console.WriteLine(datos.getManejador.stringDesdeArchivo(1000000000));
			
			Pila pila = new Pila();
			Aula aula = new Aula();
			pila.setOrdenInicio(new OrdenInicio(aula));
			pila.setOrdenLlegaAlumno(new OrdenLlegaAlumno(aula));
			pila.setOrdenAulaLlena(new OrdenAulaLlena(aula));

			llenar(pila,1);
			
						
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
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