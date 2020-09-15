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
using Infrastructure.Aspect.BusinessEntity;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
   public partial class BLTiposCambio
   {
      #region [ Propiedades ]
      public IUnityContainer ContainerService { get; set; }
      public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<TiposCambio> Loader { get; set; }
      #endregion

      #region [ Constructores ]
		public BLTiposCambio(IUnityContainer container)
		{
			this.ContainerService = container;
			Loader = new BusinessEntityLoader<TiposCambio>();
         TiposCambio item = new TiposCambio();
			Loader.EntityType = item.GetType();
		}
		#endregion
      #region [ Consultas ]
      private ObservableCollection<TiposCambio> SelectAll(String x_TIPC_AnoMes)
      {
         try
         {
            ObservableCollection<TiposCambio> items = new ObservableCollection<TiposCambio>();
            TiposCambio item = new TiposCambio();
            DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_TIPCSS_All");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPC_AnoMes", x_TIPC_AnoMes, SqlDbType.Char, 6, ParameterDirection.Input);
            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               while (reader.Read())
               {
                  item = new TiposCambio();
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
      private TiposCambio SelectOne(String TIPC_Fecha)
      {
         try
         {
            TiposCambio item = new TiposCambio();
            DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_TIPCSS_UnReg");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPC_Fecha", TIPC_Fecha, SqlDbType.Char, 8, ParameterDirection.Input);
            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               if (reader.Read())
               {
                  Loader.LoadEntity(reader, item);
                  item.Instance = InstanceEntity.Unchanged;
               }
               else
               { return null; }
            }
            return item;
         }
         catch (Exception ex)
         { throw ex; }
      }

      private bool Insert(TiposCambio item)
      {
         try
         {
            if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
            {
               DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_TIPCSI_UnReg");
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPC_Fecha", item.TIPC_Fecha, SqlDbType.Char, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecTIPC_Compra", item.TIPC_Compra, SqlDbType.Decimal, 10, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecTIPC_Venta", item.TIPC_Venta, SqlDbType.Decimal, 10, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecTIPC_DolEuro", item.TIPC_DolEuro, SqlDbType.Decimal, 10, 6, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrAUDI_UsrCrea", item.AUDI_UsrCrea, SqlDbType.VarChar, 20, ParameterDirection.Input);
               if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
               {
                  return true;
               }
               else
               { return false; }
            }
            else
            { return true; }
         }
         catch (Exception ex)
         { throw ex; }
      }

      private bool Update(TiposCambio item)
      {
         try
         {
            if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
            {
               DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_TIPCSU_UnReg");
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPC_Fecha", item.TIPC_Fecha, SqlDbType.Char, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecTIPC_Compra", item.TIPC_Compra, SqlDbType.Decimal, 10, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecTIPC_Venta", item.TIPC_Venta, SqlDbType.Decimal, 10, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecTIPC_DolEuro", item.TIPC_DolEuro, SqlDbType.Decimal, 10, 6, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrAUDI_UsrMod", item.AUDI_UsrMod, SqlDbType.VarChar, 20, ParameterDirection.Input);

               if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
               { return true; }
               else
               { return false; }
            }
            else
            { return true; }
         }
         catch (Exception ex)
         { throw ex; }
      }

      #endregion
   }
}
