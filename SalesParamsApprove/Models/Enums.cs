using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesParamsApprove.Models
{
    public enum StatusSale
    {
        // статусы хранятся в spr_tov , поле idAdvancement
        SuggestToSale = 10,
        NeedChangeParams = 15,
        ParamsChanged = 17,
        NeddChangeParamsOff = 19,
        InSales = 20,
        EndSale = 2,
    }
}
