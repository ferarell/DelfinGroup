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
	public partial class BLDetNaveViaje
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<DetNaveViaje> Loader { get; set; }
		#endregion
		
		#region [ Constructores ]
		public BLDetNaveViaje(IUnityContainer container)
		{
			this.ContainerService = container;
			Loader = new BusinessEntityLoader<DetNaveViaje>();
			DetNaveViaje item = new DetNaveViaje();
			Loader.EntityType = item.GetType();
		}
		#endregion

		#region [ Consultas ]
		private ObservableCollection<DetNaveViaje> SelectAll()
		{
			try
			{
				ObservableCollection<DetNaveViaje> items = new ObservableCollection<DetNaveViaje>();
				DetNaveViaje item = new DetNaveViaje();
				DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_DetNaveViaje");
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
		private DetNaveViaje SelectOne(Int32 DVIA_Codigo, Int32 NVIA_Codigo)
		{
			try
			{
				DetNaveViaje item = new DetNaveViaje();
				DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_DetNaveViaje");
				DataAccessEnterpriseSQL.DAAgregarParametro("@pintDVIA_Codigo", DVIA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
				DataAccessEnterpriseSQL.DAAgregarParametro("@pintNVIA_Codigo", NVIA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					if (reader.Read())
					{
						Loader.LoadEntity(reader, item);
						item.Instance = InstanceEntity.Unchanged;
					}
					else
					{ throw new Exception("No se encontro el registro."); }
				}
				return item;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ Metodos ]
		private bool Insert(ref DetNaveViaje item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_INSERTAR_DetNaveViaje");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintDVIA_Codigo", item.DVIA_Codigo, SqlDbType.Int, 4, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintNVIA_Codigo", item.NVIA_Codigo, SqlDbType.Int, 4, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintPUER_Codigo", item.PUER_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmDVIA_FecETA_EXPO_ETDMaster_IMPO", item.DVIA_FecETA_EXPO_ETDMaster_IMPO, SqlDbType.DateTime, 8, ParameterDirection.Input);
					
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrCrea", item.AUDI_UsrCrea, SqlDbType.VarChar, 20, ParameterDirection.Input);
					
					if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
					{
						Int32 _DVIA_Codigo;
						if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintDVIA_Codigo"].Value.ToString(), out _DVIA_Codigo))
						{ item.DVIA_Codigo = _DVIA_Codigo; }
						Int32 _NVIA_Codigo;
						if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintNVIA_Codigo"].Value.ToString(), out _NVIA_Codigo))
						{ item.NVIA_Codigo = _NVIA_Codigo; }
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
		private bool Update(ref DetNaveViaje item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_ACTUALIZAR_DetNaveViaje");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintDVIA_Codigo", item.DVIA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintNVIA_Codigo", item.NVIA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintPUER_Codigo", item.PUER_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmDVIA_FecETA_EXPO_ETDMaster_IMPO", item.DVIA_FecETA_EXPO_ETDMaster_IMPO, SqlDbType.DateTime, 8, ParameterDirection.Input);
					
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmAUDI_UsrMod", item.AUDI_UsrMod, SqlDbType.VarChar, 20, ParameterDirection.Input);
					
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
		private bool Delete(ref DetNaveViaje item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_ELIMINAR_DetNaveViaje");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintDVIA_Codigo", item.DVIA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintNVIA_Codigo", item.NVIA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					
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
