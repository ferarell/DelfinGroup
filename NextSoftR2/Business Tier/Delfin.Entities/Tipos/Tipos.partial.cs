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
   public partial class Tipos
   {
      #region [ Propiedades Adicionales ]
      [DataMember]
      public String TIPO_CodZONOrigen { set; get; }
      [DataMember]
      public String TIPO_CodZONDestino { set; get; }

      [DataMember]
      public String TIPO_DescTipoHijo { get; set; }

      #endregion

      #region Tipos


      public enum TipoTDO
      {
         Factura = 1, BoletaVenta = 3, LiquidacionCobranzas = 4, Invoice = 5, NotaCredito = 7, TipoDocumentoAnticipo = 9,
         CreditNote = 10, 
         TipoDocumentoProvision = 99, ReciboHonorario = 2
      }

      public enum TipoDetraccion
      {
         SinDetraccion = 1
      }

      public static String GetTipo(TipoTDO x_opcion)
      {
         try
         {
            return String.Format("{0:000}", (int)x_opcion);
         }
         catch (Exception)
         { return null; }
      }

      public static String GetTipo(TipoDetraccion x_opcion)
      {
         try
         {
            return String.Format("{0:000}", (int)x_opcion);
         }
         catch (Exception)
         { return null; }
      }


      #endregion
   }
}