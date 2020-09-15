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
	public partial class BLCuentasBancarias
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<CuentasBancarias> Loader { get; set; }
		#endregion
		
		#region [ Constructores ]
		public BLCuentasBancarias(IUnityContainer container)
		{
			this.ContainerService = container;
			Loader = new BusinessEntityLoader<CuentasBancarias>();
			CuentasBancarias Item = new CuentasBancarias();
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
				{ DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_CUBASS_TodosByFilters"); }
				if (x_filters != null && x_filters.Count > 0)
				{
					foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
					{ DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
				}
				_ds = DataAccessEnterpriseSQL.DAExecuteDataSet();
				if (_ds != null && _ds.Tables.Count == 1)
				{ _ds.Tables[0].TableName = "CuentasBancarias"; return _ds.Tables[0]; }
				else
				{ return null; }
			}
			catch (Exception)
			{ throw; }
		}
		private ObservableCollection<CuentasBancarias> SelectAllByFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
		{
			try
			{
				ObservableCollection<CuentasBancarias> items = new ObservableCollection<CuentasBancarias>();
				CuentasBancarias item = new CuentasBancarias();
				if (!String.IsNullOrEmpty(x_procedure))
				{ DataAccessEnterpriseSQL.DAAsignarProcedure(x_procedure); }
				else
				{ DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_CUBASS_TodosByFilters"); }
				if (x_filters != null && x_filters.Count > 0)
				{
					foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
					{ DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
				}
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new CuentasBancarias();
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
		private ObservableCollection<CuentasBancarias> SelectAll()
		{
			try
			{
				ObservableCollection<CuentasBancarias> items = new ObservableCollection<CuentasBancarias>();
				CuentasBancarias item = new CuentasBancarias();
				DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_CUBASS_Todos");
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new CuentasBancarias();
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
		private CuentasBancarias SelectOne(Int16 EMPR_Codigo, String CUBA_Codigo)
		{
			try
			{
				CuentasBancarias item = new CuentasBancarias();
				DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_CUBASS_UnReg");
				DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
				DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCUBA_Codigo", CUBA_Codigo, SqlDbType.Char, 3, ParameterDirection.Input);
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
		private bool Insert(ref CuentasBancarias Item)
		{
			try
			{
				if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_CUBASI_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", Item.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCUBA_Codigo", Item.CUBA_Codigo, SqlDbType.Char, 3, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", Item.SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabBCO", Item.TIPO_TabBCO, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodBCO", Item.TIPO_CodBCO, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabMND", Item.TIPO_TabMND, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodMND", Item.TIPO_CodMND, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCUBA_NroCuenta", Item.CUBA_NroCuenta, SqlDbType.VarChar, 50, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCUBA_TipoCuenta", Item.CUBA_TipoCuenta, SqlDbType.Char, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCUBA_CuenPuente", Item.CUBA_CuenPuente, SqlDbType.VarChar, 20, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCUBA_CuenContable", Item.CUBA_CuenContable, SqlDbType.VarChar, 20, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCUBA_CtaPorCobrar", Item.CUBA_CtaPorCobrar, SqlDbType.VarChar, 20, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCUBA_CtaPorPagar", Item.CUBA_CtaPorPagar, SqlDbType.VarChar, 20, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCUBA_FechaCierre", Item.CUBA_FechaCierre, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCUBA_Bloqueo", Item.CUBA_Bloqueo, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCUBA_PermChequeBlanco", Item.CUBA_PermChequeBlanco, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCUBA_PermImprAutomatica", Item.CUBA_PermImprAutomatica, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCUBA_CodAgencia", Item.CUBA_CodAgencia, SqlDbType.VarChar, 20, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCUBA_MedioVirtual", Item.CUBA_MedioVirtual, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCUBA_InscritoSOL", Item.CUBA_InscritoSOL, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCUBA_Descripcion", Item.CUBA_Descripcion, SqlDbType.VarChar, 100, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCUBA_CtaEmprVinculada", Item.CUBA_CtaEmprVinculada, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCUBA_SubCtaIngreso", Item.CUBA_SubCtaIngreso, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCUBA_SubCtaEgreso", Item.CUBA_SubCtaEgreso, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCUBA_SubCtaIngresoEV", Item.CUBA_SubCtaIngresoEV, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCUBA_SubCtaEgresoEV", Item.CUBA_SubCtaEgresoEV, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCUBA_LibroDestino", Item.CUBA_LibroDestino, SqlDbType.Char, 3, ParameterDirection.Input);

					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrCrea", Item.AUDI_UsrCrea, SqlDbType.VarChar, 20, ParameterDirection.Input);
					
					if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
					{
						Int16 _EMPR_Codigo;
						if (Int16.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@psinEMPR_Codigo"].Value.ToString(), out _EMPR_Codigo))
						{ Item.EMPR_Codigo = _EMPR_Codigo; }
						if (DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pchrCUBA_Codigo"].Value != DBNull.Value && String.IsNullOrEmpty(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pchrCUBA_Codigo"].Value.ToString()))
						{ Item.CUBA_Codigo = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pchrCUBA_Codigo"].Value.ToString(); }
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
		private bool Update(ref CuentasBancarias Item)
		{
			try
			{
				if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_CUBASU_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", Item.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCUBA_Codigo", Item.CUBA_Codigo, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", Item.SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabBCO", Item.TIPO_TabBCO, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodBCO", Item.TIPO_CodBCO, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabMND", Item.TIPO_TabMND, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodMND", Item.TIPO_CodMND, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCUBA_NroCuenta", Item.CUBA_NroCuenta, SqlDbType.VarChar, 50, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCUBA_TipoCuenta", Item.CUBA_TipoCuenta, SqlDbType.Char, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCUBA_CuenPuente", Item.CUBA_CuenPuente, SqlDbType.VarChar, 20, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCUBA_CuenContable", Item.CUBA_CuenContable, SqlDbType.VarChar, 20, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCUBA_CtaPorCobrar", Item.CUBA_CtaPorCobrar, SqlDbType.VarChar, 20, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCUBA_CtaPorPagar", Item.CUBA_CtaPorPagar, SqlDbType.VarChar, 20, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCUBA_FechaCierre", Item.CUBA_FechaCierre, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCUBA_Bloqueo", Item.CUBA_Bloqueo, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCUBA_PermChequeBlanco", Item.CUBA_PermChequeBlanco, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCUBA_PermImprAutomatica", Item.CUBA_PermImprAutomatica, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCUBA_CodAgencia", Item.CUBA_CodAgencia, SqlDbType.VarChar, 20, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCUBA_MedioVirtual", Item.CUBA_MedioVirtual, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCUBA_InscritoSOL", Item.CUBA_InscritoSOL, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCUBA_Descripcion", Item.CUBA_Descripcion, SqlDbType.VarChar, 100, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCUBA_CtaEmprVinculada", Item.CUBA_CtaEmprVinculada, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCUBA_SubCtaIngreso", Item.CUBA_SubCtaIngreso, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCUBA_SubCtaEgreso", Item.CUBA_SubCtaEgreso, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCUBA_SubCtaIngresoEV", Item.CUBA_SubCtaIngresoEV, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCUBA_SubCtaEgresoEV", Item.CUBA_SubCtaEgresoEV, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCUBA_LibroDestino", Item.CUBA_LibroDestino, SqlDbType.Char, 3, ParameterDirection.Input);

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
		private bool Delete(ref CuentasBancarias Item)
		{
			try
			{
				if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_CUBASD_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", Item.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCUBA_Codigo", Item.CUBA_Codigo, SqlDbType.Char, 3, ParameterDirection.Input);
					
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
