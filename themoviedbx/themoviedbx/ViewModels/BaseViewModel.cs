using System;
using System.ComponentModel;

namespace themoviedbx.ViewModels
{
	public class BaseViewModel : INotifyPropertyChanged
	{
		public BaseViewModel()
		{
		}

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

