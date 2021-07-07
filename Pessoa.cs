using System;
using System.Collections.Generic;


    public abstract class Pessoa : IImprimivel
    {
        protected string _nome;
        protected string _cpf;

        public string Nome
        {
            get
            {
                return this._nome;
            }
        }


        public string Cpf
        {
            get
            {
                return this._cpf;
            }
        }
public abstract void Imprimir();


    }
