using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaCafeVirtual
{
    public enum Moeda
    {
        [Description("1 Centavo")]
        UmCentavo = 1,
        [Description("5 Centavos")]
        CincoCentavos = 5,
        [Description("10 Centavos")]
        DezCentavos = 10,
        [Description("25 Centavos")]
        VinteCincoCentavos = 25,
        [Description("50 Centavos")]
        CinquentaCentavos = 50,
        [Description("1 real")]
        UmReal = 100
    }
}
