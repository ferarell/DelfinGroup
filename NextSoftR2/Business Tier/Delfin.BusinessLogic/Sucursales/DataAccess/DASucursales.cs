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
	public partial class BLSucursales
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<Sucursales> Loader { get; set; }
		#endregion
		
		#region [ Constructores ]
		public BLSucursales(IUnityContainer container)
		{
			this.ContainerService = container;
			Loader = new BusinessEntityLoader<Sucursales>();
			Sucursales item = new Sucursales();
			Loader.EntityType = item.GetType();
		}
		#endregion

		#region [ Consultas ]
		private ObservableCollection<Sucursales> SelectAll()
		{
			try
			{
				ObservableCollection<Sucursales> items = new ObservableCollection<Sucursales>();
				Sucursales item = new Sucursales();
				DataAccessEnterpriseSQL.DAAsignarProcedure("T_SP_CONSULTAR_Sucursales");
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Sucursales();
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
		private Sucursales SelectOne(Int16 SUCR_Codigo)
		{
			try
			{
				Sucursales item = new Sucursales();
				DataAccessEnterpriseSQL.DAAsignarProcedure("T_SP_CONSULTAR_Sucursales");
				DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
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
		private bool Insert(ref Sucursales item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("T_SP_INSERTAR_Sucursales");
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", item.SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSUCR_Desc", item.SUCR_Desc, SqlDbType.VarChar, 100, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSUCR_DescC", item.SUCR_DescC, SqlDbType.VarChar, 20, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSUCR_RUC", item.SUCR_RUC, SqlDbType.VarChar, 25, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSUCR_Direc", item.SUCR_Direc, SqlDbType.VarChar, 250, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", item.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrCrea", item.AUDI_UsrCrea, SqlDbType.VarChar, 20, ParameterDirection.Input);
					
					if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
					{
						Int16 _SUCR_Codigo;
						if (Int16.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@psinSUCR_Codigo"].Value.ToString(), out _SUCR_Codigo))
						{ item.SUCR_Codigo = _SUCR_Codigo; }
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
		private bool Update(ref Sucursales item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("T_SP_ACTUALIZAR_Sucursales");
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", item.SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSUCR_Desc", item.SUCR_Desc, SqlDbType.VarChar, 100, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSUCR_DescC", item.SUCR_DescC, SqlDbType.VarChar, 20, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSUCR_RUC", item.SUCR_RUC, SqlDbType.VarChar, 25, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSUCR_Direc", item.SUCR_Direc, SqlDbType.VarChar, 250, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", item.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrMod", item.AUDI_UsrMod, SqlDbType.VarChar, 20, ParameterDirection.Input);
					
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
		private bool Delete(ref Sucursales item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("T_SP_ELIMINAR_Sucursales");
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", item.SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					
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
