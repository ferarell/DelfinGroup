using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Practices.Unity;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Infrastructure.Aspect.DataAccess;
using Delfin.Entities;
using Infrastructure.Aspect.BusinessEntity;

namespace Delfin.BusinessLogic
{
	public partial class BLGestionVentas
	{
		#region [ Consultas ]
      private ObservableCollection<GestionVentas> SelectAllByProspecto(Int32 PROS_Codigo)
      {
         try
         {
            ObservableCollection<GestionVentas> items = new ObservableCollection<GestionVentas>();
            GestionVentas item = new GestionVentas();
            DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_GestionVentas");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintPROS_Codigo", PROS_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               while (reader.Read())
               {
                  item = new GestionVentas();
                  Loader.LoadEntity(reader, item);
                  item.Instance = InstanceEntity.Unchanged;
                  items.Add(item);
               }
            }
            return items;
         }
         catch (Exception ex)
         { throw ex; }
      }
      private DataTable SelectKPIContactados(Int16 EMPR_Codigo, Int16 SUCR_Codigo, DateTime GEST_FechaDesde, DateTime GEST_FechaHasta, Boolean PorEjecutivo, Nullable<Int32> ENTC_CodEjecutivo)
      {
         try
         {
            ObservableCollection<GestionVentas> items = new ObservableCollection<GestionVentas>();
            GestionVentas item = new GestionVentas();
            if (!PorEjecutivo)
            { DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_KPIContactados"); }
            else
            { DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_KPIContactados_PorEjecutivo"); }
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmGEST_FechaDesde", GEST_FechaDesde, SqlDbType.DateTime, 8, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmGEST_FechaHasta", GEST_FechaHasta, SqlDbType.DateTime, 8, ParameterDirection.Input);
            if (PorEjecutivo && ENTC_CodEjecutivo.HasValue) { DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodEjecutivo", ENTC_CodEjecutivo.Value, SqlDbType.Int, 4, ParameterDirection.Input); }
            System.Data.DataSet ds = DataAccessEnterpriseSQL.DAExecuteDataSet();
            if (ds != null && ds.Tables.Count > 0)
            { return ds.Tables[0]; }
            else
            { return null; }
            
         }
         catch (Exception ex)
         { throw ex; }
      }
      private DataTable SelectKPIReuniones(Int16 EMPR_Codigo, Int16 SUCR_Codigo, DateTime GEST_FechaDesde, DateTime GEST_FechaHasta, Boolean PorEjecutivo, Nullable<Int32> ENTC_CodEjecutivo)
      {
         try
         {
            ObservableCollection<GestionVentas> items = new ObservableCollection<GestionVentas>();
            GestionVentas item = new GestionVentas();
            if (!PorEjecutivo)
            { DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_KPIReuniones"); }
            else
            { DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_KPIReuniones_PorEjecutivo"); }
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmGEST_FechaDesde", GEST_FechaDesde, SqlDbType.DateTime, 8, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmGEST_FechaHasta", GEST_FechaHasta, SqlDbType.DateTime, 8, ParameterDirection.Input);
            if (PorEjecutivo && ENTC_CodEjecutivo.HasValue) { DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodEjecutivo", ENTC_CodEjecutivo.Value, SqlDbType.Int, 4, ParameterDirection.Input); }
            System.Data.DataSet ds = DataAccessEnterpriseSQL.DAExecuteDataSet();
            if (ds != null && ds.Tables.Count > 0)
            { return ds.Tables[0]; }
            else
            { return null; }

         }
         catch (Exception ex)
         { throw ex; }
      }
      #endregion

		#region [ Metodos ]

		#endregion
	}
}
