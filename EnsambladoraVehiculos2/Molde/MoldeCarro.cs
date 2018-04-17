using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnsambladoraVehiculos2.Molde
{

    //para crear una clase hijo. está heredando de la clase MoldeVehiculoPadre
    public class MoldeCarro : MoldeVehiculoHijo
    {
        public MoldeCarro(int _numPuertas, int _numllantas, string _color, string _marca)
            : base(_numPuertas, _numllantas, _color, _marca)
        {
        }

        public MoldeCarro(int _numPuertas, int _numllantas, string _marca)
            : base(_numPuertas, _numllantas, _marca)
        { }


        public void Reversa(int _presionPedalFreno)
        {
            if (_presionPedalFreno > 0)
                Velocidad = _presionPedalFreno / 2;
        }

    }
}
