using System;

public class Produto
{
    public int Codigo { get; set; }
    public string Nome { get; set; }
    public double Preco { get; set; }
    private double Desconto { get; } //Exercicio 4

    public Produto(int codigo, string nome, double preco)
    {
        Codigo = codigo;
        Nome = nome;
        Preco = preco;
        Desconto = 0.10;
    }

    public void AplicaDesconto()//Exercicio 4
    {
        Preco = Preco * Desconto;
    }
}

