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
      public IBLDet_Cotizacion_OV_Archivo BL_Det_Cotizacion_OV_Archivo { get; set; }
      #endregion

      #region [ Consultas ]
      public System.Data.DataTable GetDTDet_Cotizacion_OV_Archivo(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_Det_Cotizacion_OV_Archivo.GetDT(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<Det_Cotizacion_OV_Archivo> GetAllDet_Cotizacion_OV_ArchivoFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_Det_Cotizacion_OV_Archivo.GetAllFilter(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<Det_Cotizacion_OV_Archivo> GetAllDet_Cotizacion_OV_Archivo()
      {
         try
         {
            return BL_Det_Cotizacion_OV_Archivo.GetAll();
         }
         catch (Exception)
         { throw; }
      }
      public Det_Cotizacion_OV_Archivo GetOneDet_Cotizacion_OV_Archivo(Int32 OVAR_Codigo, Int32 CCOT_Numero, Int16 CCOT_Tipo)
      {
         try
         {
            return BL_Det_Cotizacion_OV_Archivo.GetOne(OVAR_Codigo, CCOT_Numero, CCOT_Tipo);
         }
         catch (Exception)
         { throw; }
      }

      #endregion

      #region [ Metodos ]
      public Boolean SaveDet_Cotizacion_OV_Archivo(ref Det_Cotizacion_OV_Archivo Item)
      {
         try
         {
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
            {
               return BL_Det_Cotizacion_OV_Archivo.Save(ref Item);
            }
            return true;
         }
         catch (Exception)
         { throw; }
      }
      #endregion
   }
}
