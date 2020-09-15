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
      #region [ Entidad_Servicio ]
      
      Boolean SaveEntidad_Servicio(Entidad_Servicio Item);

      
      Entidad_Servicio GetOneEntidad_Servicio(Int32 ESER_Codigo);

      
      ObservableCollection<Entidad_Servicio> GetAllEntidad_Servicio(Int32 ENTC_Codigo);
      #endregion
   }
}
