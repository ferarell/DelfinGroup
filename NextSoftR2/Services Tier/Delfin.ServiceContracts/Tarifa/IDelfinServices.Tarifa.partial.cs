using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;
using Delfin.Entities;
using Delfin.BusinessLogic;

namespace Delfin.ServiceContracts
{
   public partial interface IDelfinServices
   {
      
      System.Data.DataTable GetAllTarifaByContrato(Nullable<Int32> CONT_Codigo, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabVIA, String CONS_CodVIA, String TIPO_TabMND, String TIPO_CodMND, Nullable<Int32> PACK_Codigo, String TIPO_TabPAI, String TIPO_CodPAI, Nullable<Int32> PUER_Codigo);
   }
}
