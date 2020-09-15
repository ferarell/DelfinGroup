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
	public partial interface IBLPuerto
	{
		#region [ Consultas ]
		ObservableCollection<Puerto> GetAll();
      Puerto GetOne(Int32 PUER_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Puerto Item);
		Boolean Save(ref ObservableCollection<Puerto> Items);
		#endregion
	}
}
