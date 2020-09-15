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
       
       ObservableCollection<Cab_Tarjas> GetAllTarjasPorFiltros(DateTime x_FecIni, DateTime x_FecFin);

       
       DataTable GetAllAyudaTarjasFacturacion();

       
       DataSet GetAllTarjasRebatesReporte(Int32? x_ENTC_Codigo, String x_COPE_NumDoc, String x_COPE_HBL, DateTime x_COPE_FecEmiIni, DateTime x_COPE_FecEmiFin);
   }
}
