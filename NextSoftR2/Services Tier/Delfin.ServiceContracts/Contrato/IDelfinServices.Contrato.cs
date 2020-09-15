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
      #region [ Contrato ]
      
      Int32 SaveContrato(Contrato Item, Boolean Tarifario);

      
      Contrato GetOneContrato(Int16 EMPR_Codigo, Int32 CONT_Codigo);

      
      ObservableCollection<Contrato> GetAllContrato(Int16 EMPR_Codigo);
      #endregion
   }
}
