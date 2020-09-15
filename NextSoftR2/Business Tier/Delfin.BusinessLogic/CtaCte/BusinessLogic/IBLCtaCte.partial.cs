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
   public partial interface IBLCtaCte
   {
      #region [ Consultas ]
      DataTable GetCtaCteFiltros(DateTime x_Desde, DateTime x_Hasta, Int32 x_ENTC_Codigo, Boolean x_FiltroFechas);
      DataTable GetCtaCteDetalles(Int32 x_COPE_Codigo);
      DataTable GetCtaCtePendientes(Int16 x_TIPE_Codigo, Int32 x_ENTC_Codigo);

      CtaCte GetOne(Int16 EMPR_Codigo, Int32 CCCT_Codigo, Entities.CtaCte.TInterfazCtaCte x_opcion);
      DataTable GetOneCtaCteDT(Int16 EMPR_Codigo, Int32 x_CCCT_Codigo);
      #endregion

      #region [ Metodos ]

      Boolean Save(ref CtaCte Item, Entities.CtaCte.TInterfazCtaCte x_opcion);
      String SaveCCCTILD(ref CtaCte Item, String x_DOPE_Items);
      String SaveCCCTSLI(ref CtaCte Item, String x_DOPE_Items);
      Boolean GetBuscarDoc_Detraccion(String x_TipoDoc, String x_Serie, String x_NroDoc, Int32 x_CodProve);
      Boolean SaveGenerarAsientosByFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters, ref String x_mensaje);

      Boolean SaveDesvinculacion(Int16 x_EMPR_Codigo, Int32 x_CCCT_Codigo, Entities.CtaCte.TipoDesvinculacion x_opcion, Entities.CtaCte.TipoDesvAsiento x_destino, String x_usuario);
      #endregion
   }
}
