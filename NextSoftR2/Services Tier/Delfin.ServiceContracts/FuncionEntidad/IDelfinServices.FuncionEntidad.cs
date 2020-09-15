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
      #region [ FuncionEntidad ]
      
      Boolean SaveFuncionEntidad(FuncionEntidad Item);

      
      FuncionEntidad GetOneFuncionEntidad(Int32 ENTC_Codigo, Int16 TIPE_Codigo);

      
      ObservableCollection<FuncionEntidad> GetAllFuncionEntidad();
      #endregion
   }
}
