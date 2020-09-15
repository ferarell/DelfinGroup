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
       #region [ Consultas ]
       public ObservableCollection<Cab_Tarifa> GetAllByFiltrosTarifario(Int32? LineaNaviera, Int32? AgMaritimo, Int32? DepTemporal,
     Int32? DepVacio, Int32? AgAduana, Int32? Transporte, DateTime FecEmiDesde, DateTime FecEmiHasta, String TipoTarifa)
       {
           try
           {
               return BL_Cab_Tarifa.GetAllByFiltros(LineaNaviera, AgMaritimo, DepTemporal, DepVacio, AgAduana, Transporte, FecEmiDesde, FecEmiHasta, TipoTarifa);
           }
           catch (Exception ex)
           { throw ex; }
       }

       public DataTable GetAllAyudaTarifa(String x_NroTarifa, String x_DescripTarifa, String x_CTAR_Tipo, Int32 x_CTAR_Codigo)
       {
           try
           {
               return BL_Cab_Tarifa.GetAllAyudaTarifa(x_NroTarifa, x_DescripTarifa, x_CTAR_Tipo,x_CTAR_Codigo);
           }
           catch (Exception ex)
           { throw ex; }
       } 
       #endregion
       #region [Metodos]
        public Boolean ValidarCopiaTarifa(DateTime x_CTAR_FecIni, DateTime x_CTAR_FecFin, String x_CONS_CodReg, String x_TIPO_CodMnd, Int32 x_ENTC_CodigoLineaNaviera)
        {
            try
            {
                bool mIsCorrect = BL_Cab_Tarifa.ValidarCopiaTarifa(x_CTAR_FecIni, x_CTAR_FecFin, x_CONS_CodReg, x_TIPO_CodMnd, x_ENTC_CodigoLineaNaviera);
                return mIsCorrect;
            }
            catch (Exception ex)
            { throw ex; }
        }
       #endregion

   }
}
