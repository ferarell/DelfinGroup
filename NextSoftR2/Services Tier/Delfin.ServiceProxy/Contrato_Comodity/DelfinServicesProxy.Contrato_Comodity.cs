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
      public IBLContrato_Comodity BL_Contrato_Comodity { get; set; }
      #endregion

      #region [ Consultas ]
      //public System.Data.DataTable GetDTContrato_Comodity(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      //{
      //   try
      //   {
      //      return BL_Contrato_Comodity.GetDT(x_procedure, x_filters);
      //   }
      //   catch (Exception)
      //   { throw; }
      //}
      //public ObservableCollection<Contrato_Comodity> GetAllContrato_ComodityFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      //{
      //   try
      //   {
      //      return BL_Contrato_Comodity.GetAllFilter(x_procedure, x_filters);
      //   }
      //   catch (Exception)
      //   { throw; }
      //}
      public ObservableCollection<Contrato_Comodity> GetAllContrato_Comodity()
      {
         try
         {
            return BL_Contrato_Comodity.GetAll();
         }
         catch (Exception)
         { throw; }
      }
      //public Contrato_Comodity GetOneContrato_Comodity(String TIPO_TabCDT, String TIPO_CodCDT, Int32 CONT_Codigo)
      //{
      //   try
      //   {
      //      return BL_Contrato_Comodity.GetOne(TIPO_TabCDT, TIPO_CodCDT, CONT_Codigo);
      //   }
      //   catch (Exception)
      //   { throw; }
      //}

      #endregion

      #region [ Metodos ]
      public Boolean SaveContrato_Comodity(ref Contrato_Comodity Item)
      {
         try
         {
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
            {
               return BL_Contrato_Comodity.Save(ref Item);
            }
            return true;
         }
         catch (Exception)
         { throw; }
      }
      #endregion


      public bool SaveContrato_Comodity(Contrato_Comodity Item)
      {
         throw new NotImplementedException();
      }

      public Contrato_Comodity GetOneContrato_Comodity(int CONT_Codigo, string TIPO_TabCDT, string TIPO_CodCDT)
      {
         throw new NotImplementedException();
      }
   }
}
