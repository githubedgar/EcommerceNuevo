// EcommerceDelUsado.UI/ViewModels/VehiculoViewModel.cs
using EcommerceDelUsado.Application.UseCases;
using EcommerceDelUsado.Domain.Entities;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace EcommerceDelUsado.UI.ViewModels
{
    public class VehiculoViewModel : INotifyPropertyChanged
    {
        private readonly ObtenerVehiculosUseCase _useCase;

        public ObservableCollection<Vehiculo> Vehiculos { get; set; } = new ObservableCollection<Vehiculo>();

        public VehiculoViewModel(ObtenerVehiculosUseCase useCase)
        {
            _useCase = useCase;
            _ = CargarVehiculosAsync(); // Aqui inicia la carga de datos
        }

        private async Task CargarVehiculosAsync()
        {
            var lista = await _useCase.EjecutarAsync(); //Llama al caso de uso.
            Vehiculos.Clear();
            foreach (var v in lista)
            {
                Vehiculos.Add(v);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
