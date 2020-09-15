using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
       
       ObservableCollection<Det_Tarifa> GetAllDet_TarifaByTarifario(Int32 x_CTAR_Codigo, String x_CTAR_Tipo);

       
       ObservableCollection<Det_Tarifa> GetAllTarifasByCotizacion(Int32? x_CTAR_CodigoLogistico, Int32? x_CTAR_CodigoAduanero, Int32? x_CTAR_CodigoTransporte, Boolean x_Filtros);
   }
}
