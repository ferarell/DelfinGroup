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
      public IBLDet_Cotizacion_OV_Novedad BL_Det_Cotizacion_OV_Novedad { get; set; }
      #endregion

      #region [ Consultas ]
      public System.Data.DataTable GetDTDet_Cotizacion_OV_Novedad(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_Det_Cotizacion_OV_Novedad.GetDT(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<Det_Cotizacion_OV_Novedad> GetAllDet_Cotizacion_OV_NovedadFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_Det_Cotizacion_OV_Novedad.GetAllFilter(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<Det_Cotizacion_OV_Novedad> GetAllDet_Cotizacion_OV_Novedad()
      {
         try
         {
            return BL_Det_Cotizacion_OV_Novedad.GetAll();
         }
         catch (Exception)
         { throw; }
      }
      public Det_Cotizacion_OV_Novedad GetOneDet_Cotizacion_OV_Novedad(Int32 OVNO_Codigo, Int32 CCOT_Numero, Int16 CCOT_Tipo)
      {
         try
         {
            return BL_Det_Cotizacion_OV_Novedad.GetOne(OVNO_Codigo, CCOT_Numero, CCOT_Tipo);
         }
         catch (Exception)
         { throw; }
      }

      #endregion

      #region [ Metodos ]
      public Boolean SaveDet_Cotizacion_OV_Novedad(ref Det_Cotizacion_OV_Novedad Item)
      {
         try
         {
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
            {
               return BL_Det_Cotizacion_OV_Novedad.Save(ref Item);
            }
            return true;
         }
         catch (Exception)
         { throw; }
      }
      #endregion
   }
}
