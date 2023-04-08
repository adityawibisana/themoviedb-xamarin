using System;
using System.ComponentModel;
using themoviedbx.Models;

namespace themoviedbx.ViewModels
{
	public class WebViewPageViewModel : INotifyPropertyChanged
	{
		private String _url;
		public String Url
		{
			get { return _url; }
			set
			{
				_url = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Url)));
            }
		}

		public WebViewPageViewModel(String url)
		{
			this.Url = url;
		}

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

