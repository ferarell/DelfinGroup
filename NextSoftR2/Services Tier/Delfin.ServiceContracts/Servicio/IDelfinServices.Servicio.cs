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
      #region [ Servicio ]
      
      Boolean SaveServicio(Servicio Item);

      
      Servicio GetOneServicio(Int32 SERV_Codigo);

      
      ObservableCollection<Servicio> GetAllServicio();

      
      System.Data.DataTable  GetServiciosAdicionales(Int32 SERV_Codigo);
      #endregion
   }
}
