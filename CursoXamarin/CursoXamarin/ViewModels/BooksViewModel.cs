using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using CursoXamarin.Models;

namespace CursoXamarin.ViewModels {
	public class BooksViewModel {
		public ObservableCollection<Book> Books { get; set; }

		public BooksViewModel() {
			Books = new ObservableCollection<Book>() {
				new Book("Los 4 acuerdos","Miguel ruíz",298,198.50f,true),
				new Book("El sol se muere ","Jamake Highwater",378,177.50f,false),
				new Book("Antología ","Verónica Hernández",511,342.37f,true),
				new Book("Don quijote de la mancha","Miguel de Cervantes Saavedra",772,512.34f,false),
				new Book("Número cuatro","William Sort", 488, 210.9f, true), 
				new Book("Portal","Claudia Figueroa", 212, 543.98f, false)
			};
		}
	}
}
