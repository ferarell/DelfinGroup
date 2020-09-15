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
      #region [ Nave ]
      
      Boolean SaveNave(Nave Item);

      
      Nave GetOneNave(Int16 NAVE_Codigo);

      
      ObservableCollection<Nave> GetAllNave(string x_ENTC_CodTransportista);
      #endregion
   }
}
