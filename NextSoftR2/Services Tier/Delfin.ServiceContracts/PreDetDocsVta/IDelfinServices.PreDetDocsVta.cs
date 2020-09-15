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
      #region [ PreDetDocsVta ]
      
      Boolean SavePreDetDocsVta(PreDetDocsVta Item);

      
      PreDetDocsVta GetOnePreDetDocsVta(Int16 PDDO_Item, Int32 DOCV_Codigo);

      
      ObservableCollection<PreDetDocsVta> GetAllPreDetDocsVtaPorDOCV_Codigo(Int32 x_DOCV_Codigo);
      #endregion
   }
}
