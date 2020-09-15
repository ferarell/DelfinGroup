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
      #region [ CtaCte_Det_Operaciones ]
      
      Boolean SaveCtaCte_Det_Operaciones(CtaCte_Det_Operaciones Item);

      
      CtaCte_Det_Operaciones GetOneCtaCte_Det_Operaciones(Int32 DCTO_Codigo);

      
      ObservableCollection<CtaCte_Det_Operaciones> GetAllCtaCte_Det_Operaciones();
      #endregion
   }
}
