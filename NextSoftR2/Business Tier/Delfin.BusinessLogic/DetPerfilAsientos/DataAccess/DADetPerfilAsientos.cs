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
	public partial class BLDetPerfilAsientos
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<DetPerfilAsientos> Loader { get; set; }
		#endregion
		
		#region [ Constructores ]
		public BLDetPerfilAsientos(IUnityContainer container)
		{
			this.ContainerService = container;
			Loader = new BusinessEntityLoader<DetPerfilAsientos>();
			DetPerfilAsientos Item = new DetPerfilAsientos();
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
				{ DataAccessEnterpriseSQL.DAAsignarProcedure("CON_DETPSS_TodosByFilters"); }
				if (x_filters != null && x_filters.Count > 0)
				{
					foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
					{ DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
				}
				_ds = DataAccessEnterpriseSQL.DAExecuteDataSet();
				if (_ds != null && _ds.Tables.Count == 1)
				{ _ds.Tables[0].TableName = "DetPerfilAsientos"; return _ds.Tables[0]; }
				else
				{ return null; }
			}
			catch (Exception)
			{ throw; }
		}
		private ObservableCollection<DetPerfilAsientos> SelectAllByFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
		{
			try
			{
				ObservableCollection<DetPerfilAsientos> items = new ObservableCollection<DetPerfilAsientos>();
				DetPerfilAsientos item = new DetPerfilAsientos();
				if (!String.IsNullOrEmpty(x_procedure))
				{ DataAccessEnterpriseSQL.DAAsignarProcedure(x_procedure); }
				else
				{ DataAccessEnterpriseSQL.DAAsignarProcedure("CON_DETPSS_TodosByFilters"); }
				if (x_filters != null && x_filters.Count > 0)
				{
					foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
					{ DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
				}
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new DetPerfilAsientos();
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
		private ObservableCollection<DetPerfilAsientos> SelectAll()
		{
			try
			{
				ObservableCollection<DetPerfilAsientos> items = new ObservableCollection<DetPerfilAsientos>();
				DetPerfilAsientos item = new DetPerfilAsientos();
				DataAccessEnterpriseSQL.DAAsignarProcedure("CON_DETPSS_Todos");
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new DetPerfilAsientos();
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
		private DetPerfilAsientos SelectOne(String CABP_Ano, String CABP_Codigo, Int16 DETP_Item)
		{
			try
			{
				DetPerfilAsientos item = new DetPerfilAsientos();
				DataAccessEnterpriseSQL.DAAsignarProcedure("CON_DETPSS_UnReg");
				DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCABP_Ano", CABP_Ano, SqlDbType.Char, 4, ParameterDirection.Input);
				DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCABP_Codigo", CABP_Codigo, SqlDbType.VarChar, 3, ParameterDirection.Input);
				DataAccessEnterpriseSQL.DAAgregarParametro("@psinDETP_Item", DETP_Item, SqlDbType.SmallInt, 2, ParameterDirection.Input);
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
		private bool Insert(ref DetPerfilAsientos Item)
		{
			try
			{
				if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("CON_DETPSI_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCABP_Ano", Item.CABP_Ano, SqlDbType.Char, 4, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCABP_Codigo", Item.CABP_Codigo, SqlDbType.VarChar, 3, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinDETP_Item", Item.DETP_Item, SqlDbType.SmallInt, 2, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCUEN_Codigo", Item.CUEN_Codigo, SqlDbType.Char, 17, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDETP_Glosa", Item.DETP_Glosa, SqlDbType.VarChar, 100, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCENT_Codigo", Item.CENT_Codigo, SqlDbType.VarChar, 17, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDETP_DebePorc", Item.DETP_DebePorc, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDETP_HaberPorc", Item.DETP_HaberPorc, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrPART_Codigo", Item.PART_Codigo, SqlDbType.Char, 17, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintPPER_Numero", Item.PPER_Numero, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIGA_codigo", Item.TIGA_codigo, SqlDbType.Char, 17, ParameterDirection.Input);
					
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrCrea", Item.AUDI_UsrCrea, SqlDbType.VarChar, 20, ParameterDirection.Input);
					
					if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
					{
						if (DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pchrCABP_Ano"].Value != DBNull.Value && String.IsNullOrEmpty(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pchrCABP_Ano"].Value.ToString()))
						{ Item.CABP_Ano = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pchrCABP_Ano"].Value.ToString(); }
						if (DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchCABP_Codigo"].Value != DBNull.Value && String.IsNullOrEmpty(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchCABP_Codigo"].Value.ToString()))
						{ Item.CABP_Codigo = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchCABP_Codigo"].Value.ToString(); }
						Int16 _DETP_Item;
						if (Int16.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@psinDETP_Item"].Value.ToString(), out _DETP_Item))
						{ Item.DETP_Item = _DETP_Item; }
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
		private bool Update(ref DetPerfilAsientos Item)
		{
			try
			{
				if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("CON_DETPSU_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCABP_Ano", Item.CABP_Ano, SqlDbType.Char, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCABP_Codigo", Item.CABP_Codigo, SqlDbType.VarChar, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinDETP_Item", Item.DETP_Item, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCUEN_Codigo", Item.CUEN_Codigo, SqlDbType.Char, 17, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDETP_Glosa", Item.DETP_Glosa, SqlDbType.VarChar, 100, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCENT_Codigo", Item.CENT_Codigo, SqlDbType.VarChar, 17, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDETP_DebePorc", Item.DETP_DebePorc, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDETP_HaberPorc", Item.DETP_HaberPorc, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrPART_Codigo", Item.PART_Codigo, SqlDbType.Char, 17, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintPPER_Numero", Item.PPER_Numero, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIGA_codigo", Item.TIGA_codigo, SqlDbType.Char, 17, ParameterDirection.Input);
					
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
		private bool Delete(ref DetPerfilAsientos Item)
		{
			try
			{
				if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("CON_DETPSD_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCABP_Ano", Item.CABP_Ano, SqlDbType.Char, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCABP_Codigo", Item.CABP_Codigo, SqlDbType.VarChar, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinDETP_Item", Item.DETP_Item, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					
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
