public class Calculadora
{
    public int operacao { get; set; }
    public int operador1 { get; set; }
    public int operador2 { get; set; }
    public void Start()
    {
        Menu();
        switch (operacao)
        {
            default:
                Console.WriteLine("A operação não é valida.");
                break;
            case 0:
                Console.WriteLine("Deligar");
                break;
            case 1:
                operador1 = PegarValores();
                operador2 = PegarValores();
                Somar(operador1, operador2);
                break;
            case 2:
                operador1 = PegarValores();
                operador2 = PegarValores();            
                Subtrair(operador1, operador2);
                break;
            case 3:
                operador1 = PegarValores();
                operador2 = PegarValores();
                Multiplicar(operador1, operador2);
                break;
            case 4:
                operador1 = PegarValores();
                operador2 = PegarValores();
                Dividir(operador1, operador2);
                break;
        }
    }
    public int PegarValores(string tipo = "operador")
    {
        switch (tipo)
        {
            case "operacao":
                Console.WriteLine("Insira uma das operações.");
                break;
            default:
                Console.WriteLine($"Insira um {tipo}");
                break;
        }
        string? input = Console.ReadLine();
        int aux;
        int.TryParse(input, out aux);

        return aux;
    }
    public void Menu()
    {
        Console.WriteLine("\tCalculadora");
        Console.WriteLine("\tDigite 0 para sair da calculadora.");
        Console.WriteLine("\tDigite 1 para Soma.");
        Console.WriteLine("\tDigite 2 para Subtrair.");
        Console.WriteLine("\tDigite 3 para Multiplicar.");
        Console.WriteLine("\tDigite 4 para Dividir.");

        operacao = PegarValores("operacao");
    }
    public void Somar(int x, int y)
    {
        Console.WriteLine($"{x} + {y} é {x + y}");
    }

    public void Subtrair(int x, int y)
    {
        Console.WriteLine($"{x} - {y} é {x - y}");
    }

    public void Multiplicar(int x, int y)
    {
        Console.WriteLine($"{x} * {y} é {x * y}");
    }
    
    public void Dividir(int x, int y)
    {
        Console.WriteLine($"{x} / {y} é {x / y}");
    }

    public void Potencia(int x, int y)
    {
        double pot =  Math.Pow(x,y);
        Console.WriteLine($"{x} elevado à {y} é {pot}");
    }

    public void Seno(double angulo)
    {
        double radiano = angulo * Math.PI / 180;
        double seno = Math.Sin(radiano);
        Console.WriteLine($"Seno de {angulo} é {seno}");
    }
}