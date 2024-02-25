using System;
using System.Collections.Generic;

public class Aluno {
    public string Nome { get; set; }
    public string Matricula { get; set; }
}

public class Professor {
    public string Nome { get; set; }
    public string Disciplina { get; set; }
}

public class Disciplina {
    public string Nome { get; set; }
}

public class Turma {
    private List<Aluno> alunos = new List<Aluno>();
    private Professor professor;
    private Disciplina disciplina;
    private int capacidadeMaxima;
    private bool turmaAberta;
    
    public Turma(Disciplina disciplina, Professor professor, int capacidadeMaxima) {
        this.disciplina = disciplina;
        this.professor = professor;
        this.capacidadeMaxima = capacidadeMaxima;
        this.turmaAberta = false;
    }
    
    public string AddAluno(Aluno aluno) {
        if (alunos.Count < capacidadeMaxima) {
            alunos.Add(aluno);
            return "Aluno adicionado";
        } else {
            return "Turma cheia";
        }
    }
    
    public bool AbrirTurma() {
        if (alunos.Count > 0) {
            turmaAberta = true;
            return true;
        } else {
            return false;
        }
    }
    
    public string GerarPauta() {
        string pauta = $"Turma: {disciplina.Nome}\n";
        pauta += $"Disciplina: {professor.Disciplina}\n";
        pauta += $"Professor: {professor.Nome}\n";
        pauta += "Alunos inscritos:\n";
        foreach (var aluno in alunos) {
            pauta += $"{aluno.Nome} - Matrícula: {aluno.Matricula}\n";
        }
        return pauta;
    }
}
