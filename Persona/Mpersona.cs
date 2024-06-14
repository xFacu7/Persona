using Principal;

namespace LibreriaPersona{

    public class Persona{
        
        
        public string Nombre;
        public int Dni;
        public string Fec_Nac;
        public bool vivo;
        
        public Persona(int unDni,string unNombre,string unFec_Nac,bool unvivo){
            Dni = unDni;
            Nombre = unNombre;
            Fec_Nac = unFec_Nac;
            vivo = unvivo;
        }
        public string Respirar(){
            return "Respirando...";
        }
        public void morir(){
            Console.WriteLine("Persona murio...");
            vivo = false;
        }
        public void revivir()
        {
            Console.WriteLine("Persona revivio...");
            vivo = true;
        }
    }
}
