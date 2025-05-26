namespace ENT
{
    public class clsJugador
    {
        #region Atributos

        private int id;

        private string nombre;

        private int puntuacion;

        #endregion

        #region Propiedades

        public int Id 
        { 
            get 
            { 
                return id; 
            } 
        }

        public string Nombre 
        { 
            get 
            { 
                return nombre; 
            } 
            set 
            {
                if (!String.IsNullOrEmpty(value))
                {
                    nombre = value;
                }
            } 
        }

        public int Puntuacion 
        { 
            get 
            { 
                return puntuacion; 
            }
            set 
            {
                if(value > -1)
                {
                    puntuacion = value;
                }
            }
        }

        #endregion

        #region Constructores

        public clsJugador() { }

        public clsJugador(int id)
        {
            if(id > 0)
            {
                this.id = id;
            }
        }

        public clsJugador (int id, string nombre, int puntuacion)
        {
            if (id > 0)
            {
                this.id = id;
            }

            if (!String.IsNullOrEmpty(nombre))
            {
                this.nombre = nombre;
            }

            if(puntuacion > -1)
            {
                this.puntuacion = puntuacion;
            }
            
        }

        #endregion
    }
}
