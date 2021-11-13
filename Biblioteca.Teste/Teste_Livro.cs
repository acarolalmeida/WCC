using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca;

namespace Biblioteca.Teste
{
    [TestClass]
    public class LivroTeste
    {
        [TestMethod]
        public void TestaCadastroDosLivrosNaLista()
        {
            Autora autora = new Autora();
            autora.Nome = "Djamila";
            
            Livro livro = new Livro();
            livro.Titulo = "Lugar de Fala";
            livro.Autora = autora;
            livro.Preco = 15.95;

            var livroCadastrado = livro.Cadastrar();

            Assert.AreEqual(livro.Titulo, livroCadastrado.Titulo);
            Assert.AreEqual(livro.Autora, livroCadastrado.Autora);
            Assert.AreEqual(livro.Preco, livroCadastrado.Preco);
            Assert.AreEqual(livro.Descricao, livroCadastrado.Descricao);
        }
    }
}