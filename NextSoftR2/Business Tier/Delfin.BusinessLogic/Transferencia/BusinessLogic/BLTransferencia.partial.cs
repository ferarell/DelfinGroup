using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial class BLTransferencia
	{
      

      #region [ Consultas ]
		
		#endregion
		
		#region [ Metodos ]

      public Boolean Save(ref Transferencia Item, Transferencia.TOperacion x_opcion)
      {
         try
         {
            Boolean m_isCorrect = true;
            switch (x_opcion)
            {
               case Transferencia.TOperacion.Normal:
                  m_isCorrect = Save(ref Item);
                  break;
               case Transferencia.TOperacion.Eliminar:
                  m_isCorrect = SaveEliminar(ref Item);
                  break;
               case Transferencia.TOperacion.Anular:
                  m_isCorrect = SaveAnular(ref Item);
                  break;
               default:
                  break;
            }
            return m_isCorrect;
         }
         catch (Exception)
         { throw; }
      }

      public Boolean SaveEliminar(ref Transferencia Item)
      {
         try
         {
            Boolean m_isCorrect = true;
            switch (Item.Instance)
            {
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted:
                  m_isCorrect = Delete(ref Item); break;
            }
            return m_isCorrect;
         }
         catch (Exception)
         { throw; }
      }

      public Boolean SaveAnular(ref Transferencia Item)
      {
         try
         {
            Boolean m_isCorrect = true;
            switch (Item.Instance)
            {
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
                  m_isCorrect = UpdateAnular(ref Item); break;
            }
            return m_isCorrect;
         }
         catch (Exception)
         { throw; }
      }
		
		#endregion
	}
}
