using SharedLib.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Microsoft.Extensions.DependencyInjection;
using SharedLib.Services;
using SharedLib.Events;
using Prism.Events;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MyMVVMPrismSample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPageViewModel ViewModel { get; set; }
        public IEventAggregator EventAggregator { get; set; }
        public MainPage()
        {
            this.InitializeComponent();

            //CarService carService = new CarService();
            //ViewModel = new MainPageViewModel(carService);

            ViewModel = (Application.Current as App).Container.GetService<MainPageViewModel>();    //requires using Microsoft.Extensions.DependencyInjection;  
            EventAggregator = (Application.Current as App).Container.GetService<IEventAggregator>();
            DataContext = ViewModel;
        }

        private void ButtonDeleteCar_Click(object sender, RoutedEventArgs e)
        {
            EventAggregator.GetEvent<CarEvent>().Publish(ViewModel.SelectedCar);
        }
    }
}
