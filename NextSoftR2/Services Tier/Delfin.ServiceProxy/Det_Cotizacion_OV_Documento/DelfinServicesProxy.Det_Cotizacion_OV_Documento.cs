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
      public IBLDet_Cotizacion_OV_Documento BL_Det_Cotizacion_OV_Documento { get; set; }
      #endregion

      #region [ Consultas ]
      public System.Data.DataTable GetDTDet_Cotizacion_OV_Documento(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_Det_Cotizacion_OV_Documento.GetDT(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<Det_Cotizacion_OV_Documento> GetAllDet_Cotizacion_OV_DocumentoFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_Det_Cotizacion_OV_Documento.GetAllFilter(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<Det_Cotizacion_OV_Documento> GetAllDet_Cotizacion_OV_Documento()
      {
         try
         {
            return BL_Det_Cotizacion_OV_Documento.GetAll();
         }
         catch (Exception)
         { throw; }
      }
      public Det_Cotizacion_OV_Documento GetOneDet_Cotizacion_OV_Documento(Int32 CCOT_Numero, Int32 DOOV_Codigo, Int16 CCOT_Tipo)
      {
         try
         {
            return BL_Det_Cotizacion_OV_Documento.GetOne(CCOT_Numero, DOOV_Codigo, CCOT_Tipo);
         }
         catch (Exception)
         { throw; }
      }

      #endregion

      #region [ Metodos ]
      public Boolean SaveDet_Cotizacion_OV_Documento(ref Det_Cotizacion_OV_Documento Item)
      {
         try
         {
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
            {
               return BL_Det_Cotizacion_OV_Documento.Save(ref Item);
            }
            return true;
         }
         catch (Exception)
         { throw; }
      }
      #endregion
   }
}
