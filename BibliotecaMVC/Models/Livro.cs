using System;

namespace BibliotecaMVC
{
    public class Livro{

        private string titulo{get; set;}
        private string descricao{get; set;}
        private double preco{get; set;}
        private string[] genero{get; set;}
        private Autora autorLivro{get; set;}

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

        public Livro()
        {

        }

        public Livro Cadastrar()
        {
            return this;
        }
    }
} 