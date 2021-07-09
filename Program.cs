using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularBonificacao(); 

            UsarSistema();

        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor francisco = new Diretor("000.000.000-02");
            francisco.Nome = "Francisco";
            francisco.Senha = "123";

            GerenteDeConta iracema = new GerenteDeConta("000.000.000-04");
            iracema.Nome = "Iracema";
            iracema.Senha = "abc";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            sistemaInterno.Logar(parceiro, "123456");

            sistemaInterno.Logar(francisco, "123");
            sistemaInterno.Logar(iracema, "abc");
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Funcionario nicolas = new Designer("000.000.000-01");
            nicolas.Nome = "Nicolas Cage";

            Funcionario francisco = new Diretor("000.000.000-02");
            francisco.Nome = "Francisco";

            Funcionario clarice = new Auxiliar("000.000.000-03");
            clarice.Nome = "Clarice";

            Funcionario iracema = new GerenteDeConta("000.000.000-04");
            iracema.Nome = "Iracema";

            Desenvolvedor railton = new Desenvolvedor("000.000.000-05");
            railton.Nome = "Railton Rames";

            gerenciadorBonificacao.Registrar(railton);
            gerenciadorBonificacao.Registrar(iracema);
            gerenciadorBonificacao.Registrar(clarice);
            gerenciadorBonificacao.Registrar(francisco);
            gerenciadorBonificacao.Registrar(nicolas);

            Console.WriteLine("Total de bonificações do mês " +
                gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}