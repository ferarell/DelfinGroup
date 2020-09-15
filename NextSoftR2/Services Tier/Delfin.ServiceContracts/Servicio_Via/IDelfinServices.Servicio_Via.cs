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
      #region [ Servicio_Via ]
      
      Boolean SaveServicio_Via(Servicio_Via Item);

      
      Servicio_Via GetOneServicio_Via(String CONS_TabVIA, String CONS_CodVIA, Int32 SERV_Codigo);

      
      ObservableCollection<Servicio_Via> GetAllServicio_Via();
      #endregion
   }
}
