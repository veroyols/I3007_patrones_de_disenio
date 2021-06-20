/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 25/5/2021
 * Hora: 19:54
 * 
 */
using System;

namespace Practica7 {
	
	public abstract class FabricaDeComparables {
		
		protected ObtenerDatos datos = new ObtenerDatos();	
//		protected GeneradorDeDatosAleatorio generador = new GeneradorDeDatosAleatorio();
		public const int ALUMNOESTUDIOSO = 0;
		public const int ALUMNO = 1;
		public const int NUMERO = 2;
		public const int VENDEDOR = 3;
			
		public static Comparable crearAleatorio (int queComparable){
			FabricaDeComparables fabrica = null;		
			switch(queComparable){
				case ALUMNOESTUDIOSO:
			        fabrica = new FabricaDeAlumnoEstudioso();
			        break;
				case ALUMNO:
			        fabrica = new FabricaDeAlumno();
			        break;
			    case NUMERO:
			        fabrica = new FabricaDeNumero();
			        break;
			    case VENDEDOR:
			        fabrica = new FabricaDeVendedor();
			        break;
			}
		return fabrica.crearComparableAleatorio();
		}
		public static Comparable crearPorTeclado (int queComparable){
			FabricaDeComparables fabrica = null;
			switch(queComparable){
				case ALUMNO: 
			        fabrica = new FabricaDeAlumno();
			        break;
			    case NUMERO:
			        fabrica = new FabricaDeNumero();
			        break;
			    case VENDEDOR:
			        fabrica = new FabricaDeVendedor();
			        break;
			}
		return fabrica.crearComparablePorTeclado();
		}
		public static Comparable crearPorArchivo (int queComparable){
			FabricaDeComparables fabrica = null;
			switch(queComparable){
				case ALUMNO: 
			        fabrica = new FabricaDeAlumno();
			        break;
			    case NUMERO:
			        fabrica = new FabricaDeNumero();
			        break;
			    case VENDEDOR:
			        fabrica = new FabricaDeVendedor();
			        break;
			}
		return fabrica.crearComparablePorArchivo();
		}
		
		public abstract Comparable crearComparableAleatorio();
		public abstract Comparable crearComparablePorTeclado();		
		public abstract Comparable crearComparablePorArchivo();		
	}
	
	public class FabricaDeAlumnoEstudioso : FabricaDeComparables{
		public override Comparable crearComparableAleatorio(){
			return new AlumnoMuyEstudioso();
		}	
		public override Comparable crearComparablePorTeclado(){
			Console.Write("Ingrese nombre: ");
			string nombre = Console.ReadLine();
			Console.Write("Ingrese dni: ");
			int dni = int.Parse(Console.ReadLine());
			Console.Write("Ingrese promedio: ");
			int promedio = int.Parse(Console.ReadLine());
			//estrategia por defecto en Alumno
			return new AlumnoMuyEstudioso(nombre,dni,promedio);
		}
		public override Comparable crearComparablePorArchivo(){
			string nombre = datos.getManejador.stringDesdeArchivo(10);
			int dni = datos.getManejador.numeroDesdeArchivo(10);
			int promedio = datos.getManejador.numeroDesdeArchivo(1);
			//estrategia por defecto en Alumno
			return new AlumnoMuyEstudioso(nombre,dni,promedio);
		}		
	}
	
	public class FabricaDeAlumno : FabricaDeComparables{
		public override Comparable crearComparableAleatorio(){
			return new Alumno();
		}	
		public override Comparable crearComparablePorTeclado(){
			Console.Write("Ingrese nombre: ");
			string nombre = Console.ReadLine();
			Console.Write("Ingrese dni: ");
			int dni = int.Parse(Console.ReadLine());
			Console.Write("Ingrese promedio: ");
			int promedio = int.Parse(Console.ReadLine());
			//estrategia por defecto en Alumno
			return new Alumno(nombre,dni,promedio);
		}		
		public override Comparable crearComparablePorArchivo(){
			string nombre = datos.getManejador.stringDesdeArchivo(10);
			int dni = datos.getManejador.numeroDesdeArchivo(10);
			int promedio = datos.getManejador.numeroDesdeArchivo(1);
			//estrategia por defecto en Alumno
			return new Alumno(nombre,dni,promedio);
		}		
	}
		
	public class FabricaDeNumero: FabricaDeComparables{
		public override Comparable crearComparableAleatorio(){
			return new Numero(datos.getManejador.numeroAleatorio(1000));
		}
		public override Comparable crearComparablePorTeclado(){
			Console.WriteLine("Ingrese numero entero");
			return new Numero(datos.getManejador.numeroPorTeclado());
		}
		public override Comparable crearComparablePorArchivo(){
			Console.WriteLine("Leyendo desde archivo");
			return new Numero(datos.getManejador.numeroDesdeArchivo(1000));
		}
	}
	
	public class FabricaDeVendedor: FabricaDeComparables{ 
		public override Comparable crearComparableAleatorio(){
			string nombre = datos.getManejador.stringAleatorio(4);
			int dni = datos.getManejador.numeroAleatorio(99999999);
			int sueldo = datos.getManejador.numeroAleatorio(1000);
			//estrategia por defecto en Bonus
			return new Vendedor(nombre,dni,sueldo);		}
		public override Comparable crearComparablePorTeclado(){
			Console.Write("Ingrese nombre: ");
			string nombre = Console.ReadLine();
			Console.Write("Ingrese dni: ");
			int dni = int.Parse(Console.ReadLine());
			Console.Write("Ingrese sueldo $");
			int sueldo = int.Parse(Console.ReadLine());
			//estrategia por defecto en Bonus
			return new Vendedor(nombre,dni,sueldo);
		}
		public override Comparable crearComparablePorArchivo () {
			string nombre = datos.getManejador.stringDesdeArchivo(10);
			int dni = datos.getManejador.numeroDesdeArchivo(10);
			int sueldo = datos.getManejador.numeroDesdeArchivo(4);
			//estrategia por defecto en Alumno
			return new Vendedor(nombre,dni,sueldo);
		}
	}	
}
	
	

