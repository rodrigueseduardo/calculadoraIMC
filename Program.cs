Console.WriteLine("Bem vindo a calculadora de IMC!");
Console.WriteLine("Digite o seu peso em kilogramas: ");

double peso = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a sua altura em metros: ");

double altura = Convert.ToDouble(Console.ReadLine());

//calculo do imc
double imc = peso / (altura * altura);

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
