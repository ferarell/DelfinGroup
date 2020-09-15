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
      #region [ Prospecto ]
      
      Boolean SaveProspecto(Prospecto Item);

      
      Prospecto GetOneProspecto(Int32 PROS_codigo);

      
      ObservableCollection<Prospecto> GetAllProspecto();
      #endregion
   }
}
