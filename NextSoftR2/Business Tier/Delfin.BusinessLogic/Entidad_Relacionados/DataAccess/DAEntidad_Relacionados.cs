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
	public partial class BLEntidad_Relacionados
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<Entidad_Relacionados> Loader { get; set; }
		#endregion
		
		#region [ Constructores ]
		public BLEntidad_Relacionados(IUnityContainer container)
		{
			this.ContainerService = container;
			Loader = new BusinessEntityLoader<Entidad_Relacionados>();
			Entidad_Relacionados Item = new Entidad_Relacionados();
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
				{ DataAccessEnterpriseSQL.DAAsignarProcedure("RELASS_TodosByFilters"); }
				if (x_filters != null && x_filters.Count > 0)
				{
					foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
					{ DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
				}
				_ds = DataAccessEnterpriseSQL.DAExecuteDataSet();
				if (_ds != null && _ds.Tables.Count == 1)
				{ _ds.Tables[0].TableName = "Entidad_Relacionados"; return _ds.Tables[0]; }
				else
				{ return null; }
			}
			catch (Exception)
			{ throw; }
		}
		private ObservableCollection<Entidad_Relacionados> SelectAllByFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
		{
			try
			{
				ObservableCollection<Entidad_Relacionados> items = new ObservableCollection<Entidad_Relacionados>();
				Entidad_Relacionados item = new Entidad_Relacionados();
				if (!String.IsNullOrEmpty(x_procedure))
				{ DataAccessEnterpriseSQL.DAAsignarProcedure(x_procedure); }
				else
				{ DataAccessEnterpriseSQL.DAAsignarProcedure("RELASS_TodosByFilters"); }
				if (x_filters != null && x_filters.Count > 0)
				{
					foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
					{ DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
				}
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Entidad_Relacionados();
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
		private ObservableCollection<Entidad_Relacionados> SelectAll()
		{
			try
			{
				ObservableCollection<Entidad_Relacionados> items = new ObservableCollection<Entidad_Relacionados>();
				Entidad_Relacionados item = new Entidad_Relacionados();
				DataAccessEnterpriseSQL.DAAsignarProcedure("RELASS_Todos");
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Entidad_Relacionados();
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
		private Entidad_Relacionados SelectOne(Int32 RELA_Codigo)
		{
			try
			{
				Entidad_Relacionados item = new Entidad_Relacionados();
				DataAccessEnterpriseSQL.DAAsignarProcedure("RELASS_UnReg");
				DataAccessEnterpriseSQL.DAAgregarParametro("@pintRELA_Codigo", RELA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
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
		private bool Insert(ref Entidad_Relacionados Item)
		{
			try
			{
				if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("RELASI_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintRELA_Codigo", Item.RELA_Codigo, SqlDbType.Int, 4, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodPadre", Item.ENTC_CodPadre, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodHijo", Item.ENTC_CodHijo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabRGM", Item.CONS_TabRGM, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodRGM", Item.CONS_CodRGM, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitRELA_Activo", Item.RELA_Activo, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabTRF", Item.TIPO_TabTRF, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodTRF", Item.TIPO_CodTRF, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrRELA_Tipos", Item.RELA_Tipos, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitRELA_DepTemNegociaAgente", Item.RELA_DepTemNegociaAgente, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinTIPE_CodPadre", Item.TIPE_CodPadre, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinTIPE_CodHijo", Item.TIPE_CodHijo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchRELA_Observacion", Item.RELA_Observacion, SqlDbType.VarChar, 100, ParameterDirection.Input);

					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrCrea", Item.AUDI_UsrCrea, SqlDbType.VarChar, 20, ParameterDirection.Input);
					
					if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
					{
						Int32 _RELA_Codigo;
						if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintRELA_Codigo"].Value.ToString(), out _RELA_Codigo))
						{ Item.RELA_Codigo = _RELA_Codigo; }
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
		private bool Update(ref Entidad_Relacionados Item)
		{
			try
			{
				if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("RELASU_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintRELA_Codigo", Item.RELA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodPadre", Item.ENTC_CodPadre, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodHijo", Item.ENTC_CodHijo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabRGM", Item.CONS_TabRGM, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodRGM", Item.CONS_CodRGM, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitRELA_Activo", Item.RELA_Activo, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabTRF", Item.TIPO_TabTRF, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodTRF", Item.TIPO_CodTRF, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrRELA_Tipos", Item.RELA_Tipos, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitRELA_DepTemNegociaAgente", Item.RELA_DepTemNegociaAgente, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinTIPE_CodPadre", Item.TIPE_CodPadre, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinTIPE_CodHijo", Item.TIPE_CodHijo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchRELA_Observacion", Item.RELA_Observacion, SqlDbType.VarChar, 100, ParameterDirection.Input);

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
		private bool Delete(ref Entidad_Relacionados Item)
		{
			try
			{
				if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("RELASD_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintRELA_Codigo", Item.RELA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					
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
