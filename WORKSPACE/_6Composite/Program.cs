/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 16/6/2021
 * Hora: 16:43
 * 
 */
using System;

namespace _6Composite
{
	public class Program{
		
		private static Documento crearDocumento(){
			Texto d111 = new Texto("Algo que decir");
			Figura d112 = new Figura("Algo que mostrar");
			
			DocumentoCompuesto d11 = new DocumentoCompuesto("Sección 1.1");
			d11.agregarHijo(d111);
			d11.agregarHijo(d112);
			
			Texto d12 = new Texto("Algún texto");
			Figura d13 = new Figura("Alguna figura");
			
			Texto d21 = new Texto("Otro texto");
			Figura d22 = new Figura("Otra figura");
			
			DocumentoCompuesto d1 = new DocumentoCompuesto("Sección 1");
			d1.agregarHijo(d11);
			d1.agregarHijo(d12);
			d1.agregarHijo(d13);
			
			DocumentoCompuesto d2 = new DocumentoCompuesto("Sección 2");
			d2.agregarHijo(d21);
			d2.agregarHijo(d22);
			
			DocumentoCompuesto d = new DocumentoCompuesto("Documento principal");
			d.agregarHijo(d1);
			d.agregarHijo(d2);
			
			return d;
		}
		
		public static void Main(string[] args)	{
			Documento d = crearDocumento();
			
			d.leer("archivo.txt");
			d.escribir("archivo.txt");
			d.imprimir("impresora");
			
			Console.Write("Programa finalizado correctamente.");
			Console.ReadKey(true);
		}
	}
}