/*
 * Created by SharpDevelop.
 * User: Waldo
 * Date: 05/06/2019
 * Time: 13:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace _Template_Method {
	
	abstract public class Evento {
		
		private int invitados = 500;
		private bool huboProblemas = false; 
		
		public void hacerFiesta(){
			this.vestirAAgasajado();
			this.enviarInvitaciones();
			this.prepararSalon();
			while(this.quedenInvitados()){
				this.ponerMusica();
				this.servirComida();
				this.sacarFotos();
			}
			this.entregarRecuerdo();
			if(this.noHuboProblemas())
				this.limpiarSalon();
		}
		
		protected void limpiarSalon(){
			Console.WriteLine("Limpiando el enchastre que quedó.");
		}
		
		protected void sacarFotos(){ 
			Console.WriteLine("Sacando fotos"); 
		}
		
		protected bool quedenInvitados(){
			invitados -= 50;
			return invitados > 0;
		}
		
		protected bool noHuboProblemas(){
			return ! huboProblemas;
		}


		abstract protected void vestirAAgasajado();
		abstract protected void enviarInvitaciones();
		abstract protected void prepararSalon();
		abstract protected void ponerMusica();
		abstract protected void servirComida();
		abstract protected void entregarRecuerdo();

	}
}
