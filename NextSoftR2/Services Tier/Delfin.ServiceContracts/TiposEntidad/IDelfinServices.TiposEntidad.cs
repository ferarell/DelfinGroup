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
      #region [ TiposEntidad ]
      
      Boolean SaveTiposEntidad(TiposEntidad Item);

      
      TiposEntidad GetOneTiposEntidad(Int16 TIPE_Codigo);

      
      ObservableCollection<TiposEntidad> GetAllTiposEntidad();

      ObservableCollection<TiposEntidad> GetAllTiposEntidad_Relacionados();
      #endregion
   }
}
