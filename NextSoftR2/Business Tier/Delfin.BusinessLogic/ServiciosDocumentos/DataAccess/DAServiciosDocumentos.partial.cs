using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Practices.Unity;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Infrastructure.Aspect.DataAccess;
using Infrastructure.Aspect.BusinessEntity;

using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial class BLServiciosDocumentos
	{
		#region [ Consultas ]
        private ObservableCollection<ServiciosDocumentos> SelectAllServiciosDocumentosByServCodigo(Int32 SERV_Codigo)
        {
            try
            {
                ObservableCollection<ServiciosDocumentos> items = new ObservableCollection<ServiciosDocumentos>();
                ServiciosDocumentos item = new ServiciosDocumentos();
                DataAccessEnterpriseSQL.DAAsignarProcedure("SEDOSS_ServiciosDocumentosPorServicio");
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintSERV_Codigo", SERV_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
                
                using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new ServiciosDocumentos();
                        Loader.LoadEntity(reader, item);
                        item.Instance = InstanceEntity.Unchanged;
                        items.Add(item);
                    }
                }
                return items;
            }
            catch (Exception)
            { throw; }
        }
		#endregion

		#region [ Metodos ]

		#endregion
	}
}
