using OrdenarEJ4.Servicios;

namespace OrdenarEJ4.Controladores
{
    class Program
    {
        public static void Main(string[] args)
        {
            ///<sumary>
            ///Declaracion de variables y objetos
            ///<author>161023 - awb</author>
            /// </sumary>
            MenuInterfaz menu = new MenuImplementacion();
            PedidaDeDatosInterfaz pedida = new PedidaDeDatosImplementacion();

            bool cerrarMenu = false;

            while (!cerrarMenu)
            {

                ///<sumary>
                ///llamada a los metododos de menu
                ///<author>161023 - awb</author>
                /// </sumary>
                menu.MenuYSeleccion();
                double n1 = pedida.pedirDatos();
                double n2 = pedida.pedirDatos();
                double n3 = pedida.pedirDatos();

                if (n1 > n2)
                {
                    
                }
                else if (n2 > n1)
                {

                }
                else if (n2 > n3)
                {

                }
                else if (n3 > n2)
                {

                }
                else if (n3 > n1)
                {

                }
                else if (n1 > n3)
                {

                }
                ///<sumary>
                ///Proceso de comparacione de datos para ordenar
                ///<author>161023 - awb</author>
                /// </sumary>
                
                                
            }
        }
    }
}

