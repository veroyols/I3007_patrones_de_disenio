/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 2/6/2021
 * Hora: 03:42
 * 
 */
using System;

namespace Practica5 {
	
	class Program {
		
		public static void Main(string[] args) {
			
			Console.WriteLine("Hello World!");
			/* E4: Teacher x20 goToClass.*/
			Teacher teacher = new Teacher ();

			for (int i = 0; i < 5; i++) {
				IAlumno decorado = new AlumnoProxy();
				decorado = new DecoradoConLegajo(decorado);
				decorado = new DecoradoConLetras (decorado);
				decorado = new DecoradoConDescripcion (decorado);
				decorado = new DecoradoConPosicion(decorado,i);
				decorado = new DecoradoConAsteriscos (decorado);
				teacher.goToClass(new AdaptadorDeStudent(decorado)); 
			}
			
			for (int i = 0; i < 5; i++) {
				IAlumno decorado = new AlumnoMuyEstudioso();
				decorado = new DecoradoConLegajo(decorado);
				decorado = new DecoradoConLetras (decorado);
				decorado = new DecoradoConDescripcion (decorado);
				decorado = new DecoradoConPosicion(decorado,i+10);
				decorado = new DecoradoConAsteriscos (decorado);
				teacher.goToClass(new AdaptadorDeStudent(decorado)); 
			}			
			teacher.teachingAClass();
			Console.WriteLine("...");
			Console.ReadKey(true);
		}
		
		public static void llenar(Coleccionable<Comparable> coleccion, int queComparable){ 
			Iterador iteradorDeColeccion = coleccion.crearIterador();
			for (int i = 0; i < 20; i++) { //E6
				coleccion.agregar(FabricaDeComparables.crearAleatorio(queComparable));
				iteradorDeColeccion.siguiente();			
			}
		}//E7
		public static void imprimirElementos (Coleccionable<Comparable> coleccionable) {
			Console.WriteLine("------------------------"); 		
			Console.WriteLine("---Imprimir Elementos---");
			Iterador IteradorDeColeccion = coleccionable.crearIterador();
			Console.WriteLine("Imprimir {0} ",coleccionable);
			while(!IteradorDeColeccion.fin()){
				Console.WriteLine(IteradorDeColeccion.actual());
				IteradorDeColeccion.siguiente();
			}
		}
		public static void imprimirMejorPromedio (Coleccionable<Comparable> coleccionable) {
			cambiarEstrategia(coleccionable, new PorPromedio());
			Console.WriteLine("-----------------------"); 
			Console.WriteLine("---Mejores Promedios---");
			Iterador IteradorDeColeccion = coleccionable.crearIterador();
			Console.WriteLine("Imprimir {0} ",coleccionable);
			while(!IteradorDeColeccion.fin()){
				if (((Alumno)IteradorDeColeccion.actual()).sosMayor(new Alumno("",0,7 ) ) ) {
					Console.WriteLine(IteradorDeColeccion.actual());
				}
				IteradorDeColeccion.siguiente();
			}
		}		
		public static void cambiarEstrategia (Coleccionable<Comparable> coleccion, EstrategiaDeComparacion estrategia) {
			Iterador IteradorDeColeccion = coleccion.crearIterador();
			while(!IteradorDeColeccion.fin()){
				((Persona)IteradorDeColeccion.actual()).getEstrategia = estrategia;
				IteradorDeColeccion.siguiente();
			}	
		}
		public static void jornadaDeVentas (Coleccionable<Comparable> vendedores) {
			for (int i = 0; i < 20; i++) {
				Iterador iteradorDeColeccion = vendedores.crearIterador();
				GeneradorDeDatosAleatorio generador = new GeneradorDeDatosAleatorio();
				while(!iteradorDeColeccion.fin()){
					int monto = generador.numeroAleatorio(6999);
					((Vendedor)iteradorDeColeccion.actual()).venta(monto+1);
					iteradorDeColeccion.siguiente();
				}
			}
		}		
	}
}