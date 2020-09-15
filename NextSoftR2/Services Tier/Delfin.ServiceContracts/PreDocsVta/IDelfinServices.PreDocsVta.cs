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
      #region [ PreDocsVta ]

      Boolean SavePreDocsVta(ref PreDocsVta Item);

      PreDocsVta GetOnePreDocsVta(Int32 PDOC_Codigo);

      ObservableCollection<PreDocsVta> GetAllPorFiltrosLViewPreDocsVta(String x_DOCV_Numero, DateTime x_DOCV_FechaEmisionIni, DateTime x_DOCV_FechaEmisionFin, Int32? x_ENTC_Codigo, String x_Estado);

      ObservableCollection<PreDocsVta> GetAllPreDocsVtaFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);

      #endregion
   }
}
