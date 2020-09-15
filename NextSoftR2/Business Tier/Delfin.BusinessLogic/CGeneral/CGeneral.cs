using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Infrastructure.Aspect.BusinessEntity;
using Infrastructure.Aspect.DataAccess;

namespace Delfin.BusinessLogic
{
   public class CGeneral : ICGeneral
   {
      public DateTime GetFecha()
      {
         try
         {
            DataAccessEnterpriseSQL.DAAsignarProcedure("SELECT GETDATE() AS FECHA");
            DataAccessEnterpriseSQL.DASqlCommand.CommandType = CommandType.Text;
            DataTable Resultado = DataAccessEnterpriseSQL.DAExecuteDataSet().Tables[0];
            DateTime Fecha = DateTime.Now;
            if (Resultado.Rows.Count > 0)
            {
               Fecha = DateTime.Parse(Resultado.Rows[0]["FECHA"].ToString());
            }
            return Fecha; 
         }
         catch (Exception)
         { throw; }
      }

      public String getNameServer()
      {
         try
         {
            String sql = "Select HOST_NAME() AS HOST";
            DataAccessEnterpriseSQL.DAAsignarProcedure(sql);
            DataAccessEnterpriseSQL.DASqlCommand.CommandType = CommandType.Text;
            DataTable Resultado = DataAccessEnterpriseSQL.DAExecuteDataSet().Tables[0];
            String BDatos = "";
            if (Resultado.Rows.Count > 0)
            {
               BDatos = Resultado.Rows[0]["HOST"].ToString();
            }
            return BDatos; 
         }
         catch (Exception)
         { throw; }
      }

      public String getNameInstancia()
      {
         try
         {
            String sql = "SELECT @@SERVERNAME AS HOST";
            DataAccessEnterpriseSQL.DAAsignarProcedure(sql);
            DataAccessEnterpriseSQL.DASqlCommand.CommandType = CommandType.Text;
            DataTable Resultado = DataAccessEnterpriseSQL.DAExecuteDataSet().Tables[0];
            String BDatos = "";
            if (Resultado.Rows.Count > 0)
            {
               BDatos = Resultado.Rows[0]["HOST"].ToString();
            }
            return BDatos; 
         }
         catch (Exception)
         { throw; }
      }

      public String getNameDataBase()
      {
         try
         {
            String sql = "Select DB_NAME() AS BASE";
            DataAccessEnterpriseSQL.DAAsignarProcedure(sql);
            DataAccessEnterpriseSQL.DASqlCommand.CommandType = CommandType.Text;
            DataTable Resultado = DataAccessEnterpriseSQL.DAExecuteDataSet().Tables[0];
            String BDatos = "";
            if (Resultado.Rows.Count > 0)
            {
               BDatos = Resultado.Rows[0]["BASE"].ToString();
            }
            return BDatos; 
         }
         catch (Exception)
         { throw; }
      }
   }
}
