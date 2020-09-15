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
   public partial class Contrato
   {
      /// <summary>
      /// Gets or sets el valor de: ENTC_NomTransportista.
      /// </summary>
      [DataMember]
      public String ENTC_NomTransportista { get; set; }
      /// <summary>
      /// Gets or sets el valor de: ENTC_NomCliente.
      /// </summary>
      [DataMember]
      public String ENTC_NomCliente { get; set; }
      /// <summary>
      /// Gets or sets el valor de: CONS_DescRGM.
      /// </summary>
      [DataMember]
      public String CONS_DescRGM { get; set; }
      /// <summary>
      /// Gets or sets el valor de: CONS_DescVIA.
      /// </summary>
      [DataMember]
      public String CONS_DescVIA { get; set; }


      ///// <summary>
      ///// Gets or sets el valor de: TIPO_TabMND.
      ///// </summary>
      //[DataMember]
      //public String TIPO_TabMND { get; set; }
      ///// <summary>
      ///// Gets or sets el valor de: TIPO_CodMND.
      ///// </summary>
      //[DataMember]
      //public String TIPO_CodMND { get; set; }
      /// <summary>
      /// Gets or sets el valor de: TIPO_DescMND.
      /// </summary>
      [DataMember]
      public String TIPO_DescMND { get; set; }
      /// <summary>
      /// Gets or sets el valor de: PUER_CodigoOrigen.
      /// </summary>
      [DataMember]
      public Nullable<Int32> PUER_CodigoOrigen { get; set; }
      /// <summary>
      /// Gets or sets el valor de: PUER_NombreOrigen.
      /// </summary>
      [DataMember]
      public String PUER_NombreOrigen { get; set; }
      /// <summary>
      /// Gets or sets el valor de: TIPO_TabPaisOrigen.
      /// </summary>
      [DataMember]
      public String TIPO_TabPaisOrigen { get; set; }
      /// <summary>
      /// Gets or sets el valor de: TIPO_CodPaisOrigen.
      /// </summary>
      [DataMember]
      public String TIPO_CodPaisOrigen { get; set; }
      /// <summary>
      /// Gets or sets el valor de: TIPO_DescPaisOrigen.
      /// </summary>
      [DataMember]
      public String TIPO_DescPaisOrigen { get; set; }
      /// <summary>
      /// Gets or sets el valor de: PUER_CodigoDestino.
      /// </summary>
      [DataMember]
      public Nullable<Int32> PUER_CodigoDestino { get; set; }
      /// <summary>
      /// Gets or sets el valor de: PUER_NombreDestino.
      /// </summary>
      [DataMember]
      public String PUER_NombreDestino { get; set; }
      /// <summary>
      /// Gets or sets el valor de: TIPO_TabPaisDestino.
      /// </summary>
      [DataMember]
      public String TIPO_TabPaisDestino { get; set; }
      /// <summary>
      /// Gets or sets el valor de: TIPO_CodPaisDestino.
      /// </summary>
      [DataMember]
      public String TIPO_CodPaisDestino { get; set; }
      /// <summary>
      /// Gets or sets el valor de: TIPO_DescPaisDestino.
      /// </summary>
      [DataMember]
      public String TIPO_DescPaisDestino { get; set; }




      #region [ Operaciones ]
      #region [ Variables ]
      private String m_puer_codestandarorigen;
      private String m_puer_codestandardestino;
      #endregion

      #region [ Propieades ]
      /// <summary>
      /// Gets or sets el valor de: PUER_CodEstandarOrigen.
      /// </summary>
      [DataMember]
      public String PUER_CodEstandarOrigen
      {
         get { return m_puer_codestandarorigen; }
         set {
            if (m_puer_codestandarorigen != value)
            { m_puer_codestandarorigen = value; }
         }
      }

      /// <summary>
      /// Gets or sets el valor de: PUER_CodEstandarDestino.
      /// </summary>
      [DataMember]
      public String PUER_CodEstandarDestino
      {
         get { return m_puer_codestandardestino; }
         set {
            if (m_puer_codestandardestino != value)
            { m_puer_codestandardestino = value; }
         }
      }
      
      #endregion
	   #endregion

      
   }
}
