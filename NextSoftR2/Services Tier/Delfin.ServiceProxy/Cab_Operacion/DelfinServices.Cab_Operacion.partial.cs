using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.ServiceModel.Activation;
using System.Collections.ObjectModel;
using Microsoft.Practices.Unity;
using Infrastructure.Aspect.DataAccess;

namespace Delfin.ServiceProxy
{
   using Delfin.ServiceContracts;
   using Delfin.BusinessLogic;
   using Delfin.Entities;

   public partial class DelfinServicesProxy : IDelfinServices
   {
       public Boolean AnularOperacion(Int32 x_COPE_Codigo, String x_Estado, String x_AUDI_UsrMod)
       {
           try
           {
               return BL_Cab_Operacion.AnularOperacion(x_COPE_Codigo, x_Estado, x_AUDI_UsrMod);
               
           }
           catch (Exception ex)
           { throw ex; }
       }

       public DataTable GetOrdendeVenta(Decimal x_NroOV)
       {
          try
          {
             return BL_Cab_Operacion.GetOrdendeVenta(x_NroOV);
          }
          catch (Exception ex)
          { throw ex; }
       }

       public DataTable GetOrdendeVenta(String x_NroOV)
       {
          try
          {
             return BL_Cab_Operacion.GetOrdendeVenta(x_NroOV);
          }
          catch (Exception ex)
          { throw ex; }
       }

       public DataSet GetPreLiquidacion(Int32 x_COPE_Codigo, String x_TipoPreLiquidacion)
       {
          try
          {
             return BL_Cab_Operacion.GetPreLiquidacion(x_COPE_Codigo,x_TipoPreLiquidacion);
          }
          catch (Exception ex)
          { throw ex; }
       }
      
       public DataTable GetAllAyudaOperacion(Boolean Facturacion)
       {
          try
          {
             return BL_Cab_Operacion.GetAllAyudaOperacion(Facturacion);
          }
          catch (Exception ex)
          { throw ex; }
       }
       public DataTable GetAyudaOperacionXNumero(String x_COPE_NumDoc)
       {
           try
           {
              return BL_Cab_Operacion.GetAyudaOperacionXNumero(x_COPE_NumDoc);
           }
           catch (Exception ex)
           { throw ex; }
       }
       public bool GetVerificaHBLOperacion(String x_HBL)
       {
           try
           {
               return BL_Cab_Operacion.GetVerificaHBL(x_HBL);
           }
           catch (Exception ex)
           { throw ex; }
       }
       public DataTable GetAllOperacionPreLiquidacion(Int32? x_ENTC_Codigo, String x_COPE_NumDoc, String x_COPE_HBL, DateTime x_COPE_FecEmiIni, DateTime x_COPE_FecEmiFin, Boolean x_PreFacturaconSLI)
       {
           try
           {
               return BL_Cab_Operacion.GetAllOperacionPreLiquidacion(x_ENTC_Codigo, x_COPE_NumDoc, x_COPE_HBL, x_COPE_FecEmiIni, x_COPE_FecEmiFin,x_PreFacturaconSLI);
           }
           catch (Exception ex)
           { throw ex; }
       }

       public DataTable GetAllOperacionLiquidacion(Int32? x_ENTC_Codigo, String x_COPE_NumDoc, String x_COPE_HBL, DateTime x_COPE_FecEmiIni, DateTime x_COPE_FecEmiFin, String x_TipoReporte)
       {
           try
           {
               return BL_Cab_Operacion.GetAllOperacionLiquidacion(x_ENTC_Codigo, x_COPE_NumDoc, x_COPE_HBL, x_COPE_FecEmiIni, x_COPE_FecEmiFin, x_TipoReporte);
           }
           catch (Exception ex)
           { throw ex; }
       }
       public Cab_Operacion GetOneOperacionLview(Int32 COPE_Codigo)
       {
           try
           {
               return BL_Cab_Operacion.GetOneLview(COPE_Codigo);
           }
           catch (Exception ex)
           { throw ex; }
       }
   }
}
