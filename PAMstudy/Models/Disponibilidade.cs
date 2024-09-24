using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PAMstudy.Models
{
    public class Disponibilidade
    {
        public long IdDisponibilidade { get; set; }

        public string DiaSemana { get; set; }

        public DateTime  DtDas { get; set; }

        public DateTime DtAte { get; set; }
    }
}
