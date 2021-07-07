using System;
using System.Collections.Generic;

   public class Turma : IImprimivel{

      private string _nome;
      private string _serie;
      private List<Aluno> _alunos;
      private List<Professor> _professores;

              public string Nome
        {
            get
            {
                return this._nome;
            }
        }
        public List<Aluno> Alunos
        {
          get{
            return this._alunos;
          }
        }
        public List<Professor> Professores{
          get{
            return this._professores;
          }
        }
        public void AdicionarAluno(Aluno alunito)
        {
           this._alunos.Add(alunito);
        }
        public void AdicionarProfessor(Professor profezito)
        {
           this._professores.Add(profezito);
        }
               public string Serie
        {
            get
            {
                return this._serie;
            }
        }
          public Turma(string nome, string serie)
        {
            this._nome = nome;
            this._serie = serie;
            this._alunos=new List<Aluno>();
            this._professores = new List<Professor>();
        }
         public  void Imprimir()
        {
            Console.WriteLine("Nome:\t{0}", this.Nome); 
            Console.WriteLine("Serie:\t{0}", this.Serie);
            Console.WriteLine("Alunos:");
            foreach(var alunito in this._alunos){
              Console.WriteLine(alunito.Nome);
            }
            Console.WriteLine("Professores:");
            foreach(var profezito in this._professores){
              Console.WriteLine(profezito.Nome);
            }
            
        }
   }