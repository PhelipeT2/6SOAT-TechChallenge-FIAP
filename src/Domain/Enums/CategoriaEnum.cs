using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enums
{
    public enum CategoriaEnum
    {
        [Description("Lanche")]
        Lanche = 1,

        [Description("Acompanhamento")]
        Acompanhamento = 2,

        [Description("Bebida")]
        Bebida = 3,

        [Description("Sobremesa")]
        Sobremesa = 4
    }
}
