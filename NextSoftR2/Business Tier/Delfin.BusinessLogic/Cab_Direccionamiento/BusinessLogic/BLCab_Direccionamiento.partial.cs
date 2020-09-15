using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Infrastructure.Aspect.BusinessLogic;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial class BLCab_Direccionamiento
	{
		#region [ Consultas ]
      public DataTable GetForward(String Buque, String Viaje)
      {
         try
         {
            return SelectForward(Buque, Viaje);
         }
         catch (Exception ex)
         { throw ex; }
      }
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveDepTemporal(DataTable _dt)
      {
         try
         {
            Boolean m_isCorrect = true;
            Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DABeginTransaction();

            foreach (DataRow dtRow in _dt.Rows)
            {
               UpdateDepTemporal(Convert.ToInt32(dtRow[0].ToString()),Convert.ToInt32( dtRow[1].ToString()), dtRow[2].ToString());
            }
            if (m_isCorrect)
            { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DACommitTransaction(); }
            else
            { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); }
            return m_isCorrect;
         }
         catch (Exception)
         { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); throw; }
      }
		#endregion
	}
}
