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
	public partial interface IBLDetDocsVta_Det_Operacion
	{
		#region [ Consultas ]
		ObservableCollection<DetDocsVta_Det_Operacion> GetAll();
		DetDocsVta_Det_Operacion GetOne(Int32 DDDO_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save( DetDocsVta_Det_Operacion Item);
		Boolean Save(ref ObservableCollection<DetDocsVta_Det_Operacion> Items);
		#endregion
	}
}
