using System.Reflection;
using exemploExplorando.Models;
using Newtonsoft.Json;


var TipoAnonimo = new { Nome = "Leonardo", Sobrenome = "Buta", Altura = 1.80M };

Console.WriteLine("Nome: " + TipoAnonimo.Nome);
Console.WriteLine("Sobrenome: " + TipoAnonimo.Sobrenome);
Console.WriteLine("Altura: " + TipoAnonimo.Altura);



// string ConteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(ConteudoArquivo);

// foreach (Venda venda in listaVenda)
// {
//     Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}," +
//                        $"Preco: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyy HH:mm")}" +
//                        $"{(venda.Desconto.HasValue ? $"Desconto de: {venda.Desconto}" : "")}");

// }
// bool? desejaReceberEmail = true;

// if (desejaReceberEmail.HasValue && desejaReceberEmail.Value)
// {
//     Console.WriteLine("O usuário optou por receber email.");
// }
// else
// {
//     Console.WriteLine("O usuário não respondeu ou optou por receber email.");
// }

// DateTime dataAtual = DateTime.Now;

// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);
// Venda v2 = new Venda(2, "Licença Windows", 100.00M, dataAtual);
// Venda v3 = new Venda(3, "Mouse", 10.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);
// listaVendas.Add(v3);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.json", serializado);

// Console.WriteLine(serializado);






// LeituraArquivo arquivo = new LeituraArquivo(); ///

// var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if (sucesso)
// {
//     Console.WriteLine("Quantidade Linhas do arquivo" + quantidadeLinhas);
//     foreach (string linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Não foi possível ler o arquivo.");
// }






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
