using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdadeAnoBissexto
{
    internal class Pessoa
    {
        string Nome;
        int Idade;
        string Profissao;

        public Pessoa()
        {
        }

        public void SetNome(string nome)
        {
            Nome = nome;
        }
        public void SetIdade(int idade)
        {
            Idade = idade;
        }        
        public void SetProfissao(string profissao)
        {
            Profissao = profissao;
        }
        public string GetNome()
        {
            return Nome;
        }
        public int GetIdade()
        {
            return Idade;
        }
        public string GetProfissao()
        {
            return Profissao;
        }
        public int CalcularIdadeBissexto(int idade, int anoAtual)
        {
            int anosBissexto = 0;
            for (int i = 0; i < idade; i++)
            {
                if (DateTime.IsLeapYear(anoAtual - i))
                    anosBissexto++;
            }
            return anosBissexto;
        }
    }
}
