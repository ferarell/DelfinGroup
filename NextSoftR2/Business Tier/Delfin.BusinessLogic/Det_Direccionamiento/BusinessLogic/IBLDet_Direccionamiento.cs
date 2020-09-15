using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Infrastructure.Aspect.BusinessLogic;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLDet_Direccionamiento
	{
		#region [ Consultas ]
		ObservableCollection<Det_Direccionamiento> GetAll();
		DataTable GetOne(Int32 DDIR_Item, Int32 CDIR_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save( Det_Direccionamiento Item);
		Boolean Save( ObservableCollection<Det_Direccionamiento> Items);
		#endregion
	}
}
