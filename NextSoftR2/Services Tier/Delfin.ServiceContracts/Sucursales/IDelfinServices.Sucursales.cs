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
      #region [ Sucursales ]
      
      Boolean SaveSucursales(Sucursales Item);

      
      Sucursales GetOneSucursales(Int16 SUCR_Codigo);

      
      ObservableCollection<Sucursales> GetAllSucursales();
      #endregion
   }
}