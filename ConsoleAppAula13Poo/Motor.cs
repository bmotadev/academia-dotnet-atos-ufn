using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAula13Poo
{
    internal class Motor
    {
        private int cilindradas; 
        private bool ligado; 
        public int Cilindradas 
        { 
            get 
            { 
                return cilindradas; 
            } 
            set 
            { 
                cilindradas = value; 
            } 
        }
        public bool Ligado 
        { 
            get 
            { 
                return ligado; 
            } 
            set 
            { 
                ligado = value; 
            } 
        }

        public void LigarMotor()
        {
            ligado = true;
        }

        public void DesligarMotor()
        {
            ligado = false;
        }
    }
}
