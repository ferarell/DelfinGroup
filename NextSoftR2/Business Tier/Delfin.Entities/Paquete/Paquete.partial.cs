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
	public partial class Paquete
   {
      #region [ Variables ]
      private String m_tipo_desc_pack;
      private String m_tipo_desc_tam;
      private String m_tipo_desc_cont;
		
      #endregion

      #region [ Propiedades ]
      /// <summary>
      /// Gets or sets el valor de: TIPO_Desc1_Pack.
      /// </summary>
      [DataMember]
      public String TIPO_Desc1_Pack
      {
         get { return m_tipo_desc_pack; }
         set
         {
            if (m_tipo_desc_pack != value)
            {
               m_tipo_desc_pack = value;
               OnPropertyChanged("TIPO_Desc1_Pack");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: TIPO_Desc1_Tam.
      /// </summary>
      [DataMember]
      public String TIPO_Desc1_Tam
      {
         get { return m_tipo_desc_tam; }
         set
         {
            if (m_tipo_desc_tam != value)
            {
               m_tipo_desc_tam = value;
               OnPropertyChanged("TIPO_Desc1_Tam");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: TIPO_Desc1_Cont.
      /// </summary>
      [DataMember]
      public String TIPO_Desc1_Cont
      {
         get { return m_tipo_desc_cont; }
         set
         {
            if (m_tipo_desc_cont != value)
            {
               m_tipo_desc_cont = value;
               OnPropertyChanged("TIPO_Desc1_Cont");
            }
         }
      }

      /// <summary>
      /// Gets or sets el valor de: TIPO_Num1TAM.
      /// </summary>
      [DataMember]
      public Nullable<Decimal> TIPO_Num1TAM { get; set; }
      #endregion

      
	}
}
