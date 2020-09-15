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
       
      DataTable GetAllServiciosPreFactura(Int32 x_COPE_Codigo, String x_TIPO_CodMND, Decimal x_TIPO_Cambio);

       
       DataTable GetOneCORR_SerieFactura(String x_CORR_ServerName, String x_CORR_CodCorr);

       
       Boolean SaveAnulacionPreFacturaPreDocsVta(PreDocsVta Item, String TipoPrefactura);
   }
}
