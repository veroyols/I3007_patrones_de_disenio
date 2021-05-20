/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 19/5/2021
 * Hora: 12:30
 * 
ITERATOR
Permite de recorrer todos los elementos de CUALQUIER estructura de datos secuencialmente (independientemente de la estructura)
El patron iterador es el que me da los elementos que necesito de la estructura. 
 *ITERADOR: El mecanismo por el que recorremos la secuencia de inicio a fin. gracias al
 *ENUMERADOR. Responsable de sacar el elemento siguiente (segun las reglas de la secuencia enumerable)
Ejemplo: c# provee el patron iterador: foreach

Implementacion - Interfaces importantes:
 *ENUMERATOR: define al enumerador
 *ENUMERABLE: indica que esa clase puede ser usada por el iterador
 
*/
using System;

namespace _Iterator {
	
	public class Program {
				
		public static void Main(string[] args)	{
			IDocumento docText = crearDocumentoDeTexto();
			IDocumento docPres = crearPresentacion();
			
			Impresora i = new Impresora();
			i.imprimir(docText);
			i.imprimir(docPres);
			
			Console.Write("Programa finalizado correctamente.");
			Console.ReadKey(true);
		}
		
		private static IDocumento crearDocumentoDeTexto(){
			int paginas = 10;
			IDocumento d = new DocumentoDeTexto(paginas, "Manual del uso de los patrones de diseño");
			for(int i= 1; i<= paginas; i++)
				d.agregarPagina(new Pagina(i));
			return d;
		}
		
		private static IDocumento crearPresentacion(){
			int paginas = 6;
			IDocumento d = new Presentacion("Presentación para el buen uso de los patrones de diseño");
			for(int i= 1; i<= paginas; i++)
				d.agregarPagina(new Pagina(i));
			return d;
		}
	}

}