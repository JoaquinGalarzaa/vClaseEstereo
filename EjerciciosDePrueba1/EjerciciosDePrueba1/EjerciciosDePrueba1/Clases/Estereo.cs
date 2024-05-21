using System;
using EjerciciosDePrueba1.EjerciciosDePrueba1.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDePrueba1.EjerciciosDePrueba1.Clases
{
    internal class Estereo
    {
        // Campos privados
        private string Color;
        private string Marca;



        // Propiedades públicas
        public ModoEstereoEnum modo;
        public bool encendido;
        public string FrecuenciaRadio;
        public string CancionBluetooth;
        public string PistaCD;
        


        //Constructor
        public Estereo(string color, string marca)
        {
            this.Color = color;
            this.Marca = marca;
            this.modo = ModoEstereoEnum.Radio;
        }


        public void PresionarBotonEncendido()
        {
            this.encendido = !this.encendido;
        }

        public void CambiarModo(ModoEstereoEnum modo)
        {
            if (this.encendido)

                this.modo = modo;

            else Console.WriteLine("error: el stereo debe estar prendido");


        }

        public void vNombreRadio(string nombreRadio)
        {
            if (modo == ModoEstereoEnum.Radio)
            {
                FrecuenciaRadio = nombreRadio;
            }
            else
                Console.WriteLine("No se puede eleir la frecuencia porque no esta en modo radio.");
        }

        public void vNombreCancionBluetooth(string nombreCancion)
        {
            if (modo == ModoEstereoEnum.Bluetooth)
            {
                CancionBluetooth = nombreCancion;
            }
            else
                Console.WriteLine("No se puede elegir la cancion porque no esta en modo bluetooth");
        }

        public void vPistaCD(string pistaDelCd)
        {
            if (modo == ModoEstereoEnum.CD)
            {
                PistaCD = pistaDelCd;
            }
            else
                Console.WriteLine("No se puede elegir la cancion porque no esta en modo CD");
        }

        public void Display()
        {
            Console.WriteLine($"Encendido: {encendido}");
            Console.WriteLine($"Modo: {modo}");

            if (encendido)
            {
                if (modo == ModoEstereoEnum.Bluetooth)
                {
                    Console.WriteLine($"Escuchando: {CancionBluetooth}");
                }

                if (modo == ModoEstereoEnum.Radio)
                {
                    Console.WriteLine($"Escuchando: {FrecuenciaRadio}");
                }

                if (modo == ModoEstereoEnum.CD)
                {
                    Console.WriteLine($"Escuchando: {PistaCD}");
                }

            }
        }

    }

}
