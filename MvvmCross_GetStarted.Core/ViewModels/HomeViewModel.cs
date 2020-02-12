using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace MvvmCrossTest.Core.ViewModels
{
    public class HomeViewModel : MvxViewModel
    {

		private readonly IMvxNavigationService _navigationService;

		public HomeViewModel(IMvxNavigationService navigationService)
		{
			this._navigationService = navigationService;
			ResetTextCommand = new MvxCommand(() => { Hello = "Hello MvvmCross"; });
			NextPageCommand = new MvxCommand(() => { _navigationService.Navigate<SecondPageViewModel>(); });
		}

		#region Commands
		public ICommand ResetTextCommand { get; set; }
		public ICommand NextPageCommand { get; set; }
		#endregion

		private string _hello = "Hello MvvmCross";

		public string Hello
		{
			get => _hello;
			set => SetProperty(ref _hello, value);
		}



	}
}
