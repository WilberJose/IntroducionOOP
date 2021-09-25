using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionOOP
{
    class Compra
    {
        private int _compraId;
        private string _precio;
        private string _cantidad;
        private string _FechaCompra;

        public Compra()
        { }

        public Compra(int compraId, string precio, string cantidad, string FechaCompra)
        {
            _compraId = compraId;
            _precio = precio;
            _cantidad = cantidad;
            _FechaCompra = FechaCompra;
        }

        public int getCompraId()
        {
            return _compraId;
        }
        public void setCompraId(int compraId)
        {
            _compraId = compraId;
        }
        public string getPrecio()
        {
            return _precio;
        }
        public void setPrecio(string precio)
        {
            _precio = precio;
        }
        public string getCantidad()
        {
            return _cantidad;
        }
        public void setCantidad(string cantidad)
        {
            _cantidad = cantidad;
        }
        public string FechaCompra { get; set; }

        public string getCompraInfo()
        {
            return "ID: " +  _compraId + "Precio: " + _precio +
                "Cantidad: " + _cantidad + "Fecha Compra" + _FechaCompra;
        }
        
    }
}
    

