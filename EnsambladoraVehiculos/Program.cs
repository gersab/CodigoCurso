using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnsambladoraVehiculos.Molde;
using EnsambladoraVehiculos.molde;
using EnsambladoraVehiculos.ayudas;

namespace EnsambladoraVehiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            //MoldeDeCarro elPrimerCarro = new MoldeDeCarro();
            //elPrimerCarro.Color = "rojo";
            //elPrimerCarro.Marca = "chevolet";
            //elPrimerCarro.Numllantas = 4;
            //elPrimerCarro.NumPuertas = 2;

            //MoldeDeCarro elSegundoCarro = new MoldeDeCarro();
            //elSegundoCarro.Color = "verde";
            //elSegundoCarro.Marca = "mazda";
            //elSegundoCarro.Numllantas = 4;
            //elSegundoCarro.NumPuertas = 4;

            //MoldeDeCarro elTercerCarro = new MoldeDeCarro(4,4,"verde","mazda");


            MoldeDeCarro elTercerCarro = new MoldeDeCarro(4, 4, Marcas.Mazda.ToString(), Colores.Azul.ToString());

            MoldeDeCarro elCuartoCarro = new MoldeDeCarro(2, 4, Marcas.Mercedes.ToString(), Colores.Amarillo.ToString());
            


            MoldeDeCiclas laPrimeraCicla = new MoldeDeCiclas();
                
            


        }

    }
}
