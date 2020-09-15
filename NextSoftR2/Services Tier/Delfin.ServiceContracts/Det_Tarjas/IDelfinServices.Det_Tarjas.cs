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
      #region [ Det_Tarjas ]
      
      Boolean SaveDet_Tarjas(Det_Tarjas Item);

      
      Det_Tarjas GetOneDet_Tarjas(Int32 DTAJ_Item, Int32 TARJ_Codigo);

       
       ObservableCollection<Det_Tarjas> GetAllDet_TarjasPorTARJ_Codigo(Int32 x_TARJ_Codigo);

       #endregion
   }
}
