using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Activation;
using System.Collections.ObjectModel;
using Microsoft.Practices.Unity;
using Infrastructure.Aspect.DataAccess;
using Delfin.ServiceContracts;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.ServiceProxy
{

   public partial class DelfinServicesProxy : IDelfinServices
   {
      #region [ Propiedades ]
      [Dependency]
      public IBLDet_CNTR BL_Det_CNTR { get; set; }
      #endregion

      #region [ Consultas ]
      public System.Data.DataTable GetDTDet_CNTR(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_Det_CNTR.GetDT(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<Det_CNTR> GetAllDet_CNTRFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_Det_CNTR.GetAllFilter(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<Det_CNTR> GetAllDet_CNTR()
      {
         try
         {
            return BL_Det_CNTR.GetAll();
         }
         catch (Exception)
         { throw; }
      }
      public Det_CNTR GetOneDet_CNTR(Int16 CCOT_Tipo, Int32 CCOT_Numero, Int32 DHBL_Item)
      {
         try
         {
            return BL_Det_CNTR.GetOne(CCOT_Tipo, CCOT_Numero, DHBL_Item);
         }
         catch (Exception)
         { throw; }
      }

      #endregion

      #region [ Metodos ]
      public Boolean SaveDet_CNTR(ref Det_CNTR Item)
      {
         try
         {
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
            {
               return BL_Det_CNTR.Save(ref Item);
            }
            return true;
         }
         catch (Exception)
         { throw; }
      }
      #endregion
   }
}
