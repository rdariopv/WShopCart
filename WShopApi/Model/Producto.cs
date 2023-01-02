using System.Buffers.Text;

namespace WShopApi.Model
{
    public class Producto
    {
        public int codigo { get; set; }
        public string Nombre { get; set; }
        public string image { get; set; }
        public string precio { get; set; }
        public string moneda { get; set; }
    }
}
