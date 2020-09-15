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
      #region [ Tipos ]
      
      Boolean SaveTipos(Tipos Item);

      
      Tipos GetOneTipos(String TIPO_CodTabla, String TIPO_CodTipo);

      
      ObservableCollection<Tipos> GetAllTipos();
      #endregion
   }
}
