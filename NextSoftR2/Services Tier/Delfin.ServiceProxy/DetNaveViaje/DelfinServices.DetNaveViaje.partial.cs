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
      public ObservableCollection<DetNaveViaje> GetAllDetNaveViajeAyuda(String CONS_TabRGM, String CONS_CodRGM, String CONS_TabVIA, String CONS_CodVIA, Int32 PUER_CodOrigen, Int32 PUER_CodDestino, DateTime CCOT_Fecha, String NVIA_NroViaje)
      {
         try
         {
            return BL_DetNaveViaje.GetAllAyuda(CONS_TabRGM, CONS_CodRGM, CONS_TabVIA, CONS_CodVIA, PUER_CodOrigen, PUER_CodDestino, CCOT_Fecha, NVIA_NroViaje);
         }
         catch (Exception)
         { throw; }
      }
      public DetNaveViaje GetOneDetNaveViajeByOV(String CONS_TabRGM, String CONS_CodRGM, String CONS_TabVIA, String CONS_CodVIA, Int32 PUER_CodOrigen, Int32 PUER_CodDestino, Int32 NVIA_Codigo)
      {
         try
         {
            return BL_DetNaveViaje.GetOneByOV(CONS_TabRGM, CONS_CodRGM, CONS_TabVIA, CONS_CodVIA, PUER_CodOrigen, PUER_CodDestino, NVIA_Codigo);
         }
         catch (Exception)
         { throw; }
      }
   }
}
