using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca;

namespace Biblioteca.Teste
{
    [TestClass]
    public class AutoraTeste
    {
        [TestMethod]
        public void VerificaSeNomeDaAutoraĆDjamila()
        {
            Autora autora = new Autora();
            autora.Nome = "Djamila Perfeita";
            Assert.AreEqual("Djamila Perfeita", autora.Nome);
        }
    }
}