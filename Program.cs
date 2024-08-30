char sair;
do
{
    try
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Digite o primeiro número: ");
        double numero1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double numero2 = double.Parse(Console.ReadLine());

        Console.Write("\nInforme qual operação você quer fazer: (+, -, *, /): ");
        char operacao = char.Parse(Console.ReadLine());
        Console.ResetColor();

        double resultado = 0;

        switch (operacao)
        {
            case '+':
                resultado = numero1 + numero2;
                Console.WriteLine($"{numero1} + {numero2} = {resultado}");
                break;
            case '-':
                resultado = numero1 - numero2;
                Console.WriteLine($"{numero1} - {numero2} = {resultado}");
                break;
            case '*':
                resultado = numero1 * numero2;
                Console.WriteLine($"{numero1} * {numero2} = {resultado}");
                break;
            case '/':
                try
                {
                    if (numero2 == 0)
                    {
                        throw new DivideByZeroException();
                    }
                    resultado = numero1 / numero2;
                    Console.WriteLine($"{numero1} / {numero2} = {resultado}");
                }
                catch (DivideByZeroException ex)
                {

                    Console.WriteLine(ex.Message);
                }
                break;
            default:
                try
                {
                    throw new InvalidOperationException();
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                //Console.WriteLine("Operação inválida.");
                break;
        }
    }
    catch (FormatException ex)
    {

        Console.WriteLine(ex.Message);
    }
    finally
    {
        Console.Write("Aperte 'X' para Sair ou 'C' para continuar: ");
        sair = Console.ReadLine()[0];
    }  
}
while (sair != 'x' && sair != 'X');
Console.WriteLine("Programa encerrado.");


Console.ReadKey();


