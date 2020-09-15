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
      #region [ Consultas ]

      DataTable GetCtaCteFiltros(DateTime x_Desde, DateTime x_Hasta, Int32 x_ENTC_Codigo, Boolean x_FiltroFechas);
      DataTable GetCtaCteDetalles(Int32 x_COPE_Codigo);
      DataTable GetCtaCtePendientes(Int16 x_TIPE_Codigo, Int32 x_ENTC_Codigo);
      Boolean GetCtaCteDoc_Detraccion(String x_TipoDoc, String x_Serie, String x_NroDoc, Int32 x_CodProve);
      DataTable GetOneCtaCteDT(Int16 EMPR_Codigo, Int32 x_CCCT_Codigo);

      #endregion

      #region [ Metodos ]

      CtaCte GetOneCtaCte(Int16 EMPR_Codigo, Int32 CCCT_Codigo, Entities.CtaCte.TInterfazCtaCte x_opcion);

      Boolean SaveCtaCte(ref CtaCte Item, Entities.CtaCte.TInterfazCtaCte x_opcion);
      String SaveCtaCteILD(ref CtaCte Item, String x_DOPE_Items);
      String SaveCtaCteSLI(ref CtaCte Item, String x_DOPE_Items);

      Boolean SaveCtaCteGenerarAsientosByFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters, ref String x_mensaje);

      Boolean SaveCtaCteDesvinculacion(Int16 x_EMPR_Codigo, Int32 x_CCCT_Codigo, Entities.CtaCte.TipoDesvinculacion x_opcion, Entities.CtaCte.TipoDesvAsiento x_destino, String x_usuario);

      #endregion
   }
}
