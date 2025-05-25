using System.Collections.ObjectModel;
using EcommerceDelUsado.Domain.Entities;

namespace EcommerceDelUsado.UI.ViewModels
{
    public class MotosTradicionalesViewModel
    {
        public ObservableCollection<Moto> Motos { get; }

        public MotosTradicionalesViewModel()
        {
            Motos = new ObservableCollection<Moto>
            {
                // Ducati
                new Moto { Marca = "Ducati", Imagen = "mototradducati1.png" },
                new Moto { Marca = "Ducati", Imagen = "mototradducati2.png" },
                new Moto { Marca = "Ducati", Imagen = "mototradducati3.png" },

                // Honda
                new Moto { Marca = "Honda", Imagen = "mototradhonda1.png" },
                new Moto { Marca = "Honda", Imagen = "mototradhonda2.png" },
                new Moto { Marca = "Honda", Imagen = "mototradhonda3.png" },

                // Suzuki
                new Moto { Marca = "Suzuki", Imagen = "mototradsuzuki1.png" },
                new Moto { Marca = "Suzuki", Imagen = "mototradsuzuki2.png" },
                new Moto { Marca = "Suzuki", Imagen = "mototradsuzuki3.png" },

                // Yamaha
                new Moto { Marca = "Yamaha", Imagen = "mototradyamaha1.png" },
                new Moto { Marca = "Yamaha", Imagen = "mototradyamaha2.png" },
                new Moto { Marca = "Yamaha", Imagen = "mototradyamaha3.png" }
            };
        }
    }
}
