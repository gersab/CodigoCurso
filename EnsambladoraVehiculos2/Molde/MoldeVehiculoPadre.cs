using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnsambladoraVehiculos2.Molde
{
    public class MoldeVehiculoPadre
    {
        #region Propiedades

        /// <summary>
        /// esta propiedad me guarda el numero de puertas que va a tener el carro
        /// </summary>
        public int NumPuertas { get; set; }

        /// <summary>
        /// esta propiedad me guarda el numero de llantas que va a tener el carro
        /// </summary>

        public int Numllantas { get; set; }


        /// <summary>
        /// esta propiedad me guarda el color que va a tener el carro
        /// </summary>

        public string Color { get; set; }

        /// <summary>
        /// esta propiedad me controla la velocidad que va a tener el carro
        /// </summary>

        //public ColorVehiculo color { get; set; }

        public int Velocidad { get; set; }

        /// <summary>
        /// /// esta propiedad me controla la aceleracion que va a tener el carro
        /// </summary>
        /// <param name="_presionPedal"></param>



        //public string Marca { get; set; }

        public string Marca { get; set; }


        #endregion

        #region Metodos
        public void Acelerar(int _presionPedal)
        {
            if (_presionPedal > 0)
                Velocidad = _presionPedal * 2;
            Velocidad = 0;
        }

        /// <summary>
        /// /// esta propiedad me controla la velocidad que va a tener el carro cuando frena
        /// </summary>
        /// <param name="_presionPedalFreno"></param>

        public void Frenar(int _presionPedalFreno)
        {
            if (_presionPedalFreno > 0)
                Velocidad = _presionPedalFreno / 2;
            Velocidad = 0;
        }
        #endregion







    }
}
