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
	public partial class BLGRR_Contrato
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<GRR_Contrato> Loader { get; set; }
		#endregion
		
		#region [ Constructores ]
		public BLGRR_Contrato(IUnityContainer container)
		{
			this.ContainerService = container;
			Loader = new BusinessEntityLoader<GRR_Contrato>();
			GRR_Contrato Item = new GRR_Contrato();
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
            { DataAccessEnterpriseSQL.DAAsignarProcedure("COM_GCONSS_Todos"); }
				if (x_filters != null && x_filters.Count > 0)
				{
					foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
					{ DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
				}
				_ds = DataAccessEnterpriseSQL.DAExecuteDataSet();
				if (_ds != null && _ds.Tables.Count == 1)
				{ _ds.Tables[0].TableName = "GRR_Contrato"; return _ds.Tables[0]; }
				else
				{ return null; }
			}
			catch (Exception)
			{ throw; }
		}
		private ObservableCollection<GRR_Contrato> SelectAllByFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
		{
			try
			{
				ObservableCollection<GRR_Contrato> items = new ObservableCollection<GRR_Contrato>();
				GRR_Contrato item = new GRR_Contrato();
				if (!String.IsNullOrEmpty(x_procedure))
				{ DataAccessEnterpriseSQL.DAAsignarProcedure(x_procedure); }
				else
            { DataAccessEnterpriseSQL.DAAsignarProcedure("COM_GCONSS_Todos"); }
				if (x_filters != null && x_filters.Count > 0)
				{
					foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
					{ DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
				}
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new GRR_Contrato();
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
		private ObservableCollection<GRR_Contrato> SelectAll()
		{
			try
			{
				ObservableCollection<GRR_Contrato> items = new ObservableCollection<GRR_Contrato>();
				GRR_Contrato item = new GRR_Contrato();
            DataAccessEnterpriseSQL.DAAsignarProcedure("COM_GCONSS_Todos");
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new GRR_Contrato();
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
      private GRR_Contrato SelectOne(String REBA_Tipo, Int32 REBA_Codigo, Int32 CONT_Codigo)
		{
			try
			{
				GRR_Contrato item = new GRR_Contrato();
            DataAccessEnterpriseSQL.DAAsignarProcedure("COM_GCONSS_UnReg");
				DataAccessEnterpriseSQL.DAAgregarParametro("@pchrREBA_Tipo", REBA_Tipo, SqlDbType.Char, 1, ParameterDirection.Input);
				DataAccessEnterpriseSQL.DAAgregarParametro("@pintREBA_Codigo", REBA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCONT_Numero", CONT_Codigo, SqlDbType.VarChar, 50, ParameterDirection.Input);
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
		private bool Insert(ref GRR_Contrato Item)
		{
			try
			{
            //if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
            //{
               DataAccessEnterpriseSQL.DAAsignarProcedure("COM_GCONSI_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrREBA_Tipo", Item.REBA_Tipo, SqlDbType.Char, 1, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintREBA_Codigo", Item.REBA_Codigo, SqlDbType.Int, 4, ParameterDirection.InputOutput);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCONT_Numero", Item.CONT_Numero, SqlDbType.VarChar, 50, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCONT_NumeroEquivalente", Item.CONT_NumeroEquivalente, SqlDbType.VarChar, 50, ParameterDirection.Input);
					
					if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
					{ return true;	}
					else
					{ return false; }
            //}
            //else
            //{ return true; }
			}
			catch (Exception)
			{ throw; }
		}
		private bool Update(ref GRR_Contrato Item)
		{
			try
			{
				if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
				{
               DataAccessEnterpriseSQL.DAAsignarProcedure("COM_GCONSI_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrREBA_Tipo", Item.REBA_Tipo, SqlDbType.Char, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintREBA_Codigo", Item.REBA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCONT_Numero", Item.CONT_Numero, SqlDbType.VarChar, 50, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCONT_NumeroEquivalente", Item.CONT_NumeroEquivalente, SqlDbType.VarChar, 50, ParameterDirection.Input);
					
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
		private bool Delete(ref GRR_Contrato Item)
		{
			try
			{
				if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
				{
               DataAccessEnterpriseSQL.DAAsignarProcedure("COM_GCONSD_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrREBA_Tipo", Item.REBA_Tipo, SqlDbType.Char, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintREBA_Codigo", Item.REBA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCONT_Numero", Item.CONT_Numero, SqlDbType.VarChar, 50, ParameterDirection.Input);
               
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
