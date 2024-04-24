using System;
using DatosPostulante;


namespace DatosPostulante
{
    internal class Postulante
    {
        private string nombre, apellido, tipoID, nroID;
        public Postulante(string nombre, string apellido, string tipoID, string nroID)
        {
            Nombre = nombre;
            Apellido = apellido;
            TipoID = tipoID;
            NroID = nroID;
        }
        public string Nombre
        {
            get { return nombre; }
            private set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            private set { apellido = value; }
        }

        public string TipoID
        {
            get { return tipoID; }
            private set { tipoID = value; }
        }

        public string NroID
        {
            get { return nroID; }
            private set { nroID = value; }
        }
    }


}










