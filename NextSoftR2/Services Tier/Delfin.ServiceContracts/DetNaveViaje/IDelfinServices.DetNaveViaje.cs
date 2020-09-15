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
      #region [ DetNaveViaje ]
      
      Boolean SaveDetNaveViaje(DetNaveViaje Item);

      
      DetNaveViaje GetOneDetNaveViaje(Int32 DVIA_Codigo, Int32 NVIA_Codigo);

      
      ObservableCollection<DetNaveViaje> GetAllDetNaveViaje();
      #endregion
   }
}
