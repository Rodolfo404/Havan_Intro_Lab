using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Usuario_Ex1
{
    class ModuloUsuario
    {
        UsuarioRepository repository = new UsuarioRepository();
        public void Create()
        {
            string resposta = "";

            do
            {
                Console.WriteLine("Digite seu nome");
                string nome = Validacao.ValidaStringEmBranco();
                Console.WriteLine("Digite seu sobrenome");
                string sobrenome = Validacao.ValidaStringEmBranco();
                Console.WriteLine("Digite sua idade");
                int idade = Validacao.ValidaInteiros();
                Console.WriteLine("Digite seu e-mail");
                string email = Validacao.ValidaStringEmBranco();
                Console.WriteLine("digite seu endereço");
                string endereco = Validacao.ValidaStringEmBranco();

                Usuario model = new Usuario(nome, sobrenome, idade, email, endereco);
                repository.Create(model);
                Console.WriteLine("Deseja cadastrar mais 1?(y/n)");
                resposta = Console.ReadLine();
            } while (resposta == "y");
        }
    }
}
