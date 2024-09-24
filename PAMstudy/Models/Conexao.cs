using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PAMstudy.Models
{
    public class Conexao
    {
        public long Id { get; set; }

        public DateTime DataCriacao { get; set; }

        public Monitor IdMonitor { get; set; }
    }

}
