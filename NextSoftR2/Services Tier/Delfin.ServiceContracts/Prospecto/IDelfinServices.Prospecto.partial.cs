using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;
using Delfin.Entities;
using Delfin.BusinessLogic;
using System.Data;

namespace Delfin.ServiceContracts
{
   public partial interface IDelfinServices
   {
      
      ObservableCollection<Prospecto> GetAllProspectosValidos(DataTable Items, Int16 EMPR_Codigo, Int16 SUCR_Codigo, DateTime PROS_FecAsignacion);

      
      ObservableCollection<Prospecto> GetAllProspectosByEjecutivo(Int16 EMPR_Codigo, Int16 SUCR_Codigo, Int32 ENTC_CodEjecutivo, Nullable<Int32> ENTC_CodAgenteCarga, Nullable<DateTime> PROS_FecAsignacion, Nullable<DateTime> PROS_FecAsignacionInicio, Nullable<DateTime> PROS_FecAsignacionFinal);

      
      ObservableCollection<Prospecto> GetAllProspectosByEjecutivoGestionVentas(Int16 EMPR_Codigo, Int16 SUCR_Codigo, Int32 ENTC_CodEjecutivo, Nullable<Int32> ENTC_CodAgenteCarga, Nullable<DateTime> GEST_FechaProximaGestion);

      
      Boolean AsignarProspectos(DataTable Items, Int16 EMPR_Codigo, Int16 SUCR_Codigo, DateTime PROS_FecAsignacion, String AUDI_Usuario);

      
      Boolean ReAsignarProspectos(DataTable Items, Int16 EMPR_Codigo, Int16 SUCR_Codigo, DateTime PROS_FecAsignacion, String AUDI_Usuario);

   }
}
