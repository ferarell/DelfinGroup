using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLServiciosLineaNegocio
	{
		#region [ Consultas ]
        ObservableCollection<ServiciosLineaNegocio> GetAllServiciosLineaNegocioByServCodigo(Int32 SERV_Codigo);
		#endregion
		
		#region [ Metodos ]
        bool Insert(ref ServiciosLineaNegocio Item);
        bool Update(ref ServiciosLineaNegocio Item);
        bool Delete(ref ServiciosLineaNegocio Item);
		#endregion
	}
}
