using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Practices.Unity;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Infrastructure.Aspect.DataAccess;
using Delfin.Entities;
namespace Delfin.BusinessLogic
{
   public partial interface IBLDet_Operacion
   {
      #region [ Consultas ]
      DataTable GetAyudaOperacionXProveedor(Int32 x_COPE_Codigo, String x_Moneda, Decimal x_TipoCambio, Int32 x_CCCT_Codigo);
      Boolean UpdateEstado(Int32 x_COPE_Codigo, String x_CTAR_Tipo, Int32 x_CCCT_Codigo, Int16 x_TIPE_Codigo, Int32 x_ENTC_Codigo, Decimal x_Monto, Boolean x_UltimoMonto, String x_Usuario, String x_DOPE_Items);
      Boolean DeleteServicioCtaCte(CtaCte ItemCtaCte);
      ObservableCollection<Det_Operacion> GetAllByDOCV_Codigo(Int32 x_DOCV_Codigo);
      DataTable GetServicioByOperacion(Int32 x_COPE_Codigo);
      DataTable GetVerificaServicioFacturado(Int32 x_COPE_Codigo, Int32 x_DOPE_Item);
      #endregion

      #region [ Metodos ]

      Boolean UpdateDetOperacionPreFactura(Int32 x_COPE_Codigo, Int32 x_DOPE_Item, Int16 x_PDDO_Item, Int32 x_DOCV_Codigo, String x_CONS_CodEST);
      #endregion
   }
}
