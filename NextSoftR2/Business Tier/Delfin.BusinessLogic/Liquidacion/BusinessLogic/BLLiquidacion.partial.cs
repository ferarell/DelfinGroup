using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial class BLLiquidacion
	{
		#region [ Consultas ]
		
		#endregion
		
		#region [ Metodos ]

      public Boolean Save(ref Liquidacion Item, Liquidacion.TOperacion x_toperacion)
      {
         try
         {
            Boolean m_isCorrect = true;

            switch (x_toperacion)
            {
               case Liquidacion.TOperacion.Anular:
                  m_isCorrect = SaveCambiarEstado(ref Item);
                  break;
               case Liquidacion.TOperacion.Aprobar:
                  m_isCorrect = SaveCambiarEstado(ref Item);
                  break;
               case Liquidacion.TOperacion.Liquidar:
                  m_isCorrect = SaveCambiarEstado(ref Item);
                  break;
               default:
                  break;
            }
            return m_isCorrect;
         }
         catch (Exception)
         { throw; }
      }

      public Boolean SaveCambiarEstado(ref Liquidacion Item)
      {
         try
         {
            Boolean m_isCorrect = true;
            switch (Item.Instance)
            {
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
                  m_isCorrect = UpdateCambiarEstado(ref Item); 
                  break;
            }
            return m_isCorrect;
         }
         catch (Exception)
         { throw; }
      }

		
		#endregion
	}
}
