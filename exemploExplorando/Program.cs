using exemploExplorando.Models;





LeituraArquivo arquivo = new LeituraArquivo(); ///

var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

if (sucesso)
{
    Console.WriteLine("Quantidade Linhas do arquivo" + quantidadeLinhas);
    foreach (string linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Não foi possível ler o arquivo.");
}






// (int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Alex", "Lopes ", 1.83M);// forma 

// // ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Alex", "Lopes ", 1.83M);
// // var exemploTuplaCreate = Tuple.Create(1, "Alex", "Lopes, 1,83M");

// Console.WriteLine($"ID: {tupla.Id}");
// Console.WriteLine($"Nome: {tupla.Nome}");
// Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
// Console.WriteLine($"Altura: {tupla.Altura}");












// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP", "São Paulo");
// estados.Add("BA", "Bahia");
// estados.Add("MG", "Minas Gerais");
// estados.Add("PE", "Pernambuco");

// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }




// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach (var item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

// pilha.Push(20);

// foreach (var item in pilha)
// {
//     Console.WriteLine(item);
// }



// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach (var item in fila)
// {
//     Console.WriteLine(item);
// }

// fila.Enqueue(10);


// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");

// foreach (var item in fila)
// {
//     Console.WriteLine(item);
// }

// new ExemploExcessão().Metodo1();



// try
// {

//     string[] linhas = File.ReadAllLines("Arquivos/arquivo_Leitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }

// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine("Arquivo não encotrado." + ex.Message);
// }
// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine("Diretório não encontrado." + ex.Message);
// }
// finally
// {
//     Console.WriteLine("Chegou até aqui");
// }




// Pessoa pessoa1 = new Pessoa(nome: "Alex", sobrenome: "Lopes");

// Pessoa pessoa2 = new Pessoa(nome: "Caio", sobrenome: "Lopes");

// Curso CursoDeInglês = new Curso();
// CursoDeInglês.Nome = "Inglês";
// CursoDeInglês.Alunos = new List<Pessoa>();

// CursoDeInglês.AdicionarAluno(pessoa1);
// CursoDeInglês.AdicionarAluno(pessoa2);
// CursoDeInglês.ListarAlunos();
