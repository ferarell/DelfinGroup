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
      #region [ Det_Tarifa_Servicio ]
      
      Boolean SaveDet_Tarifa_Servicio( ref Det_Tarifa_Servicio Item);

      
      Det_Tarifa_Servicio GetOneDet_Tarifa_Servicio(Int32 CTAR_Codigo, String CTAR_Tipo, Int32 DTAS_Item);

      
      ObservableCollection<Det_Tarifa_Servicio> GetAllDet_Tarifa_Servicio();
      #endregion
   }
}
