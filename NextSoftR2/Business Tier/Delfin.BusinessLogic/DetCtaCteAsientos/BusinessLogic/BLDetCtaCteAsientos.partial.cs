using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
   public partial class BLDetCtaCteAsientos
   {
      #region [ Consultas ]

      #endregion

      #region [ Metodos ]

      public Boolean DeleteForCtaCte(Int16 EMPR_Codigo, Int32 CCCT_Codigo)
      {
         try
         {
            Boolean m_isCorrect = true;

            m_isCorrect = Delete(EMPR_Codigo , CCCT_Codigo); 

            return m_isCorrect;
         }
         catch (Exception)
         { throw; }
      }

      #endregion
   }
}
