using System;
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
	public partial class BLEntidadCuentaBancaria
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<EntidadCuentaBancaria> Loader { get; set; }
		#endregion
		
		#region [ Constructores ]
		public BLEntidadCuentaBancaria(IUnityContainer container)
		{
			this.ContainerService = container;
			Loader = new BusinessEntityLoader<EntidadCuentaBancaria>();
			EntidadCuentaBancaria Item = new EntidadCuentaBancaria();
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
				{ DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_ENCBSS_TodosByFilters"); }
				if (x_filters != null && x_filters.Count > 0)
				{
					foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
					{ DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
				}
				_ds = DataAccessEnterpriseSQL.DAExecuteDataSet();
				if (_ds != null && _ds.Tables.Count == 1)
				{ _ds.Tables[0].TableName = "EntidadCuentaBancaria"; return _ds.Tables[0]; }
				else
				{ return null; }
			}
			catch (Exception)
			{ throw; }
		}
		private ObservableCollection<EntidadCuentaBancaria> SelectAllByFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
		{
			try
			{
				ObservableCollection<EntidadCuentaBancaria> items = new ObservableCollection<EntidadCuentaBancaria>();
				EntidadCuentaBancaria item = new EntidadCuentaBancaria();
				if (!String.IsNullOrEmpty(x_procedure))
				{ DataAccessEnterpriseSQL.DAAsignarProcedure(x_procedure); }
				else
				{ DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_ENCBSS_TodosByFilters"); }
				if (x_filters != null && x_filters.Count > 0)
				{
					foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
					{ DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
				}
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new EntidadCuentaBancaria();
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
		private ObservableCollection<EntidadCuentaBancaria> SelectAll()
		{
			try
			{
				ObservableCollection<EntidadCuentaBancaria> items = new ObservableCollection<EntidadCuentaBancaria>();
				EntidadCuentaBancaria item = new EntidadCuentaBancaria();
				DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_ENCBSS_Todos");
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new EntidadCuentaBancaria();
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
		private EntidadCuentaBancaria SelectOne(Int32 ENTC_Codigo, String TIPO_TabBCO, String TIPO_CodBCO)
		{
			try
			{
				EntidadCuentaBancaria item = new EntidadCuentaBancaria();
				DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_ENCBSS_UnReg");
				DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", ENTC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
				DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabBCO", TIPO_TabBCO, SqlDbType.Char, 3, ParameterDirection.Input);
				DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodBCO", TIPO_CodBCO, SqlDbType.Char, 3, ParameterDirection.Input);
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
		private bool Insert(ref EntidadCuentaBancaria Item)
		{
			try
			{
				if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_ENCBSI_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", Item.ENTC_Codigo, SqlDbType.Int, 4, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabBCO", Item.TIPO_TabBCO, SqlDbType.Char, 3, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodBCO", Item.TIPO_CodBCO, SqlDbType.Char, 3, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrENCB_TipoCuenta", Item.ENCB_TipoCuenta, SqlDbType.Char, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENCB_NroCuentaSol", Item.ENCB_NroCuentaSol, SqlDbType.VarChar, 50, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENCB_NroCuentaDol", Item.ENCB_NroCuentaDol, SqlDbType.VarChar, 50, ParameterDirection.Input);
					
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrCrea", Item.AUDI_UsrCrea, SqlDbType.VarChar, 20, ParameterDirection.Input);
					
					if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
					{
						Int32 _ENTC_Codigo;
						if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintENTC_Codigo"].Value.ToString(), out _ENTC_Codigo))
						{ Item.ENTC_Codigo = _ENTC_Codigo; }
						if (DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pchrTIPO_TabBCO"].Value != DBNull.Value && String.IsNullOrEmpty(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pchrTIPO_TabBCO"].Value.ToString()))
						{ Item.TIPO_TabBCO = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pchrTIPO_TabBCO"].Value.ToString(); }
						if (DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pchrTIPO_CodBCO"].Value != DBNull.Value && String.IsNullOrEmpty(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pchrTIPO_CodBCO"].Value.ToString()))
						{ Item.TIPO_CodBCO = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pchrTIPO_CodBCO"].Value.ToString(); }
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
		private bool Update(ref EntidadCuentaBancaria Item)
		{
			try
			{
				if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_ENCBSU_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", Item.ENTC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabBCO", Item.TIPO_TabBCO, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodBCO", Item.TIPO_CodBCO, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrENCB_TipoCuenta", Item.ENCB_TipoCuenta, SqlDbType.Char, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENCB_NroCuentaSol", Item.ENCB_NroCuentaSol, SqlDbType.VarChar, 50, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENCB_NroCuentaDol", Item.ENCB_NroCuentaDol, SqlDbType.VarChar, 50, ParameterDirection.Input);
					
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
		private bool Delete(ref EntidadCuentaBancaria Item)
		{
			try
			{
				if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_ENCBSD_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", Item.ENTC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabBCO", Item.TIPO_TabBCO, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodBCO", Item.TIPO_CodBCO, SqlDbType.Char, 3, ParameterDirection.Input);
					
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
		#endregion
	}
}
