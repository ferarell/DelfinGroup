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
      #region [ DetDocsVta ]
      
      Boolean SaveDetDocsVta(DetDocsVta Item);

      
      DetDocsVta GetOneDetDocsVta(Int16 DDOV_Item, Int32 DOCV_Codigo);

      
      ObservableCollection<DetDocsVta> GetAllDetDocsVta();
      #endregion
   }
}
