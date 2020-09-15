using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLServiciosRegimenVia
	{
		#region [ Consultas ]
        ObservableCollection<ServiciosRegimenVia> GetAllServiciosRegimenViaByServCodigo(Int32 SERV_Codigo);
		#endregion
		
		#region [ Metodos ]
        bool Insert(ref ServiciosRegimenVia Item);
        bool Update(ref ServiciosRegimenVia Item);
        bool Delete(ref ServiciosRegimenVia Item);
		#endregion
	}
}
