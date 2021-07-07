using System;
using System.Collections.Generic;

  public class Aluno : Pessoa{


        private string _matricula;

            public string Matricula
        {
            get
            {
                return this._matricula;
            }
        }
           
        public Aluno(string nome,string matricula, string cpf)
        {
          
            this._matricula = matricula;
            this._nome = nome;
            this._cpf = cpf;
        }
         public override void Imprimir()
        {
            Console.WriteLine("Matricula:\t{0}", this.Matricula);
            Console.WriteLine("Nome:\t{0}", this.Nome); 
            Console.WriteLine("CPF:\t{0}", this.Cpf);

        }
  }
