using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Practices.Unity;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Infrastructure.Aspect.DataAccess;
using Delfin.Entities;
using Infrastructure.Aspect.BusinessEntity;
using System.IO;

namespace Delfin.BusinessLogic
{
    public partial class BLParametros
    {
        #region [ Consultas ]
        private Parametros SelectOneByClave(String PARA_Clave)
        {
            try
            {
                Parametros item = new Parametros();
                DataAccessEnterpriseSQL.DAAsignarProcedure("T_SP_CONSULTAR_Parametros");
                DataAccessEnterpriseSQL.DAAgregarParametro("@pvchPARA_Clave", PARA_Clave, SqlDbType.VarChar, 20, ParameterDirection.Input);
                using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
                {
                    if (reader.Read())
                    {
                        Loader.LoadEntity(reader, item);
                        item.Instance = InstanceEntity.Unchanged;
                    }
                    else
                    { throw new Exception("No se encontro el prametro:" + PARA_Clave); }
                }
                return item;
            }
            catch (Exception ex)
            { throw ex; }
        }

        private ObservableCollection<Parametros> SelectAllByClave(String PARA_Clave)
        {
            try
            {
                ObservableCollection<Parametros> items = new ObservableCollection<Parametros>();
                Parametros item = new Parametros();
                DataAccessEnterpriseSQL.DAAsignarProcedure("PARASS_Todos_Correos");
                DataAccessEnterpriseSQL.DAAgregarParametro("@pvchPARA_Clave", PARA_Clave, SqlDbType.VarChar, 20, ParameterDirection.Input);

                using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Parametros();
                        Loader.LoadEntity(reader, item);
                        item.Instance = InstanceEntity.Unchanged;
                        items.Add(item);
                    }
                }
                return items;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        #endregion

        #region [ Metodos ]

        #endregion
    }
}
