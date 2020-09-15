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
      #region [ NaveViaje ]
      
      Int32 SaveNaveViaje(NaveViaje Item);

      
      NaveViaje GetOneNaveViaje(Int32 NVIA_Codigo);

      
      ObservableCollection<NaveViaje> GetAllNaveViaje();
      #endregion
   }
}
