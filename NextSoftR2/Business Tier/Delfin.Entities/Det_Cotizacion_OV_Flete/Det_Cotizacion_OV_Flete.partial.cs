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
	public partial class Det_Cotizacion_OV_Flete
	{
      /// <summary>
      /// Gets or sets el valor de: PACK_Desc.
      /// </summary>
      [DataMember]
      public String PACK_Desc { get; set; }

      /// <summary>
      /// Gets or sets el valor de: PACK_DescC.
      /// </summary>
      [DataMember]
      public String PACK_DescC { get; set; }

      public void CalcularTotales()
      {
         try
         {
            DCOT_TotalUniCosto = DCOT_Cantidad * DCOT_PrecioUniCosto;
            DCOT_TotalUniVenta = DCOT_Cantidad * DCOT_PrecioUniVenta;
         }
         catch (Exception)
         { }
      }

      public Decimal Contenedor
      {
         get {
            if (ItemPaquete != null && ItemPaquete.TIPO_CodPAQ == "001") //Contendor
            { return DCOT_Cantidad; }
            else
            { return (Decimal)0.00; }
         }
      }
      public Decimal TEUS
      {
         get {
            if (ItemPaquete != null && ItemPaquete.TIPO_CodPAQ == "001" && ItemPaquete.TIPO_Num1TAM.HasValue)
            { return DCOT_Cantidad * ItemPaquete.TIPO_Num1TAM.Value; }
            else
            { return (Decimal)0.00; }
         }
      }
	}
}
