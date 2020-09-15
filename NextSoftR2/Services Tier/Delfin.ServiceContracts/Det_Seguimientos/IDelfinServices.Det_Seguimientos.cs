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
      #region [ Det_Seguimientos ]
      
      Boolean SaveDet_Seguimientos(Det_Seguimientos Item);

      
      Det_Seguimientos GetOneDet_Seguimientos(Int32 CSEG_Codigo);

      
      ObservableCollection<Det_Seguimientos> GetAllDet_Seguimientos();
      #endregion
   }
}
