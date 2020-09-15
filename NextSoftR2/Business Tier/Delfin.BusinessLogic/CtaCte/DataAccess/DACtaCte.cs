using System;
using System.Data.SqlClient;
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
	public partial class BLCtaCte
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<CtaCte> Loader { get; set; }
		#endregion
		
		#region [ Constructores ]
		public BLCtaCte(IUnityContainer container)
		{
			this.ContainerService = container;
			Loader = new BusinessEntityLoader<CtaCte>();
			CtaCte Item = new CtaCte();
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
				{ DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_CCCTSS_TodosByFilters"); }
				if (x_filters != null && x_filters.Count > 0)
				{
					foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
					{ DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
				}
				_ds = DataAccessEnterpriseSQL.DAExecuteDataSet();
				if (_ds != null && _ds.Tables.Count == 1)
				{ _ds.Tables[0].TableName = "CtaCte"; return _ds.Tables[0]; }
				else
				{ return null; }
			}
			catch (Exception)
			{ throw; }
		}
		private ObservableCollection<CtaCte> SelectAllByFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
		{
			try
			{
				ObservableCollection<CtaCte> items = new ObservableCollection<CtaCte>();
				CtaCte item = new CtaCte();
				if (!String.IsNullOrEmpty(x_procedure))
				{ DataAccessEnterpriseSQL.DAAsignarProcedure(x_procedure); }
				else
				{ DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_CCCTSS_TodosByFilters"); }
				if (x_filters != null && x_filters.Count > 0)
				{
					foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
					{ DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
				}
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new CtaCte();
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
		private ObservableCollection<CtaCte> SelectAll()
		{
			try
			{
				ObservableCollection<CtaCte> items = new ObservableCollection<CtaCte>();
				CtaCte item = new CtaCte();
				DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_CCCTSS_Todos");
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new CtaCte();
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
		private CtaCte SelectOne(Int16 EMPR_Codigo, Int32 CCCT_Codigo)
		{
			try
			{
				CtaCte item = new CtaCte();
				DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_CCCTSS_UnReg");
				DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
				DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCCT_Codigo", CCCT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
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
		private bool Insert(ref CtaCte Item)
		{
			try
			{
				if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_CCCTSI_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", Item.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCCT_Codigo", Item.CCCT_Codigo, SqlDbType.Int, 4, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", Item.SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintDOCV_Codigo", Item.DOCV_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinTIPE_Codigo", Item.TIPE_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", Item.ENTC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabTDO", Item.TIPO_TabTDO, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabMND", Item.TIPO_TabMND, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabFPG", Item.TIPO_TabFPG, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodTDO", Item.TIPO_CodTDO, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodMND", Item.TIPO_CodMND, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodFPG", Item.TIPO_CodFPG, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCCT_Serie", Item.CCCT_Serie, SqlDbType.VarChar, 20, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCCT_Numero", Item.CCCT_Numero, SqlDbType.VarChar, 20, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCCT_AsientoContable", Item.CCCT_AsientoContable, SqlDbType.VarChar, 50, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCCT_FechaEmision", Item.CCCT_FechaEmision, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pnumCCCT_TipoCambio", Item.CCCT_TipoCambio, SqlDbType.Decimal, 10, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCCT_FechaRecepcion", Item.CCCT_FechaRecepcion, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCCT_FechaVcto", Item.CCCT_FechaVcto, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCCT_FechaPosPago", Item.CCCT_FechaPosPago, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCCCT_ValVta", Item.CCCT_ValVta, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCCCT_Discrepancia", Item.CCCT_Discrepancia, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCCCT_Imp1", Item.CCCT_Imp1, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCCCT_Imp2", Item.CCCT_Imp2, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCCCT_Imp3", Item.CCCT_Imp3, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCCCT_Imp4", Item.CCCT_Imp4, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCCCT_Monto", Item.CCCT_Monto, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCCCT_Pendiente", Item.CCCT_Pendiente, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCCT_FecReg", Item.CCCT_FecReg, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCCT_FecCancel", Item.CCCT_FecCancel, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCCCT_Adquisicion", Item.CCCT_Adquisicion, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCCCT_Pago", Item.CCCT_Pago, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCCCT_PagoReg", Item.CCCT_PagoReg, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCCCT_Otros", Item.CCCT_Otros, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCCT_Glosa", Item.CCCT_Glosa, SqlDbType.VarChar, 100, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCCCT_Estado", Item.CCCT_Estado, SqlDbType.Char, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCCT_NroTransRef", Item.CCCT_NroTransRef, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCCCT_TipoLetra", Item.CCCT_TipoLetra, SqlDbType.Char, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCCT_Agrupacion", Item.CCCT_Agrupacion, SqlDbType.VarChar, 15, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCCT_RegCompras", Item.CCCT_RegCompras, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCCT_Anexo", Item.CCCT_Anexo, SqlDbType.VarChar, 50, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabREG", Item.TIPO_TabREG, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodREG", Item.TIPO_CodREG, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCCT_CobranzaDudosa", Item.CCCT_CobranzaDudosa, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCCCT_TCHistorico", Item.CCCT_TCHistorico, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCCT_FecCierre", Item.CCCT_FecCierre, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCCCT_TCCierre", Item.CCCT_TCCierre, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCCT_FecCierreHistorico", Item.CCCT_FecCierreHistorico, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCCT_UltimoCierre", Item.CCCT_UltimoCierre, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintSERV_Codigo", Item.SERV_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCCT_PagoInmediato", Item.CCCT_PagoInmediato, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCCCT_SituacionLetra", Item.CCCT_SituacionLetra, SqlDbType.Char, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCCT_Aceptada1", Item.CCCT_Aceptada1, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCCT_Aceptada2", Item.CCCT_Aceptada2, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCCT_Protestada", Item.CCCT_Protestada, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCCT_NroProtesto", Item.CCCT_NroProtesto, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCCCT_EstadoLetra", Item.CCCT_EstadoLetra, SqlDbType.Char, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCCT_NroUnicoBCO", Item.CCCT_NroUnicoBCO, SqlDbType.VarChar, 20, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCCT_FecAceptacion", Item.CCCT_FecAceptacion, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCCT_SinDocOrigen", Item.CCCT_SinDocOrigen, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCCT_FecEnvioBanco", Item.CCCT_FecEnvioBanco, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCCT_FecEnvioProveedor", Item.CCCT_FecEnvioProveedor, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCCT_NroDetraccion", Item.CCCT_NroDetraccion, SqlDbType.VarChar, 20, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCCT_FecDetraccion", Item.CCCT_FecDetraccion, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabDetrac", Item.TIPO_TabDetrac, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodDetrac", Item.TIPO_CodDetrac, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabBCO", Item.TIPO_TabBCO, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodBCO", Item.TIPO_CodBCO, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCCT_GlosaCobranza", Item.CCCT_GlosaCobranza, SqlDbType.VarChar, 100, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCCCT_ValorReferencial", Item.CCCT_ValorReferencial, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCCT_Notas", Item.CCCT_Notas, SqlDbType.VarChar, 1000, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCCCT_PorDetraccion", Item.CCCT_PorDetraccion, SqlDbType.Decimal, 5, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCCCT_MontoDetraccion", Item.CCCT_MontoDetraccion, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCCT_ProvAsumeDetraccion", Item.CCCT_ProvAsumeDetraccion, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCABP_Ano", Item.CABP_Ano, SqlDbType.Char, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCABP_Codigo", Item.CABP_Codigo, SqlDbType.VarChar, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCCT_Cuenta", Item.CCCT_Cuenta, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCCT_CuentaIGV", Item.CCCT_CuentaIGV, SqlDbType.VarChar, 20, ParameterDirection.Input);
               /* Campos agregados para el enlace contable - Ysaacx - 21/12/2016 */
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCCT_CuentaBI", Item.CCCT_CuentaBI, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCCT_CodReferencia", Item.CCCT_CodReferencia, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCCT_SerieReferencia", Item.CCCT_SerieReferencia, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCCT_NumeroReferencia", Item.CCCT_NumeroReferencia, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCCT_FechaEmisionReferencia", Item.CCCT_FechaEmisionReferencia, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodTDOReferencia", Item.TIPO_CodTDOReferencia, SqlDbType.Char, 3, ParameterDirection.Input);

               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCCCT_Origen", Item.CCCT_Origen, SqlDbType.Char, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCCCT_PorcImp1", Item.CCCT_PorcImp1, SqlDbType.Decimal, 5, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCCCT_PorcImp2", Item.CCCT_PorcImp2, SqlDbType.Decimal, 5, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCCCT_PorcImp3", Item.CCCT_PorcImp3, SqlDbType.Decimal, 5, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCCCT_PorcImp4", Item.CCCT_PorcImp4, SqlDbType.Decimal, 5, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCCT_RetencionIGV", Item.CCCT_RetencionIGV, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabTI3", Item.TIPO_TabTI3, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodTI3", Item.TIPO_CodTI3, SqlDbType.Char, 3, ParameterDirection.Input);

					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrCrea", Item.AUDI_UsrCrea, SqlDbType.VarChar, 20, ParameterDirection.Input);
					
					if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
					{
						Int16 _EMPR_Codigo;
						if (Int16.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@psinEMPR_Codigo"].Value.ToString(), out _EMPR_Codigo))
						{ Item.EMPR_Codigo = _EMPR_Codigo; }
						Int32 _CCCT_Codigo;
						if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintCCCT_Codigo"].Value.ToString(), out _CCCT_Codigo))
						{ Item.CCCT_Codigo = _CCCT_Codigo; }
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
		private bool Update(ref CtaCte Item)
		{
			try
			{
				if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_CCCTSU_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", Item.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCCT_Codigo", Item.CCCT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", Item.SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintDOCV_Codigo", Item.DOCV_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinTIPE_Codigo", Item.TIPE_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", Item.ENTC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabTDO", Item.TIPO_TabTDO, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabMND", Item.TIPO_TabMND, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabFPG", Item.TIPO_TabFPG, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodTDO", Item.TIPO_CodTDO, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodMND", Item.TIPO_CodMND, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodFPG", Item.TIPO_CodFPG, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCCT_Serie", Item.CCCT_Serie, SqlDbType.VarChar, 20, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCCT_Numero", Item.CCCT_Numero, SqlDbType.VarChar, 20, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCCT_AsientoContable", Item.CCCT_AsientoContable, SqlDbType.VarChar, 50, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCCT_FechaEmision", Item.CCCT_FechaEmision, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pnumCCCT_TipoCambio", Item.CCCT_TipoCambio, SqlDbType.Decimal, 10, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCCT_FechaRecepcion", Item.CCCT_FechaRecepcion, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCCT_FechaVcto", Item.CCCT_FechaVcto, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCCT_FechaPosPago", Item.CCCT_FechaPosPago, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCCCT_ValVta", Item.CCCT_ValVta, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCCCT_Discrepancia", Item.CCCT_Discrepancia, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCCCT_Imp1", Item.CCCT_Imp1, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCCCT_Imp2", Item.CCCT_Imp2, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCCCT_Imp3", Item.CCCT_Imp3, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCCCT_Imp4", Item.CCCT_Imp4, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCCCT_Monto", Item.CCCT_Monto, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCCCT_Pendiente", Item.CCCT_Pendiente, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCCT_FecReg", Item.CCCT_FecReg, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCCT_FecCancel", Item.CCCT_FecCancel, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCCCT_Adquisicion", Item.CCCT_Adquisicion, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCCCT_Pago", Item.CCCT_Pago, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCCCT_PagoReg", Item.CCCT_PagoReg, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCCCT_Otros", Item.CCCT_Otros, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCCT_Glosa", Item.CCCT_Glosa, SqlDbType.VarChar, 100, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCCCT_Estado", Item.CCCT_Estado, SqlDbType.Char, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCCT_NroTransRef", Item.CCCT_NroTransRef, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCCCT_TipoLetra", Item.CCCT_TipoLetra, SqlDbType.Char, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCCT_Agrupacion", Item.CCCT_Agrupacion, SqlDbType.VarChar, 15, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCCT_RegCompras", Item.CCCT_RegCompras, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCCT_Anexo", Item.CCCT_Anexo, SqlDbType.VarChar, 50, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabREG", Item.TIPO_TabREG, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodREG", Item.TIPO_CodREG, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCCT_CobranzaDudosa", Item.CCCT_CobranzaDudosa, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCCCT_TCHistorico", Item.CCCT_TCHistorico, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCCT_FecCierre", Item.CCCT_FecCierre, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCCCT_TCCierre", Item.CCCT_TCCierre, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCCT_FecCierreHistorico", Item.CCCT_FecCierreHistorico, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCCT_UltimoCierre", Item.CCCT_UltimoCierre, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintSERV_Codigo", Item.SERV_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCCT_PagoInmediato", Item.CCCT_PagoInmediato, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCCCT_SituacionLetra", Item.CCCT_SituacionLetra, SqlDbType.Char, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCCT_Aceptada1", Item.CCCT_Aceptada1, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCCT_Aceptada2", Item.CCCT_Aceptada2, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCCT_Protestada", Item.CCCT_Protestada, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCCT_NroProtesto", Item.CCCT_NroProtesto, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCCCT_EstadoLetra", Item.CCCT_EstadoLetra, SqlDbType.Char, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCCT_NroUnicoBCO", Item.CCCT_NroUnicoBCO, SqlDbType.VarChar, 20, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCCT_FecAceptacion", Item.CCCT_FecAceptacion, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCCT_SinDocOrigen", Item.CCCT_SinDocOrigen, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCCT_FecEnvioBanco", Item.CCCT_FecEnvioBanco, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCCT_FecEnvioProveedor", Item.CCCT_FecEnvioProveedor, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCCT_NroDetraccion", Item.CCCT_NroDetraccion, SqlDbType.VarChar, 20, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCCT_FecDetraccion", Item.CCCT_FecDetraccion, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabDetrac", Item.TIPO_TabDetrac, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodDetrac", Item.TIPO_CodDetrac, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabBCO", Item.TIPO_TabBCO, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodBCO", Item.TIPO_CodBCO, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCCT_GlosaCobranza", Item.CCCT_GlosaCobranza, SqlDbType.VarChar, 100, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCCCT_ValorReferencial", Item.CCCT_ValorReferencial, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCCT_Notas", Item.CCCT_Notas, SqlDbType.VarChar, 1000, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCCCT_PorDetraccion", Item.CCCT_PorDetraccion, SqlDbType.Decimal, 5, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCCCT_MontoDetraccion", Item.CCCT_MontoDetraccion, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCCT_ProvAsumeDetraccion", Item.CCCT_ProvAsumeDetraccion, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCABP_Ano", Item.CABP_Ano, SqlDbType.Char, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCABP_Codigo", Item.CABP_Codigo, SqlDbType.VarChar, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCCT_Cuenta", Item.CCCT_Cuenta, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCCT_CuentaIGV", Item.CCCT_CuentaIGV, SqlDbType.VarChar, 20, ParameterDirection.Input);
               /* Campos agregados para el enlace contable - Ysaacx - 21/12/2016 */
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCCT_CuentaBI", Item.CCCT_CuentaBI, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCCT_CodReferencia", Item.CCCT_CodReferencia, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCCT_SerieReferencia", Item.CCCT_SerieReferencia, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCCT_NumeroReferencia", Item.CCCT_NumeroReferencia, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCCT_FechaEmisionReferencia", Item.CCCT_FechaEmisionReferencia, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodTDOReferencia", Item.TIPO_CodTDOReferencia, SqlDbType.Char, 3, ParameterDirection.Input);

               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCCCT_Origen", Item.CCCT_Origen, SqlDbType.Char, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCCCT_PorcImp1", Item.CCCT_PorcImp1, SqlDbType.Decimal, 5, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCCCT_PorcImp2", Item.CCCT_PorcImp2, SqlDbType.Decimal, 5, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCCCT_PorcImp3", Item.CCCT_PorcImp3, SqlDbType.Decimal, 5, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecCCCT_PorcImp4", Item.CCCT_PorcImp4, SqlDbType.Decimal, 5, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitCCCT_RetencionIGV", Item.CCCT_RetencionIGV, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabTI3", Item.TIPO_TabTI3, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodTI3", Item.TIPO_CodTI3, SqlDbType.Char, 3, ParameterDirection.Input);

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
		private bool Delete(ref CtaCte Item)
		{
			try
			{
				if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_CCCTSD_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", Item.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCCT_Codigo", Item.CCCT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					
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
                if (ex.Number == 547)
                {
                    throw new Exception
                       (String.Format("# No se puede Eliminar este Registro por tener relaciones activas. #" + ex.Message, ex));
                }
                else
                {
                    throw;
                }
            }
			catch (Exception)
			{ throw; }
		}
		#endregion
	}
}
