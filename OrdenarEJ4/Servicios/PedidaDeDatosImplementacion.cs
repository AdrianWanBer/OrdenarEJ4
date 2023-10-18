namespace OrdenarEJ4.Servicios
{
    internal class PedidaDeDatosImplementacion : PedidaDeDatosInterfaz
    {
        public double pedirDatos()
        {
            ///<summary>
            ///Metodo que se encargara de recoger los numeros
            ///awb - 131023
            /// </summary>
            Console.Out.WriteLine("Escriba un numero");
            double numeroEscrito = double.Parse(Console.ReadLine());

            return numeroEscrito;
        }
    }
}
