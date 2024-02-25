class Program {
    static void Main(string[] args) {
        Aluno aluno1 = new Aluno { Nome = "Maria", Matricula = "2021001" };
        Aluno aluno2 = new Aluno { Nome = "José", Matricula = "2021002" };
        Disciplina disciplina = new Disciplina { Nome = "Matemática" };
        Professor professor = new Professor { Nome = "João Silva", Disciplina = "Matemática" };
        Turma turma = new Turma(disciplina, professor, 5);

        Console.WriteLine(turma.AddAluno(new Aluno { Nome = "Ana", Matricula = "2021003" })); 
        Console.WriteLine(turma.AddAluno(new Aluno { Nome = "Carlos", Matricula = "2021004" }));
        Console.WriteLine(turma.AddAluno(new Aluno { Nome = "Luiza", Matricula = "2021005" }));
        Console.WriteLine(turma.AddAluno(aluno1));
        Console.WriteLine(turma.AddAluno(aluno2));
        Console.WriteLine(turma.GerarPauta());
    }
}
