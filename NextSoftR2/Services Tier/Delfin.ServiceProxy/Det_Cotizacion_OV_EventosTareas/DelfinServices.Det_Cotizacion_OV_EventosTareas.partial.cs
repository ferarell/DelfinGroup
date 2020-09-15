using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
      public ObservableCollection<Det_Cotizacion_OV_EventosTareas> GetAllDet_Cotizacion_OV_EventosTareasByCotizacion_OV(Int32 CCOT_Numero, Int16 CCOT_Tipo)
      {
         try
         {
            return BL_Det_Cotizacion_OV_EventosTareas.GetAllByCotizacion_OV(CCOT_Numero, CCOT_Tipo);
         }
         catch (Exception)
         { throw; }
      }
   }
}
