using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_Producto;
using Microsoft.VisualStudio.TestTools.UnitTesting;




namespace Prueba_Unitaria_RE17
{
    [TestClass]
    public class TestProducto
    {
        [TestMethod]
        public void ValidarConstructorDefecto()
        {
             
            // Validar datos
            Producto producto = new Producto();

            // Validar que los datos no sean vacíos, debe ser "desconocidos"
            Assert.IsNotNull(producto);

            // Validación de las propiedades
            // Validar que la propiedad esté asignada

            Assert.IsNotNull(producto.Nombre);

            Assert.IsNotNull(producto.Precio);

            



        }
        [TestMethod]
        public void ValidarConstructorNombre()
        {
            Producto productoNombre = new Producto("Fran");

            // Validar que el precio no sea nulo
            Assert.IsNotNull(productoNombre.Precio);
        }
        [TestMethod]
        public void ValidarConstructorCompleto()
        {
            Producto producto = new Producto("Fran", 20);

            // Validar que se calcule el precio IVA
            Assert.AreNotEqual(producto.Precio, producto.PrecioIVA);

            // Validar Precio IVA

            producto.Precio = 20;

            Assert.AreNotEqual(producto.PrecioIVA, 840);
            
        }

    }
}
