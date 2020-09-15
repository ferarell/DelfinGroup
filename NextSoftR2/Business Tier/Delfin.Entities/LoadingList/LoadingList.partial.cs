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
   public partial class LoadingList
   {
      /// <summary>
      /// Gets or sets el valor de: CCOT_NumDoc.
      /// </summary>
      [DataMember]
      public String CCOT_NumDoc { get; set; }
      /// <summary>
      /// Gets or sets el valor de: NVIA_NroViaje.
      /// </summary>
      [DataMember]
      public String NVIA_NroViaje { get; set; }
      /// <summary>
      /// Gets or sets el valor de: NVIA_NroManifiesto.
      /// </summary>
      [DataMember]
      public String NVIA_NroManifiesto { get; set; }
      /// <summary>
      /// Gets or sets el valor de: PUER_NomOrigen.
      /// </summary>
      [DataMember]
      public String PUER_NomOrigen { get; set; }
      /// <summary>
      /// Gets or sets el valor de: PUER_NomDestino.
      /// </summary>
      [DataMember]
      public String PUER_NomDestino { get; set; }

      public Boolean LoadingListAsociado
      {
         get { return (LOAD_Codigo.HasValue && CCOT_Numero.HasValue); }
      }
      public Boolean LoadingListNoAsociado
      {
         get { return (LOAD_Codigo.HasValue && !CCOT_Numero.HasValue); }
      }
      public Boolean OrdenVentaAsociada
      {
         get { return (!LOAD_Codigo.HasValue && CCOT_Numero.HasValue); }
      }

   }
}
