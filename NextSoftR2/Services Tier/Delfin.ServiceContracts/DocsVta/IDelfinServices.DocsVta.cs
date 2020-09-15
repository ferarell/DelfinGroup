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
      #region [ DocsVta ]
      
      Boolean SaveDocsVta(ref DocsVta Item);
            
      DocsVta GetOneDocsVta(Int32 DOCV_Codigo);
            
      ObservableCollection<DocsVta> GetAllDocsVtaPorFiltrosLView(String x_DOCV_Numero, DateTime x_DOCV_FechaEmisionIni, DateTime x_DOCV_FechaEmisionFin, Int32? x_ENTC_Codigo, String x_Estado);
            
      Boolean ModificarCliente(Int32 x_DOCV_Codigo, Int32 x_ENTC_Codigo, String x_AUDI_UsrMod,Int16 x_TIPE_Codigo);

      #endregion
   }
}
