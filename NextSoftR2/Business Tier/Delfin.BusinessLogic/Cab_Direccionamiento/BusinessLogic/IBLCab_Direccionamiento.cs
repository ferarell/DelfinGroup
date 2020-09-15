using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Infrastructure.Aspect.DataAccess;
using Infrastructure.Aspect.BusinessLogic;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLCab_Direccionamiento
	{
		#region [ Consultas ]
      DataTable GetAll(DateTime CDIR_FecEmisionInicio, DateTime CDIR_FecEmisionFin, Nullable<DateTime> CDIR_FecArriboInicio, Nullable<DateTime> CDIR_FecArriboFin, String CDIR_HBL, String CDIR_MBL, Int32 ENTC_CodCliente, Int32 ENTC_CodLinea, Int32 ENTC_CodTemporal, Int16 NAVE_Codigo);
		Cab_Direccionamiento GetOne(Int32 CDIR_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save( ref Cab_Direccionamiento Item);
		Boolean Save( ObservableCollection<Cab_Direccionamiento> Items);
		#endregion
	}
}
