using System;


    public class Professor: Pessoa{

      private string _email;

        public string Email
        {
            get
            {
                return this._email;
            }
        }
        public Professor(string nome ,string email,string cpf)
        {
          this._nome = nome;
          this._cpf = cpf;
          this._email = email;
        }
         public override void Imprimir()
        {
            Console.WriteLine("Email:\t{0}", this.Email);
            Console.WriteLine("Nome:\t{0}", this.Nome); 
            Console.WriteLine("CPF:\t{0}", this.Cpf);
   
        }
    }