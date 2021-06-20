/*
 * Created by SharpDevelop.
 * User: Waldo
 * Date: 12/06/2019
 * Time: 8:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Chain_of_responsability
{
	public abstract class Manejador
	{
		Manejador sucesor = null;

		public Manejador(Manejador s){
			sucesor = s;
		}

		virtual public void arreglarLuces() {
			if(sucesor != null) 
				sucesor.arreglarLuces();
		}
		virtual public void corregirSonido() {
			if(sucesor != null) 
				sucesor.corregirSonido();
		}
		virtual public void arreglarMesa() {
			if(sucesor != null)
				sucesor.arreglarMesa();
		}
		virtual public void encolarSilla() {
			if(sucesor != null) 
				sucesor.encolarSilla();
		}
		virtual public void cocerCamisa() {
			if(sucesor != null) 
				sucesor.cocerCamisa();
		}
		virtual public void apagarFocoDeIncendio() {
			if(sucesor != null)
				sucesor.apagarFocoDeIncendio();
		}
		virtual public void atenderUnDesmayo() {
			if(sucesor != null)
				sucesor.atenderUnDesmayo();
		}
		virtual public void arreglarPerdidaDeGas() {
			if(sucesor != null)
				sucesor.arreglarPerdidaDeGas();
		}

	}
	
	public class Gasista : Manejador{
		public Gasista(Manejador m) : base (m){ }
		
		override public void arreglarPerdidaDeGas() {
			Console.WriteLine("Arreglando la pérdida de gas");
		}
	}
	
	public class Electricista : Manejador{
		public Electricista(Manejador m) : base (m){ }
		
		override public void arreglarLuces() {
			Console.WriteLine("Arreglando las luces que fallan");
		}
	}
	
	public class Carpintero : Manejador{
		public Carpintero(Manejador m) : base (m){ }
		
		override public void arreglarMesa() {
			Console.WriteLine("Arreglando la mesa");
		}
		override public void encolarSilla() {
			Console.WriteLine("Encolando la silla");
		}
	}
	
	public class Bombero : Manejador{
		public Bombero(Manejador m) : base (m){ }
		
		override public void arreglarLuces() {
			Console.WriteLine("Bajando la térmica para arreglar las luces... igual pido ayuda al alectricista...");
			base.arreglarLuces();
		}
		override public void arreglarPerdidaDeGas() {
			Console.WriteLine("Cerrando la llave de paso... igual pido ayuda al gasista...");
			base.arreglarPerdidaDeGas();
		}
		override public void atenderUnDesmayo() {
			Console.WriteLine("Aplicando primeros auxilios... igual pido ayuda al médico...");
			base.atenderUnDesmayo();
		}
		override public void apagarFocoDeIncendio() {
			Console.WriteLine("Esta tarea es solo mía... apagando el incendio");
		}
		
	}
}
