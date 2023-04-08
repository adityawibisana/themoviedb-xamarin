using System;
using System.Collections.Generic;
using themoviedbx.ViewModels;
using Xamarin.Forms;

namespace themoviedbx
{	
	public partial class WebViewPage : ContentPage
	{
		WebViewPageViewModel vm;
		public WebViewPage (String url)
		{
			InitializeComponent ();
            vm = new WebViewPageViewModel(url);
            BindingContext = vm;
        }
	}
}

