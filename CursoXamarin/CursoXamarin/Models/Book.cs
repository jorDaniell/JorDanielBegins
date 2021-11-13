using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace CursoXamarin.Models {
	public class Book : INotifyPropertyChanged {

		#region Properties

		private string title;
		public string Title {
			get { return title; }
			set {
				title = value;
				OnPropertyChanged();
			}
		}

		private Image coverPage;
		public Image CoverPage {
			get { return coverPage; }
			set {
				coverPage = value;
				OnPropertyChanged();
			}
		}

		private string author;
		public string Author {
			get { return author; }
			set {
				author = value;
				OnPropertyChanged();
			}
		}

		private int numberPages;
		public int NumberPages {
			get { return numberPages; }
			set {
				numberPages = value;
				OnPropertyChanged();
			}
		}

		private float price;
		public float Price {
			get { return price; }
			set {
				price = value;
				OnPropertyChanged();
			}
		}

		private bool isOutOf;
		public bool IsOutOf {
			get { return isOutOf; }
			set { isOutOf = value; }
		}
		#endregion

		public Book() { }

		public Book(String title, String author, int numberPages, float price, bool isOutOF) {
			Title = title;
			Author = author;
			NumberPages = numberPages;
			Price = price;
			IsOutOf = isOutOF;
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		public override String ToString() {
			return $"{Title} | {Author} | {NumberPages} | {Price} | {IsOutOf}";
		}
	}
}
