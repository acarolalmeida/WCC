using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BibliotecaMVC
{
    public class LivroController : Controller 
    {  
        public IActionResult Livro()
        {
            var listaDeLivros = new Livro("Quem tem medo do feminismo negro", "", 20.00, new string[]{}, new Autora("Djamila")).Model;
           
            var autora = new Autora("Djamila");

            var livroUm = new Livro();
            livroUm.Titulo = "Titulo 01";
            livroUm.Autora = autora;
            livroUm.Preco = 18.90;
            livroUm.Descricao = "";
            livroUm.Genero = new string[]{};

            var livroDois = new Livro();
            livroDois.Titulo = "Titulo 02";
            livroDois.Autora = autora;
            livroDois.Preco = 25.90;
            livroDois.Descricao = "";
            livroDois.Genero = new string[]{};
            
            listaDeLivros.Add(livroUm);
            listaDeLivros.Add(livroDois);

            return View(listaDeLivros);
        }
    }
}