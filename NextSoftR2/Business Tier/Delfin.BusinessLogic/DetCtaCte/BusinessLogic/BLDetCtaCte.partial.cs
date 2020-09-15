using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Infrastructure.Aspect.BusinessLogic;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial class BLDetCtaCte
	{
		#region [ Consultas ]
		
		#endregion
		
		#region [ Metodos ]

      public Boolean Save(ref DetCtaCte Item, DetCtaCte.TInterfazDetCtaCte x_opcion)
      {
         try
         {
            Boolean m_isCorrect = true;
            switch (x_opcion)
            {
               case DetCtaCte.TInterfazDetCtaCte.Normal:
                  this.Save(ref Item);
                  break;
               case DetCtaCte.TInterfazDetCtaCte.Canje:
                  SaveCanje(ref Item);
                  break;
               default:
                  break;
            }
            return m_isCorrect;
         }
         catch (Exception)
         { throw; }
      }

      public Boolean SaveCanje(ref DetCtaCte Item)
      {
         try
         {
            Boolean m_isCorrect = true;
            m_isCorrect = InsertUpdate(ref Item); 
            return m_isCorrect;
         }
         catch (Exception)
         { throw; }
      }

		#endregion
	}
}
