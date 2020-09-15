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
		#region [ Consultas ]

      
      ObservableCollection<Entidad_Relacionados> GetAllDepositoTemporalByCliente(Int32 ENTC_Codigo);
      
      ObservableCollection<Entidad_Relacionados> GetAllEntidadRelacionadosByCliente(Nullable<Int32> ENTC_Codigo, String RELA_Tipos);

      
      ObservableCollection<Entidad_Relacionados> GetAllEntidadRelacionadosByRelaTipo(String RELA_Tipos);

      #endregion

      #region [ Metodos ]

      #endregion
   }
}
