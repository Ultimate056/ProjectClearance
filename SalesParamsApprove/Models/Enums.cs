using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesParamsApprove.Models
{
    public enum StatusSale
    {
        SuggestToSale = 10,
        NeedChangeParams = 15,
        ParamsChanged = 17,
        InSales = 20,
        EndSale = 21,
    }
}
