using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial class BLGRR
	{
		#region [ Consultas ]
      public ObservableCollection<Contrato> GetAllContratoByTransportista(Int32 ENTC_CodTransportista, DateTime REBA_FecIni, DateTime REBA_FecFin)
      {
         try
         {
            return SelectAllContratoByTransportista(ENTC_CodTransportista, REBA_FecIni, REBA_FecFin);
         }
         catch (Exception)
         { throw; }
      }
		#endregion
		
		#region [ Metodos ]
		
		#endregion
	}
}
