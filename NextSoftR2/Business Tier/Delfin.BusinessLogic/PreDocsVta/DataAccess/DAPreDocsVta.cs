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
using Infrastructure.Aspect.BusinessEntity;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
   public partial class BLPreDocsVta
   {
      #region [ Propiedades ]
      public IUnityContainer ContainerService { get; set; }
      public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<PreDocsVta> Loader { get; set; }
      #endregion

      #region [ Constructores ]
      public BLPreDocsVta(IUnityContainer container)
      {
         this.ContainerService = container;
         Loader = new BusinessEntityLoader<PreDocsVta>();
         PreDocsVta item = new PreDocsVta();
         Loader.EntityType = item.GetType();
      }
      #endregion

      #region [ Consultas ]
      private ObservableCollection<PreDocsVta> SelectAllPorFiltrosLView(String x_DOCV_Numero, DateTime x_DOCV_FechaEmisionIni, DateTime x_DOCV_FechaEmisionFin, Int32? x_ENTC_Codigo, String x_Estado)
      {
         try
         {
            ObservableCollection<PreDocsVta> items = new ObservableCollection<PreDocsVta>();
            PreDocsVta item = new PreDocsVta();
            DataAccessEnterpriseSQL.DAAsignarProcedure("VEN_PDOCSS_TodosPorFiltros");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDOCV_Numero", x_DOCV_Numero, SqlDbType.VarChar, 20, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmDOCV_FechaEmisionIni", x_DOCV_FechaEmisionIni, SqlDbType.DateTime, 8, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmDOCV_FechaEmisionFin", x_DOCV_FechaEmisionFin, SqlDbType.DateTime, 8, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", x_ENTC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            if (x_Estado == null)
               DataAccessEnterpriseSQL.DAAgregarParametro("@Estado", DBNull.Value, SqlDbType.Char, 1, ParameterDirection.Input);
            else
               DataAccessEnterpriseSQL.DAAgregarParametro("@Estado", x_Estado, SqlDbType.Char, 1, ParameterDirection.Input);
            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               while (reader.Read())
               {
                  item = new PreDocsVta();
                  Loader.LoadEntity(reader, item);
                  item.Instance = InstanceEntity.Unchanged;
                  items.Add(item);
               }
            }
            return items;
         }
         catch (Exception ex)
         { throw ex; }
      }
      private PreDocsVta SelectOne(Int32 PDOC_Codigo)
      {
         try
         {
            PreDocsVta item = new PreDocsVta();
            DataAccessEnterpriseSQL.DAAsignarProcedure("VEN_PDOCSS_UnReg");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintPDOC_Codigo", PDOC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               if (reader.Read())
               {
                  Loader.LoadEntity(reader, item);
                  item.Instance = InstanceEntity.Unchanged;
               }
            }
            return item;
         }
         catch (Exception ex)
         { throw ex; }
      }
      private ObservableCollection<PreDocsVta> SelectAllByFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            ObservableCollection<PreDocsVta> items = new ObservableCollection<PreDocsVta>();
            PreDocsVta item = new PreDocsVta();
            if (!String.IsNullOrEmpty(x_procedure))
            { DataAccessEnterpriseSQL.DAAsignarProcedure(x_procedure); }
            else
            { DataAccessEnterpriseSQL.DAAsignarProcedure("VEN_PDOCSS_TodosByFilters"); }
            if (x_filters != null && x_filters.Count > 0)
            {
               foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
               { DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
            }
            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               while (reader.Read())
               {
                  item = new PreDocsVta();
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
      #endregion

      #region [ Metodos ]
      private bool Insert(ref PreDocsVta item)
      {
         try
         {
            if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
            {
               DataAccessEnterpriseSQL.DAAsignarProcedure("VEN_PDOCSI_UnReg");
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintPDOC_Codigo", item.PDOC_Codigo, SqlDbType.Int, 4, ParameterDirection.InputOutput);
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
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabTDO", item.TIPO_TabTDO, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodTDO", item.TIPO_CodTDO, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabMND", item.TIPO_TabMND, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodMND", item.TIPO_CodMND, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodANU", item.CONS_CodANU, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabANU", item.CONS_TabANU, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", item.ENTC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinTIPE_Codigo", item.TIPE_Codigo, SqlDbType.SmallInt, 4, ParameterDirection.Input);

               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrCrea", item.AUDI_UsrCrea, SqlDbType.VarChar, 20, ParameterDirection.Input);

               if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
               {
                  Int32 _PDOC_Codigo;
                  if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintPDOC_Codigo"].Value.ToString(), out _PDOC_Codigo))
                  { item.PDOC_Codigo = _PDOC_Codigo; }
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
      private bool Update(ref PreDocsVta item)
      {
         try
         {
            if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
            {
               DataAccessEnterpriseSQL.DAAsignarProcedure("VEN_PDOCSU_UnReg");
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintPDOC_Codigo", item.PDOC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
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
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabTDO", item.TIPO_TabTDO, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodTDO", item.TIPO_CodTDO, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabMND", item.TIPO_TabMND, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodMND", item.TIPO_CodMND, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodANU", item.CONS_CodANU, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabANU", item.CONS_TabANU, SqlDbType.Char, 3, ParameterDirection.Input);

               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrMod", item.AUDI_UsrMod, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", item.ENTC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinTIPE_Codigo", item.TIPE_Codigo, SqlDbType.SmallInt, 4, ParameterDirection.Input);
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
      private bool Delete(ref PreDocsVta item)
      {
         try
         {
            if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
            {
               DataAccessEnterpriseSQL.DAAsignarProcedure("VEN_PDOCSD_UnReg");
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintPDOC_Codigo", item.PDOC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);

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
      #endregion
   }
}
