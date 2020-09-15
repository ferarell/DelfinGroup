using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Practices.Unity;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Infrastructure.Aspect.DataAccess;
using Delfin.Entities;
using Infrastructure.Aspect.BusinessEntity;

namespace Delfin.BusinessLogic
{
   public partial class BLDocsVta
   {
      #region [ Consultas ]
      public DataSet SelectAllImpresionFactura(Int32 x_DOCV_Codigo)
      {
         try
         {
            DataSet _dt = new DataSet();
            DataAccessEnterpriseSQL.DAAsignarProcedure("VEN_DDOVSS_TodosImpresionByDOCV_Codigo");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintDOCV_Codigo", x_DOCV_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            _dt = DataAccessEnterpriseSQL.DAExecuteDataSet();
            if (_dt != null)
            {
               return _dt;
            }
            return null;
         }
         catch (Exception ex)
         { throw ex; }
      }

      private ObservableCollection<DocsVta> SelectAllByFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            ObservableCollection<DocsVta> items = new ObservableCollection<DocsVta>();
            DocsVta item = new DocsVta();
            if (!String.IsNullOrEmpty(x_procedure))
            { DataAccessEnterpriseSQL.DAAsignarProcedure(x_procedure); }
            else
            { DataAccessEnterpriseSQL.DAAsignarProcedure("VEN_DOCVSS_TodosByFilters"); }
            if (x_filters != null && x_filters.Count > 0)
            {
               foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
               { DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
            }
            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               while (reader.Read())
               {
                  item = new DocsVta();
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

      private DataSet SelectDS(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters, Boolean x_transaccion = false)
      {
         try
         {
            if (x_transaccion) { DataAccessEnterpriseSQL.DABeginTransaction(); }
            ObservableCollection<DocsVta> items = new ObservableCollection<DocsVta>();
            DocsVta item = new DocsVta();
            if (!String.IsNullOrEmpty(x_procedure))
            { DataAccessEnterpriseSQL.DAAsignarProcedure(x_procedure); }
            else
            { DataAccessEnterpriseSQL.DAAsignarProcedure("VEN_DOCVSS_TodosByFilters"); }
            if (x_filters != null && x_filters.Count > 0)
            {
               foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
               { DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
            }

            System.Data.DataSet DSResultado = DataAccessEnterpriseSQL.DAExecuteDataSet();
            if (x_transaccion) { DataAccessEnterpriseSQL.DACommitTransaction(); }
            return DSResultado;
         }
         catch (Exception)
         {
            if (x_transaccion) { DataAccessEnterpriseSQL.DARollbackTransaction(); }
            throw;
         }
      }

      private DataSet SelectDS(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters, ref Int16 x_empr_codigo, ref int x_ccct_codigo, ref Boolean x_generado, Boolean x_transaccion = false)
      {
         try
         {
            if (x_transaccion) { DataAccessEnterpriseSQL.DABeginTransaction(); }
            ObservableCollection<DocsVta> items = new ObservableCollection<DocsVta>();
            DocsVta item = new DocsVta();
            if (!String.IsNullOrEmpty(x_procedure))
            { DataAccessEnterpriseSQL.DAAsignarProcedure(x_procedure); }
            else
            { DataAccessEnterpriseSQL.DAAsignarProcedure("VEN_DOCVSS_TodosByFilters"); }
            if (x_filters != null && x_filters.Count > 0)
            {
               foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
               { DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
            }
            DataAccessEnterpriseSQL.DAAgregarParametro("@AsientoGenerado", x_generado, SqlDbType.Bit, 1, ParameterDirection.InputOutput);
            DataAccessEnterpriseSQL.DAAgregarParametro("@EMPR_Codigo", x_empr_codigo, SqlDbType.SmallInt, 2, ParameterDirection.InputOutput);
            DataAccessEnterpriseSQL.DAAgregarParametro("@CCCT_Codigo", x_ccct_codigo, SqlDbType.Int, 4, ParameterDirection.InputOutput);

            System.Data.DataSet DSResultado = DataAccessEnterpriseSQL.DAExecuteDataSet();
            if (x_transaccion) { DataAccessEnterpriseSQL.DACommitTransaction(); }

            if (DataAccessEnterpriseSQL.DASqlCommand.Parameters["@AsientoGenerado"].Value != null)
            { x_generado = ((Boolean)(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@AsientoGenerado"].Value)); }

            Int16 _empr_codigo;
            if (Int16.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@EMPR_Codigo"].Value.ToString(), out _empr_codigo))
            { x_empr_codigo = _empr_codigo; }

            Int32 _ccct_codigo;
            if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@CCCT_Codigo"].Value.ToString(), out _ccct_codigo))
            { x_ccct_codigo = _ccct_codigo; }

            return DSResultado;
         }
         catch (Exception)
         {
            if (x_transaccion) { DataAccessEnterpriseSQL.DARollbackTransaction(); }
            throw;
         }
      }

      #endregion

      #region [ Metodos ]

      private bool Facturar(DocsVta item)
      {
         try
         {
            DataAccessEnterpriseSQL.DAAsignarProcedure("VEN_DOCVSI_InsertaUnDocumento");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintPDOC_Codigo", item.PDOC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrCrea", item.AUDI_UsrCrea, SqlDbType.VarChar, 20, ParameterDirection.Input);
            return DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0;
         }
         catch (Exception ex)
         { throw ex; }
      }

      public bool AnularDocsVta(DocsVta item)
      {
         try
         {
            DataAccessEnterpriseSQL.DAAsignarProcedure("VEN_DOCVSU_UnRegAnulacion");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintDOCV_Codigo", item.DOCV_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodANU", item.CONS_CodANU, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabANU", item.CONS_TabANU, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrMod", item.AUDI_UsrMod, SqlDbType.VarChar, 20, ParameterDirection.Input);

            return DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0;

         }
         catch (Exception ex)
         { throw ex; }
      }

      private DataSet SelectDS(string x_procedure, List<object> filters)
      {
         DataSet _ds = new DataSet();
         try
         {
            if (String.Equals(x_procedure, "VEN_DOCVSS_TodosByFiltros"))
            {

               DataAccessEnterpriseSQL.DAAsignarProcedure("VEN_DOCVSS_TodosByFiltros");
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDOCV_Numero", filters[0], SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmDOCV_FechaEmisionIni", filters[1], SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmDOCV_FechaEmisionFin", filters[2], SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", filters[3], SqlDbType.Int, 4, ParameterDirection.Input);
               if (filters[4] == null)
                  DataAccessEnterpriseSQL.DAAgregarParametro("@Estado", DBNull.Value, SqlDbType.Char, 1, ParameterDirection.Input);
               else
                  DataAccessEnterpriseSQL.DAAgregarParametro("@Estado", filters[4], SqlDbType.Char, 1, ParameterDirection.Input);
               _ds = DataAccessEnterpriseSQL.DAExecuteDataSet();

               if (_ds != null)
               {
                  return _ds;
               }
               return null;
            }

            else if (String.Equals(x_procedure, "VEN_SUM_DocvByPadre"))
            {

               DataAccessEnterpriseSQL.DAAsignarProcedure("VEN_SUM_DocvByPadre");
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintDOCV_CodigoPadre", filters[0], SqlDbType.Int, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchTIPO_CodTDO", filters[1], SqlDbType.Char, 3, ParameterDirection.Input);

               _ds = DataAccessEnterpriseSQL.DAExecuteDataSet();

               if (_ds != null)
               {
                  return _ds;
               }
               return null;
            }

            else if (String.Equals(x_procedure, "VEN_DOCV_ByFilters"))
            {
               DataAccessEnterpriseSQL.DAAsignarProcedure("VEN_DOCV_ByFilters");
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDOCV_Numero", filters[0], SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabTDO", filters[1], SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodTDO", filters[2], SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", filters[3], SqlDbType.Int, 4, ParameterDirection.Input);

               _ds = DataAccessEnterpriseSQL.DAExecuteDataSet();

               if (_ds != null)
               {
                  return _ds;
               }
               return null;
            }

            else
            {
               return null;
            }
         }
         catch (Exception ex)
         { throw ex; }
      }

      private bool InsertNotaCredito(ref DocsVta item)
      {
         try
         {
            if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
            {
               DataAccessEnterpriseSQL.DAAsignarProcedure("VEN_DOCVSI_UnRegNC");

               DataAccessEnterpriseSQL.DAAgregarParametro("@pintDOCV_Codigo", item.DOCV_Codigo, SqlDbType.Int, 4, ParameterDirection.InputOutput);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintDOCV_CodigoPadre", item.DOCV_CodigoPadre, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", item.ENTC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDOCV_Numero", item.DOCV_Numero, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pnumDOCV_TipoCambio", item.DOCV_TipoCambio, SqlDbType.Decimal, 8, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmDOCV_FechaEmision", item.DOCV_FechaEmision, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmDOCV_FechaVcmto", item.DOCV_FechaVcmto, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrDOCV_Estado", item.DOCV_Estado, SqlDbType.Char, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOCV_PrecVtaTotal", item.DOCV_PrecVtaTotal, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOCV_PrecVtaTotalD", item.DOCV_PrecVtaTotalD, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOCV_ValorTotal", item.DOCV_ValorTotal, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOCV_ValorTotalD", item.DOCV_ValorTotalD, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOCV_ValorVtaTotal", item.DOCV_ValorVtaTotal, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOCV_ValorVtaTotalD", item.DOCV_ValorVtaTotalD, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOCV_Descuento", item.DOCV_Descuento, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOCV_DescuentoD", item.DOCV_DescuentoD, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDOCV_Observaciones", item.DOCV_Observaciones, SqlDbType.VarChar, 1024, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOCV_Impuesto1", item.DOCV_Impuesto1, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOCV_Impuesto1D", item.DOCV_Impuesto1D, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOCV_Impuesto2", item.DOCV_Impuesto2, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOCV_Impuesto2D", item.DOCV_Impuesto2D, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOCV_Impuesto3", item.DOCV_Impuesto3, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOCV_Impuesto3D", item.DOCV_Impuesto3D, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOCV_Impuesto4", item.DOCV_Impuesto4, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOCV_Impuesto4D", item.DOCV_Impuesto4D, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOCV_PorcImp1", item.DOCV_PorcImp1, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOCV_PorcImp2", item.DOCV_PorcImp2, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOCV_PorcImp3", item.DOCV_PorcImp3, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOCV_PorcImp4", item.DOCV_PorcImp4, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDOCV_Notas", item.DOCV_Notas, SqlDbType.VarChar, 1000, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDOCV_Serie", item.DOCV_Serie, SqlDbType.VarChar, 10, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabFPG", item.TIPO_TabFPG, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodFPG", item.TIPO_CodFPG, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabMND", item.TIPO_TabMND, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodMND", item.TIPO_CodMND, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabTDO", item.TIPO_TabTDO, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodTDO", item.TIPO_CodTDO, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodANU", item.CONS_CodANU, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabANU", item.CONS_TabANU, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintPDOC_Codigo", item.PDOC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);

               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrCrea", item.AUDI_UsrCrea, SqlDbType.VarChar, 20, ParameterDirection.Input);

               if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
               {
                  Int32 _DOCV_Codigo;
                  if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintDOCV_Codigo"].Value.ToString(), out _DOCV_Codigo))
                  { item.DOCV_Codigo = _DOCV_Codigo; }
                  return true;
               }
               else
               { return false; }
            }
            else
            { return true; }
         }
         catch (Exception ex)
         { throw ex; }
      }

      private bool UpdateNotaCredito(ref DocsVta item)
      {
         try
         {
            if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
            {
               DataAccessEnterpriseSQL.DAAsignarProcedure("VEN_DOCVSU_UnRegNC");
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintDOCV_Codigo", item.DOCV_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDOCV_Numero", item.DOCV_Numero, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pnumDOCV_TipoCambio", item.DOCV_TipoCambio, SqlDbType.Decimal, 8, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmDOCV_FechaEmision", item.DOCV_FechaEmision, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmDOCV_FechaVcmto", item.DOCV_FechaVcmto, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrDOCV_Estado", item.DOCV_Estado, SqlDbType.Char, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOCV_PrecVtaTotal", item.DOCV_PrecVtaTotal, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOCV_PrecVtaTotalD", item.DOCV_PrecVtaTotalD, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOCV_ValorTotal", item.DOCV_ValorTotal, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOCV_ValorTotalD", item.DOCV_ValorTotalD, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOCV_ValorVtaTotal", item.DOCV_ValorVtaTotal, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOCV_ValorVtaTotalD", item.DOCV_ValorVtaTotalD, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOCV_Descuento", item.DOCV_Descuento, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOCV_DescuentoD", item.DOCV_DescuentoD, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDOCV_Observaciones", item.DOCV_Observaciones, SqlDbType.VarChar, 1024, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOCV_Impuesto1", item.DOCV_Impuesto1, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOCV_Impuesto1D", item.DOCV_Impuesto1D, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOCV_Impuesto2", item.DOCV_Impuesto2, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOCV_Impuesto2D", item.DOCV_Impuesto2D, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOCV_Impuesto3", item.DOCV_Impuesto3, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOCV_Impuesto3D", item.DOCV_Impuesto3D, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOCV_Impuesto4", item.DOCV_Impuesto4, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOCV_Impuesto4D", item.DOCV_Impuesto4D, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOCV_PorcImp1", item.DOCV_PorcImp1, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOCV_PorcImp2", item.DOCV_PorcImp2, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOCV_PorcImp3", item.DOCV_PorcImp3, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOCV_PorcImp4", item.DOCV_PorcImp4, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDOCV_Notas", item.DOCV_Notas, SqlDbType.VarChar, 1000, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDOCV_Serie", item.DOCV_Serie, SqlDbType.VarChar, 10, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabFPG", item.TIPO_TabFPG, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodFPG", item.TIPO_CodFPG, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabMND", item.TIPO_TabMND, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodMND", item.TIPO_CodMND, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabTDO", item.TIPO_TabTDO, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodTDO", item.TIPO_CodTDO, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodANU", item.CONS_CodANU, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabANU", item.CONS_TabANU, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintPDOC_Codigo", item.PDOC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintDOCV_CodigoPadre", item.DOCV_CodigoPadre, SqlDbType.Int, 4, ParameterDirection.Input);

               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrMod", item.AUDI_UsrMod, SqlDbType.VarChar, 20, ParameterDirection.Input);

               if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
               { return true; }
               else
               { return false; }
            }
            else
            { return true; }
         }
         catch (Exception ex)
         { throw ex; }
      }

      private bool UpdateAnularFactura(ref DocsVta item)
      {
         try
         {

            DataAccessEnterpriseSQL.DAAsignarProcedure("VEN_DOCVSU_UnRegAnularFacturaOV");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintDOCV_Codigo", item.DOCV_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrMod", item.AUDI_UsrMod, SqlDbType.VarChar, 20, ParameterDirection.Input);

            if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
            { return true; }
            else
            { return false; }

         }
         catch (Exception ex)
         { throw ex; }
      }

      private bool UpdateFormaPagoFactura(ref DocsVta item)
      {
         try
         {

            DataAccessEnterpriseSQL.DAAsignarProcedure("VEN_DOCVSU_UnRegFormaPago");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintDOCV_Codigo", item.DOCV_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);

            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabFPG", item.TIPO_TabFPG, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodFPG", item.TIPO_CodFPG, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmDOCV_FechaVcmto", item.DOCV_FechaVcmto, SqlDbType.DateTime, 8, ParameterDirection.Input);

            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrMod", item.AUDI_UsrMod, SqlDbType.VarChar, 20, ParameterDirection.Input);

            if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 1)
            { return true; }
            else
            { return false; }

         }
         catch (Exception ex)
         { throw ex; }
      }

      private bool RegenerarDocumentoVenta(ref DocsVta item)
      {
         try
         {

            DataAccessEnterpriseSQL.DAAsignarProcedure("VEN_DOCVSI_RegenerarDocumento");
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", item.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintDOCV_Codigo", item.DOCV_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDOCV_Serie", item.DOCV_Serie, SqlDbType.VarChar, 20, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrMod", item.AUDI_UsrMod, SqlDbType.VarChar, 20, ParameterDirection.Input);

            if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 1)
            { return true; }
            else
            { return false; }

         }
         catch (Exception ex)
         { throw ex; }
      }

      private bool UpdateFactura(DocsVta item)
      {
         try
         {
            DataAccessEnterpriseSQL.DAAsignarProcedure("VEN_DOCVSU_Cliente");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintDOCV_Codigo", item.DOCV_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", item.ENTC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrMod", item.AUDI_UsrMod, SqlDbType.VarChar, 20, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinTIPE_Codigo", item.TIPE_Codigo, SqlDbType.SmallInt, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDOCV_Serie", item.DOCV_Serie, SqlDbType.VarChar, 20, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDOCV_Observaciones", item.DOCV_Observaciones, SqlDbType.VarChar, 1024, ParameterDirection.Input);

            if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
            { return true; }
            else
            { return false; }
         }
         catch (Exception ex)
         { throw ex; }
      }

      #endregion
   }
}
