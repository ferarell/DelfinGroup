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
      #region [ Ubigeos ]
      
      Boolean SaveUbigeos(Ubigeos Item);

      
      Ubigeos GetOneUbigeos(String UBIG_Codigo, String TIPO_CodPais, String TIPO_TabPais);

      
      ObservableCollection<Ubigeos> GetAllUbigeos();
      #endregion
   }
}
