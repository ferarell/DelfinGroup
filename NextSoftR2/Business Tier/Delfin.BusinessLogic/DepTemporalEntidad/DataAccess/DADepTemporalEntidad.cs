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
	public partial class BLDepTemporalEntidad
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<DepTemporalEntidad> Loader { get; set; }
		#endregion
		
		#region [ Constructores ]
		public BLDepTemporalEntidad(IUnityContainer container)
		{
			this.ContainerService = container;
			Loader = new BusinessEntityLoader<DepTemporalEntidad>();
			DepTemporalEntidad item = new DepTemporalEntidad();
			Loader.EntityType = item.GetType();
		}
		#endregion

		#region [ Consultas ]
        private ObservableCollection<DepTemporalEntidad> SelectAll(Int32? x_ENTC_Codigo)
		{
			try
			{
				ObservableCollection<DepTemporalEntidad> items = new ObservableCollection<DepTemporalEntidad>();
				DepTemporalEntidad item = new DepTemporalEntidad();
                DataAccessEnterpriseSQL.DAAsignarProcedure("DETESS_TodosDepTemporal");
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", x_ENTC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new DepTemporalEntidad();
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
		private DepTemporalEntidad SelectOne(Int32 DETE_Codigo)
		{
			try
			{
				DepTemporalEntidad item = new DepTemporalEntidad();
				DataAccessEnterpriseSQL.DAAsignarProcedure("DETESS_UnReg");
				DataAccessEnterpriseSQL.DAAgregarParametro("@pintDETE_Codigo", DETE_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
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
		private bool Insert(ref DepTemporalEntidad item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("DETESI_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintDETE_Codigo", item.DETE_Codigo, SqlDbType.Int, 4, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodLNaviera", item.ENTC_CodLNaviera, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodDepTemporal", item.ENTC_CodDepTemporal, SqlDbType.Int, 4, ParameterDirection.Input);
					
					
					if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
					{
						Int32 _DETE_Codigo;
						if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintDETE_Codigo"].Value.ToString(), out _DETE_Codigo))
						{ item.DETE_Codigo = _DETE_Codigo; }
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
		private bool Update(ref DepTemporalEntidad item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("DETESU_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintDETE_Codigo", item.DETE_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodLNaviera", item.ENTC_CodLNaviera, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodDepTemporal", item.ENTC_CodDepTemporal, SqlDbType.Int, 4, ParameterDirection.Input);
					
					
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
		private bool Delete(ref DepTemporalEntidad item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("DETESD_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintDETE_Codigo", item.DETE_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					
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
