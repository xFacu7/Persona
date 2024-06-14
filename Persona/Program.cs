using LibreriaPersona;

namespace Principal{

    public class Programa{


        static void Main(){

        Persona p1 = new Persona( 4570,"Pedro", "19/03/2000",true);

        Console.WriteLine(p1.Dni);
        Console.WriteLine(p1.Nombre);
        Console.WriteLine(p1.Fec_Nac);
        Console.WriteLine(p1.vivo);
        Console.WriteLine(p1.Respirar());
        p1.morir();
        p1.revivir();
    }

    }
}