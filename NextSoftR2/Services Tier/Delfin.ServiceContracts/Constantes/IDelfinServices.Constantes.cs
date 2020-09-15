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
      #region [ Constantes ]
      
      Boolean SaveConstantes(Constantes Item);

      
      Constantes GetOneConstantes(String CONS_CodTabla, String CONS_CodTipo);

      
      ObservableCollection<Constantes> GetAllConstantes();
      #endregion
   }
}
