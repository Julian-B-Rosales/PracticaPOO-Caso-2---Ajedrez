using LibAjedrez.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAjedrez.Models
{
    public class Peon : PiezaAjedrez
    {
        public override string Mover()
        {
            return "Se ha movido el peon";
        }
    }
}
