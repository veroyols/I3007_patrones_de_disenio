/*
 * Created by SharpDevelop.
 * User: Waldo
 * Date: 05/06/2019
 * Time: 14:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Chain_of_responsability
{
	
	public class Evento
	{
		private Manejador manejador;
		private Random cubilete = new Random();
		
		public Evento(Manejador m){
			manejador = m;
		}
		
		public void hacerFiesta()	{
			for(int i = 0; i < 20; i++){
				int problema = this.establecerProblema();
				this.solucionarProblema(problema);
			}
		}
		
		private int establecerProblema(){
			int p = cubilete.Next(1, 9);
			Console.WriteLine("----------------------------------------------------");
			switch(p){
					case 1: Console.WriteLine("Las luces no encienden"); break;
				case 2: Console.WriteLine("La música suena horrible"); break;
				case 3: Console.WriteLine("Una mesa se rompió"); break;
				case 4: Console.WriteLine("Una silla se rompió"); break;
				case 5: Console.WriteLine("A alguien se le descoció la ropa"); break;
				case 6: Console.WriteLine("¡FUEGO! ¡FUEGO!"); break;
				case 7: Console.WriteLine("Alguien cayó desamayado"); break;
				case 8: Console.WriteLine("Huele a gas"); break;
			}
			return p;
		}
		
		private void solucionarProblema(int p){
			switch(p){
				case 1: manejador.arreglarLuces(); break;
				case 2: manejador.corregirSonido(); break;
				case 3: manejador.arreglarMesa(); break;
				case 4: manejador.encolarSilla(); break;
				case 5: manejador.cocerCamisa(); break;
				case 6: manejador.apagarFocoDeIncendio(); break;
				case 7: manejador.atenderUnDesmayo(); break;
				case 8: manejador.arreglarPerdidaDeGas(); break;
			}
			Console.WriteLine("----------------------------------------------------");
		}
	}
}
