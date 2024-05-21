
using EjerciciosDePrueba1.EjerciciosDePrueba1.Clases;

namespace EjerciciosDePrueba1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            ObjetoEstereo();


        }

        private static void ObjetoEstereo()
        {
            //Instanciado
            Estereo miEstereo = new Estereo("Negro", "Pioneer");


            //Encendido del Estereo
            miEstereo.PresionarBotonEncendido();


            //Eleccion del modo del Estereo
            miEstereo.CambiarModo(EjerciciosDePrueba1.Enums.ModoEstereoEnum.Radio);


            //Nombre de Frecuencia/Cancion/Pista
            miEstereo.vNombreRadio("FM 101.5");
            miEstereo.vNombreCancionBluetooth("'Muchachos' - La T Y La M");
            miEstereo.vPistaCD("'El Bombon' - Los Palmeras");

            //Display
            miEstereo.Display();
            
            




        }
    }
}
