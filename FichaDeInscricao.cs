using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_S02
{
    // nome da classe (public classe = modificador público)
    public class FichaDeInscricao
    {
        //Criação de propriedades públicas
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool MenorIdade { get; set; }

        //Construtor com parâmetros
        public FichaDeInscricao(int id, string nome, DateTime dataNascimento, bool menorIdade)
        {
            Id = id;
            Nome = nome;
            DataNascimento = dataNascimento;
            MenorIdade = menorIdade;
        }

        //Método com a função void
        //Void é um ato ou ação
        public void Ficha()
        {
            if(MenorIdade == false)
            {
                Console.WriteLine($"{Nome} que tem a ficha de inscrição com o código n.º {Id} nascido em {DataNascimento} é menor de idade");
            }
            else
            {
                Console.WriteLine($"{Nome} que tem a ficha de inscrição com o código n.º {Id} nascido em {DataNascimento} é maior de idade");
            }

        }
    }

}
