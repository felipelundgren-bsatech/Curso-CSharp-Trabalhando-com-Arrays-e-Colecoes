using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Util;
using System.Collections;
using System.Collections.Concurrent;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

#region Exemplos Arrays e Coleções
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
    var contaDoFelipe = new ContaCorrente(874) { Conta = "7070-X", Saldo = 700 };
    listaDeContas.Adicionar(contaDoFelipe);
    //listaDeContas.ExibeLista();
    //Console.WriteLine("----------------------------------------------------");
    //listaDeContas.Remover(contaDoFelipe);
    //listaDeContas.ExibeLista();
    for (int i = 0; i < listaDeContas.Tamanho; i++)
    {
        ContaCorrente conta = listaDeContas[i];
        Console.WriteLine($"Indice [{i}] = {conta.Conta}/{conta.Numero_agencia}");
    }

}
//TestarArrayDeContasCorrentes();
#endregion

ArrayList _listaDeContas = new ArrayList();
void AtendimentoCliente()
{
    char op = '0';
    while (op!='6')
    {
        Console.Clear();
        Console.WriteLine("Atendimento ao Cliente - ByteBank");
        Console.WriteLine("------------------------------");
        Console.WriteLine("1 - Cadastrar Conta Corrente");
        Console.WriteLine("2 - Listar Contas Correntes");
        Console.WriteLine("3 - Remover Conta Corrente");
        Console.WriteLine("4 - Ordenar Contas Correntes");
        Console.WriteLine("5 - Pesquisar Conta Corrente");
        Console.WriteLine("6 - Sair Do Sistema");
        Console.WriteLine("\n\n");
        Console.Write("Digite a Opção Desejada: ");
        op = Console.ReadLine()[0];
        switch (op)
        {
            case '1':
                Console.Clear();
                Console.WriteLine("Cadastro de Conta Corrente");
                Console.WriteLine("------------------------------");
                CadastrarConta();
                
                break;
            case '2':
                Console.Clear();
                Console.WriteLine("Listar Contas Correntes");
                Console.WriteLine("------------------------------");
                ListarContas();
                break;
            case '3':
                Console.Clear();
                Console.WriteLine("Remover Conta Corrente");
                Console.WriteLine("------------------------------");
                break;
            case '4':
                Console.Clear();
                Console.WriteLine("Ordenar Contas Correntes");
                Console.WriteLine("------------------------------");
                break;
            case '5':
                Console.Clear();
                Console.WriteLine("Pesquisar Conta Corrente");
                Console.WriteLine("------------------------------");
                break;
            case '6':
                Console.Clear();
                Console.WriteLine("Obrigado por utilizar o ByteBank!");
                break;
            default:
                Console.Clear();
                Console.WriteLine("Opção Inválida! Tente Novamente.");
                break;
        }
    }
}

void ListarContas()
{
    Console.WriteLine("Lista de Contas");
    Console.WriteLine("-------------------------");
    if (_listaDeContas.Count<=0)
    {
        Console.WriteLine("--- Não há contas cadastradas ---");
        Console.ReadKey();
        return;
    }
    foreach (ContaCorrente conta in _listaDeContas)
    {
        Console.WriteLine("--- Dados da conta ---");
        Console.WriteLine($"Numero da Conta: {conta.Conta}");
        Console.WriteLine($"Número da Agência: {conta.Numero_agencia}");
        Console.WriteLine($"Titular: {conta.Titular.Nome}");
        Console.WriteLine($"CPF do Titular: {conta.Titular.Cpf}");
        Console.WriteLine($"Saldo: {conta.Saldo}");
        Console.WriteLine("-------------------------");

    }
}

void CadastrarConta()
{
    Console.WriteLine("Cadastramento de contas: ");
    Console.WriteLine("-------------------------");
   
    Console.Write("Número da conta: ");
    string numeroConta = Console.ReadLine();
  
    Console.Write("Numero da Agencia: ");
    int numeroAgencia = int.Parse(Console.ReadLine());
    ContaCorrente conta = new ContaCorrente(numeroAgencia, numeroConta);
  
    Console.Write("Informe o saldo inicial: ");
    conta.Saldo = double.Parse(Console.ReadLine());
   
    Console.Write("Informe o titular: ");
    conta.Titular.Nome = Console.ReadLine();
    
    Console.Write("Informe o CPF do titular: ");
    conta.Titular.Cpf = Console.ReadLine();
    
    Console.Write("Informe a profissão do titular: ");
    conta.Titular.Profissao = Console.ReadLine();

    _listaDeContas.Add(conta);
    Console.WriteLine("---Conta cadastrada com sucesso---");
    Console.ReadLine();
}

AtendimentoCliente();