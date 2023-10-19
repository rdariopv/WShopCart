using WShopApi.Model;
using WShopApi.Data;

namespace WShopApi.Repository
{
    public class ShopBiz : IShopBiz
    {
        public List<Producto> GetProductos()
        {

            // aqui ing llamar a la referencia web del soap service
            List<Producto> listPrd = new List<Producto>();
            Producto prd1 = new Producto();
            prd1.Codigo = 1;
            prd1.Nombre = "Vajilla inglesa";
            prd1.Precio = 40.5;
            prd1.Moneda = 1;
            prd1.DescMoneda = "BOB";

            Producto prd2 = new Producto();
            prd2.Codigo = 2;
            prd2.Nombre = "Escoba diaria";
            prd2.Precio = 40.5;
            prd2.Moneda = 2;
            prd2.DescMoneda = "USD.";


            listPrd.Add(prd1);
            listPrd.Add(prd2);
            return listPrd;

        }




    }

}