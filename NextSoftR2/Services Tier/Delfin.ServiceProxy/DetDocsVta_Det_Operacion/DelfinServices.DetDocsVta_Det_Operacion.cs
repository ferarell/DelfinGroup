using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Activation;
using System.Collections.ObjectModel;
using Microsoft.Practices.Unity;
using Infrastructure.Aspect.DataAccess;

namespace Delfin.ServiceProxy
{
   using Delfin.ServiceContracts;
   using Delfin.BusinessLogic;
   using Delfin.Entities;

   public partial class DelfinServicesProxy : IDelfinServices
   {
      #region [ DetDocsVta_Det_Operacion ]
      [Dependency]
      public IBLDetDocsVta_Det_Operacion BL_DetDocsVta_Det_Operacion { get; set; }

      public Boolean SaveDetDocsVta_Det_Operacion(DetDocsVta_Det_Operacion Item)
      {
         try
         {
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
            {
               return BL_DetDocsVta_Det_Operacion.Save(Item);
            }
            return true;
         }
         catch (Exception ex)
         { throw ex; }
      }

      public DetDocsVta_Det_Operacion GetOneDetDocsVta_Det_Operacion(Int32 DDDO_Codigo)
      {
         try
         {
            return BL_DetDocsVta_Det_Operacion.GetOne(DDDO_Codigo);
         }
         catch (Exception ex)
         { throw ex; }
      }

      public ObservableCollection<DetDocsVta_Det_Operacion> GetAllDetDocsVta_Det_Operacion()
      {
         try
         {
            return BL_DetDocsVta_Det_Operacion.GetAll();
         }
         catch (Exception ex)
         { throw ex; }
      }
      #endregion
   }
}
