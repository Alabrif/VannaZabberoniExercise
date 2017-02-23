using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicazioneMesiWPF
{
    class Mese
    {
        public Enum Nome { get; set; }
        public int GiorniMese { get; set; }
        public string Stagione { get; set; }

        public Mese ()
        {

        }

        public Mese (Enum nome, int giorniMese, string stagione)
        {
            this.Nome = nome;
            this.GiorniMese = giorniMese;
            this.Stagione = stagione;
        }
    }
}
