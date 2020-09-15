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
	public partial class Puerto
   {
      #region [ Variables ]
      private String m_TIPO_DescPais;
      private String m_TIPO_DescCPais;
	   private String m_CONS_DescVia;

      private String m_tipo_tabtrf;
      private String m_tipo_codtrf;
      private String m_tipo_desctrf;
      #endregion

      #region [ Propiedades ]
      /// <summary>
      /// Gets or sets el valor de: TIPO_DescPais.
      /// </summary>
      [DataMember]
      public String TIPO_DescPais
      {
         get { return m_TIPO_DescPais; }
         set
         {
            if (m_TIPO_DescPais != value)
            {
               m_TIPO_DescPais = value;
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: TIPO_DescCPais.
      /// </summary>
      [DataMember]
      public String TIPO_DescCPais
      {
         get { return m_TIPO_DescCPais; }
         set
         {
            if (m_TIPO_DescCPais != value)
            {
               m_TIPO_DescCPais = value;
            }
         }
      }

      /// <summary>
      /// Gets or sets el valor de: CONS_DescVia.
      /// </summary>
      [DataMember]
      public String CONS_DescVia
      {
         get { return m_CONS_DescVia; }
         set
         {
            if (m_CONS_DescVia != value)
            {
               m_CONS_DescVia = value;
            }
         }
      }

      /// <summary>
      /// Gets or sets el valor de: TIPO_TabTRF.
      /// </summary>
      [DataMember]
      public String TIPO_TabTRF
      {
         get { return m_tipo_tabtrf; }
         set
         {
            if (m_tipo_tabtrf != value)
            { m_tipo_tabtrf = value; }
         }
      }
      
      /// <summary>
      /// Gets or sets el valor de: TIPO_CodTRF.
      /// </summary>
      [DataMember]
      public String TIPO_CodTRF
      {
         get { return m_tipo_codtrf; }
         set
         {
            if (m_tipo_codtrf != value)
            { m_tipo_codtrf = value; }
         }
      }

      /// <summary>
      /// Gets or sets el valor de: TIPO_DescTRF.
      /// </summary>
      [DataMember]
      public String TIPO_DescTRF
      {
         get { return m_tipo_desctrf; }
         set
         {
            if (m_tipo_desctrf != value)
            { m_tipo_desctrf = value; }
         }
      }
      #endregion
	}
}
