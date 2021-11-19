using System;
using System.Collections.Generic;
using BibliotecaMVC.Service;

namespace BibliotecaMVC
{
    public class Livro{

        private string titulo{get; set;}
        private string descricao{get; set;}
        private double preco{get; set;}
        private string[] genero{get; set;}
        private Autora autorLivro{get; set;}

        public Livro()
        {

        }

        public Livro(string titulo, string descricao, double preco, string[] genero, Autora autora)
        {
            Titulo = titulo; 
            Descricao = descricao;
            Preco = preco;
            Genero = genero;
            Autora = autora;
        }

        public string Titulo
        {
            get {return titulo;}
            set {titulo = value;}
        }

        public string Descricao
        {
            get {return descricao;}
            set {descricao = value;}
        }

        public double Preco
        {
            get {return preco;}
            set {preco = value;}
        }

        public string[] Genero
        {
            get {return genero;}
            set {genero = value;}
        }

        public Autora Autora
        {
            get {return autorLivro;}
            set {autorLivro = value;}
        }

        public Livro Cadastrar()
        {
            return this;
        }

        public List<Livro> Model => new List<Livro>()
        {
            this,
            new Livro("Lugar de Fala", "", 18.90, new string[]{}, new Autora("Djamila"))
        };

        public List<Livro> GetLivros()
        {
            var servico = new BibliotecaService();
            var resposta = servico.BuscaLivro();
            var listaDeLivro = new List<Livro>();

            foreach (var item in resposta.Results)
            {
                var livro = new Livro()
                {
                    Titulo = item.TrackName,
                    Autora = new Autora(item.ArtistName),
                    Preco = item.Price,
                    Genero = item.Genres,
                    Descricao = item.Description
                };
                listaDeLivro.Add(livro);
            }

            return listaDeLivro;
        }
    }
} 