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
	public partial class BLGRR_Paquetes
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<GRR_Paquetes> Loader { get; set; }
		#endregion
		
		#region [ Constructores ]
		public BLGRR_Paquetes(IUnityContainer container)
		{
			this.ContainerService = container;
			Loader = new BusinessEntityLoader<GRR_Paquetes>();
			GRR_Paquetes Item = new GRR_Paquetes();
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
            { DataAccessEnterpriseSQL.DAAsignarProcedure("COM_GPACSS_Todos"); }
				if (x_filters != null && x_filters.Count > 0)
				{
					foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
					{ DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
				}
				_ds = DataAccessEnterpriseSQL.DAExecuteDataSet();
				if (_ds != null && _ds.Tables.Count == 1)
				{ _ds.Tables[0].TableName = "GRR_Paquetes"; return _ds.Tables[0]; }
				else
				{ return null; }
			}
			catch (Exception)
			{ throw; }
		}
		private ObservableCollection<GRR_Paquetes> SelectAllByFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
		{
			try
			{
				ObservableCollection<GRR_Paquetes> items = new ObservableCollection<GRR_Paquetes>();
				GRR_Paquetes item = new GRR_Paquetes();
				if (!String.IsNullOrEmpty(x_procedure))
				{ DataAccessEnterpriseSQL.DAAsignarProcedure(x_procedure); }
				else
            { DataAccessEnterpriseSQL.DAAsignarProcedure("COM_GPACSS_Todos"); }
				if (x_filters != null && x_filters.Count > 0)
				{
					foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
					{ DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
				}
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new GRR_Paquetes();
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
		private ObservableCollection<GRR_Paquetes> SelectAll()
		{
			try
			{
				ObservableCollection<GRR_Paquetes> items = new ObservableCollection<GRR_Paquetes>();
				GRR_Paquetes item = new GRR_Paquetes();
            DataAccessEnterpriseSQL.DAAsignarProcedure("COM_GPACSS_Todos");
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new GRR_Paquetes();
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
		private GRR_Paquetes SelectOne(String REBA_Tipo, Int32 REBA_Codigo, Int32 PACK_Codigo)
		{
			try
			{
				GRR_Paquetes item = new GRR_Paquetes();
            DataAccessEnterpriseSQL.DAAsignarProcedure("COM_GPACSS_UnReg");
				DataAccessEnterpriseSQL.DAAgregarParametro("@pchrREBA_Tipo", REBA_Tipo, SqlDbType.Char, 1, ParameterDirection.Input);
				DataAccessEnterpriseSQL.DAAgregarParametro("@pintREBA_Codigo", REBA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
				DataAccessEnterpriseSQL.DAAgregarParametro("@pintPACK_Codigo", PACK_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
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
		private bool Insert(ref GRR_Paquetes Item)
		{
			try
			{
            //if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
            //{
               DataAccessEnterpriseSQL.DAAsignarProcedure("COM_GPACSI_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrREBA_Tipo", Item.REBA_Tipo, SqlDbType.Char, 1, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintREBA_Codigo", Item.REBA_Codigo, SqlDbType.Int, 4, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintPACK_Codigo", Item.PACK_Codigo, SqlDbType.Int, 4, ParameterDirection.InputOutput);
					
					if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
					{ return true; }
					else
					{ return false; }
            //}
            //else
            //{ return true; }
			}
			catch (Exception)
			{ throw; }
		}
		private bool Update(ref GRR_Paquetes Item)
		{
			try
			{
				if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
				{
               DataAccessEnterpriseSQL.DAAsignarProcedure("COM_GPACSI_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrREBA_Tipo", Item.REBA_Tipo, SqlDbType.Char, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintREBA_Codigo", Item.REBA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintPACK_Codigo", Item.PACK_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					
					
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
		private bool Delete(ref GRR_Paquetes Item)
		{
			try
			{
				if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
				{
               DataAccessEnterpriseSQL.DAAsignarProcedure("COM_GPACSD_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrREBA_Tipo", Item.REBA_Tipo, SqlDbType.Char, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintREBA_Codigo", Item.REBA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintPACK_Codigo", Item.PACK_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					
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
