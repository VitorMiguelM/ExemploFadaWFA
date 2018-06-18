using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioFada
{
    public class Fada
    {
        public string nome;
        public string familia;
        public string cor;
        public string corDaAsa;
        public double tamanhoDaAsa;
        public bool barulho;
        public string elemento;
        public bool mulher; 

        public string Nome
        {
            get { return nome; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("O campo nome deve ser preenchido");
                }
                if (value.Count() < 3)
                {
                    throw new Exception("Nome deve conter ao menos 3 caracteres");
                }
                nome = value;
            }
        }

        public string Familia
        {
            get { return familia; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("O campo família deve ser preenchido");
                }
                if (value.Count() < 3)
                {
                    throw new Exception("Família deve conter ao menos 3 caracteres");
                }
                familia = value;
            }
        }
        
    }
}
