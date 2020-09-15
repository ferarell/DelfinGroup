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
	public partial class BLDetNaveViaje
	{
      #region [ Consultas ]
      private ObservableCollection<DetNaveViaje> SelectAllByNaveViaje(Int32 NVIA_Codigo)
      {
         try
         {
            ObservableCollection<DetNaveViaje> items = new ObservableCollection<DetNaveViaje>();
            DetNaveViaje item = new DetNaveViaje();
            DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_DetNaveViaje");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintNVIA_Codigo", NVIA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               while (reader.Read())
               {
                  item = new DetNaveViaje();
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
      private ObservableCollection<DetNaveViaje> SelectAllAyuda(String CONS_TabRGM, String CONS_CodRGM, String CONS_TabVIA, String CONS_CodVIA, Int32 PUER_CodOrigen, Int32 PUER_CodDestino, DateTime CCOT_Fecha, String NVIA_NroViaje)
      {
         try
         {
            ObservableCollection<DetNaveViaje> items = new ObservableCollection<DetNaveViaje>();
            DetNaveViaje item = new DetNaveViaje();
            DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_DetNaveViaje_AyudaOV");

            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabRGM", CONS_TabRGM, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodRGM", CONS_CodRGM, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabVIA", CONS_TabVIA, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodVIA", CONS_CodVIA, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintPUER_CodOrigen", PUER_CodOrigen, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintPUER_CodDestino", PUER_CodDestino, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCOT_Fecha", CCOT_Fecha, SqlDbType.DateTime, 8, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchNVIA_NroViaje", NVIA_NroViaje, SqlDbType.VarChar, 50, ParameterDirection.Input);

            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               while (reader.Read())
               {
                  item = new DetNaveViaje();
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
      private DetNaveViaje SelectOneByOV(String CONS_TabRGM, String CONS_CodRGM, String CONS_TabVIA, String CONS_CodVIA, Int32 PUER_CodOrigen, Int32 PUER_CodDestino, Int32 NVIA_Codigo)
      {
         try
         {
            DetNaveViaje item = new DetNaveViaje();
            DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_DetNaveViaje_SelectByOV");

            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabRGM", CONS_TabRGM, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodRGM", CONS_CodRGM, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabVIA", CONS_TabVIA, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodVIA", CONS_CodVIA, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintPUER_CodOrigen", PUER_CodOrigen, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintPUER_CodDestino", PUER_CodDestino, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintNVIA_Codigo", NVIA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);

            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               if (reader.Read())
               {
                  Loader.LoadEntity(reader, item);
                  item.Instance = InstanceEntity.Unchanged;
               }
               else
               { item = null; }
            }
            return item;
         }
         catch (Exception ex)
         { throw ex; }
      }
      #endregion

		#region [ Metodos ]

		#endregion
	}
}
