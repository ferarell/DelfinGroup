using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLGRR
	{
		#region [ Consultas ]
      ObservableCollection<Contrato> GetAllContratoByTransportista(Int32 ENTC_CodTransportista, DateTime REBA_FecIni, DateTime REBA_FecFin);
		#endregion
		
		#region [ Metodos ]
		
		#endregion
	}
}
