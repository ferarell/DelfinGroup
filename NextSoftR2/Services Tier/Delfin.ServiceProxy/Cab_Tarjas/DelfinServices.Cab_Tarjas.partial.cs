using System;
using System.Collections.Generic;
using System.Data;
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

   public partial class DelfinServicesProxy : IDelfinServices
   {
       public ObservableCollection<Cab_Tarjas> GetAllTarjasPorFiltros(DateTime x_FecIni, DateTime x_FecFin)
       {
           try
           {
               return BL_Cab_Tarjas.GetAllTarjasPorFiltros(x_FecIni, x_FecFin);
           }
           catch (Exception ex)
           { throw ex; }
       }
       public DataTable GetAllAyudaTarjasFacturacion()
       {
           try
           {
               return BL_Cab_Tarjas.GetAyudaTarjas();
           }
           catch (Exception ex)
           { throw ex; }
       }
       public DataSet GetAllTarjasRebatesReporte(Int32? x_ENTC_Codigo, String x_COPE_NumDoc, String x_COPE_HBL, DateTime x_COPE_FecEmiIni, DateTime x_COPE_FecEmiFin)
       {
           try
           {
               return BL_Cab_Tarjas.GetAllTarjasRebate(x_ENTC_Codigo, x_COPE_NumDoc, x_COPE_HBL, x_COPE_FecEmiIni, x_COPE_FecEmiFin);
           }
           catch (Exception ex)
           { throw ex; }
       }
   }
}
