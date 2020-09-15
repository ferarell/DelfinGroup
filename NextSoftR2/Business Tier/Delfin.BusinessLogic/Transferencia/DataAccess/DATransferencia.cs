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
	public partial class BLTransferencia
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<Transferencia> Loader { get; set; }
		#endregion
		
		#region [ Constructores ]
		public BLTransferencia(IUnityContainer container)
		{
			this.ContainerService = container;
			Loader = new BusinessEntityLoader<Transferencia>();
			Transferencia Item = new Transferencia();
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
				{ DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_TRANSS_TodosByFilters"); }
				if (x_filters != null && x_filters.Count > 0)
				{
					foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
					{ DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
				}
				_ds = DataAccessEnterpriseSQL.DAExecuteDataSet();
				if (_ds != null && _ds.Tables.Count == 1)
				{ _ds.Tables[0].TableName = "Transferencia"; return _ds.Tables[0]; }
				else
				{ return null; }
			}
			catch (Exception)
			{ throw; }
		}
		private ObservableCollection<Transferencia> SelectAllByFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
		{
			try
			{
				ObservableCollection<Transferencia> items = new ObservableCollection<Transferencia>();
				Transferencia item = new Transferencia();
				if (!String.IsNullOrEmpty(x_procedure))
				{ DataAccessEnterpriseSQL.DAAsignarProcedure(x_procedure); }
				else
				{ DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_TRANSS_TodosByFilters"); }
				if (x_filters != null && x_filters.Count > 0)
				{
					foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
					{ DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
				}
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Transferencia();
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
		private ObservableCollection<Transferencia> SelectAll()
		{
			try
			{
				ObservableCollection<Transferencia> items = new ObservableCollection<Transferencia>();
				Transferencia item = new Transferencia();
				DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_TRANSS_Todos");
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Transferencia();
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
		private Transferencia SelectOne(Int16 EMPR_Codigo, Int32 TRAN_Codigo)
		{
			try
			{
				Transferencia item = new Transferencia();
				DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_TRANSS_UnReg");
				DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
				DataAccessEnterpriseSQL.DAAgregarParametro("@pintTRAN_Codigo", TRAN_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
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
		private bool Insert(ref Transferencia Item)
		{
			try
			{
				if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_TRANSI_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", Item.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintTRAN_Codigo", Item.TRAN_Codigo, SqlDbType.Int, 4, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmTRAN_Fecha", Item.TRAN_Fecha, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchTRAN_Glosa", Item.TRAN_Glosa, SqlDbType.VarChar, 1000, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTRAN_Estado", Item.TRAN_Estado, SqlDbType.Char, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTRAN_Tipo", Item.TRAN_Tipo, SqlDbType.Char, 1, ParameterDirection.Input);
					
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrCrea", Item.AUDI_UsrCrea, SqlDbType.VarChar, 20, ParameterDirection.Input);
					
					if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
					{
						Int16 _EMPR_Codigo;
						if (Int16.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@psinEMPR_Codigo"].Value.ToString(), out _EMPR_Codigo))
						{ Item.EMPR_Codigo = _EMPR_Codigo; }
						Int32 _TRAN_Codigo;
						if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintTRAN_Codigo"].Value.ToString(), out _TRAN_Codigo))
						{ Item.TRAN_Codigo = _TRAN_Codigo; }
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
		private bool Update(ref Transferencia Item)
		{
			try
			{
				if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_TRANSU_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", Item.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintTRAN_Codigo", Item.TRAN_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmTRAN_Fecha", Item.TRAN_Fecha, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchTRAN_Glosa", Item.TRAN_Glosa, SqlDbType.VarChar, 1000, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTRAN_Estado", Item.TRAN_Estado, SqlDbType.Char, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTRAN_Tipo", Item.TRAN_Tipo, SqlDbType.Char, 1, ParameterDirection.Input);
					
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
		private bool Delete(ref Transferencia Item)
		{
			try
			{
				if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_TRANSD_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", Item.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintTRAN_Codigo", Item.TRAN_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					
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
