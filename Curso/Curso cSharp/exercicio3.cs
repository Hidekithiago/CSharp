using System;
using System.Web;

public class Calculadora
{
    public double Valor1 { get; set; }
    public double Valor2 { get; set; }
    public string Operador { get; set; }
    public double Resultado { get; }

    public Calculadora(double valor1, double valor2, string operador)
    {
        Valor1 = valor1;
        Valor2 = valor2;
        Operador = operador;
    }

    public static double RealizaCalculo(double valor1, double valor2, string operador)
    {
        double resultado = 0;
        if (operador.Equals("+"))
        {
            resultado = valor1 + valor2;
            Console.WriteLine($"Valor1 {valor1} \nValor2 {valor2}\n Resultado {resultado}");
        }


        else if (operador.Equals("-")) resultado = valor1 - valor2;
        else if (operador.Equals("/")) resultado = valor1 / valor2;
        else if (operador.Equals("*")) resultado = valor1 * valor2;
        else if (operador.Equals("**"))
        {
            resultado = Math.Pow(valor1, valor2);
        }
        return resultado;
    }
    public class Execucao { }
    /*
    static void Main(string[] args)
    {
        Calculadora calculadora = new Calculadora(2, 3, "**");
        
        double resultado = RealizaCalculo(calculadora.Valor1, calculadora.Valor2, calculadora.Operador);
        
        
        double a = Double.Parse(Console.ReadLine());
        double b = Double.Parse(Console.ReadLine());
        string c = Console.ReadLine();
        calculadora = new Calculadora(a, b, c);
        Console.WriteLine(calculadora);
        resultado = RealizaCalculo(calculadora.Valor1, calculadora.Valor2, calculadora.Operador);
    }*/
}

