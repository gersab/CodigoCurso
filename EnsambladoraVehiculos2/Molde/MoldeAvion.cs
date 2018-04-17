using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnsambladoraVehiculos2.Molde
{
    public class MoldeAvion : MoldeVehiculoHijo
    {

        public MoldeAvion(int _numPuertas, int _numllantas, string _color, string _marca)
            : base(_numPuertas, _numllantas, _color, _marca)
        {
        }

        public MoldeAvion(int _numPuertas, int _numllantas, string _marca)
            : base(_numPuertas, _numllantas, _marca)
        { }
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
