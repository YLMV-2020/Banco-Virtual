using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaDominio.Entidades;

namespace MasterTest
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void test1_calcularComision()
        {
            TipoTransaccion a = TipoTransaccion.CUENTA_PROPIA;
            float monto = 50;
            float resultadoEsperado = 0.5f;
            Transaccion transaccion = new Transaccion();

            float resultado = transaccion.calcularComision(a, monto);
            Assert.AreEqual(resultadoEsperado, resultado);

        }

        [TestMethod]
        public void test2_calcularComision()
        {
            TipoTransaccion a = TipoTransaccion.OTRA_CUENTA;
            float monto = 40f;
            float resultadoEsperado = 6f;
            Transaccion transaccion = new Transaccion();

            float resultado = transaccion.calcularComision(a, monto);
            Assert.AreEqual(resultadoEsperado, resultado);

        }

        [TestMethod]
        public void test3_validarMonto()
        {
            float monto1 = 5;
            float cuenta1 = 10;
            bool resultadoEsperado = true;
            Transaccion transaccion = new Transaccion();
            if (transaccion != null)
            {
                bool resultado = transaccion.validarMonto(monto1, cuenta1);
                Assert.AreEqual(resultadoEsperado, resultado);
            }
        }

        [TestMethod]
        public void test4_validarMonto()
        {
            float monto1 = 10;
            float cuenta1 = 5;
            bool resultadoEsperado = false;
            Transaccion transaccion = new Transaccion();
            bool resultado = transaccion.validarMonto(monto1, cuenta1);
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void test5_validarMonto()
        {
            float monto1 = 10;
            float cuenta1 = 10;
            bool resultadoEsperado = true;
            Transaccion transaccion = new Transaccion();
            bool resultado = transaccion.validarMonto(monto1, cuenta1);
            Assert.AreEqual(resultadoEsperado, resultado);
        }
        [TestMethod]

        public void test6_verificarCodigo()
        {
            string codigoaux = "123";
            string codigoaux2 = "123";
            bool resultadoEsperado = true;
            Transaccion transaccion = new Transaccion();
            bool resultado = transaccion.verificarCodigo(codigoaux, codigoaux2);
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void test7_verificarCodigo()
        {
            string codigoaux = "123";
            string codigoaux2 = "124";
            bool resultadoEsperado = false;
            Transaccion transaccion = new Transaccion();
            bool resultado = transaccion.verificarCodigo(codigoaux, codigoaux2);
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void test8_calcularMontoTotal()
        {
            TipoTransaccion a = TipoTransaccion.CUENTA_PROPIA;
            float monto = 50f;
            float resultadoEsperado = 50.50f;
            Transaccion transaccion = new Transaccion();
            float resultado = transaccion.calcularMontoTotal(a, monto);
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void test9_calcularMontoTotal()
        {
            TipoTransaccion a = TipoTransaccion.OTRA_CUENTA;
            float monto = 50f;
            float resultadoEsperado = 57.5f;
            Transaccion transaccion = new Transaccion();
            float resultado = transaccion.calcularMontoTotal(a, monto);
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void test10_RealizarTransaccion()
        {
            float monto1 = 5;
            string moneda = "SOL";
            float resultadoEsperado = 5;
            Transaccion transaccion = new Transaccion();
            float resultado = transaccion.calcularTransferencia(monto1, moneda);
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void test11_RealizarTransaccion()
        {
            float monto1 = 5;
            string moneda = "DOLAR";
            float resultadoEsperado = 17.25f;
            Transaccion transaccion = new Transaccion();
            float resultado = transaccion.calcularTransferencia(monto1, moneda);
            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}
