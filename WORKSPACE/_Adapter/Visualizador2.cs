/*
 * Created by SharpDevelop.
 * User: Waldo
 * Date: 18/06/2019
 * Time: 9:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;


namespace _Adapter
{
	
	public class FabricaDeImagenes : FabricaDeDocumentos{
		override public IDocumento crearDocumento(string nombre){
			IImage imagenAdaptada = new Imagen(nombre);
			IDocumento d = new DocumentoAdapter(imagenAdaptada);
			return d;
		}
	}
}
