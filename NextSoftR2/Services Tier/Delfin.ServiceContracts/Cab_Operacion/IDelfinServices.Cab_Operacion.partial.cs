using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;
using Delfin.Entities;
using Delfin.BusinessLogic;

namespace Delfin.ServiceContracts
{
   public partial interface IDelfinServices
   {

      Boolean AnularOperacion(Int32 x_COPE_Codigo, String x_Estado, String x_AUDI_UsrMod);

      DataTable GetOrdendeVenta(Decimal x_NroOV);
      DataTable GetOrdendeVenta(String x_NroOV);

      DataSet GetPreLiquidacion(Int32 x_COPE_Codigo, String x_TipoPreLiquidacion);

      DataTable GetAllAyudaOperacion(Boolean Facturacion);

      DataTable GetAyudaOperacionXNumero(String x_COPE_NumDoc);

      bool GetVerificaHBLOperacion(String x_HBL);

      DataTable GetAllOperacionPreLiquidacion(Int32? x_ENTC_Codigo, String x_COPE_NumDoc, String x_COPE_HBL, DateTime x_COPE_FecEmiIni, DateTime x_COPE_FecEmiFin, Boolean x_PreFacturaconSLI);

      DataTable GetAllOperacionLiquidacion(Int32? x_ENTC_Codigo, String x_COPE_NumDoc, String x_COPE_HBL, DateTime x_COPE_FecEmiIni, DateTime x_COPE_FecEmiFin, String x_TipoReporte);

      Cab_Operacion GetOneOperacionLview(Int32 COPE_Codigo);
   }
}
