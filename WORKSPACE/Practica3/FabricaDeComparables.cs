///*
// * Creado por SharpDevelop.
// * Usuario: veros
// * Fecha: 25/5/2021
// * Hora: 19:54
// * 
// */
//using System;
//
//namespace Practica3 {
//	
//	public abstract class FabricaDeComparables {
//		
//		Comparable crearAleatorio ();/*crearAleatorio()  Devuelve un Comparable generado aleatoriamente*/
//		Comparable crearPorTeclado ();/* crearPorTeclado()  Devuelve un comparable donde los datos se ingresan por teclado*/
//
//
//		public const int LOCAL = 1;
//		public const int VISITANTE = 2;
//		public const int SUPLENTE = 3;
//		
//		public static int profesorPorDefecto = LOCAL;
//		
//		public static Profesor crearProfesorPreseteado(){
//			return crearProfesor(profesorPorDefecto);
//		}
//		
//		public static Profesor crearProfesor(int queProfesor){
//			FabricaDeProfesores fabrica = null;
//		
//			switch(queProfesor){
//				case LOCAL: 
//			        fabrica = new FabricaDeProfesorLocal();
//			        break;
//				case VISITANTE:
//			        fabrica = new FabricaDeProfesorVisitante();
//			        break;
//			    case SUPLENTE:
//			        fabrica = new FabricaDeProfesorSuplente();
//			        break;
//		}
//		return fabrica.crearProfesor();
//	}
//		
//	public abstract Profesor crearProfesor();		
//		
//	}
//}
