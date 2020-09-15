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
      #region [ Paquete ]
      
      Boolean SavePaquete(Paquete Item);

      
      Paquete GetOnePaquete(Int32 PACK_Codigo);

      
      ObservableCollection<Paquete> GetAllPaquete();
      #endregion
   }
}
