using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAula13Poo
{
    internal class Carro
    {
        private string marca;
        private string modelo;
        private int ano;
        private Motor m;

        public string Marca 
        { 
            get 
            { 
                return marca; 
            } 
            set 
            {  
                marca = value; 
            } 
        }
        
        public string Modelo
        {
            get
            {
                return modelo;
            }
            set
            {
                modelo = value;
            }
        }

        public int Ano
        {
            get
            {
                return ano;
            }
            set
            {
                ano = value;
            }
        }
    }
}
