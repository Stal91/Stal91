

using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Atendimento;
using bytebank_ATENDIMENTO.bytebank.Util;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

/*
A utilizar a encapsular a manipulação de um array de objetos em um classe a fim de facilitar a manutenção de uma estrutura de objetos;
Como utilizar um indexador, que permite que uma classe desenvolvida por você possa ser indexada como um array;
A utilizar a collection ArrayList, uma classe que permite trabalhar com coleções de objetos e já implementa uma série de métodos para manipulação de um array de objetos.
*/

#region nesta aula
//A utilizar uma lista genérica de objetos utilizando a classe List, que permite a tipagem de uma lista de objetos e que permite a redução da probabilidade de erros de conversão para a manipulação da lista;
//Sobre métodos disponíveis pela classe List que dinamiza a manipulação de lista de objetos;
//A criar uma classe para tratar as exceções da aplicação e que se faz necessária uma vez que a aplicação em desenvolvimento tem uma interface de interação com o usuário.
#endregion

#region Exemplos Arrays em C#


/*
 Como vimos, os arrays, ou vetores, 
são um agrupamento de elementos que armazenamos em uma sequência,
sendo o primeiro elemento do array o índice zero. Normalmente,
quando criamos uma estrutura deste tipo, temos que definir sua 
dimensão, que pode ser única ou multidimensional. 
Vamos a um exemplo de um array de uma dimensão:

int[] numeros = new int[10]; 

Podemos ter ainda um array com mais de uma dimensão, como por exemplo:

int[,] numeros = new int[3,3];

 */
void TestaArrayInt()
{
    int[] idades = new int[5];
    idades[0] = 30;
    idades[1] = 23;
    idades[2] = 40;
    idades[3] = 18;
    idades[4] = 14;

    Console.WriteLine($"Tamano do Array {idades.Length}");

    int acumulador = 0;
    for (int i = 0; i < idades.Length; i++)
    {
        int idade = idades[i];
        Console.WriteLine($"indice [{i}] = {idade}");
        acumulador += idade;
    }

    int media = acumulador / idades.Length;
    Console.WriteLine($"Media de idades = {media}");
}


void TestaBuscarPalavra()

/*
 Nesta aula aprendemos como percorrer um array em busca de determinado elemento,
então que tal praticar um pouco? Vamos criar uma função que pesquise uma palavra
dentro de um array de strings.
 */


{
    string[] arrayDePalavras = new string[5];
    for (int i = 0; i < arrayDePalavras.Length; i++)
    {
        Console.Write($"Digite {i+1}ª Plavra: ");
        arrayDePalavras[i] = Console.ReadLine();

    }
    Console.WriteLine("Digite a palavra a ser encontrada: ");
    var busca = Console.ReadLine();

    foreach (string palavra in arrayDePalavras)
    {
        if (palavra.Equals(busca))
        {
            Console.WriteLine($"Palavra encontrada = {busca}");
            break;
        }

    }
}

void TestaArrayBool()
{
    bool[] opcoes = { true, false, true, true, true, false };
    for (int i = 0; i < opcoes.Length; i++)
    {
        Console.WriteLine($"Opcao {i} = {opcoes[i]}");
    }
}

//Array amostra = Array.CreateInstance(typeof(double), 5);
Array amostra = new double[5]; //forma simplificada ^ desse de cima
amostra.SetValue(5.9, 0);
amostra.SetValue(1.8, 1);
amostra.SetValue(7.1, 2);
amostra.SetValue(10, 3);
amostra.SetValue(6.9, 4);

//TestaMediana(amostra);
void TestaMediana(Array array)
/*
 * A classe Array é a superclasse de onde todas as instâncias de array do C# herdam seus atributos e métodos. Dentre as características desta classe temos:

Pode possuir uma ou mais dimensões.
Tem um tamanho fixo.
Suporta acesso por índices.
Como vimos, podemos criar uma instância da classe usando a sintaxe mais simplificada int[] valores = new int[10] ou usar o método CreateInstance por exemplo: Array pesquisa = Array.CreateInstance(typeof(double), 6);

Para adicionar elementos ao vetor podemos usar o método SetValue que recebe dois parâmetros: o elemento e o índice, onde o elemento será “setado”. Temos um exemplo: pesquisa.SetValue(9.1,1);

As principais propriedades e métodos disponibilizados pela classe Array apresentamos na tabela abaixo:

Propriedade/Método	Descrição
GetValue	retorna o conteúdo/valor de um elemento pelo índice.
GetLength	retorna o números de elementos do array.
Rank	retorna o número de dimensões de um array.
CopyTo	cria uma cópia de todos os valores de um array.
Sort	ordena os valores de um array de forma ascendente.
Reverse	inverte a ordem de elementos de um array.
Clone	cria uma cópia do array.
Length	retorna o número de elementos de um array.
IndexOf	encontra a primeira ocorrência de um elemento no array.
LastIndexOf	encontra a última ocorrência de um elemento no array.
Clear	limpa todas as posições de um array.
Exists	verifica se existe ou não um elemento no array.
 */


