using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Delfin.BusinessLogic;
using Delfin.Entities;
using Infrastructure.Aspect.DataAccess;
using Infrastructure.Aspect.Constants;

namespace Delfin.BusinessLogic
{
   public partial class BLPlanillas
   {
      #region [ Consultas ]

      #endregion

      #region [ Metodos ]

      public Boolean SaveLevantarRespuesta(Infrastructure.Aspect.Constants.CCabeceraRDetracciones RDetraccion, ref String x_resultado)
      {
         try
         {
            DataAccessEnterpriseSQL.DABeginTransaction();
            Boolean m_isCorrect = true;
            x_resultado = "";
            foreach (Infrastructure.Aspect.Constants.CRespuestaDetracciones item in RDetraccion.ListRespuestas)
            {
               if (!UpdateRDetraccion(item))
               { x_resultado += String.Format("* No se actualizo el registro {0}, de la Entidad: {1} - {2}.{3}", item.NumeroComprobante, item.NroDocProveedor, item.RazonSocial, Environment.NewLine); }
            }
            if (m_isCorrect) { DataAccessEnterpriseSQL.DACommitTransaction(); }
            else { DataAccessEnterpriseSQL.DARollbackTransaction(); }
            return m_isCorrect;
         }
         catch (Exception)
         {
            DataAccessEnterpriseSQL.DARollbackTransaction();
            throw;
         }
      }

      #endregion
   }
}
