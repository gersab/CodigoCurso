using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnsambladoraVehiculos.molde
{
    public enum ColorCicla
    {
        Azul = 2, Rojo, Verde, Negro, Amarillo
    }

    public enum MarcaCicla
    {
        Benotto = 2, GW, Pirelli, Venzo, Canion
    }

    public enum CambiosCicla
    {
        21=2, 24, 27, 29
    }
    public class MoldeDeCiclas
    {
        public MoldeDeCiclas(CambiosCicla _numCambios, MarcaCicla _marca, ColorCicla _color)
        {
            NumCambios = _numCambios;
            Marca = _marca;
            Color = _color;
        }

        public CambiosCicla NumCambios { get; set; }


        public MarcaCicla Marca { get; set; }

        public ColorCicla Color { get; set; }

        public int Velocidad { get; set; }

        
        public void Acelerar(int _presionPedal)
        {
            if (_presionPedal > 0)
                Velocidad = _presionPedal * 2;
            Velocidad = 0;
        }
        public void Frenar(int _presionPedalFreno)
        {
            if (_presionPedalFreno > 0)
                Velocidad = _presionPedalFreno / 2;
            Velocidad = 0;
        }

    }
}
