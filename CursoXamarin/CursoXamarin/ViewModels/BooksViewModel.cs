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
				new Book("El sol se muere ","Jamake Highwater",378,177.50f,false)
			};
		}
	}
}
