using static System.Net.Mime.MediaTypeNames;

namespace IdadeAnoBissexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            Console.WriteLine("Digite o nome da pessoa:");
            pessoa.SetNome(Console.ReadLine());
            
            Console.WriteLine("Digite a idade da pessoa:");
            int idade = 0; 
            do
            {
                idade = int.Parse(Console.ReadLine());
                if (idade < 0 || idade > 120)
                    Console.WriteLine("Digite uma idade válida!");
            } while (idade < 0 || idade > 120);
            
            pessoa.SetIdade(idade);
            
            Console.WriteLine("Digite a profissão da pessoa:");
            pessoa.SetProfissao(Console.ReadLine());

            int anoAtual = DateOnly.FromDateTime(DateTime.Now).Year;
            int anosBissexto = pessoa.CalcularIdadeBissexto(idade, anoAtual);
            Console.WriteLine($"{pessoa.GetNome()}, tem {pessoa.GetIdade()} e é {pessoa.GetProfissao()}, {pessoa.GetNome()} teria {anosBissexto} anos se só fizesse aniversário nos anos bissextos!");
        }
    }
}
