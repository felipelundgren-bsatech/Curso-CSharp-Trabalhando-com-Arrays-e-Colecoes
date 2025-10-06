using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Util;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");


void TestarArrayInt()
{
    int[] idades = {15, 28, 35, 42, 57};

    Console.WriteLine($"Tamanho do array idades: {idades.Length}");
    int acumulador = 0;
    for (int i = 0; i < idades.Length; i++)
    {
        int idade = idades[i];
        Console.WriteLine($"Indice[{i}] = {idades[i]}");
        acumulador += idade;
        double media = acumulador / idades.Length;
        Console.WriteLine($"a media das idades é: {media}");
    }
}

void TestarBuscarPalavra()
{
    string[] arrayDePalavras = new string[5];

    for (int i = 0; i < arrayDePalavras.Length; i++)
    {
        Console.Write($"Digite  {i+1}ª Palavra: ");
        arrayDePalavras[i] = Console.ReadLine();
    }
    Console.WriteLine("Digite a palavra a ser encontrada: ");
    var palavraBuscada = Console.ReadLine();

    foreach (string palavra in arrayDePalavras)
    {
        if (palavra.Equals(palavraBuscada))
        {
            Console.WriteLine($"Palavra Encontrada = {palavraBuscada}");
            break;
        }
        
    }
}


Array amostra  = Array.CreateInstance(typeof(double), 5);
amostra.SetValue(5.9, 0);
amostra.SetValue(6.7, 1);
amostra.SetValue(7.1, 2);
amostra.SetValue(8.3, 3);
amostra.SetValue(9.4, 4);
void TestaMediana(Array array)
{ 
    if (array == null) 
    {
        Console.WriteLine("Array para cálculo da mediana é nulo");
        
    }
    else
    {
        double[] numerosOrdenados = (double[])array.Clone();
        Array.Sort(numerosOrdenados);
        
        int tamanho = numerosOrdenados.Length;
        int meio = tamanho / 2;
        double mediana = (tamanho%2 != 0)? numerosOrdenados[meio]:
                                           numerosOrdenados[meio] + numerosOrdenados[meio -1] /2;

        Console.WriteLine($"Com base na amostra a mediana = {mediana}");
    }
}

void TestarArrayDeContasCorrentes()
{
    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
    listaDeContas.Adicionar(new ContaCorrente(874) { Conta = "1010-X", Saldo = 100 });
    listaDeContas.Adicionar(new ContaCorrente(874) { Conta = "2020-X", Saldo = 200 });
    listaDeContas.Adicionar(new ContaCorrente(874) { Conta = "3030-X", Saldo = 300 });
    listaDeContas.Adicionar(new ContaCorrente(874) { Conta = "4040-X", Saldo = 400 });
    listaDeContas.Adicionar(new ContaCorrente(874) { Conta = "5050-X", Saldo = 500 });
    listaDeContas.Adicionar(new ContaCorrente(874) { Conta = "6060-X", Saldo = 600 });
}
TestarArrayDeContasCorrentes();