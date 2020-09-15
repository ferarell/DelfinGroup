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
      #region [ PreDetDocsVta_Det_Operacion ]
      
      Boolean SavePreDetDocsVta_Det_Operacion(PreDetDocsVta_Det_Operacion Item);

      
      PreDetDocsVta_Det_Operacion GetOnePreDetDocsVta_Det_Operacion(Int32 PDDO_Codigo);

      
      ObservableCollection<PreDetDocsVta_Det_Operacion> GetAllPreDetDocsVta_Det_Operacion();
      #endregion
   }
}