{
    if ((array == null) || (array.Length == 0))
    {
        Console.WriteLine("ARRay para calculo da mediana esta vazio ou nulo.");
    }
    double[] numeroOrdenados = (double[])array.Clone();
    Array.Sort(numeroOrdenados);

   
    int tamanho = numeroOrdenados.Length;
    int meio = tamanho / 2;
    double mediana = (tamanho % 2 != 0) ? numeroOrdenados[meio] :
                                     (numeroOrdenados[meio] + numeroOrdenados[meio - 1]) / 2;

    Console.WriteLine($"Com base na amostra a mediana = {mediana}");
}

void TestaArrayDeContasCorrentes()
{

    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
    listaDeContas.Adicionar(new ContaCorrente(874, "5679787-A"));
    listaDeContas.Adicionar(new ContaCorrente(874, "4456668-B"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    var ContaPedro = new ContaCorrente(899, "382918-F");
    listaDeContas.Adicionar(ContaPedro);
    // listaDeContas.ExibeLista();
    // System.Console.WriteLine("=============");
    // listaDeContas.Remover(ContaPedro);
    // listaDeContas.ExibeLista();

    for (int i = 0; i < listaDeContas.Tamanho; i++)
    {
        ContaCorrente conta = listaDeContas[i];
        System.Console.WriteLine($"Indice [{i}] = {conta.Conta}/{conta.Numero_agencia} ");
    }
}


//TestaArrayDeContasCorrentes();
#endregion

#region Exemplos de uso do list
//List<ContaCorrente> _listaDeContas2 = new List<ContaCorrente>()
//{
//    new ContaCorrente(874, "5679787-A"),
//    new ContaCorrente(874, "4456668-B"),
//    new ContaCorrente(874, "7781438-C")
//};

//List<ContaCorrente> _listaDeContas3 = new List<ContaCorrente>()
//{
//    new ContaCorrente(951, "5679787-E"),
//    new ContaCorrente(321, "4456668-F"),
//    new ContaCorrente(719, "7781438-G")
//};

//_listaDeContas2.AddRange(_listaDeContas3);
//_listaDeContas2.Reverse();

//for (int i = 0; i < _listaDeContas2.Count; i++)
//{
//    Console.WriteLine($"Indice[{i}] = Conta [{_listaDeContas2[i].Conta}]");
//}

//var range = _listaDeContas3.GetRange(0, 1);
//for (int i = 0; i < range.Count; i++)
//{
//    Console.WriteLine($"Indice[{i}] = Conta [{range[i].Conta}]");
//}
#endregion

#region nesta aula 

//Sobre a interface IComparable, que deve ser implementada pelo tipo de classe que irá tipificar uma lista genérica para usarmos o método Sort;
//Como utilizar o método Remove da classe lista para remoção de um elemento do array de objetos;
//Como implementar a interface de forma tipada IComparable e o método CompareTo para fazer a ordenação da lista de contas correntes;
//A criar um algoritmo de busca simples para encontrar um objeto no array de contas correntes.

//A utilizar o método de extensão Where aplicado diretamente a lista de objetos, que permite a simplificação da busca de um elemento na lista;
//Sobre a configuração no arquivo .Csproj que configura o projeto para alertar sobre operações que podem retornar um valor nulo para um objeto;
//A usar a sintaxe de consulta do LINQ que torna o código bem legível e de fácil entendimento;
//Como utilizar a estrutura Guid do C# para gerar uma sequência alfanumérica de forma aleatória no sistema.
#endregion

new ByteBankAtendimento().AtendimentoCliente();














