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
      #region [ Contrato_Comodity ]
      
      Boolean SaveContrato_Comodity(Contrato_Comodity Item);

      
      Contrato_Comodity GetOneContrato_Comodity(Int32 CONT_Codigo, String TIPO_TabCDT, String TIPO_CodCDT);

      
      ObservableCollection<Contrato_Comodity> GetAllContrato_Comodity();
      #endregion
   }
}
