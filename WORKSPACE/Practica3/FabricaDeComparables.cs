/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 25/5/2021
 * Hora: 19:54
 * 
 */
using System;

namespace Practica3 {
	
	public abstract class FabricaDeComparables {
		
		public const int ALUMNO = 1;
		public const int PERSONA = 2;
		public const int NUMERO = 3;
		public const int CLAVEVALOR = 4;
			
		public static Comparable crear (int queComparable){
			FabricaDeComparables fabrica = null;
		
			switch(queComparable){
				case ALUMNO: 
			        fabrica = new FabricaDeAlumno();
			        break;
				case PERSONA:
			        fabrica = new FabricaDePersona();
			        break;
			    case NUMERO:
			        fabrica = new FabricaDeNumero();
			        break;
			    case CLAVEVALOR:
			        fabrica = new FabricaDeClaveValor();
			        break;
			}
		return fabrica.crearComparable();
		}
		
		public static Comparable crearAleatorio(){
			GeneradorDeDatosAleatorio generador = new GeneradorDeDatosAleatorio();
			return FabricaDeComparables.crear(generador.numeroAleatorio(3) + 1);
		}/*crearAleatorio()  Devuelve un Comparable generado aleatoriamente*/
		
		public static Comparable crearPorTeclado(){
			Console.WriteLine("Ingrese un numero: \n(1)ALUMNO \n(2)PERSONA \n(3)NUMERO \n(4)CLAVEVALOR");
			int queComparable = int.Parse(Console.ReadLine());
			return FabricaDeComparables.crear(queComparable);
		}/* crearPorTeclado()  Devuelve un comparable donde los datos se ingresan por teclado*/

		public abstract Comparable crearComparable();		
	}
	
		public class FabricaDeAlumno : FabricaDeComparables{
			override public Comparable crearComparable(){
				return new Alumno();
		}
	}
		public class FabricaDePersona : FabricaDeComparables{
			override public Comparable crearComparable(){
				return new Persona();
		}
	}
		public class FabricaDeNumero: FabricaDeComparables{
			override public Comparable crearComparable(){
				return new Numero();
		}
	}
		public class FabricaDeClaveValor: FabricaDeComparables{
			override public Comparable crearComparable(){
				return new ClaveValor();
		}
	}	
}

