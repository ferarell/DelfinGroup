using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Infrastructure.Aspect.BusinessEntity;
using Microsoft.Practices.Unity;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Infrastructure.Aspect.DataAccess;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial class BLDet_Seguimientos
	{
		#region [ Consultas ]
        private ObservableCollection<Det_Seguimientos> SelectAllByCabSeguimiento(Int32 x_CSEG_Codigo)
        {
            try
            {
                ObservableCollection<Det_Seguimientos> items = new ObservableCollection<Det_Seguimientos>();
                Det_Seguimientos item = new Det_Seguimientos();
                DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_DSEGSS_TodosByCSEG_Codigo");
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintCSEG_Codigo", x_CSEG_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
                using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Det_Seguimientos();
                        Loader.LoadEntity(reader, item);
                        item.Instance = InstanceEntity.Unchanged;
                        items.Add(item);
                    }
                }
                return items;
            }
            catch (Exception ex)
            { throw ex; }
        }
		#endregion

		#region [ Metodos ]

		#endregion
	}
}
