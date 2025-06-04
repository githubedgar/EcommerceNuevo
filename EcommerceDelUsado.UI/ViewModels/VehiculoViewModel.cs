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

        public ObservableCollection<Vehiculo> ImagenesIzquierda { get; set; } = new ObservableCollection<Vehiculo>();
        public ObservableCollection<Vehiculo> ImagenesDerecha { get; set; } = new ObservableCollection<Vehiculo>();
        public ObservableCollection<Vehiculo> Vehiculos { get; set; } = new ObservableCollection<Vehiculo>();

        public VehiculoViewModel(ObtenerVehiculosUseCase useCase, string tipo)
        {
            _useCase = useCase;
            _ = CargarVehiculosAsync(tipo);
        }

        private async Task CargarVehiculosAsync(string tipo)
        {
            var lista = await _useCase.EjecutarAsync();

            // 🔍 Mostrar tipos cargados desde la base
            foreach (var v in lista)
            {
                System.Diagnostics.Debug.WriteLine($"Tipo en BD: '{v.Tipo}'");
            }

            // Filtrar por tipo solicitado
            var filtrados = lista.Where(v => v.Tipo == tipo).ToList();

            System.Diagnostics.Debug.WriteLine($"➡ Motos encontradas: {filtrados.Count}");

            ImagenesIzquierda.Clear();
            ImagenesDerecha.Clear();
            Vehiculos.Clear(); // 🆕 Limpiar y llenar Vehiculos

            for (int i = 0; i < filtrados.Count; i++)
            {
                if (i % 2 == 0)
                    ImagenesIzquierda.Add(filtrados[i]);
                else
                    ImagenesDerecha.Add(filtrados[i]);

                Vehiculos.Add(filtrados[i]); // 🆕 Llenar colección completa
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
