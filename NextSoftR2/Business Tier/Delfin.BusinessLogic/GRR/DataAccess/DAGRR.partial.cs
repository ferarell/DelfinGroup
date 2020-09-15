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
	public partial class BLGRR
	{
		#region [ Consultas ]
      //
      private ObservableCollection<Contrato> SelectAllContratoByTransportista(Int32 ENTC_CodTransportista, DateTime REBA_FecIni, DateTime REBA_FecFin)
      {
         try
         {
            ObservableCollection<Contrato> items = new ObservableCollection<Contrato>();
            Contrato item = new Contrato();

            BusinessEntityLoader<Contrato> LoaderContrato = new BusinessEntityLoader<Contrato>();
            LoaderContrato.EntityType = item.GetType();


            DataAccessEnterpriseSQL.DAAsignarProcedure("COM_REBASS_GetContratos");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodTransportista", ENTC_CodTransportista, SqlDbType.Int, 4, ParameterDirection.Input);            
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmREBA_FecIni", REBA_FecIni, SqlDbType.DateTime, 8, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmREBA_FecFin", REBA_FecFin, SqlDbType.DateTime, 8, ParameterDirection.Input);
            
            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               while (reader.Read())
               {
                  item = new Contrato();
                  LoaderContrato.LoadEntity(reader, item);
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
