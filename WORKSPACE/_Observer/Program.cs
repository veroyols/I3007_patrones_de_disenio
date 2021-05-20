/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 20/5/2021
 * Hora: 00:57
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace _Observer {
	
	public class Program {
				
		public static void Main(string[] args)	{
			
			//Inicialización
			Terminal t = new Terminal();
			Cajero[] cs = new Cajero[5];
			for(int c = 0; c < 5; c++){
				cs[c] = new Cajero(c+1);
				t.agregarObservador(cs[c]);
			}
			for(int c = 0; c < 5; c++){
				for(int d = 0; d < 5; d++){
					if(c != d)
						cs[c].agregarObservador(cs[d]);
				}
			}
			
			//Simulación
			Random r = new Random();
			for(int c = 1; c <= 100; c++){
				if(r.NextDouble() > 0.4)
					t.solicitar();
				else{
					int cj = r.Next(5);
					cs[cj].llamar();
				}
			}
			
			Console.Write("Programa finalizado correctamente.");
			Console.ReadKey(true);
		}
	}
}