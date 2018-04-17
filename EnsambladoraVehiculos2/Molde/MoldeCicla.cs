using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnsambladoraVehiculos2.Molde
{
    public class MoldeCicla : MoldeVehiculoPadre
    {

        public void MoldeCicla(int _numllantas, string _color, string _marca)
        {
            Numllantas = _numllantas;
            Color = _color;
            Marca = _marca;
        }

        #region propiedades

        public int Altura { get; set; }
        #endregion

        #region Metodos
        public void AumentarAltura(int _presionPedalAltura)
        {
            if (_presionPedalAltura > 0)
                Velocidad = _presionPedalAltura * 2;
            Velocidad = 0;
        }
        #endregion
    }
}
