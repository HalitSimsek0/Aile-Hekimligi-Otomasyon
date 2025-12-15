using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTO
{
    public class MisafirDto
    {
        public int MisafirId { get; set; }
        public string Tc { get; set; }

        public int HekimId { get; set; }  
        public string Hekim { get; set; }
    }
}
