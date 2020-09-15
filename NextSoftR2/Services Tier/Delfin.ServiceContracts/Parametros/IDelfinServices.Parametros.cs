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
      #region [ Parametros ]
      //
      //Boolean SaveParametros(Parametros Item);

      
      Boolean SaveParametros(ObservableCollection<Parametros> Items);

      
      Parametros GetOneParametros(Int32 PARA_Codigo);

      
      ObservableCollection<Parametros> GetAllParametros();
      #endregion
   }
}
