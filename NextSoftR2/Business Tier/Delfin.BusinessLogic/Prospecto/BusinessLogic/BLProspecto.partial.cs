using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Infrastructure.Aspect.BusinessLogic;
using Delfin.BusinessLogic;
using Delfin.Entities;
using System.Data;
using Microsoft.Practices.Unity;

namespace Delfin.BusinessLogic
{
	public partial class BLProspecto
   {
      #region [ Propiedades ]
      [Dependency]
      public IBLGestionVentas BL_GestionVentas { get; set; }
      #endregion  

      #region [ Consultas ]
      public ObservableCollection<Prospecto> GetAllValidos(DataTable Items, Int16 EMPR_Codigo, Int16 SUCR_Codigo, DateTime PROS_FecAsignacion)
      {
         try
         {
            return SelectAllValidos(Items, EMPR_Codigo, SUCR_Codigo, PROS_FecAsignacion);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<Prospecto> GetAllByEjecutivo(Int16 EMPR_Codigo, Int16 SUCR_Codigo, Int32 ENTC_CodEjecutivo, Nullable<Int32> ENTC_CodAgenteCarga, Nullable<DateTime> PROS_FecAsignacion, Nullable<DateTime> PROS_FecAsignacionInicio, Nullable<DateTime> PROS_FecAsignacionFinal)
      {
         try
         {
            return SelectAllByEjecutivo(EMPR_Codigo, SUCR_Codigo, ENTC_CodEjecutivo, ENTC_CodAgenteCarga, PROS_FecAsignacion, PROS_FecAsignacionInicio, PROS_FecAsignacionFinal);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<Prospecto> GetAllByEjecutivoGestionVentas(Int16 EMPR_Codigo, Int16 SUCR_Codigo, Int32 ENTC_CodEjecutivo, Nullable<Int32> ENTC_CodAgenteCarga, Nullable<DateTime> GEST_FechaProximaGestion)
      {
         try
         {
            ObservableCollection<Prospecto> Items = SelectAllByEjecutivoGestionVentas(EMPR_Codigo, SUCR_Codigo, ENTC_CodEjecutivo, ENTC_CodAgenteCarga, GEST_FechaProximaGestion);
            foreach (Prospecto item in Items)
            { item.ListGestionVentas = BL_GestionVentas.GetAllByProspecto(item.PROS_codigo); }
            return Items;
         }
         catch (Exception)
         { throw; }
      }
      #endregion
		
		#region [ Metodos ]
      public Boolean Asignar(DataTable Items, Int16 EMPR_Codigo, Int16 SUCR_Codigo, DateTime PROS_FecAsignacion, String AUDI_Usuario)
      {
         try
         {
            return InsertAsignacion(Items, EMPR_Codigo, SUCR_Codigo, PROS_FecAsignacion, AUDI_Usuario);
         }
         catch (Exception)
         { throw; }
      }
      public Boolean ReAsignar(DataTable Items, Int16 EMPR_Codigo, Int16 SUCR_Codigo, DateTime PROS_FecAsignacion, String AUDI_Usuario)
      {
         try
         {
            return UpdateAsignacion(Items, EMPR_Codigo, SUCR_Codigo, PROS_FecAsignacion, AUDI_Usuario);
         }
         catch (Exception)
         { throw; }
      }
		#endregion
	}
}
