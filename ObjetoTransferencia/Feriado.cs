using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Feriado
    {

            public DateTime Date { get; set; }
            public string Name { get; set; }

        public  Feriado(DateTime data, string nome)
        {
            Date = data;
            Name = nome;
        }
    }
}
