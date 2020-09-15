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
      #region [ Entidad ]
      
      Entidad SaveEntidad( Entidad Item);
      Entidad GetOneEntidad(Int32 ENTC_Codigo, Nullable<Int16> x_TIPE_Codigo = null, Boolean x_soloentidad = false);

      ObservableCollection<Entidad> GetAllEntidad(Nullable<Int16> x_TIPE_Codigo = null, string x_ENTC_NomCompleto = null);

      #endregion
   }
}
