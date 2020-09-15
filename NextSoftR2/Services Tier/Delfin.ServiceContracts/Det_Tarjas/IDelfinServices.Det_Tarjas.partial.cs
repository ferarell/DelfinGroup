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
       
       DataTable GetAllDet_TarjasServiciosFacturacion(Int32 x_DOCV_Codigo, String x_TIPO_CodMND, Decimal x_TipoCambio);

   }
}
