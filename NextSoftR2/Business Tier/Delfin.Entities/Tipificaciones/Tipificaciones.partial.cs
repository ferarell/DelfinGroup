using System;
using System.Text;
using System.Linq;
using System.Globalization;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.Serialization;
using Infrastructure.Aspect;
using Infrastructure.Aspect.BusinessEntity;

namespace Delfin.Entities
{
   public partial class Tipificaciones
   {
      public String CENT_Desc { get; set; }
      public String TIPO_CodDES_Text { get; set; }
      public String ENTC_RazonSocial { get; set; }
      public String TIPE_Descripcion { get; set; }
      public String TIPD_Tipo_Text { get; set; }
      public String TIPO_CodMND_Text { get; set; }

      public String TIPD_GeneraCtaCte_Text
      {
         get
         {
            return TIPD_GeneraCtaCte ? "Si" : "No";
         }
      }
   }
}
