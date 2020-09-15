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
	public partial class BLLoadingList_Files
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<LoadingList_Files> Loader { get; set; }
		#endregion
		
		#region [ Constructores ]
		public BLLoadingList_Files(IUnityContainer container)
		{
			this.ContainerService = container;
			Loader = new BusinessEntityLoader<LoadingList_Files>();
			LoadingList_Files Item = new LoadingList_Files();
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
				{ DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_LOADSS_TodosByFilters"); }
				if (x_filters != null && x_filters.Count > 0)
				{
					foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
					{ DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
				}
				_ds = DataAccessEnterpriseSQL.DAExecuteDataSet();
				if (_ds != null && _ds.Tables.Count == 1)
				{ _ds.Tables[0].TableName = "LoadingList_Files"; return _ds.Tables[0]; }
				else
				{ return null; }
			}
			catch (Exception)
			{ throw; }
		}
		private ObservableCollection<LoadingList_Files> SelectAllByFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
		{
			try
			{
				ObservableCollection<LoadingList_Files> items = new ObservableCollection<LoadingList_Files>();
				LoadingList_Files item = new LoadingList_Files();
				if (!String.IsNullOrEmpty(x_procedure))
				{ DataAccessEnterpriseSQL.DAAsignarProcedure(x_procedure); }
				else
				{ DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_LOADSS_TodosByFilters"); }
				if (x_filters != null && x_filters.Count > 0)
				{
					foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
					{ DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
				}
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new LoadingList_Files();
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
		private ObservableCollection<LoadingList_Files> SelectAll()
		{
			try
			{
				ObservableCollection<LoadingList_Files> items = new ObservableCollection<LoadingList_Files>();
				LoadingList_Files item = new LoadingList_Files();
				DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_LOADSS_Todos");
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new LoadingList_Files();
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
		private LoadingList_Files SelectOne(Int32 LOAD_Codigo, Int32 FILE_Codigo)
		{
			try
			{
				LoadingList_Files item = new LoadingList_Files();
				DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_LOADSS_UnReg");
				DataAccessEnterpriseSQL.DAAgregarParametro("@pintLOAD_Codigo", LOAD_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
				DataAccessEnterpriseSQL.DAAgregarParametro("@pintFILE_Codigo", FILE_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
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
		private bool Insert(ref LoadingList_Files Item)
		{
			try
			{
				if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_LOADSI_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintLOAD_Codigo", Item.LOAD_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintFILE_Codigo", Item.FILE_Codigo, SqlDbType.Int, 4, ParameterDirection.InputOutput);

               DataAccessEnterpriseSQL.DAAgregarParametro("@pintFILE_ContentLenght", Item.ItemFile.FILE_ContentLenght, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchFILE_ContentType", Item.ItemFile.FILE_ContentType, SqlDbType.VarChar, 250, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchFILE_FileName", Item.ItemFile.FILE_FileName, SqlDbType.VarChar, 250, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pimgFILE_InputStream", Item.ItemFile.FILE_InputStream, SqlDbType.Image, 2147483647, ParameterDirection.Input);

					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrCrea", Item.AUDI_UsrCrea, SqlDbType.VarChar, 20, ParameterDirection.Input);
					
					if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
					{
                  //Int32 _LOAD_Codigo;
                  //if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintLOAD_Codigo"].Value.ToString(), out _LOAD_Codigo))
                  //{ Item.LOAD_Codigo = _LOAD_Codigo; }
						Int32 _FILE_Codigo;
						if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintFILE_Codigo"].Value.ToString(), out _FILE_Codigo))
						{ Item.FILE_Codigo = _FILE_Codigo; }
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
		private bool Update(ref LoadingList_Files Item)
		{
			try
			{
				if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_LOADSU_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintLOAD_Codigo", Item.LOAD_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintFILE_Codigo", Item.FILE_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					
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
		private bool Delete(ref LoadingList_Files Item)
		{
			try
			{
				if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_LOADSD_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintLOAD_Codigo", Item.LOAD_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintFILE_Codigo", Item.FILE_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					
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
