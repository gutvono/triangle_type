float side1 = 0, side2 = 0, side3 = 0;
int restart = 0;


do
{
    Console.Clear();

    Console.WriteLine("ESTE PROGRAMA IRÁ MOSTRAR QUAL O TIPO DO TRIANGO DADOS OS LADOS INFORMADOS ABAIXO");

    Console.Write("Informe o primeiro lado:");
    side1 = float.Parse(Console.ReadLine());
    Console.WriteLine();

    Console.Write("Informe o segundo lado:");
    side2 = float.Parse(Console.ReadLine());
    Console.WriteLine();

    Console.Write("Informe o terceiro lado:");
    side3 = float.Parse(Console.ReadLine());
    Console.WriteLine();

    //EQUILATERO
    if (side1 == side2 && side2 == side3)
    {
        Console.WriteLine("Este triangulo é EQUILATERO");
    }
    else if (side1 == side2 || side2 == side3 || side1 == side3)
    {
        Console.WriteLine("Este triângulo é ISÓSCELES");
    }
    else
    {
        Console.WriteLine("Este triângulo é ESCALENO");
    }

    Console.WriteLine();
    Console.WriteLine("Deseja reiniciar?");
    Console.WriteLine("1 - SIM");
    Console.WriteLine("2 - NÃO");
    restart = int.Parse(Console.ReadLine());

} while (restart == 1);