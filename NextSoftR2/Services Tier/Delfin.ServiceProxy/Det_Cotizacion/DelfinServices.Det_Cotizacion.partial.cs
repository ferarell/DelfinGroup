using System;
using System.Collections.Generic;
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
   using System.Data;

   public partial class DelfinServicesProxy : IDelfinServices
   {
       public ObservableCollection<Det_Cotizacion> GetAllDet_CotizacionByOperacion(Int32? x_CTAR_CodigoLogistico, Int32? x_CTAR_CodigoAduanero, Int32? x_CTAR_CodigoTransporte)
       {
           try
           {
               return BL_Det_Cotizacion.GetAllDet_CotizacionByOperacion(x_CTAR_CodigoLogistico, x_CTAR_CodigoAduanero, x_CTAR_CodigoTransporte);
           }
           catch (Exception ex)
           { throw ex; }
       }
       public DataTable GetAllAyudaCotizacion(Int32? x_ENTC_CodigoCliente, Int32? x_ENTC_CodigoLNaviera, String x_NroCotizacion, String x_CTAR_Tipo , Int32 x_CCOT_Codigo)
       {
           try
           {
               return  BL_Det_Cotizacion.GetAllAyudaCotizacion(x_ENTC_CodigoCliente,x_ENTC_CodigoLNaviera,x_NroCotizacion, x_CTAR_Tipo, x_CCOT_Codigo);
           }
           catch (Exception ex)
           { throw ex; }
       }
   }
}
