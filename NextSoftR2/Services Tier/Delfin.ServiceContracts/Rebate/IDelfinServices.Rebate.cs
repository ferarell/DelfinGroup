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
      #region [ Rebate ]
      
      Boolean SaveRebate(Rebate Item);

      
      Rebate GetOneRebate(Int32 REBA_Codigo);

      
      ObservableCollection<Rebate> GetAllRebate(string x_CONC_TabReb, string x_CONC_CodReb, string x_ENTC_CodTransportista, DateTime x_REBA_FecIni);
      #endregion
   }
}
