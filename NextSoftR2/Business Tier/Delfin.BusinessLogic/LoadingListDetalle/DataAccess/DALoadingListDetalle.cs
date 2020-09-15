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
	public partial class BLLoadingListDetalle
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<LoadingListDetalle> Loader { get; set; }
		#endregion
		
		#region [ Constructores ]
		public BLLoadingListDetalle(IUnityContainer container)
		{
			this.ContainerService = container;
			Loader = new BusinessEntityLoader<LoadingListDetalle>();
			LoadingListDetalle Item = new LoadingListDetalle();
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
				{ DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_LODESS_TodosByFilters"); }
				if (x_filters != null && x_filters.Count > 0)
				{
					foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
					{ DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
				}
				_ds = DataAccessEnterpriseSQL.DAExecuteDataSet();
				if (_ds != null && _ds.Tables.Count == 1)
				{ _ds.Tables[0].TableName = "LoadingListDetalle"; return _ds.Tables[0]; }
				else
				{ return null; }
			}
			catch (Exception)
			{ throw; }
		}
		private ObservableCollection<LoadingListDetalle> SelectAllByFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
		{
			try
			{
				ObservableCollection<LoadingListDetalle> items = new ObservableCollection<LoadingListDetalle>();
				LoadingListDetalle item = new LoadingListDetalle();
				if (!String.IsNullOrEmpty(x_procedure))
				{ DataAccessEnterpriseSQL.DAAsignarProcedure(x_procedure); }
				else
				{ DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_LODESS_TodosByFilters"); }
				if (x_filters != null && x_filters.Count > 0)
				{
					foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
					{ DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
				}
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new LoadingListDetalle();
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
		private ObservableCollection<LoadingListDetalle> SelectAll()
		{
			try
			{
				ObservableCollection<LoadingListDetalle> items = new ObservableCollection<LoadingListDetalle>();
				LoadingListDetalle item = new LoadingListDetalle();
				DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_LODESS_Todos");
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new LoadingListDetalle();
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
		private LoadingListDetalle SelectOne(Int32 LOAD_Codigo, Int16 LODE_Item)
		{
			try
			{
				LoadingListDetalle item = new LoadingListDetalle();
				DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_LODESS_UnReg");
				DataAccessEnterpriseSQL.DAAgregarParametro("@pintLOAD_Codigo", LOAD_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
				DataAccessEnterpriseSQL.DAAgregarParametro("@psinLODE_Item", LODE_Item, SqlDbType.SmallInt, 2, ParameterDirection.Input);
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
		private bool Insert(ref LoadingListDetalle Item)
		{
			try
			{
				if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_LODESI_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintLOAD_Codigo", Item.LOAD_Codigo, SqlDbType.Int, 4, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinLODE_Item", Item.LODE_Item, SqlDbType.SmallInt, 2, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrLODE_CargaTipo", Item.LODE_CargaTipo, SqlDbType.Char, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCNTR_Numero", Item.CNTR_Numero, SqlDbType.VarChar, 20, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecLODE_PesoBruto", Item.LODE_PesoBruto, SqlDbType.Decimal, 14, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecLODE_Volumen", Item.LODE_Volumen, SqlDbType.Decimal, 14, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecLODE_CantBultos", Item.LODE_CantBultos, SqlDbType.Decimal, 14, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchLODE_Precinto", Item.LODE_Precinto, SqlDbType.VarChar, 50, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchLODE_DescCarga", Item.LODE_DescCarga, SqlDbType.VarChar, 1024, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchLODE_MarcasNumeros", Item.LODE_MarcasNumeros, SqlDbType.VarChar, 1024, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchLODE_TipoTamanio", Item.LODE_TipoTamanio, SqlDbType.VarChar, 100, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitLODE_CargaPeligrosa", Item.LODE_CargaPeligrosa, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabIMO", Item.TIPO_TabIMO, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodIMO", Item.TIPO_CodIMO, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrLODE_TipoCNT", Item.LODE_TipoCNT, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinLODE_TamanioCNT", Item.LODE_TamanioCNT, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintDHBL_Item", Item.DHBL_Item, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Tipo", Item.CCOT_Tipo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", Item.CCOT_Numero, SqlDbType.Int, 4, ParameterDirection.Input);
					
					
					if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
					{
						Int32 _LOAD_Codigo;
						if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintLOAD_Codigo"].Value.ToString(), out _LOAD_Codigo))
						{ Item.LOAD_Codigo = _LOAD_Codigo; }
						Int16 _LODE_Item;
						if (Int16.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@psinLODE_Item"].Value.ToString(), out _LODE_Item))
						{ Item.LODE_Item = _LODE_Item; }
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
		private bool Update(ref LoadingListDetalle Item)
		{
			try
			{
				if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_LODESU_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintLOAD_Codigo", Item.LOAD_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinLODE_Item", Item.LODE_Item, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrLODE_CargaTipo", Item.LODE_CargaTipo, SqlDbType.Char, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCNTR_Numero", Item.CNTR_Numero, SqlDbType.VarChar, 20, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecLODE_PesoBruto", Item.LODE_PesoBruto, SqlDbType.Decimal, 14, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecLODE_Volumen", Item.LODE_Volumen, SqlDbType.Decimal, 14, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecLODE_CantBultos", Item.LODE_CantBultos, SqlDbType.Decimal, 14, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchLODE_Precinto", Item.LODE_Precinto, SqlDbType.VarChar, 50, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchLODE_DescCarga", Item.LODE_DescCarga, SqlDbType.VarChar, 1024, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchLODE_MarcasNumeros", Item.LODE_MarcasNumeros, SqlDbType.VarChar, 1024, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchLODE_TipoTamanio", Item.LODE_TipoTamanio, SqlDbType.VarChar, 100, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitLODE_CargaPeligrosa", Item.LODE_CargaPeligrosa, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabIMO", Item.TIPO_TabIMO, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodIMO", Item.TIPO_CodIMO, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrLODE_TipoCNT", Item.LODE_TipoCNT, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinLODE_TamanioCNT", Item.LODE_TamanioCNT, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintDHBL_Item", Item.DHBL_Item, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Tipo", Item.CCOT_Tipo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", Item.CCOT_Numero, SqlDbType.Int, 4, ParameterDirection.Input);
					
					
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
		private bool Delete(ref LoadingListDetalle Item)
		{
			try
			{
				if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_LODESD_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintLOAD_Codigo", Item.LOAD_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinLODE_Item", Item.LODE_Item, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					
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
