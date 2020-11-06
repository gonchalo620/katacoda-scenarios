using System;
using Xunit;
using library;

namespace library.testing
{
    public class Test
    {
        [Fact]
        public void TestingSaludo()
        {
            var buzon = new Buzon();
            var actual = buzon.Saludar();
            Assert.Equal("Hola usuario de EPM", actual);
        }

        [Fact]
        public void TestingSaludoUsuario()
        {
            var buzon = new Buzon();
            var actual = buzon.Saludar("Gonzalo");
            Assert.Equal("Hola Gonzalo, le saluda EPM", actual);
        }
    }
}