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
using Infrastructure.Aspect.Collections;

using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial class BLCab_MBL
	{
		#region [ Consultas ]
      private Cab_MBL SelectOneByNumero(String CMBL_Numero)
      {
         try
         {
            Cab_MBL item = new Cab_MBL();
            DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_CMBLSS_UnRegByNumero");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCMBL_Numero", CMBL_Numero, SqlDbType.VarChar, 25, ParameterDirection.Input);
            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               if (reader.Read())
               {
                  Loader.LoadEntity(reader, item);
                  item.Instance = InstanceEntity.Unchanged;
               }

               //ListCab_Cotizacion_OV               
               if (reader.NextResult())
               {
                  BusinessEntityLoader<Cab_Cotizacion_OV> LoaderCab_Cotizacion_OV = new BusinessEntityLoader<Cab_Cotizacion_OV>();
                  Cab_Cotizacion_OV itemCab_Cotizacion_OV = new Cab_Cotizacion_OV();
                  LoaderCab_Cotizacion_OV.EntityType = itemCab_Cotizacion_OV.GetType();
                  while (reader.Read())
                  {
                     itemCab_Cotizacion_OV = new Cab_Cotizacion_OV();
                     LoaderCab_Cotizacion_OV.LoadEntity(reader, itemCab_Cotizacion_OV);
                     itemCab_Cotizacion_OV.Instance = InstanceEntity.Unchanged;
                     item.ListCab_Cotizacion_OV.Add(itemCab_Cotizacion_OV);
                  }
               }

               //ListDet_CNTR               
               if (reader.NextResult())
               {
                  BusinessEntityLoader<Det_CNTR> LoaderDet_CNTR = new BusinessEntityLoader<Det_CNTR>();
                  Det_CNTR itemDet_CNTR = new Det_CNTR();
                  LoaderDet_CNTR.EntityType = itemDet_CNTR.GetType();
                  while (reader.Read())
                  {
                     itemDet_CNTR = new Det_CNTR();
                     LoaderDet_CNTR.LoadEntity(reader, itemDet_CNTR);
                     itemDet_CNTR.Instance = InstanceEntity.Unchanged;
                     item.ListDet_CNTR.Add(itemDet_CNTR);
                     itemDet_CNTR = null;
                  }
               }

               foreach (Cab_Cotizacion_OV _itemCab_Cotizacion_OV in item.ListCab_Cotizacion_OV)
               { _itemCab_Cotizacion_OV.ItemsDet_CNTR = item.ListDet_CNTR.Where(DHBL => DHBL.CCOT_Tipo == _itemCab_Cotizacion_OV.CCOT_Tipo && DHBL.CCOT_Numero == _itemCab_Cotizacion_OV.CCOT_Numero).ToObservableCollection(); }

            }
            return item;
         }
         catch (Exception)
         { throw; }
      }
		#endregion

		#region [ Metodos ]

		#endregion
	}
}
