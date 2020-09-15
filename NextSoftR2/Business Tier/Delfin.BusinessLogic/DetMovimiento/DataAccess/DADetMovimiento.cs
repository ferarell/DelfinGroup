﻿using System;
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
	public partial class BLDetMovimiento
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<DetMovimiento> Loader { get; set; }
		#endregion
		
		#region [ Constructores ]
		public BLDetMovimiento(IUnityContainer container)
		{
			this.ContainerService = container;
			Loader = new BusinessEntityLoader<DetMovimiento>();
			DetMovimiento Item = new DetMovimiento();
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
				{ DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_DMOVSS_TodosByFilters"); }
				if (x_filters != null && x_filters.Count > 0)
				{
					foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
					{ DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
				}
				_ds = DataAccessEnterpriseSQL.DAExecuteDataSet();
				if (_ds != null && _ds.Tables.Count == 1)
				{ _ds.Tables[0].TableName = "DetMovimiento"; return _ds.Tables[0]; }
				else
				{ return null; }
			}
			catch (Exception)
			{ throw; }
		}
		private ObservableCollection<DetMovimiento> SelectAllByFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
		{
			try
			{
				ObservableCollection<DetMovimiento> items = new ObservableCollection<DetMovimiento>();
				DetMovimiento item = new DetMovimiento();
				if (!String.IsNullOrEmpty(x_procedure))
				{ DataAccessEnterpriseSQL.DAAsignarProcedure(x_procedure); }
				else
				{ DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_DMOVSS_TodosByFilters"); }
				if (x_filters != null && x_filters.Count > 0)
				{
					foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
					{ DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
				}
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new DetMovimiento();
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
		private ObservableCollection<DetMovimiento> SelectAll()
		{
			try
			{
				ObservableCollection<DetMovimiento> items = new ObservableCollection<DetMovimiento>();
				DetMovimiento item = new DetMovimiento();
				DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_DMOVSS_Todos");
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new DetMovimiento();
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
		private DetMovimiento SelectOne(Int16 EMPR_Codigo, Int32 MOVI_Codigo, Int16 DMOV_Item)
		{
			try
			{
				DetMovimiento item = new DetMovimiento();
				DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_DMOVSS_UnReg");
				DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
				DataAccessEnterpriseSQL.DAAgregarParametro("@pintMOVI_Codigo", MOVI_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
				DataAccessEnterpriseSQL.DAAgregarParametro("@psinDMOV_Item", DMOV_Item, SqlDbType.SmallInt, 2, ParameterDirection.Input);
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
		private bool Insert(ref DetMovimiento Item)
		{
			try
			{
				if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_DMOVSI_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", Item.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintMOVI_Codigo", Item.MOVI_Codigo, SqlDbType.Int, 4, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinDMOV_Item", Item.DMOV_Item, SqlDbType.SmallInt, 2, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabTGB", Item.TIPO_TabTGB, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodTGB", Item.TIPO_CodTGB, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDMOV_MontoDebe", Item.DMOV_MontoDebe, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDMOV_MontoHaber", Item.DMOV_MontoHaber, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDMOV_NroOperacion", Item.DMOV_NroOperacion, SqlDbType.VarChar, 20, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrDMOV_Flujo", Item.DMOV_Flujo, SqlDbType.Char, 18, ParameterDirection.Input);
					
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrCrea", Item.AUDI_UsrCrea, SqlDbType.VarChar, 20, ParameterDirection.Input);
					
					if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
					{
						Int16 _EMPR_Codigo;
						if (Int16.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@psinEMPR_Codigo"].Value.ToString(), out _EMPR_Codigo))
						{ Item.EMPR_Codigo = _EMPR_Codigo; }
						Int32 _MOVI_Codigo;
						if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintMOVI_Codigo"].Value.ToString(), out _MOVI_Codigo))
						{ Item.MOVI_Codigo = _MOVI_Codigo; }
						Int16 _DMOV_Item;
						if (Int16.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@psinDMOV_Item"].Value.ToString(), out _DMOV_Item))
						{ Item.DMOV_Item = _DMOV_Item; }
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
		private bool Update(ref DetMovimiento Item)
		{
			try
			{
				if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_DMOVSU_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", Item.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintMOVI_Codigo", Item.MOVI_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinDMOV_Item", Item.DMOV_Item, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabTGB", Item.TIPO_TabTGB, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodTGB", Item.TIPO_CodTGB, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDMOV_MontoDebe", Item.DMOV_MontoDebe, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDMOV_MontoHaber", Item.DMOV_MontoHaber, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDMOV_NroOperacion", Item.DMOV_NroOperacion, SqlDbType.VarChar, 20, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrDMOV_Flujo", Item.DMOV_Flujo, SqlDbType.Char, 18, ParameterDirection.Input);
					
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
		private bool Delete(ref DetMovimiento Item)
		{
			try
			{
				if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_DMOVSD_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", Item.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintMOVI_Codigo", Item.MOVI_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinDMOV_Item", Item.DMOV_Item, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					
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
