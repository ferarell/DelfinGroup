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
   public partial class DetCtaCteAsientos
   {

      [DataMember]
      public String CUEN_Desc { get; set; }

      [DataMember]
      public String CENT_Desc { get; set; }

      /// <summary>
      /// Gets or sets el valor de: TIPO_CodOPE.
      /// </summary>
      [DataMember]
      public String TIPO_CodOPEstr
      {
         get { return m_tipo_codope; }
         set
         {
            m_tipo_codope = value;
         }
      }

      public Boolean ValidarCentroCto { get; set; }

   }
}
