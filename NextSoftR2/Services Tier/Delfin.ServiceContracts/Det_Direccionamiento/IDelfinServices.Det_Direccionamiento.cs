using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;
using Delfin.Entities;
using Delfin.BusinessLogic;
using System.Data;

namespace Delfin.ServiceContracts
{
   public partial interface IDelfinServices
   {
      #region [ Det_Direccionamiento ]
      
      Boolean SaveDet_Direccionamiento(Det_Direccionamiento Item);

      
      DataTable GetOneDet_Direccionamiento(Int32 DDIR_Item, Int32 CDIR_Codigo);

      
      ObservableCollection<Det_Direccionamiento> GetAllDet_Direccionamiento();
      #endregion
   }
}
