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
using System.Data.SqlClient;

namespace Delfin.BusinessLogic
{
	public partial class BLServiciosDocumentos
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<ServiciosDocumentos> Loader { get; set; }
		#endregion
		
		#region [ Constructores ]
		public BLServiciosDocumentos(IUnityContainer container)
		{
			this.ContainerService = container;
			Loader = new BusinessEntityLoader<ServiciosDocumentos>();
			ServiciosDocumentos Item = new ServiciosDocumentos();
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
				{ DataAccessEnterpriseSQL.DAAsignarProcedure("SEDOSS_TodosByFilters"); }
				if (x_filters != null && x_filters.Count > 0)
				{
					foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
					{ DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
				}
				_ds = DataAccessEnterpriseSQL.DAExecuteDataSet();
				if (_ds != null && _ds.Tables.Count == 1)
				{ _ds.Tables[0].TableName = "ServiciosDocumentos"; return _ds.Tables[0]; }
				else
				{ return null; }
			}
			catch (Exception)
			{ throw; }
		}
		private ObservableCollection<ServiciosDocumentos> SelectAllByFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
		{
			try
			{
				ObservableCollection<ServiciosDocumentos> items = new ObservableCollection<ServiciosDocumentos>();
				ServiciosDocumentos item = new ServiciosDocumentos();
				if (!String.IsNullOrEmpty(x_procedure))
				{ DataAccessEnterpriseSQL.DAAsignarProcedure(x_procedure); }
				else
				{ DataAccessEnterpriseSQL.DAAsignarProcedure("SEDOSS_TodosByFilters"); }
				if (x_filters != null && x_filters.Count > 0)
				{
					foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
					{ DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
				}
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new ServiciosDocumentos();
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
		private ObservableCollection<ServiciosDocumentos> SelectAll()
		{
			try
			{
				ObservableCollection<ServiciosDocumentos> items = new ObservableCollection<ServiciosDocumentos>();
				ServiciosDocumentos item = new ServiciosDocumentos();
				DataAccessEnterpriseSQL.DAAsignarProcedure("SEDOSS_Todos");
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new ServiciosDocumentos();
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
		private ServiciosDocumentos SelectOne(Int32 SERV_Codigo)
		{
			try
			{
				ServiciosDocumentos item = new ServiciosDocumentos();
				DataAccessEnterpriseSQL.DAAsignarProcedure("SEDOSS_UnReg");
				DataAccessEnterpriseSQL.DAAgregarParametro("@pintSERV_Codigo", SERV_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
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
		public bool Insert(ref ServiciosDocumentos Item)
		{
			try
			{
                if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("SEDOSI_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintSERV_Codigo", Item.SERV_Codigo, SqlDbType.Int, 4, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabTDO", Item.TIPO_TabTDO, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodTDO", Item.TIPO_CodTDO, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrSEDO_Tipo", Item.SEDO_Tipo, SqlDbType.Char, 1, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintSEDO_Item", Item.SEDO_Item, SqlDbType.Int, 4, ParameterDirection.Input);

                    DataAccessEnterpriseSQL.DAAgregarParametro("@psinTIPE_Codigo", Item.TIPE_Codigo, SqlDbType.SmallInt, 4, ParameterDirection.Input);

                    if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
					{
						Int32 _SERV_Codigo;
						if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintSERV_Codigo"].Value.ToString(), out _SERV_Codigo))
						{ Item.SERV_Codigo = _SERV_Codigo; }
						return true;
					}
					else
					{ return false; }
				}
				else
				{ return true; }
			}
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    throw new Exception
                       (String.Format("# Hay mas de un registro con el mismo Documento y el Tipo de Mov.(I/C) #" + ex.Message, ex));
                }
                else
                {
                    throw;
                }
            }
            catch (Exception ex)
            { throw ex; }
		}
		public bool Update(ref ServiciosDocumentos Item)
		{
			try
			{
                if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("SEDOSU_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintSERV_Codigo", Item.SERV_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabTDO", Item.TIPO_TabTDO, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodTDO", Item.TIPO_CodTDO, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrSEDO_Tipo", Item.SEDO_Tipo, SqlDbType.Char, 1, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintSEDO_Item", Item.SEDO_Item, SqlDbType.Int, 4, ParameterDirection.Input);

                    DataAccessEnterpriseSQL.DAAgregarParametro("@psinTIPE_Codigo", Item.TIPE_Codigo, SqlDbType.SmallInt, 4, ParameterDirection.Input);
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
                if (ex.Number == 2627)
                {
                    throw new Exception
                       (String.Format("# Hay mas de un registro con el mismo Documento y el Tipo de Mov.(I/C) #" + ex.Message, ex));
                }
                else
                {
                    throw;
                }
            }
            catch (Exception ex)
            { throw ex; }
		}
		public bool Delete(ref ServiciosDocumentos Item)
		{
			try
			{
				if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted && Item.SEDO_Seleccionar == 0)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("SEDOSD_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintSERV_Codigo", Item.SERV_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabTDO", Item.TIPO_TabTDO, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodTDO", Item.TIPO_CodTDO, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrSEDO_Tipo", Item.SEDO_Tipo, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintSEDO_Item", Item.SEDO_Item, SqlDbType.Int, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@psinTIPE_Codigo", Item.TIPE_Codigo, SqlDbType.SmallInt, 4, ParameterDirection.Input);
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
