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
      public IBLDet_Cotizacion_OV_EventosTareas BL_Det_Cotizacion_OV_EventosTareas { get; set; }
      #endregion

      #region [ Consultas ]
      public System.Data.DataTable GetDTDet_Cotizacion_OV_EventosTareas(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_Det_Cotizacion_OV_EventosTareas.GetDT(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<Det_Cotizacion_OV_EventosTareas> GetAllDet_Cotizacion_OV_EventosTareasFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_Det_Cotizacion_OV_EventosTareas.GetAllFilter(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<Det_Cotizacion_OV_EventosTareas> GetAllDet_Cotizacion_OV_EventosTareas()
      {
         try
         {
            return BL_Det_Cotizacion_OV_EventosTareas.GetAll();
         }
         catch (Exception)
         { throw; }
      }
      public Det_Cotizacion_OV_EventosTareas GetOneDet_Cotizacion_OV_EventosTareas(Int32 CCOT_Numero, Int16 CCOT_Tipo, Int16 EVEN_Item)
      {
         try
         {
            return BL_Det_Cotizacion_OV_EventosTareas.GetOne(CCOT_Numero, CCOT_Tipo, EVEN_Item);
         }
         catch (Exception)
         { throw; }
      }

      #endregion

      #region [ Metodos ]
      public Boolean SaveDet_Cotizacion_OV_EventosTareas(ref Det_Cotizacion_OV_EventosTareas Item)
      {
         try
         {
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
            {
               return BL_Det_Cotizacion_OV_EventosTareas.Save(ref Item);
            }
            return true;
         }
         catch (Exception)
         { throw; }
      }
      #endregion
   }
}
