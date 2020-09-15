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
	public partial interface IBLPreDetDocsVta_Det_Operacion
	{
		#region [ Consultas ]
		ObservableCollection<PreDetDocsVta_Det_Operacion> GetAll();
		PreDetDocsVta_Det_Operacion GetOne(Int32 PDDO_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save( PreDetDocsVta_Det_Operacion Item);
		Boolean Save(ref ObservableCollection<PreDetDocsVta_Det_Operacion> Items);
		#endregion
	}
}
