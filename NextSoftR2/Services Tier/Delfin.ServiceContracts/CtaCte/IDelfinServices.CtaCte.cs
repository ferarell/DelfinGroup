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
      
      System.Data.DataTable GetDTCtaCte(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
      
      ObservableCollection<CtaCte> GetAllCtaCteFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
      
      ObservableCollection<CtaCte> GetAllCtaCte();
      
      CtaCte GetOneCtaCte(Int16 EMPR_Codigo, Int32 CCCT_Codigo);

      #endregion

      #region [ Metodos ]
      
      Boolean SaveCtaCte(ref CtaCte Item);
      String SaveCtaCteILD(ref CtaCte Item);
      #endregion

   }
}
