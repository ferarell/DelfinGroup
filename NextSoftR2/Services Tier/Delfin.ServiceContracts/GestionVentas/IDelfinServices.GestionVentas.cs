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
      #region [ GestionVentas ]
      
      Boolean SaveGestionVentas(GestionVentas Item);

      
      GestionVentas GetOneGestionVentas(Int32 GEST_Codigo);

      
      ObservableCollection<GestionVentas> GetAllGestionVentas();
      #endregion
   }
}
