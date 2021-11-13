using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoXamarin.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CursoXamarin {
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageA : ContentPage {
		public PageA() {
			InitializeComponent();
		}

		private void btnMainPage_Clicked(object sender, EventArgs e) {
			Navigation.PopAsync();
		}

		private void btnBooks_Clicked(object sender, EventArgs e) {
			Navigation.PushAsync(new BooksView());
		}
	}
}