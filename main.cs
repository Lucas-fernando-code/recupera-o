using System;
using System.Collections.Generic;
class MainClass {
  public static void Main (string[] args) {
  
    Aluno a1 = new Aluno("Jo",   "A78265139","12345678911");
    Aluno a2 = new Aluno("Lala", "A27346133","98745632121");
    Aluno a3 = new Aluno("Lis",  "A21312312","15935748622");
    Aluno a4 = new Aluno("Lô",   "A457238423","26841357946");
    Aluno a5 = new Aluno("Titi", "A382735922","16794238156");
    Aluno a6 = new Aluno("Juca", "A018367541","65419872366");

    Professor p1 = new Professor("Anaxarmandra", "anax@email.com","149785623");
    Professor p2 = new Professor("Hermenegildo", "herm@email.com","254987613");
    Professor p3 = new Professor("Benevides", "bene@email.com","3216548756");

    Turma t1 = new Turma("101", "1° série");
    t1.AdicionarAluno(a1);
    t1.AdicionarAluno(a2);
    t1.AdicionarAluno(a3);
    t1.AdicionarProfessor(p1);
    t1.AdicionarProfessor(p2);

    Turma t2 = new Turma("201", "2° série");
    t2.AdicionarAluno(a4);
    t2.AdicionarAluno(a5);
    t2.AdicionarAluno(a6);
    t2.AdicionarProfessor(p2);
    t2.AdicionarProfessor(p3);

    Relatorio rAlunos = new Relatorio("Alunos", "Relatório de Alunos");
    rAlunos.AdicionarItem(a1);
    rAlunos.AdicionarItem(a2);
    rAlunos.AdicionarItem(a3);
    rAlunos.AdicionarItem(a4);
    rAlunos.AdicionarItem(a5);
    rAlunos.AdicionarItem(a6);

    Relatorio rProfessores = new Relatorio("Professores", "Relatório de Professores");
    rProfessores.AdicionarItem(p1);
    rProfessores.AdicionarItem(p2);
    rProfessores.AdicionarItem(p3);

    Relatorio rTurmas = new Relatorio("Turmas", "Relatório de Turmas");
    rTurmas.AdicionarItem(t1);
    rTurmas.AdicionarItem(t2);

    rAlunos.ImprimirRelatorio();
    rProfessores.ImprimirRelatorio();
    rTurmas.ImprimirRelatorio();


  }
}