using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;
using Delfin.Entities;
using Delfin.BusinessLogic;

namespace Delfin.ServiceContracts
{
   public partial interface IDelfinServices
   {
		#region [ Consultas ]
      ObservableCollection<Contrato> GetAllContratoByTransportista(Int32 ENTC_CodTransportista, DateTime REBA_FecIni, DateTime REBA_FecFin);
		#endregion

		#region [ Metodos ]
		#endregion
   }
}
