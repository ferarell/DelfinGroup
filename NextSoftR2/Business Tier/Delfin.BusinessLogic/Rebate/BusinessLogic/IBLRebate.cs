using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Infrastructure.Aspect.BusinessLogic;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLRebate
	{
		#region [ Consultas ]
        ObservableCollection<Rebate> GetAll(string x_CONC_TabReb, string x_CONC_CodReb, string x_ENTC_CodTransportista, DateTime x_REBA_FecIni);
		Rebate GetOne(Int32 REBA_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Rebate Item);
		Boolean Save(ref ObservableCollection<Rebate> Items);
		#endregion
	}
}
