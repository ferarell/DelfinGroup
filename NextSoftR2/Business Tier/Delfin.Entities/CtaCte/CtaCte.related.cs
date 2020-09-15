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
   public partial class CtaCte
   {
      #region [ Variables ]

      private Entidad m_itemEntidad;
      private ObservableCollection<Entidad> m_listEntidad;
      private TiposEntidad m_itemTiposEntidad;
      private ObservableCollection<TiposEntidad> m_listTiposEntidad;
      private DocsVta m_itemDocsVta;
      private ObservableCollection<DocsVta> m_listDocsVta;
      private ObservableCollection<Det_Operacion> m_listdet_operacion;
      private ObservableCollection<DetCtaCte> m_listDetCtaCte;

      #endregion

      #region [ Propiedades ]

      [DataMember]
      public ObservableCollection<DetCtaCte> ListDetCtaCte
      {
         get { return this.m_listDetCtaCte; }
         set { this.m_listDetCtaCte = value; }
      }

      /// <summary>
      /// Gets or sets el valor de: Entidad.
      /// </summary>
      [DataMember]
      public Entidad ItemEntidad
      {
         get { return m_itemEntidad; }
         set { m_itemEntidad = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: Entidad.
      /// </summary>
      [DataMember]
      public ObservableCollection<Entidad> ListEntidad
      {
         get { return m_listEntidad; }
         set { m_listEntidad = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: TiposEntidad.
      /// </summary>
      [DataMember]
      public TiposEntidad ItemTiposEntidad
      {
         get { return m_itemTiposEntidad; }
         set { m_itemTiposEntidad = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: TiposEntidad.
      /// </summary>
      [DataMember]
      public ObservableCollection<TiposEntidad> ListTiposEntidad
      {
         get { return m_listTiposEntidad; }
         set { m_listTiposEntidad = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: DocsVta.
      /// </summary>
      [DataMember]
      public DocsVta ItemDocsVta
      {
         get { return m_itemDocsVta; }
         set { m_itemDocsVta = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: DocsVta.
      /// </summary>
      [DataMember]
      public ObservableCollection<DocsVta> ListDocsVta
      {
         get { return m_listDocsVta; }
         set { m_listDocsVta = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: DocsVta.
      /// </summary>
      [DataMember]
      public ObservableCollection<Det_Operacion> ListDet_Operacion
      {
         get { return m_listdet_operacion; }
         set { m_listdet_operacion = value; }
      }

      [DataMember]
      public CabPerfilAsientos ItemCabPerfilAsientos { get; set; }

      [DataMember]
      public ObservableCollection<DetCtaCteAsientos> ListDetCtaCteAsientos { get; set; }

      [DataMember]
      public DetCtaCteAsientos DetCtaCteAsientos { get; set; }

      [DataMember]
      public ObservableCollection<DetCtaCteAsientos> ListDetCtaCteAsientosEliminados { get; set; }

      #endregion
   }
}
