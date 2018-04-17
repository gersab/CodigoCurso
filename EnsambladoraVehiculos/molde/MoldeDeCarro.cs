using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnsambladoraVehiculos.Molde
{
    /// <summary>
    /// este es un molde para carros
    /// </summary>

    //definir una constante para hacer lista se usa la palabra enum
    public enum ColorVehiculo
    {
        Rojo = 2, Gris, Negro, Amarillo, Azul
    }

    public enum MarcaVehiculo
    {
        Mazda = 2, Renault, Chevrolet, Hiunday, BMW, Mercedes
    }

    public class MoldeDeCarro
    {
        //para crear un costructor: ct+tab tab

        public MoldeDeCarro(int _numPuertas, int _numllantas, string _color, string _marca)
        {
            NumPuertas = _numPuertas;
            Numllantas = _numllantas;
            Color = _color;
            Marca = _marca;
        }

        public MoldeDeCarro(int _numPuertas, int _numllantas, string _marca)
        {
            NumPuertas = _numPuertas;
            Numllantas = _numllantas;
            Marca = _marca;
        }


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