using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Infrastructure.Aspect.BusinessLogic;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
   public partial interface IBLPreDocsVta
   {
      #region [ Consultas ]

      ObservableCollection<PreDocsVta> GetAllPorFiltrosLView(String x_DOCV_Numero, DateTime x_DOCV_FechaEmisionIni, DateTime x_DOCV_FechaEmisionFin, Int32? x_ENTC_Codigo, String x_Estado);
      ObservableCollection<PreDocsVta> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
      PreDocsVta GetOne(Int32 PDOC_Codigo);

      #endregion

      #region [ Metodos ]

      Boolean Save(ref PreDocsVta Item);
      Boolean Save(ref ObservableCollection<PreDocsVta> Items);
      Boolean SaveAnulacion(PreDocsVta Item, String TipoPrefactura);

      #endregion
   }
}
