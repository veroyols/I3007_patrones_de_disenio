/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 19/5/2021
 * Hora: 20:43
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace _Template_Method {
	
	public class CumpleDe15 : Evento{
		
		override protected void vestirAAgasajado(){ Console.WriteLine("Buscando vestido para la quinceañera"); }
		override protected void enviarInvitaciones(){ Console.WriteLine("Enviando invitaciones con dibujitos de unicornios"); }
		override protected void prepararSalon(){ Console.WriteLine("Preparando salón para los jóvenes"); }
		override protected void ponerMusica(){ Console.WriteLine("Poniendo música moderna"); }
		override protected void servirComida(){ Console.WriteLine("Sirviendo pizzas y gaseasosas"); }
		override protected void entregarRecuerdo(){ Console.WriteLine("Entregando caramelos"); }
	}
}
