using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Infrastructure.Aspect.BusinessLogic;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
   public partial interface IBLDocsVta
   {
      #region [ Consultas ]

      DataSet GetAllImpresionFactura(Int32 x_DOCV_Codigo);
      DataSet GetDS(string x_procedure, List<object> filters);
      DataSet GetDS(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters, Boolean x_transaccion = false);
      ObservableCollection<DocsVta> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
      DocsVta GetOne(Int16 EMPR_Codigo, Int32 DOCV_Codigo);
      #endregion

      #region [ Metodos ]

      DataSet GetImpresionDS(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters, String x_usuario, Int16 x_sucr_codigo, Boolean x_transaccion = false);
      DataSet GetImpresionFEDS(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters, String x_usuario, Int16 x_sucr_codigo, Boolean x_transaccion = false, String Email = "");
      Boolean SaveFacturacion(DocsVta Item);
      Boolean Save(ref DocsVta Item, Entities.DocsVta.TInterfazDocsVta x_opcion);
      bool AnularDocsVtaFacturacion(DocsVta item, string TipDocVta);

      #endregion
   }
}
