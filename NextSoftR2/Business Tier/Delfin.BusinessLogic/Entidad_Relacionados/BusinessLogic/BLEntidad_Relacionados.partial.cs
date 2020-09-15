using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
   public partial class BLEntidad_Relacionados
   {
      #region [ Consultas ]
      public ObservableCollection<Entidad_Relacionados> GetAllDepositoTemporalByCliente(Int32 ENTC_Codigo)
      {
         try
         {
            if (ENTC_Codigo == null) { return null; }
            return SelectAllDepositoTemporalByCliente(ENTC_Codigo);
         }
         catch (Exception)
         { throw; }
      }


      public ObservableCollection<Entidad_Relacionados> GetAllEntidadRelacionadosByCliente(Nullable<Int32> ENTC_Codigo, String RELA_Tipos)
      {
         try
         {
            return SelectAllEntidadRelacionadosByCliente(ENTC_Codigo, RELA_Tipos);
         }
         catch (Exception)
         { throw; }
      }

      public ObservableCollection<Entidad_Relacionados> GetAllEntidadRelacionadosByRelaTipo(String RELA_Tipos)
      {
         try
         {
            if (RELA_Tipos == null) { return null; }
            return SelectAllEntidadRelacionadosByRelaTipos(RELA_Tipos);
         }
         catch (Exception)
         { throw; }
      }

      public ObservableCollection<Entidad_Relacionados> GetAllPorEntidadPadre(Int32 ENTC_Codigo)
      {
         try
         {
            return SelectAll(ENTC_Codigo);
         }
         catch (Exception)
         { throw; }
      }

      #endregion

      #region [ Metodos ]
      public Boolean UpdateDeposito(ref Entidad_Relacionados Item)
      {
         try
         {
            Boolean m_isCorrect = true;
            m_isCorrect = UpdateDTE(ref Item); 
            return m_isCorrect;
         }
         catch (Exception)
         { throw; }
      }
      #endregion
   }
}
