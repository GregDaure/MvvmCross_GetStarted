using MvvmCross.Core;
using MvvmCross.Platforms.Uap.Core;
using MvvmCross.Platforms.Uap.Views;
using System;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace MvvmCrossTest
{
    sealed partial class App : UWPApplication
    {
        public App()
        {
            InitializeComponent();
        }
    }

    public abstract class UWPApplication : MvxApplication<MvxWindowsSetup<Core.App>, Core.App>
    {
    }
}
