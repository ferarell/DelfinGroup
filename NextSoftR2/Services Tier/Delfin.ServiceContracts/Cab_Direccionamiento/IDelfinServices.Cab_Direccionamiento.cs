using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Data;
using System.ServiceModel;
using System.Runtime.Serialization;
using Delfin.Entities;
using Delfin.BusinessLogic;

namespace Delfin.ServiceContracts
{
   public partial interface IDelfinServices
   {
      #region [ Cab_Direccionamiento ] 
      
      Boolean SaveCab_Direccionamiento(ref Cab_Direccionamiento Item);

      
      Cab_Direccionamiento GetOneCab_Direccionamiento(Int32 CDIR_Codigo);


      DataTable GetAllCab_Direccionamiento(DateTime CDIR_FecEmisionInicio, DateTime CDIR_FecEmisionFin, Nullable<DateTime> CDIR_FecArriboInicio, Nullable<DateTime> CDIR_FecArriboFin, String CDIR_HBL, String CDIR_MBL, Int32 ENTC_CodCliente, Int32 ENTC_CodLinea, Int32 ENTC_CodTemporal, Int16 NAVE_Codigo);
      #endregion
   }
}
