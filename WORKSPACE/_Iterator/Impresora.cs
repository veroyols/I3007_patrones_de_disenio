/*
 * Created by SharpDevelop.
 * User: Waldo
 * Date: 15/04/2019
 * Time: 13:49
 * 
 * EJEMPLO CLASE 2 - ITERATOR*/
 
using System;

namespace _Iterator
{
	public class Pagina{
		private int numero;
		
		public Pagina(int n){
			numero = n;
		}
		
		override public string ToString(){
			return "" + numero;
		}
	} //Personas Alumnos
	
	public interface IDocumento : Iterable {
		void agregarPagina(Pagina p);
		string getTitulo();
	} //Pila Cola
	
	public class DocumentoDeTexto : IDocumento {
		private Pagina[] paginas;
		private string titulo;
		private int dl;
		
		public string getTitulo(){
			return titulo;
		}
		
		public DocumentoDeTexto(int ps, string t){
			titulo = t;
			paginas = new Pagina[ps];
			dl = 0;
		}
		
		public void agregarPagina(Pagina p){
			paginas[dl++] = p;
		}
		
		public IteradorDePaginas crearIterador(){
			return new IteradorDeArreglos(paginas, dl);
		}
	}
	
	public class Diapositiva{
		private Pagina pagina;
		private Diapositiva siguiente;
		
		public Diapositiva(Pagina p, Diapositiva s){
			pagina = p;
			siguiente = s;
		}
		
		public Pagina getPagina(){
			return pagina;
		}
		
		public Diapositiva getSiguiente(){
			return siguiente;
		}
	}
	
	public class Presentacion : IDocumento {
		private Diapositiva siguiente;
		private string titulo;
		
		public Presentacion(string t){
			titulo = t;
			siguiente = null;
		}
		
		public string getTitulo(){
			return titulo;
		}
		
		public void agregarPagina(Pagina p){
			siguiente = new Diapositiva(p, siguiente);
		}
		
		public IteradorDePaginas crearIterador(){
			return new IteradorDeListasEnlazadas(siguiente);
		}
	}
	
	public class Impresora
	{
		public void imprimir(IDocumento doc){
			IteradorDePaginas ite = doc.crearIterador();
			Console.WriteLine("Imprimiendo documento " + doc.getTitulo());
			while(! ite.fin()){
				this.imprimirPagina(ite.actual());
				ite.siguiente();
			}
		}
		
		private void imprimirPagina(Pagina p){
			Console.WriteLine("\tImprimiendo página " + p);
		}
	}
	
}
