using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G4_Ejercicio4
{
    abstract class Vehiculo
    {
        string tipomotor;
        string transmision;
        int llantas;
        int pasajeros;
        double masa;
        string combustible;
        int sizerin;

        public string Tipomotor
        {
            get { return tipomotor; }
            set { tipomotor = value; }
        }

        public string Transmision
        {
            get { return transmision; }
            set { transmision = value; }
        }

        public int Llantas
        {
            get { return llantas; }
            set { llantas = value; }
        }

        public int Pasajeros
        {
            get { return pasajeros; }
            set { pasajeros = value; }
        }

        public double Masa
        {
            get { return masa; }
            set { masa = value; }
        }

        public string Combustible
        {
            get { return combustible; }
            set { combustible = value; }
        }

        public int Rines
        {
            get { return sizerin; }
            set { sizerin = value; }
        }
    }
}
