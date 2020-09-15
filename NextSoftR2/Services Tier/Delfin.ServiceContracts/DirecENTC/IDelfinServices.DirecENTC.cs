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
      #region [ DirecENTC ]
      
      Boolean SaveDirecENTC(DirecENTC Item);

      
      DirecENTC GetOneDirecENTC(Int32 ENTC_Codigo, Int16 DIRE_Codigo);

      
      ObservableCollection<DirecENTC> GetAllDirecENTC(Int32 x_ENTC_Codigo);
      #endregion
   }
}
