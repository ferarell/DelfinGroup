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
      Boolean GetComisionValidar(Int32 COMI_Codigo, DateTime COMI_FecIni, DateTime COMI_FecFin);
		#endregion

		#region [ Metodos ]
      Boolean SaveComisionesOV(ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters); //(Int32 NVIA_Codigo, String Usuario);
		#endregion
   }
}
