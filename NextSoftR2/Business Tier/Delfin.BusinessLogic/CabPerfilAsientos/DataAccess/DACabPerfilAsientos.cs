using System;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Practices.Unity;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Infrastructure.Aspect.DataAccess;
using Infrastructure.Aspect.BusinessEntity;

using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial class BLCabPerfilAsientos
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<CabPerfilAsientos> Loader { get; set; }
		#endregion
		
		#region [ Constructores ]
		public BLCabPerfilAsientos(IUnityContainer container)
		{
			this.ContainerService = container;
			Loader = new BusinessEntityLoader<CabPerfilAsientos>();
			CabPerfilAsientos Item = new CabPerfilAsientos();
			Loader.EntityType = Item.GetType();
		}
		#endregion

		#region [ Consultas ]
		private System.Data.DataTable SelectAllByFilterDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
		{
			try
			{
				DataSet _ds = new DataSet();
				if (!String.IsNullOrEmpty(x_procedure))
				{ DataAccessEnterpriseSQL.DAAsignarProcedure(x_procedure); }
				else
				{ DataAccessEnterpriseSQL.DAAsignarProcedure("CON_CABPSS_TodosByFilters"); }
				if (x_filters != null && x_filters.Count > 0)
				{
					foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
					{ DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
				}
				_ds = DataAccessEnterpriseSQL.DAExecuteDataSet();
				if (_ds != null && _ds.Tables.Count == 1)
				{ _ds.Tables[0].TableName = "CabPerfilAsientos"; return _ds.Tables[0]; }
				else
				{ return null; }
			}
			catch (Exception)
			{ throw; }
		}
		private ObservableCollection<CabPerfilAsientos> SelectAllByFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
		{
			try
			{
				ObservableCollection<CabPerfilAsientos> items = new ObservableCollection<CabPerfilAsientos>();
				CabPerfilAsientos item = new CabPerfilAsientos();
				if (!String.IsNullOrEmpty(x_procedure))
				{ DataAccessEnterpriseSQL.DAAsignarProcedure(x_procedure); }
				else
				{ DataAccessEnterpriseSQL.DAAsignarProcedure("CON_CABPSS_TodosByFilters"); }
				if (x_filters != null && x_filters.Count > 0)
				{
					foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
					{ DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
				}
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new CabPerfilAsientos();
						Loader.LoadEntity(reader, item);
						item.Instance = InstanceEntity.Unchanged;
						items.Add(item);
					}
				}
				return items;
			}
			catch (Exception)
			{ throw; }
		}
		private ObservableCollection<CabPerfilAsientos> SelectAll()
		{
			try
			{
				ObservableCollection<CabPerfilAsientos> items = new ObservableCollection<CabPerfilAsientos>();
				CabPerfilAsientos item = new CabPerfilAsientos();
				DataAccessEnterpriseSQL.DAAsignarProcedure("CON_CABPSS_Todos");
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new CabPerfilAsientos();
						Loader.LoadEntity(reader, item);
						item.Instance = InstanceEntity.Unchanged;
						items.Add(item);
					}
				}
				return items;
			}
			catch (Exception)
			{ throw; }
		}
		private CabPerfilAsientos SelectOne(String CABP_Ano, String CABP_Codigo)
		{
			try
			{
				CabPerfilAsientos item = new CabPerfilAsientos();
				DataAccessEnterpriseSQL.DAAsignarProcedure("CON_CABPSS_UnReg");
				DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCABP_Ano", CABP_Ano, SqlDbType.Char, 4, ParameterDirection.Input);
				DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCABP_Codigo", CABP_Codigo, SqlDbType.VarChar, 3, ParameterDirection.Input);
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
			catch (Exception)
			{ throw; }
		}
		#endregion

		#region [ Metodos ]
		private bool Insert(ref CabPerfilAsientos Item)
		{
			try
			{
				if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("CON_CABPSI_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCABP_Ano", Item.CABP_Ano, SqlDbType.Char, 4, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCABP_Codigo", Item.CABP_Codigo, SqlDbType.VarChar, 3, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCABP_Desc", Item.CABP_Desc, SqlDbType.VarChar, 100, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodREG", Item.TIPO_CodREG, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabREG", Item.TIPO_TabREG, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCABP_ValorRef", Item.CABP_ValorRef, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrCrea", Item.AUDI_UsrCrea, SqlDbType.VarChar, 20, ParameterDirection.Input);
					
					if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
					{
						if (DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pchrCABP_Ano"].Value != DBNull.Value && !String.IsNullOrEmpty(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pchrCABP_Ano"].Value.ToString()))
						{ Item.CABP_Ano = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pchrCABP_Ano"].Value.ToString(); }
						if (DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchCABP_Codigo"].Value != DBNull.Value && !String.IsNullOrEmpty(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchCABP_Codigo"].Value.ToString()))
						{ Item.CABP_Codigo = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchCABP_Codigo"].Value.ToString(); }
						return true;
					}
					else
					{ return false; }
				}
				else
				{ return true; }
			}
			catch (Exception)
			{ throw; }
		}
		private bool Update(ref CabPerfilAsientos Item)
		{
			try
			{
				if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("CON_CABPSU_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCABP_Ano", Item.CABP_Ano, SqlDbType.Char, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCABP_Codigo", Item.CABP_Codigo, SqlDbType.VarChar, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCABP_Desc", Item.CABP_Desc, SqlDbType.VarChar, 100, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodREG", Item.TIPO_CodREG, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabREG", Item.TIPO_TabREG, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCABP_ValorRef", Item.CABP_ValorRef, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrMod", Item.AUDI_UsrMod, SqlDbType.VarChar, 20, ParameterDirection.Input);
					
					if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
					{ return true; }
					else
					{ return false; }
				}
				else
				{ return true; }
			}
			catch (Exception)
			{ throw; }
		}
		private bool Delete(ref CabPerfilAsientos Item)
		{
			try
			{
				if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("CON_CABPSD_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCABP_Ano", Item.CABP_Ano, SqlDbType.Char, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCABP_Codigo", Item.CABP_Codigo, SqlDbType.VarChar, 3, ParameterDirection.Input);
					
					if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
					{ return true; }
					else
					{ return false; }
				}
				else
				{ return true; }
			}
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    throw new Exception
                       (String.Format("# No se puede Eliminar este Registro por tener relaciones activas. #" + ex.Message, ex));
                }
                else
                {
                    throw;
                }
            }
			catch (Exception)
			{ throw; }
		}
		#endregion
	}
}
