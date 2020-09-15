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

   public partial class DelfinServices : IDelfinServices
   {
      #region [ Propiedades ]
      [Dependency]
      public IBLDetDocsVta_Det_Operacion BL_DetDocsVta_Det_Operacion { get; set; }
      #endregion

      #region [ Consultas ]
      public System.Data.DataTable GetDTDetDocsVta_Det_Operacion(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_DetDocsVta_Det_Operacion.GetDT(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<DetDocsVta_Det_Operacion> GetAllDetDocsVta_Det_OperacionFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_DetDocsVta_Det_Operacion.GetAllFilter(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<DetDocsVta_Det_Operacion> GetAllDetDocsVta_Det_Operacion()
      {
         try
         {
            return BL_DetDocsVta_Det_Operacion.GetAll();
         }
         catch (Exception)
         { throw; }
      }
      public DetDocsVta_Det_Operacion GetOneDetDocsVta_Det_Operacion(Int32 DDVO_Codigo)
      {
         try
         {
            return BL_DetDocsVta_Det_Operacion.GetOne(DDVO_Codigo);
         }
         catch (Exception)
         { throw; }
      }

      #endregion

      #region [ Metodos ]
      public Boolean SaveDetDocsVta_Det_Operacion(ref DetDocsVta_Det_Operacion Item)
      {
         try
         {
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
            {
               return BL_DetDocsVta_Det_Operacion.Save(ref Item);
            }
            return true;
         }
         catch (Exception)
         { throw; }
      }
      #endregion
   }
}
