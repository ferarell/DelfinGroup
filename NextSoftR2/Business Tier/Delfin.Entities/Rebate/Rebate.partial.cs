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
   public partial class Rebate
   {

      /// <summary>
      /// Gets or sets el valor de: ENTC_NomTransportista.
      /// </summary>
      [DataMember]
      public String ENTC_NomTransportista { get; set; }

      /// <summary>
      /// Gets or sets el valor de: PUER_NomOrigen.
      /// </summary>
      [DataMember]
      public String PUER_NomOrigen { get; set; }
      /// <summary>
      /// Gets or sets el valor de: TIPO_TabPaisOrigen.
      /// </summary>
      [DataMember]
      public String TIPO_TabPaisOrigen { get; set; }
      /// <summary>
      /// Gets or sets el valor de: NAVE_Nombre.
      /// </summary>
      [DataMember]
      public String TIPO_CodPaisOrigen { get; set; }
      /// <summary>
      /// Gets or sets el valor de: TIPO_DescPaisOrigen.
      /// </summary>
      [DataMember]
      public String TIPO_DescPaisOrigen { get; set; }
      
      /// <summary>
      /// Gets or sets el valor de: PUER_NomDestino.
      /// </summary>
      [DataMember]
      public String PUER_NomDestino { get; set; }
      /// <summary>
      /// Gets or sets el valor de: TIPO_TabPaisDestino.
      /// </summary>
      [DataMember]
      public String TIPO_TabPaisDestino { get; set; }
      /// <summary>
      /// Gets or sets el valor de: NAVE_Nombre.
      /// </summary>
      [DataMember]
      public String TIPO_CodPaisDestino { get; set; }
      /// <summary>
      /// Gets or sets el valor de: TIPO_DescPaisDestino.
      /// </summary>
      [DataMember]
      public String TIPO_DescPaisDestino { get; set; }
      
      /// <summary>
      /// Gets or sets el valor de: TIPO_DescMnd.
      /// </summary>
      [DataMember]
      public String TIPO_DescMnd { get; set; }
   }
}
