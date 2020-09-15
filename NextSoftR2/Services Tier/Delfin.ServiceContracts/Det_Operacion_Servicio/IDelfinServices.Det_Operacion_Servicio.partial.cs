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
       
       DataSet GetAllServiciosAdicionalesReporte(Int32? x_ENTC_Codigo, DateTime x_COPE_FecEmiIni,DateTime x_COPE_FecEmiFin, String x_TipoReporteAdicional);
   }
}
