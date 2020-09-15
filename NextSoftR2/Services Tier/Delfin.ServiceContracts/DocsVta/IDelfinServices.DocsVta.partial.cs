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

      Boolean SaveDocsVtaFacturacion(DocsVta Item);

      Boolean SaveDocsVta(ref DocsVta Item, Entities.DocsVta.TInterfazDocsVta x_opcion);

      bool AnularDocsVtaFacturacion(DocsVta item, string TipDocVta);

      DataSet GetAllDocsVtaImpresionFactura(Int32 x_DOCV_Codigo);

      DataSet GetDS(string x_procedure, List<object> filters);

      DataSet GetImpresionDSDocsVta(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters, String x_usuario, Int16 x_sucr_codigo, Boolean x_transaccion = false);

      DataSet GetImpresionFEDSDocsVta(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters, String x_usuario, Int16 x_sucr_codigo, Boolean x_transaccion = false, String Email = "");

      DataSet GetDSDocsVta(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters, Boolean x_transaccion = false);
      ///DataSet GetImpresionDSDocsVta(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters, String x_usuario, Int16 x_sucr_codigo, Boolean x_transaccion = false);

      [OperationContract]
      ObservableCollection<DocsVta> GetAllDocsVtaFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);

      DocsVta GetOneDocsVta(Int16 EMPR_Codigo, Int32 DOCV_Codigo);
   }
}
