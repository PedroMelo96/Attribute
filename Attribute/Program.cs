using Attribute;
using System;
using System.Reflection;

class Program
{
    public static void ExibirDadosAberto(object objeto)
    {
        Type tipo = objeto.GetType();


    PropertyInfo[] propriedades = tipo.GetProperties();

        foreach (PropertyInfo propriedade in propriedades)
        {
            object valor = propriedade.GetValue(objeto);

            Console.WriteLine($"{propriedade.Name}: {valor}");
        }
    }

    public static void ExibirDadosControlado(object objeto)
    {
        Type tipo = objeto.GetType();

        PropertyInfo[] propriedades = tipo.GetProperties();

        foreach (PropertyInfo propriedade in propriedades)
        {
            ExibirAttribute atributo = propriedade.GetCustomAttribute<ExibirAttribute>();

            if (atributo != null)
            {
                object valor = propriedade.GetValue(objeto);

                Console.WriteLine($"{propriedade.Name}: {valor}");
            }
        }
    }

    static void Main(string[] args)
    {
        Equipamento equipamento = new Equipamento
        {
            Id = 1,
            Nome = "Notebook",
            Fabricante = "Lenovo",
            NumeroSerie = "ABC123456",
            Valor = 3500.00m,
            Localizacao = "Laboratório de Informática"
        };

        Console.WriteLine("=== REFLECTION ABERTA ===");

        ExibirDadosAberto(equipamento);

        Console.WriteLine();

        Console.WriteLine("=== REFLECTION CONTROLADA ===");

        ExibirDadosControlado(equipamento);
    }


}
