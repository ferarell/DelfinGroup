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
      #region [ Entidad_Acuerdo ]
      
      Boolean SaveEntidad_Acuerdo(Entidad_Acuerdo Item);

      
      Entidad_Acuerdo GetOneEntidad_Acuerdo(Int32 ACUE_Codigo);

      
      ObservableCollection<Entidad_Acuerdo> GetAllEntidad_Acuerdo();
      #endregion
   }
}
