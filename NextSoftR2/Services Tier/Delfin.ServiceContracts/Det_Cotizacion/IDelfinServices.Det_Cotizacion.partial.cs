using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;
using Delfin.Entities;
using Delfin.BusinessLogic;
using System.Data;

namespace Delfin.ServiceContracts
{
   public partial interface IDelfinServices
   {
       
       ObservableCollection<Det_Cotizacion> GetAllDet_CotizacionByOperacion(Int32? x_CTAR_CodigoLogistico, Int32? x_CTAR_CodigoAduanero, Int32? x_CTAR_CodigoTransporte);

       
       DataTable GetAllAyudaCotizacion(Int32? x_ENTC_CodigoCliente, Int32? x_ENTC_CodigoLNaviera, String x_NroCotizacion, String x_CTAR_Tipo, Int32 x_CCOT_Codigo);
   }
}
