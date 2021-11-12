using System;

public class Livro{

    public string titulo{get; set;}
    public string descricao{get; set;}
    public double preço{get; set;}
    public string[] genero{get; set;}
    Autora autorLivro{get; set;}

    public Livro(){}
}