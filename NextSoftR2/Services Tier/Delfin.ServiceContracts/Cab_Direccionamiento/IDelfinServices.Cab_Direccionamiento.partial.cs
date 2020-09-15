using System;
using System.Data;
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
      #region [ Cab_Direccionamiento ]
      
      Boolean SaveDepTemporal(DataTable _dt);

      
      DataTable GetForward(String Buque, String Viaje);
      #endregion
   }
}
