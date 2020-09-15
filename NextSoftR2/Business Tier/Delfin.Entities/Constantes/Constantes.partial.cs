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
   public partial class Constantes
   {
      #region [ Propiedades Adicionales ]
      [DataMember]
      public String CONS_CodBas { set; get; }
      [DataMember]
      public String CONS_CodTipoTipo { set; get; }

      public enum TipoAnulacion
      {
         AnulacionFactura = 1, AnulacionSLI = 2, AnulacionOV = 3, AnulacionPreFactura = 4, AnulacionIL = 5
      }
            
      public static String GetTabAnulacion() {  return "ANU"; } 

      public static String GetCodAnulacion(TipoAnulacion x_tanulacion)
      {
         try
         {
            return String.Format("{0:000}", ((int)x_tanulacion));
         }
         catch (Exception)
         { return "001"; }
      }

      #endregion
   }
}
