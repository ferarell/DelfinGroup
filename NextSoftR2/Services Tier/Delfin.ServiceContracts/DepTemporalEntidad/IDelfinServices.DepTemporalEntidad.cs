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
      #region [ DepTemporalEntidad ]
      
      Boolean SaveDepTemporalEntidad(DepTemporalEntidad Item);

      
      DepTemporalEntidad GetOneDepTemporalEntidad(Int32 DETE_Codigo);

      
      ObservableCollection<DepTemporalEntidad> GetAllDepTemporalEntidad(Int32? x_ENTC_Codigo);
      #endregion
   }
}
