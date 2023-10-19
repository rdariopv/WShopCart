
using System.Buffers.Text;
using System.ComponentModel.DataAnnotations;

namespace WShopApi.Model
{

    public class Producto
    {
        [Key]
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Imagen { get; set; }
        public double Precio { get; set; }
        public int Moneda { get; set; }
        public String DescMoneda { get; set; }

    }
}
