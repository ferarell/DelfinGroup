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
      #region [ DetDocsVta_Det_Operacion ]
      
      Boolean SaveDetDocsVta_Det_Operacion(DetDocsVta_Det_Operacion Item);

      
      DetDocsVta_Det_Operacion GetOneDetDocsVta_Det_Operacion(Int32 DDDO_Codigo);

      
      ObservableCollection<DetDocsVta_Det_Operacion> GetAllDetDocsVta_Det_Operacion();
      #endregion
   }
}
