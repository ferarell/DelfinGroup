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
	public partial interface IBLDet_Seguimientos
	{
		#region [ Consultas ]
		ObservableCollection<Det_Seguimientos> GetAll();
		Det_Seguimientos GetOne(Int32 CSEG_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save( Det_Seguimientos Item);
		Boolean Save(ref ObservableCollection<Det_Seguimientos> Items);
		#endregion
	}
}
