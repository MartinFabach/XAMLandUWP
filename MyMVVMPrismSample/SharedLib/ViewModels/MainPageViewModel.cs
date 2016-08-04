using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using SharedLib.Events;
using SharedLib.Interfaces;
using SharedLib.Models;
using SharedLib.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SharedLib.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        #region Commands
        public ICommand AddCarCommand { get; }

        #endregion
        private readonly ICarService carService;
        private readonly IEventAggregator eventAggregator;

     

        public Car Car { get; set; }
        public ObservableCollection<Car> Cars { get; set; }

        private Car selectedCar;
        public Car SelectedCar
        {
            get { return selectedCar; }
            set { SetProperty(ref selectedCar, value); }
        }

        public MainPageViewModel(ICarService carService, IEventAggregator eventAggregator)
        {
            this.carService = carService;
            Car = carService.GetCar();
            Cars = new ObservableCollection<Car>(carService.GetCars());

            AddCarCommand = new DelegateCommand(OnAddCar);
            this.eventAggregator = eventAggregator;
            this.eventAggregator.GetEvent<CarEvent>().Subscribe(DeleteCar);
        }

        private void DeleteCar(Car obj)
        {
            Cars.Remove(obj);
        }

        private void OnAddCar()
        {
            Cars.Add(Car);
        }

        public void AddCar()
        {
            Cars.Add(Car);
        }
    }
}
