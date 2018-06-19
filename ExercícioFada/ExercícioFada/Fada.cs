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
        public string elemento;
        public bool tamanhoDaAsa;
        public bool barulho;
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
                if (value.Count() > 50)
                {
                    throw new Exception("Nome deve ter menos de 50 caracteres");
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
                familia = value;
            }
        }

        public string Cor
        {
            get { return cor; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("O campo cor deve ser preenchido");
                }
                cor = value;
            }
        }

        public string CorDaAsa
        {
            get { return corDaAsa; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("O campo cor da asa deve ser preenchido");
                }
                corDaAsa = value;
            }
        }

        public string Elemento
        {
            get { return elemento; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Campo elemento deve ser preenchido");
                }
                elemento = value;
            }
        }

        public bool Mulher
        {
            get { return mulher; }
            set
            {
                mulher = value;
            }
        }
     

        public Fada(string Nome, string Familia, string Cor)
        {
            Nome = nome;
            Familia = familia;
            Cor = cor;
        }

        public Fada(string Nome, string Cor, bool Mulher )
        {
            Nome = nome;
            Cor = cor;
            Mulher = mulher;
        }

        public Fada()
        {
            // TODO: Complete member initialization
        }

        


        
    }
}
