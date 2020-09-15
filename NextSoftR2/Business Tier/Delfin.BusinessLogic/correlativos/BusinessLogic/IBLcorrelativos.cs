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
	public partial interface IBLcorrelativos
	{
		#region [ Consultas ]
		ObservableCollection<correlativos> GetAll();
		correlativos GetOne(String CORR_ServerName, String CORR_CodCorr);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref correlativos Item);
		Boolean Save(ref ObservableCollection<correlativos> Items);
		#endregion
	}
}
