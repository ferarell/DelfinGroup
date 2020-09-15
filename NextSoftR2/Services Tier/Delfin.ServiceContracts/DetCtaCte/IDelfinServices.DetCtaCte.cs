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
      #region [ Consultas ]
      
      System.Data.DataTable GetDTDetCtaCte(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
      
      ObservableCollection<DetCtaCte> GetAllDetCtaCteFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
      
      ObservableCollection<DetCtaCte> GetAllDetCtaCte();
      
      DetCtaCte GetOneDetCtaCte(Int16 EMPR_Codigo, Int32 CCCT_Codigo, Int16 DCCT_Item);

      #endregion

      #region [ Metodos ]
      
      Boolean SaveDetCtaCte(ref DetCtaCte Item);
      #endregion

   }
}
