using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Activation;
using System.Collections.ObjectModel;
using Microsoft.Practices.Unity;
using Infrastructure.Aspect.DataAccess;
using Delfin.ServiceContracts;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.ServiceProxy
{

   public partial class DelfinServices : IDelfinServices
   {
      #region [ Propiedades ]
      [Dependency]
      public IBLDet_Cotizacion BL_Det_Cotizacion { get; set; }
      #endregion

      #region [ Consultas ]
      public System.Data.DataTable GetDTDet_Cotizacion(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_Det_Cotizacion.GetDT(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<Det_Cotizacion> GetAllDet_CotizacionFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_Det_Cotizacion.GetAllFilter(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<Det_Cotizacion> GetAllDet_Cotizacion()
      {
         try
         {
            return BL_Det_Cotizacion.GetAll();
         }
         catch (Exception)
         { throw; }
      }
      public Det_Cotizacion GetOneDet_Cotizacion(Int32 CCOT_Codigo, Int32 DCOT_Item)
      {
         try
         {
            return BL_Det_Cotizacion.GetOne(CCOT_Codigo, DCOT_Item);
         }
         catch (Exception)
         { throw; }
      }

      #endregion

      #region [ Metodos ]
      public Boolean SaveDet_Cotizacion(ref Det_Cotizacion Item)
      {
         try
         {
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
            {
               return BL_Det_Cotizacion.Save(ref Item);
            }
            return true;
         }
         catch (Exception)
         { throw; }
      }
      #endregion
   }
}
