Console.WriteLine("Bem vindo a calculadora de IMC!");

bool continuar = true;

while (continuar)
{
    Console.WriteLine("Digite o seu peso em kilogramas: ");
    double peso = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Digite a sua altura em metros: ");
    double altura = Convert.ToDouble(Console.ReadLine());

    //calculo do imc
    double imc = CalcularIMC(peso, altura);

    //exibe o IMC e categoria do peso
    Console.WriteLine($"\nSeu IMC é: {imc}");

    if (imc < 18.5)
        Console.WriteLine("Abaixo do peso");
    else if (imc < 25)
        Console.WriteLine("Peso normal");
    else if (imc < 30)
        Console.WriteLine("Sobrepeso");
    else
        Console.WriteLine("Obesidade");

    //pergunta ao usuário se deseja que o cálculo seja realizado novamente
    Console.Write("\nDeseja que o cálculo seja realizado novamente? (S/N): ");
    string resposta = Console.ReadLine().ToUpper();

    if (resposta == "S");
        
        else break;
}

Console.WriteLine("\nObrigado por utilizar minha calculadora de IMC!");

static double CalcularIMC(double peso, double altura)
{
    return peso / (altura * altura);
}