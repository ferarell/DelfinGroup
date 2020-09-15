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
      
      ObservableCollection<DetNaveViaje> GetAllDetNaveViajeAyuda(String CONS_TabRGM, String CONS_CodRGM, String CONS_TabVIA, String CONS_CodVIA, Int32 PUER_CodOrigen, Int32 PUER_CodDestino, DateTime CCOT_Fecha, String NVIA_NroViaje);
      
      DetNaveViaje GetOneDetNaveViajeByOV(String CONS_TabRGM, String CONS_CodRGM, String CONS_TabVIA, String CONS_CodVIA, Int32 PUER_CodOrigen, Int32 PUER_CodDestino, Int32 NVIA_Codigo);
   }
}
