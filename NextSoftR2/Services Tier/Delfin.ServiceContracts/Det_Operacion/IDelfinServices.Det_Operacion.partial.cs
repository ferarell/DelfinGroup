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
      
      DataTable GetAyudaOperacionXProveedor(Int32 x_COPE_Codigo, String x_Moneda, Decimal x_TipoCambio, Int32 x_CCCT_Codigo);

      
      ObservableCollection<Det_Operacion> GetAllDetOperacvionByDOCV_Codigo(Int32 x_DOCV_Codigo);
      DataTable GetServicioByOperacion(Int32 x_COPE_Codigo);
      DataTable GetServicioFacturado(Int32 x_COPE_Codigo, Int32 x_DOPE_Item);
   }
}
