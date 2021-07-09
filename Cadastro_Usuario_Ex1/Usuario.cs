using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Cadastro_Usuario_Ex1
{
    class Usuario
    {
        public string nome = String.Empty;
        public string sobrenome = String.Empty;
        public int idade = 0;
        public string email = String.Empty;
        public string endereco = String.Empty;
        public void Cadastro()
        {
            Console.WriteLine("Digite seu nome");          
            this.nome = Validacao.ValidaStringEmBranco();
            Console.WriteLine("Digite seu sobrenome");
            this.sobrenome = Validacao.ValidaStringEmBranco();
            Console.WriteLine("Digite sua idade");
            this.idade = Validacao.ValidaInteiros();
            Console.WriteLine("Digite seu e-mail");
            this.email = Validacao.ValidaStringEmBranco();
            Console.WriteLine("digite seu endereço");
            this.endereco = Validacao.ValidaStringEmBranco();
            Console.WriteLine($"Seus dados são:\n nome: {this.nome.ToLower()}\n sobrenome: {this.sobrenome.ToLower()}\n idade: {this.idade}\n email: {this.email.ToLower()}\n endereço: {this.endereco.ToLower()}\n");
            Console.WriteLine("aperte qualquer tecla para sair");
            Console.ReadLine();
        }

        

     }
    
}
