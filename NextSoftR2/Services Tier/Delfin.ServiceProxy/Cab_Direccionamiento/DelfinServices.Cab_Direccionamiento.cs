using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ServiceModel.Activation;
using System.Collections.ObjectModel;
using Microsoft.Practices.Unity;
using Infrastructure.Aspect.DataAccess;

namespace Delfin.ServiceProxy
{
   using Delfin.ServiceContracts;
   using Delfin.BusinessLogic;
   using Delfin.Entities;

   public partial class DelfinServicesProxy : IDelfinServices
   {
      #region [ Cab_Direccionamiento ]
      [Dependency]
      public IBLCab_Direccionamiento BL_Cab_Direccionamiento { get; set; }

      public Boolean SaveCab_Direccionamiento(ref Cab_Direccionamiento Item)
      {
         try
         {
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
            {
               return BL_Cab_Direccionamiento.Save(ref Item);
            }
            return true;
         }
         catch (Exception ex)
         { throw ex; }
      }

      public Cab_Direccionamiento GetOneCab_Direccionamiento(Int32 CDIR_Codigo)
      {
         try
         {
            return BL_Cab_Direccionamiento.GetOne(CDIR_Codigo);
         }
         catch (Exception ex)
         { throw ex; }
      }

      public DataTable GetAllCab_Direccionamiento(DateTime CDIR_FecEmisionInicio, DateTime CDIR_FecEmisionFin, Nullable<DateTime> CDIR_FecArriboInicio, Nullable<DateTime> CDIR_FecArriboFin,
                                                         String CDIR_HBL, String CDIR_MBL, Int32 ENTC_CodCliente, Int32 ENTC_CodLinea, Int32 ENTC_CodTemporal, Int16 NAVE_Codigo)
      {
         try
         {
            return BL_Cab_Direccionamiento.GetAll(CDIR_FecEmisionInicio, CDIR_FecEmisionFin, CDIR_FecArriboInicio, CDIR_FecArriboFin, CDIR_HBL, CDIR_MBL, ENTC_CodCliente, ENTC_CodLinea, ENTC_CodTemporal, NAVE_Codigo);
         }
         catch (Exception ex)
         { throw ex; }
      }
      #endregion
   }
}
