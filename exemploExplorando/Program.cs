using exemploExplorando.Models;

Pessoa pessoa1 = new Pessoa(nome: "Alex", sobrenome: "Lopes");

Pessoa pessoa2 = new Pessoa(nome: "Caio", sobrenome: "Lopes");

Curso CursoDeInglês = new Curso();
CursoDeInglês.Nome = "Inglês";
CursoDeInglês.Alunos = new List<Pessoa>();

CursoDeInglês.AdicionarAluno(pessoa1);
CursoDeInglês.AdicionarAluno(pessoa2);
CursoDeInglês.ListarAlunos();
