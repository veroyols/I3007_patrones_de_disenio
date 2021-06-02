/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 28/5/2021
 * Hora: 19:35
 * 
 */
using System;

namespace Practica4 {
	
	class Program {
		
		public static void Main(string[] args) {
			
			/* E4: Teacher x20 goToClass.*/
			Teacher teacher = new Teacher ();

			for (int i = 0; i < 10; i++) {
				IAlumno decorado = new Alumno();
				decorado = new DecoradoConLegajo(decorado);
				decorado = new DecoradoConLetras (decorado);
				decorado = new DecoradoConDescripcion (decorado);
				decorado = new DecoradoConPosicion(decorado,i);
				decorado = new DecoradoConAsteriscos (decorado);
				teacher.goToClass(new AdaptadorDeStudent(decorado)); 
			}
			
			for (int i = 0; i < 10; i++) {
				IAlumno decorado = new AlumnoMuyEstudioso();
				decorado = new DecoradoConLegajo(decorado);
				decorado = new DecoradoConLetras (decorado);
				decorado = new DecoradoConDescripcion (decorado);
				decorado = new DecoradoConPosicion(decorado,i+10);
				decorado = new DecoradoConAsteriscos (decorado);
				teacher.goToClass(new AdaptadorDeStudent(decorado)); 
			}			
			teacher.teachingAClass();
			
			//E6
//			Console.WriteLine("IAlumno para decorar: ");
//			IAlumno decorado = new Alumno("Raton Perez",6);
//			decorado = new DecoradoConLegajo(decorado);
//			decorado = new DecoradoConLetras (decorado);
//			decorado = new DecoradoConDescripcion (decorado);
//			decorado = new DecoradoConPosicion(decorado,5);
//			decorado = new DecoradoConAsteriscos (decorado);
//			Console.WriteLine(decorado.mostrarCalificacion());	
//
//			Student student = new AdaptadorDeStudent(decorado);
			
//			Coleccionable<Comparable> coleccion = new Pila();
//			llenar(coleccion,1);
//			Iterador iterador = coleccion.crearIterador();
//			while(!iterador.fin()){
//				AdaptadorDeStudent student = new AdaptadorDeStudent ((Alumno)iterador.actual());
//				iterador.siguiente();
//			}	
//			teacher.setStudents(coleccion);
			
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