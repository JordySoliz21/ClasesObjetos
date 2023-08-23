using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjBoletaVenta
{
    public class Boleta
    {
        public int NumeroBoleta { get; set; }
        public string NombreCliente { get; set; }
        public string DireccionCliente { get; set; }
        public string CedulaCliente { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string DescripcionProducto { get; set; }
        public int CantidadComprada { get; set; }

        public double determinaPrecio ()
        {
            switch (DescripcionProducto)
            {
                case "PS5 + 1 MANDO DS5": return 500;
                case "PAS4(1TB) + 1 MANDO PS4": return 619;
                case "MANDO PS5/ DS5": return 69;
                case "MANDO PS4/ DS4": return 60;
            }
            return 0;
        }
        public double calculaImporte()
        {
            return CantidadComprada * determinaPrecio();
        }
    }
}
