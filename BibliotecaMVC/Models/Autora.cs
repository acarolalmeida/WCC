using System;
using System.Collections.Generic;

namespace BibliotecaMVC
{
    public class Autora
    {
        private string nome {get; set;}
        
        public Autora()
        {

        }

        public Autora(string nome)
        {
            Nome = nome;
        }

        public string Nome
        {
            get {return nome;}
            set {nome = value;}
            //set {nome = $"{value} perfeita";}
        }

        public List<Autora> Model => new List<Autora>() 
        {
            this, 
            new Autora("Djamila")
        };

    }
}  