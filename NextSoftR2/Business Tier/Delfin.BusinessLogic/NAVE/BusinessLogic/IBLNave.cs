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
	public partial interface IBLNave
	{
		#region [ Consultas ]
        ObservableCollection<Nave> GetAll(string x_ENTC_CodTransportista);
		Nave GetOne(Int16 NAVE_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Nave Item);
		Boolean Save(ref ObservableCollection<Nave> Items);
		#endregion
	}
}
