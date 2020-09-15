using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
   public partial interface IBLEntidad_Relacionados
   {
      #region [ Consultas ]
      ObservableCollection<Entidad_Relacionados> GetAllDepositoTemporalByCliente(Int32 ENTC_Codigo);
      ObservableCollection<Entidad_Relacionados> GetAllEntidadRelacionadosByCliente(Nullable<Int32> ENTC_Codigo, String RELA_Tipos);

      ObservableCollection<Entidad_Relacionados> GetAllEntidadRelacionadosByRelaTipo(String RELA_Tipos);

      ObservableCollection<Entidad_Relacionados> GetAllPorEntidadPadre(Int32 ENTC_Codigo);
      #endregion

      #region [ Metodos ]
      Boolean UpdateDeposito(ref Entidad_Relacionados Item);
      #endregion
   }
}
