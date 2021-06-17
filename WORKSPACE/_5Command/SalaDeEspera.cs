/*
 * Created by SharpDevelop.
 * User: Waldo
 * Date: 01/09/2019
 * Time: 9:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace _5Command
{
	public class Paciente{
		private int numero;
		
		public void tomarPresion(){
			Console.WriteLine("Paciente: No gracias, el tensiómetro me hace doler el brazo");
		}
		public void ofrecerTazaDeCafe(){
			Console.WriteLine("Paciente: No gracias, dudo de como esté hecho");
		}
		public void desearSuerte(){
			Console.WriteLine("Paciente: ¿Por qué me desea suerte?");
		}
		public void desinfectarAsinto(){
			Console.WriteLine("Paciente: Espere a que termine de levantarme antes de tirar ese producto");
		}
		
		public void setNumero(int n){
			numero = n;
		}
		
		public int getNumero(){
			return numero;
		}
	}
	
	public class Enfermero {
		List<Paciente> pacientesEnEspera = new List<Paciente>();
		IOrden ordenPush = null, ordenPop = null;
		int numero = 1;
		
		public Enfermero(IOrden oPush, IOrden oPop){
			ordenPush = oPush;
			ordenPop = oPop;
		}
		
		public void recibirPaciente(Paciente paciente) {
			// Método push
			Console.WriteLine("Enfermero: Buenos días, siéntese y espere a que el médico lo llame. Usted tiene el número " + numero);
			paciente.setNumero(numero);
			numero++;
			pacientesEnEspera.Add(paciente);
			ordenPush.ejecutar(paciente);
		}
		public Paciente proximoAAtender() {
			// Método pop
			Paciente p = pacientesEnEspera[0];
			Console.WriteLine("Enfermero: Paciente " + p.getNumero() + ", el médico lo atenderá ahora");
			
			pacientesEnEspera.RemoveAt(0);
			ordenPop.ejecutar(p);
			return p;
		}

		public void setOrdenPush(IOrden oPush){
			ordenPush = oPush;
		}

		public void setOrdenPop(IOrden oPop) {
			ordenPop = oPop;
		}
		
		public bool hayPacientesEnEspera(){
			return pacientesEnEspera.Count > 0;
		}

	}
	
}
