using System;
using System.Collections.Generic;

namespace Biblioteca
{
    internal class Program
    {
        static void Main(string[] args){

        Autora autora = new Autora();
        autora.Nome = "Djamila Ribeiro";

        Autora autora02 = new Autora();
        autora02.Nome = "Stephanie Meyer"; 

        Livro livro = new Livro();
        livro.Autora = autora;
        livro.Preco = 25.90;
        livro.Titulo = "Lugar de Fala";
        
        Livro livro02 = new Livro(){
            Titulo = "Divergente",
            Autora = autora02,
            Preco = 35.00,
        };

        List<Livro> listaLivros = new List<Livro>();
        listaLivros.Add(livro);
        listaLivros.Add(livro02);

        }
    }
}
