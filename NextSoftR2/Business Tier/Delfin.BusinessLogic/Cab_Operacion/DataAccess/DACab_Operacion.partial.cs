using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Infrastructure.Aspect.BusinessEntity;
using Microsoft.Practices.Unity;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Infrastructure.Aspect.DataAccess;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial class BLCab_Operacion
	{
		#region [ Consultas ]
      public DataTable SelectOrdendeVenta(Decimal x_NroOV)
      {
         try
         {
            DataSet _dt = new DataSet();
            DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_OPESS_SeleccionarOV");
            DataAccessEnterpriseSQL.DAAgregarParametro("@NumOV", x_NroOV, SqlDbType.Decimal, 12, ParameterDirection.Input);
            _dt = DataAccessEnterpriseSQL.DAExecuteDataSet();
            if (_dt != null && _dt.Tables.Count > 0 && _dt.Tables[0].Rows.Count > 0)
            {
               return _dt.Tables[0];
            }
            return null;
         }
         catch (Exception ex)
         { throw ex; }
      }
      public DataTable SelectOrdendeVenta(String x_NroOV)
      {
         try
         {
            DataSet _dt = new DataSet();
            DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_OPESS_SeleccionarOVv2");
            DataAccessEnterpriseSQL.DAAgregarParametro("@NumOV", x_NroOV, SqlDbType.VarChar, 20, ParameterDirection.Input);
            _dt = DataAccessEnterpriseSQL.DAExecuteDataSet();
            if (_dt != null && _dt.Tables.Count > 0 && _dt.Tables[0].Rows.Count > 0)
            {
               return _dt.Tables[0];
            }
            return null;
         }
         catch (Exception ex)
         { throw ex; }
      }
      public DataSet SelectPreLiquidacion(Int32 x_COPE_Codigo,String x_TipoPreLiquidacion)
      {
            try
            {
                DataSet _dt = new DataSet();
                if (!String.IsNullOrEmpty(x_TipoPreLiquidacion))
                {
                    if (x_TipoPreLiquidacion.Equals("Liquidacion")) /* Liquidacion :) */
                    {
                        DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_COPESS_Liquidacion");
                    }
                    else /* Con Servicio Logistico  y Sin Servicio Logistico:) */
                    {
                        DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_COPESS_PreLiquidacion");
                    }
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintCOPE_Codigo", x_COPE_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
                    _dt = DataAccessEnterpriseSQL.DAExecuteDataSet();
                }
                return _dt;
            }
            catch (Exception ex)
            { throw ex; }
      }
        public DataTable SelectAllAyudaOperacion(Boolean Facturacion)
        {
            try
            {
                DataSet _dt = new DataSet();
                DataAccessEnterpriseSQL.DAAsignarProcedure(Facturacion ? "SLI_COPESS_TodosAyudaFacturacion": "SLI_COPESS_TodosAyuda");
                _dt = DataAccessEnterpriseSQL.DAExecuteDataSet();
                if (_dt != null && _dt.Tables.Count > 0 && _dt.Tables[0].Rows.Count > 0)
                {
                    return _dt.Tables[0];
                }
                return null;
            }
            catch (Exception ex)
            { throw ex; }
        }
      
         public DataTable SelectAyudaOperacionXNumero(String x_COPE_NumDoc)
        {
            try
            {
                DataSet _dt = new DataSet();
                DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_COPESS_TodosByNumero");
                DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCOPE_NumDoc", x_COPE_NumDoc, SqlDbType.VarChar, 11, ParameterDirection.Input);

                _dt = DataAccessEnterpriseSQL.DAExecuteDataSet();
                if (_dt != null && _dt.Tables.Count > 0 && _dt.Tables[0].Rows.Count > 0)
                {
                    return _dt.Tables[0];
                }
                return null;
            }
            catch (Exception ex)
            { throw ex; }
        }
         private DataTable SelectAllOperacionPreLiquidacion(Int32? x_ENTC_Codigo, String x_COPE_NumDoc,String x_COPE_HBL, DateTime x_COPE_FecEmiIni, DateTime x_COPE_FecEmiFin,Boolean x_PreFacturaconSLI)
         {
             try
             {
                 DataSet _dt = new DataSet();
                 DataAccessEnterpriseSQL.DAAsignarProcedure(x_PreFacturaconSLI ? "SLI_COPESS_TodosReportePreLiquidacionConSLI" : "SLI_COPESS_TodosReportePreLiquidacionSinSLI");
                 if (x_ENTC_Codigo != null)
                 {
                     DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", x_ENTC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
                 }
                 else
                 {
                     DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", DBNull.Value, SqlDbType.Int, 4, ParameterDirection.Input);
                 }
                 if (!String.IsNullOrEmpty(x_COPE_NumDoc))
                 {
                     DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCOPE_NumDoc", x_COPE_NumDoc, SqlDbType.VarChar, 11, ParameterDirection.Input);
                 }
                 else
                 {
                     DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCOPE_NumDoc", DBNull.Value, SqlDbType.VarChar, 11, ParameterDirection.Input);
                 }
                 if (!String.IsNullOrEmpty(x_COPE_HBL))
                 {
                     DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCOPE_HBL", x_COPE_HBL, SqlDbType.VarChar, 20, ParameterDirection.Input);
                 }
                 else
                 {
                     DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCOPE_HBL", DBNull.Value, SqlDbType.VarChar, 20, ParameterDirection.Input);
                 }
                 DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCOPE_FecEmiIni", x_COPE_FecEmiIni, SqlDbType.DateTime, 8, ParameterDirection.Input);
                 DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCOPE_FecEmiFin", x_COPE_FecEmiFin, SqlDbType.DateTime, 8, ParameterDirection.Input);
                 _dt = DataAccessEnterpriseSQL.DAExecuteDataSet();
                 if (_dt != null && _dt.Tables.Count > 0 && _dt.Tables[0].Rows.Count > 0)
                 {
                     return _dt.Tables[0];
                 }
                 return null;
             }
             catch (Exception ex)
             { throw ex; }
         }

         private DataTable SelectAllOperacionLiquidacion(Int32? x_ENTC_Codigo, String x_COPE_NumDoc, String x_COPE_HBL, DateTime x_COPE_FecEmiIni, DateTime x_COPE_FecEmiFin, String x_TipoReporte)
         {
             try
             {
                 DataSet _dt = new DataSet();
                 DataAccessEnterpriseSQL.DAAsignarProcedure(x_TipoReporte.Equals("Resumido") ? "SLI_COPESS_TodosReporteLiquidacion" : "SLI_COPESS_TodosReporteLiquidacionDetallado");
                 if (x_ENTC_Codigo != null)
                 {
                     DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", x_ENTC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
                 }
                 else
                 {
                     DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", DBNull.Value, SqlDbType.Int, 4, ParameterDirection.Input);
                 }
                 if (!String.IsNullOrEmpty(x_COPE_NumDoc))
                 {
                     DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCOPE_NumDoc", x_COPE_NumDoc, SqlDbType.VarChar, 11, ParameterDirection.Input);
                 }
                 else
                 {
                     DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCOPE_NumDoc", DBNull.Value, SqlDbType.VarChar, 11, ParameterDirection.Input);
                 }
                 if (!String.IsNullOrEmpty(x_COPE_HBL))
                 {
                     DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCOPE_HBL", x_COPE_HBL, SqlDbType.VarChar, 20, ParameterDirection.Input);
                 }
                 else
                 {
                     DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCOPE_HBL", DBNull.Value, SqlDbType.VarChar, 20, ParameterDirection.Input);
                 }
                 DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCOPE_FecEmiIni", x_COPE_FecEmiIni, SqlDbType.DateTime, 8, ParameterDirection.Input);
                 DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCOPE_FecEmiFin", x_COPE_FecEmiFin, SqlDbType.DateTime, 8, ParameterDirection.Input);
                 _dt = DataAccessEnterpriseSQL.DAExecuteDataSet();
                 if (_dt != null && _dt.Tables.Count > 0 && _dt.Tables[0].Rows.Count > 0)
                 {
                     return _dt.Tables[0];
                 }
                 return null;
             }
             catch (Exception ex)
             { throw ex; }
         }
         private Cab_Operacion SelectOneLview(Int32 COPE_Codigo)
         {
             try
             {
                 Cab_Operacion item = new Cab_Operacion();
                 DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_COPESS_GetOneByLView");
                 DataAccessEnterpriseSQL.DAAgregarParametro("@pintCOPE_Codigo", COPE_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
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
		#endregion

		#region [ Metodos ]
        private bool Anular(Int32 x_COPE_Codigo, String x_Estado, String x_AUDI_UsrMod)
        {
            try
            {
                DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_COPESU_UnReg_AnularOperacion");
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintCOPE_Codigo", x_COPE_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodEstado", x_Estado, SqlDbType.Char, 3, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrMod", x_AUDI_UsrMod, SqlDbType.VarChar, 20, ParameterDirection.Input);
                if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
                { return true; }
                return false;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private bool VerificaHBL( String x_HBL)
        {
            try
            {
                DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_COPESU_ExisteHBLOperacion");
                DataAccessEnterpriseSQL.DAAgregarParametro("@pvchHBL", x_HBL, SqlDbType.VarChar, 20, ParameterDirection.Input);
                DataSet dt = DataAccessEnterpriseSQL.DAExecuteDataSet();
                return dt.Tables.Count > 0 && dt.Tables[0].Rows.Count > 0;
            }
            catch (Exception ex)
            { throw ex; }
        }
		#endregion
	}
}
