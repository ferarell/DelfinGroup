using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Infrastructure.Aspect.BusinessLogic;
using Delfin.BusinessLogic;
using Delfin.Entities;
using Infrastructure.Aspect.DataAccess;

namespace Delfin.BusinessLogic
{
   public partial class BLCab_Operacion
   {
      #region [ Consultas ]
      public DataSet GetPreLiquidacion(Int32 x_COPE_Codigo, String x_TipoPreLiquidacion)
      {
         try
         {
            return SelectPreLiquidacion(x_COPE_Codigo, x_TipoPreLiquidacion);
         }
         catch (Exception ex)
         { throw ex; }
      }
      public DataTable GetOrdendeVenta(Decimal x_NroOV)
      {
         try
         {
            return SelectOrdendeVenta(x_NroOV);
         }
         catch (Exception ex)
         { throw ex; }

      }
      public DataTable GetOrdendeVenta(String x_NroOV)
      {
         try
         {
            return SelectOrdendeVenta(x_NroOV);
         }
         catch (Exception ex)
         { throw ex; }

      }
      public DataTable GetAllAyudaOperacion(Boolean Facturacion)
      {
         try
         {
            return SelectAllAyudaOperacion(Facturacion);
         }
         catch (Exception ex)
         { throw ex; }
      }
      public DataTable GetAyudaOperacionXNumero(String x_COPE_NumDoc)
      {
         try
         {
            return SelectAyudaOperacionXNumero(x_COPE_NumDoc);
         }
         catch (Exception ex)
         { throw ex; }
      }
      public DataTable GetAllOperacionPreLiquidacion(Int32? x_ENTC_Codigo, String x_COPE_NumDoc, String x_COPE_HBL, DateTime x_COPE_FecEmiIni, DateTime x_COPE_FecEmiFin, Boolean x_PreFacturaconSLI)
      {
         try
         {
            return SelectAllOperacionPreLiquidacion(x_ENTC_Codigo, x_COPE_NumDoc, x_COPE_HBL, x_COPE_FecEmiIni, x_COPE_FecEmiFin, x_PreFacturaconSLI);
         }
         catch (Exception ex)
         { throw ex; }
      }
      public DataTable GetAllOperacionLiquidacion(Int32? x_ENTC_Codigo, String x_COPE_NumDoc, String x_COPE_HBL, DateTime x_COPE_FecEmiIni, DateTime x_COPE_FecEmiFin, String x_TipoReporte)
      {
         try
         {
            return SelectAllOperacionLiquidacion(x_ENTC_Codigo, x_COPE_NumDoc, x_COPE_HBL, x_COPE_FecEmiIni, x_COPE_FecEmiFin, x_TipoReporte);
         }
         catch (Exception ex)
         { throw ex; }
      }
      public Cab_Operacion GetOneLview(Int32 COPE_Codigo)
      {
         try
         {
            return SelectOneLview(COPE_Codigo);
         }
         catch (Exception ex)
         { throw ex; }
      }
      #endregion

      #region [ Metodos ]
      public Boolean AnularOperacion(Int32 x_COPE_Codigo, String x_Estado, String x_AUDI_UsrMod)
      {
         try
         {
            Boolean m_isCorrect = true;
            Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DABeginTransaction();
            m_isCorrect = Anular(x_COPE_Codigo, x_Estado, x_AUDI_UsrMod);
            if (m_isCorrect)
            { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DACommitTransaction(); }
            else
            { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); }
            return m_isCorrect;
         }
         catch (Exception)
         { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); throw; }
      }
      public bool GetVerificaHBL(String x_HBL)
      {
         try
         {
            return VerificaHBL(x_HBL);
         }
         catch (Exception ex)
         { throw ex; }
      }

      #endregion
   }
}
