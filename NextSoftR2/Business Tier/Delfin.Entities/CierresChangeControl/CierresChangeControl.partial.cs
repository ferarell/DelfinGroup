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
   public partial class CierresChangeControl
   {
      /// <summary>
      /// Gets or sets el valor de: CHAN_DescMes.
      /// </summary>
      [DataMember]
      public String CHAN_DescMes { get; set; }

      /// <summary>
      /// Gets or sets el valor de: CHAN_DescEstado.
      /// </summary>
      [DataMember]
      public String CHAN_DescEstado
      {
         get
         {
            switch (CHAN_Estado)
            {
               case "A":
                  return "Abierto";
               case "C":
                  return "Cerrado";
               default:
                  return null;
            }
         }
      }

      public String AsientoContable
      {
         get
         {
            if (!String.IsNullOrEmpty(m_caba_nrovoucher))
            { return String.Format("{0}{1}-{2}-{3}", m_caba_ano, m_caba_mes, m_tipo_codreg, m_caba_nrovoucher); }
            else { return ""; }
         }
      }

   }
}
