using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoXamarin.Views;
using Xamarin.Forms;

namespace CursoXamarin {
	public partial class MainPage : ContentPage {
		public MainPage() {
			InitializeComponent();
		}

		private void btnPageA_Clicked(object sender, EventArgs e) {
			Navigation.PushAsync(new PageA());
		}

		private void btnBooks_Clicked(object sender, EventArgs e) {
			Navigation.PushAsync(new BooksView());
		}
	}
}
