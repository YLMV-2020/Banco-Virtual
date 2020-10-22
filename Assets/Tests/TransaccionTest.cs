using System.Collections;
using System.Collections.Generic;
using CapaDominio.Entidades;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestRunner;
using UnityEngine.TestTools;

namespace Tests
{
    public class TransaccionTest
    {

        [Test]
        public void test1_validarMonto()
        {

            Cuenta cuenta = new Cuenta();
            Transaccion transaccion = new Transaccion();
            transaccion.Monto = 5;
            cuenta.Saldo = 10;
            bool resultadoEsperado = true;
            bool resultado = transaccion.validarMonto(cuenta);
            Assert.AreEqual(resultadoEsperado, resultado);


        }
        [Test]
        public void test2_validarMonto()
        {
            Cuenta cuenta = new Cuenta();
            Transaccion transaccion = new Transaccion();
            transaccion.Monto = 10;
            cuenta.Saldo = 5;
            bool resultadoEsperado = false;
            bool resultado = transaccion.validarMonto(cuenta);

            Assert.AreEqual(resultadoEsperado, resultado);

        }
        [Test]
        public void test3_validarMonto()
        {
            Cuenta cuenta = new Cuenta();
            Transaccion transaccion = new Transaccion();
            transaccion.Monto = 10;
            cuenta.Saldo = 10;
            bool resultadoEsperado = true;
            bool resultado = transaccion.validarMonto(cuenta);

            Assert.AreEqual(resultadoEsperado, resultado);


        }

        [Test]
        public void test4_calcularComision()
        {

            Transaccion transaccion = new Transaccion();
            transaccion.Tipo = TipoTransaccion.CUENTA_PROPIA;
            transaccion.Monto = 50;
            float resultadoEsperado = 0.5f;
            float resultado = transaccion.calcularComision();
            Assert.AreEqual(resultadoEsperado, resultado);

        }
        [Test]
        public void test5_calcularComision()
        {

            Transaccion transaccion = new Transaccion();
            transaccion.Monto = 40;
            transaccion.Tipo = TipoTransaccion.OTRA_CUENTA;
            float resultadoEsperado = 6;
            float resultado = transaccion.calcularComision();
            Assert.AreEqual(resultadoEsperado, resultado);

        }
        [Test]
        public void test6_calcularMontoTotal()
        {
            Transaccion transaccion = new Transaccion();
            transaccion.Tipo = TipoTransaccion.CUENTA_PROPIA;
            transaccion.Monto = 50;
            float resultadoEsperado = 50.5f;
            float resultado = transaccion.calcularMontoTotal();
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [Test]

        public void test7_calcularMontoTotal()
        {
            Transaccion transaccion = new Transaccion();
            transaccion.Tipo = TipoTransaccion.OTRA_CUENTA;
            transaccion.Monto = 40;
            float resultadoEsperado = 46;
            float resultado = transaccion.calcularMontoTotal();
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [Test]
        public void test8_validarValoracion()
        {
            Transaccion transaccion = new Transaccion();
            transaccion.Valoracion = 9;
            bool resultadoEsperado = false;
            bool resultado = transaccion.validarValoracion();
            Assert.AreEqual(resultadoEsperado, resultado);
        }
        [Test]
        public void test9_validarValoracion()
        {
            Transaccion transaccion = new Transaccion();
            transaccion.Valoracion = 1;
            bool resultadoEsperado = true;
            bool resultado = transaccion.validarValoracion();
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [Test]
        public void test10_RealizarTransaccion()
        {
            Transaccion transaccion = new Transaccion();
            Cuenta cuenta = new Cuenta();
            transaccion.Monto = 5;
            cuenta.Moneda = Moneda.SOL;
            float resultadoEsperado = 5;
            float resultado = transaccion.calcularTransferencia(cuenta);
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [Test]
        public void test11_RealizarTransaccion()
        {
            Transaccion transaccion = new Transaccion();
            transaccion.Monto = 5;
            Cuenta cuenta = new Cuenta();
            cuenta.Moneda = Moneda.DOLAR;
            float resultadoEsperado = 17.25f;
            float resultado = transaccion.calcularTransferencia(cuenta);
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [Test]
        public void test12_verificarCodigo()
        {
            bool resultadoEsperado = true;
            Usuario usuario = new Usuario();
            string claveaux = "123";
            usuario.Clave = "123";
            bool resultado = usuario.verificarCodigo(claveaux);
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [Test]
        public void test13_verificarCodigo()
        {
            bool resultadoEsperado = false;
            Usuario usuario = new Usuario();
            string claveaux = "123";
            usuario.Clave = "124";
            bool resultado = usuario.verificarCodigo(claveaux);

            Assert.AreEqual(resultadoEsperado, resultado);

        }

    }
}
