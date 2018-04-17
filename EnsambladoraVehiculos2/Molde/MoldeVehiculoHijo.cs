using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnsambladoraVehiculos2.Molde
{
    public class MoldeVehiculoHijo : MoldeVehiculoPadre
    {
        #region Constructores
        public void MoldeCarro(int _numPuertas, int _numllantas, string _color, string _marca)
        {
            NumPuertas = _numPuertas;
            Numllantas = _numllantas;
            Color = _color;
            Marca = _marca;
        }

        public void MoldeCarro(int _numPuertas, int _numllantas, string _marca)
        {
            NumPuertas = _numPuertas;
            Numllantas = _numllantas;
            Marca = _marca;
        }

        public MoldeVehiculoHijo()
        {

        }
        #endregion


        #region Propiedades
        public int NumPuertas { get; set; }
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

        public void Reversa(int _presionPedalFreno)
        {
            if (_presionPedalFreno > 0)
                Velocidad = _presionPedalFreno / 2;
        }
        #endregion
    }

}

