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
using Infrastructure.Aspect.Collections;
using Delfin.Entities;
using Infrastructure.Aspect.BusinessEntity;

namespace Delfin.BusinessLogic
{
	public partial class BLProspecto
	{
		#region [ Consultas ]
      private ObservableCollection<Prospecto> SelectAllValidos(DataTable Items, Int16 EMPR_Codigo, Int16 SUCR_Codigo, DateTime PROS_FecAsignacion)
      {
         try
         {
            ObservableCollection<Prospecto> items = new ObservableCollection<Prospecto>();
            Prospecto item = new Prospecto();
            DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_Prospecto_ValidarImportacion");
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmPROS_FecAsignacion", PROS_FecAsignacion, SqlDbType.DateTime, 8, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@ptvpPROS_Importacion", Items, SqlDbType.Structured);
            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               while (reader.Read())
               {
                  item = new Prospecto();
                  Loader.LoadEntity(reader, item);
                  item.Instance = InstanceEntity.Added;
                  items.Add(item);
               }
            }
            return items;
         }
         catch (Exception ex)
         { throw ex; }
      }
      private ObservableCollection<Prospecto> SelectAllByEjecutivo(Int16 EMPR_Codigo, Int16 SUCR_Codigo, Int32 ENTC_CodEjecutivo, Nullable<Int32> ENTC_CodAgenteCarga, Nullable<DateTime> PROS_FecAsignacion, Nullable<DateTime> PROS_FecAsignacionInicio, Nullable<DateTime> PROS_FecAsignacionFinal)
      {
         try
         {
            ObservableCollection<Prospecto> items = new ObservableCollection<Prospecto>();
            Prospecto item = new Prospecto();
            DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_Prospecto");
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodEjecutivo", ENTC_CodEjecutivo, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodAgenteCarga", ENTC_CodAgenteCarga, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmPROS_FecAsignacion", PROS_FecAsignacion, SqlDbType.DateTime, 8, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmPROS_FecAsignacionInicio", PROS_FecAsignacionInicio, SqlDbType.DateTime, 8, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmPROS_FecAsignacionFinal", PROS_FecAsignacionFinal, SqlDbType.DateTime, 8, ParameterDirection.Input);
            
            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               while (reader.Read())
               {
                  item = new Prospecto();
                  Loader.LoadEntity(reader, item);
                  item.Instance = InstanceEntity.Added;
                  items.Add(item);
               }
            }
            return items;
         }
         catch (Exception ex)
         { throw ex; }
      }
      private ObservableCollection<Prospecto> SelectAllByEjecutivoGestionVentas(Int16 EMPR_Codigo, Int16 SUCR_Codigo, Int32 ENTC_CodEjecutivo, Nullable<Int32> ENTC_CodAgenteCarga, Nullable<DateTime> GEST_FechaProximaGestion)
      {
         try
         {
            BusinessEntityLoader<Entidad> LoaderContacto = new BusinessEntityLoader<Entidad>();
            Entidad contacto = new Entidad();
            LoaderContacto.EntityType = contacto.GetType();

            ObservableCollection<Prospecto> items = new ObservableCollection<Prospecto>();
            Prospecto item = new Prospecto();
            DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_Prospecto_GestionVentas");
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodEjecutivo", ENTC_CodEjecutivo, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodAgenteCarga", ENTC_CodAgenteCarga, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmGEST_FechaProximaGestion", GEST_FechaProximaGestion, SqlDbType.DateTime, 8, ParameterDirection.Input);

            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               while (reader.Read())
               {
                  item = new Prospecto();
                  
                  Loader.LoadEntity(reader, item);

                  if (item.ENTC_CodContacto.HasValue)
                  {
                     item.ItemContacto = new Entidad();
                     LoaderContacto.LoadEntity(reader, item.ItemContacto);
                  }
                  
                  item.Instance = InstanceEntity.Added;
                  items.Add(item);
               }
            }
            return items;
         }
         catch (Exception ex)
         { throw ex; }
      }
      #endregion

		#region [ Metodos ]
      private Boolean InsertAsignacion(DataTable Items, Int16 EMPR_Codigo, Int16 SUCR_Codigo, DateTime PROS_FecAsignacion, String AUDI_Usuario)
      {
         try
         {
            DataAccessEnterpriseSQL.DABeginTransaction();

            ObservableCollection<Prospecto> items = new ObservableCollection<Prospecto>();
            Prospecto item = new Prospecto();
            DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_INSERTAR_Prospecto_Asignar");
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmPROS_FecAsignacion", PROS_FecAsignacion, SqlDbType.DateTime, 8, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_Usuario", AUDI_Usuario, SqlDbType.VarChar, 20, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@ptvpPROS_Importacion", Items, SqlDbType.Structured);

            if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
            { DataAccessEnterpriseSQL.DACommitTransaction(); return true; }
            else
            { DataAccessEnterpriseSQL.DARollbackTransaction(); return false; }
         }
         catch (Exception)
         { DataAccessEnterpriseSQL.DARollbackTransaction();  throw; }
      }
      private Boolean UpdateAsignacion(DataTable Items, Int16 EMPR_Codigo, Int16 SUCR_Codigo, DateTime PROS_FecAsignacion, String AUDI_Usuario)
      {
         try
         {
            DataAccessEnterpriseSQL.DABeginTransaction();

            ObservableCollection<Prospecto> items = new ObservableCollection<Prospecto>();
            Prospecto item = new Prospecto();
            DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_ACTUALIZAR_Prospecto_ReAsignar");
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmPROS_FecAsignacion", PROS_FecAsignacion, SqlDbType.DateTime, 8, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_Usuario", AUDI_Usuario, SqlDbType.VarChar, 20, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@ptvpPROS_Importacion", Items, SqlDbType.Structured);

            if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
            { DataAccessEnterpriseSQL.DACommitTransaction(); return true; }
            else
            { DataAccessEnterpriseSQL.DARollbackTransaction(); return false; }
         }
         catch (Exception)
         { DataAccessEnterpriseSQL.DARollbackTransaction(); throw; }
      }
		#endregion
	}
}
