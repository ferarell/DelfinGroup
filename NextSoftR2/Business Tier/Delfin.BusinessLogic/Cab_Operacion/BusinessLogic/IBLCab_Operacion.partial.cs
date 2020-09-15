using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Infrastructure.Aspect.BusinessLogic;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
   public partial interface IBLCab_Operacion
   {
      #region [ Consultas ]

      DataTable GetAllAyudaOperacion(Boolean Facturacion);
      DataTable GetAyudaOperacionXNumero(String x_COPE_NumDoc);
      DataSet GetPreLiquidacion(Int32 x_COPE_Codigo, String x_TipoPreLiquidacion);
      DataTable GetOrdendeVenta(Decimal x_NroOV);
      DataTable GetOrdendeVenta(String x_NroOV);
      DataTable GetAllOperacionPreLiquidacion(Int32? x_ENTC_Codigo, String x_COPE_NumDoc, String x_COPE_HBL, DateTime x_COPE_FecEmiIni, DateTime x_COPE_FecEmiFin, Boolean x_PreFacturaconSLI);
      DataTable GetAllOperacionLiquidacion(Int32? x_ENTC_Codigo, String x_COPE_NumDoc, String x_COPE_HBL, DateTime x_COPE_FecEmiIni, DateTime x_COPE_FecEmiFin, String x_TipoReporte);

      Cab_Operacion GetOneLview(Int32 COPE_Codigo);
      #endregion

      #region [ Metodos ]
      Boolean AnularOperacion(Int32 x_COPE_Codigo, String x_Estado, String x_AUDI_UsrMod);
      bool GetVerificaHBL(String x_HBL);

      #endregion
   }
}
