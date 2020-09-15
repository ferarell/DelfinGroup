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
	public partial class BLComision
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<Comision> Loader { get; set; }
		#endregion
		
		#region [ Constructores ]
		public BLComision(IUnityContainer container)
		{
			this.ContainerService = container;
			Loader = new BusinessEntityLoader<Comision>();
			Comision Item = new Comision();
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
				{ DataAccessEnterpriseSQL.DAAsignarProcedure("COM_COMISS_TodosByFilters"); }
				if (x_filters != null && x_filters.Count > 0)
				{
					foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
					{ DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
				}
				_ds = DataAccessEnterpriseSQL.DAExecuteDataSet();
				if (_ds != null && _ds.Tables.Count == 1)
				{ _ds.Tables[0].TableName = "Comision"; return _ds.Tables[0]; }
				else
				{ return null; }
			}
			catch (Exception)
			{ throw; }
		}
		private ObservableCollection<Comision> SelectAllByFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
		{
			try
			{
				ObservableCollection<Comision> items = new ObservableCollection<Comision>();
				Comision item = new Comision();
				if (!String.IsNullOrEmpty(x_procedure))
				{ DataAccessEnterpriseSQL.DAAsignarProcedure(x_procedure); }
				else
				{ DataAccessEnterpriseSQL.DAAsignarProcedure("COM_COMISS_TodosByFilters"); }
				if (x_filters != null && x_filters.Count > 0)
				{
					foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
					{ DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
				}
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Comision();
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
		private ObservableCollection<Comision> SelectAll()
		{
			try
			{
				ObservableCollection<Comision> items = new ObservableCollection<Comision>();
				Comision item = new Comision();
				DataAccessEnterpriseSQL.DAAsignarProcedure("COM_COMISS_Todos");
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Comision();
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
		private Comision SelectOne(Int32 COMI_Codigo)
		{
			try
			{
				Comision item = new Comision();
				DataAccessEnterpriseSQL.DAAsignarProcedure("COM_COMISS_UnReg");
				DataAccessEnterpriseSQL.DAAgregarParametro("@pintCOMI_Codigo", COMI_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
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
		private bool Insert(ref Comision Item)
		{
			try
			{
				if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("COM_COMISI_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCOMI_Codigo", Item.COMI_Codigo, SqlDbType.Int, 4, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", Item.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", Item.SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCOMI_FecIni", Item.COMI_FecIni, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCOMI_FecFin", Item.COMI_FecFin, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabMND", Item.TIPO_TabMND, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodMND", Item.TIPO_CodMND, SqlDbType.Char, 3, ParameterDirection.Input);
					
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrCrea", Item.AUDI_UsrCrea, SqlDbType.VarChar, 20, ParameterDirection.Input);
					
					if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
					{
						Int32 _COMI_Codigo;
						if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintCOMI_Codigo"].Value.ToString(), out _COMI_Codigo))
						{ Item.COMI_Codigo = _COMI_Codigo; }
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
		private bool Update(ref Comision Item)
		{
			try
			{
				if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("COM_COMISU_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCOMI_Codigo", Item.COMI_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", Item.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", Item.SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCOMI_FecIni", Item.COMI_FecIni, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCOMI_FecFin", Item.COMI_FecFin, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabMND", Item.TIPO_TabMND, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodMND", Item.TIPO_CodMND, SqlDbType.Char, 3, ParameterDirection.Input);
					
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
		private bool Delete(ref Comision Item)
		{
			try
			{
				if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("COM_COMISD_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCOMI_Codigo", Item.COMI_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					
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
