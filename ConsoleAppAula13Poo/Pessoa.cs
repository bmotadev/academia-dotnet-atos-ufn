using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAula13Poo
{
    internal class Pessoa
    {
        /*Encapsulamento é um principio da orientação a objetos         * Permite proteger informações de um objeto        public -> vai ser publico, vai ser visivel a todos os componentes do propgrama        private -> é acessivel somente dentro da classe        protected -> é acessivel dentro da prórpia classe e nas suas subclasses (herança)        internal -> podem ser acessado dentro do mesmo assembly (um conjunto de aquivos de código fontes        que são compilados juntos)1 - Criar uma classe chamada Pessoa com 2 construtores, um que receba o nome e a idade da pessoa e outro recebendo apenas a idade. Solicite ao usuário qual dos construtores ele gostaria de utilizar na instanciação da classe. Além de receber parâmetros, os construtores imprimem na tela o conteúdo dos parâmetros recebidos         */
        public string nome;
        private int idade;
        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
            Console.WriteLine("Nome: " + nome + " Idade: " + idade);
        }
        public Pessoa(int idade)
        {
            this.idade = idade;
            Console.WriteLine("Idade: " + idade);
        }
    }
}