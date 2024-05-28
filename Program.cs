// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

//1. Crie um programa em que o usuário precisa digitar um nome e uma mensagem de boas vindas personalizada com o nome dele é exibida:  Olá, Welisson! Seja muito bem-vindo!

Console.WriteLine("Olá, qual é seu nome ?");
var nome = Console.ReadLine();

//2. Crie um programa que concatene um nome e um sobrenome inseridos pelo usuário e ao final exiba o nome completo.

Console.WriteLine($"Olá, {nome}! Seja muito bem-vindo!");
Console.WriteLine("Qual é o seu sobrenome?");
var sobreNome = Console.ReadLine();

Console.WriteLine($"Seu nome completo e {nome} {sobreNome}");

//3.Crie um programa com 2 valores do tipo `**double`** já declarados ****que retorne:
//    -A soma entre esses dois números;
//    -A subtração entre os dois números;
//    -A multiplicação entre os dois números;
//    -A divisão entre os dois números (vale uma verificação se o segundo número é 0!);
//    -A média entre os dois números.

operacao(2, 2);

static void operacao(double n1, double n2)
{
    Console.WriteLine($"A soma dos numeros {n1} e {n2} é igual a {n1 + n2}");
    Console.WriteLine($"A subtração dos numeros {n1} e {n2} é igual a {n1 - n2}");
    Console.WriteLine($"A multiplicação dos numeros {n1} e {n2} é igual a {n1 * n2}");

    if (n2 == 0)
    {
        Console.WriteLine("O segundo numero e igual a 0!");
    }
    else
    {
        Console.WriteLine($"A divisão dos numeros {n1} e {n2} é igual a {n1 / n2}");
    }
    Console.WriteLine($"A media dos numeros {n1} e {n2} é igual a {(n1 + n2) / 2}");
}

//4.Crie um programa em que o usuário digita uma ou mais palavras e é exibido a quantidade de caracteres que a palavra inserida tem.

Console.WriteLine("Digite uma frase:");
var frase = Console.ReadLine();

Console.WriteLine($"O numero de caracteres dessa frase e {frase.Length}");

//5. 1. Crie um programa em que o usuário precisa digitar a placa de um veículo e o programa verifica se a placa é válida, seguindo o padrão brasileiro válido até 2018:
//      -A placa deve ter 7 caracteres alfanuméricos;
//      -Os três primeiros caracteres são letras (maiúsculas ou minúsculas);
//      -Os quatro últimos caracteres são números;

//Ao final, o programa deve exibir ***Verdadeiro*** se a placa for válida e ***Falso*** caso contrário.

Console.WriteLine(verificarPlaca("sss7626"));

static bool verificarPlaca(string placa)
{
    Regex regex = new Regex("^[a-zA-Z]{3}\\d+$");

    if (placa.Length == 7 && regex.IsMatch(placa))
    {
        return true;
    }
    else
    {
        return false;
    }
}

DateTime dataAtual = DateTime.Now;

// Formato completo
Console.WriteLine("Formato completo: " + dataAtual.ToString("dddd, dd MMMM yyyy HH:mm:ss"));

// Apenas a data no formato "01/03/2024"
Console.WriteLine("Apenas a data: " + dataAtual.ToString("dd/MM/yyyy"));

// Apenas a hora no formato de 24 horas
Console.WriteLine("Apenas a hora: " + dataAtual.ToString("HH:mm:ss"));

// A data com o mês por extenso
string mesPorExtenso = dataAtual.ToString("dd MMMM yyyy").Replace(dataAtual.ToString("MMMM"), GetMonthName(dataAtual.Month));
Console.WriteLine("Data com o mês por extenso: " + mesPorExtenso);

static string GetMonthName(int month)
{
    switch (month)
    {
        case 1: return "janeiro";
        case 2: return "fevereiro";
        case 3: return "março";
        case 4: return "abril";
        case 5: return "maio";
        case 6: return "junho";
        case 7: return "julho";
        case 8: return "agosto";
        case 9: return "setembro";
        case 10: return "outubro";
        case 11: return "novembro";
        case 12: return "dezembro";
        default: throw new ArgumentOutOfRangeException("month", "Valor do mês inválido");
    }
}