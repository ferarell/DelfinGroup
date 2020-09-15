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
	public partial class Series
   {
      #region Propiedades
            
      [DataMember]
      public String TIPO_TDO { get; set; }
      [DataMember]
      public String SERI_UnidadNegocio_text { get; set; }

      public String GetSERI_UnidadNegocio()
      {
         try
         {
            switch (SERI_UnidadNegocio)
            {
               case "S":
                  return "SLI";
               case "M":
                  return "Mandato";
               case "E":
                  return "Exportaci�n";
               case "O":
                  return "Otros Tr�ficos";
               default:
                  break;
            }
            return "-";
         }
         catch (Exception)
         { return null; }
      }

      #endregion
   }
}
