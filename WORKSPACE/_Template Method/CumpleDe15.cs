/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 19/5/2021
 * Hora: 20:42
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace _Template_Method {
	
	public class Casamiento : Evento{
	
		override protected void vestirAAgasajado(){ Console.WriteLine("Buscando vestido y traje para los novios"); }
		override protected void enviarInvitaciones(){ Console.WriteLine("Enviando invitaciones formales"); }
		override protected void prepararSalon(){ Console.WriteLine("Preparando salón para los novios"); }
		override protected void ponerMusica(){ Console.WriteLine("Poniendo música de antes"); }
		override protected void servirComida(){ Console.WriteLine("Sirviendo lomo y vino"); }
		override protected void entregarRecuerdo(){ Console.WriteLine("Entregando un bonzai"); }
	}
}
