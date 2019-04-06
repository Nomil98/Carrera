class Carrera
    {
        private int _NumeroCorredor;
        protected int _Posicion;
        private static Random ran = new Random();

        public int NumeroCorredor
        {
            get { return _NumeroCorredor; }
        }
        public int Posicion
        {
            get { return _Posicion; }
        }
        public Carrera (int NumeroCorredor)
        {
            /// Le damos el número al corredor e inicializamos la posición
            /// de los corredores en 0.

            _NumeroCorredor = NumeroCorredor;
            _Posicion = 0;
        }

        public override string ToString()
        {
            return _NumeroCorredor.ToString() + _Posicion.ToString();
        }

        public int Correr()
        {
            return ran.Next(20) + 1;
            ///Generará un numero aleatorio del 0 al 19 y le sumará 1.
        }
