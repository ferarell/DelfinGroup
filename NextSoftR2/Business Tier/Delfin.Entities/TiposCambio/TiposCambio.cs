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
   [Serializable()]
   [KnownType(typeof(MasterBusinessEntity))]
   public partial class TiposCambio : MasterBusinessEntity, INotifyPropertyChanged
   {
      #region [ Variables ]
      private String m_tipc_fecha;
      private Decimal m_tipc_compra;
      private Decimal m_tipc_venta;
      private Nullable<Decimal> m_tipc_doleuro;
      private String m_audi_usrcrea;
      private DateTime m_audi_feccrea;
      private String m_audi_usrmod;
      private Nullable<DateTime> m_audi_fecmod;
      #endregion

      #region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase TiposCambio.
		/// </summary>
		public TiposCambio()
		{  }
		#endregion

      #region [ Propiedades ]
      /// <summary>
      /// Gets or sets el valor de: TIPC_Fecha.
      /// </summary>
      [DataMember]
      public String TIPC_Fecha
      {
         get { return m_tipc_fecha; }
         set
         {
            if (m_tipc_fecha != value)
            {
               m_tipc_fecha = value;
               OnPropertyChanged("TIPC_Fecha");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: TIPC_Compra.
      /// </summary>
      [DataMember]
      public Decimal TIPC_Compra
      {
         get { return m_tipc_compra; }
         set
         {
            if (m_tipc_compra != value)
            {
               m_tipc_compra = value;
               OnPropertyChanged("TIPC_Compra");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: TIPC_Venta.
      /// </summary>
      [DataMember]
      public Decimal TIPC_Venta
      {
         get { return m_tipc_venta; }
         set
         {
            if (m_tipc_venta != value)
            {
               m_tipc_venta = value;
               OnPropertyChanged("TIPC_Venta");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: TIPC_DolEuro.
      /// </summary>
      [DataMember]
      public Nullable<Decimal> TIPC_DolEuro
      {
         get { return m_tipc_doleuro; }
         set
         {
            if (m_tipc_doleuro != value)
            {
               m_tipc_doleuro = value;
               OnPropertyChanged("TIPC_DolEuro");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: AUDI_UsrCrea.
      /// </summary>
      [DataMember]
      public String AUDI_UsrCrea
      {
         get { return m_audi_usrcrea; }
         set
         {
            if (m_audi_usrcrea != value)
            {
               m_audi_usrcrea = value;
               OnPropertyChanged("AUDI_UsrCrea");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: AUDI_FecCrea.
      /// </summary>
      [DataMember]
      public DateTime AUDI_FecCrea
      {
         get { return m_audi_feccrea; }
         set
         {
            if (m_audi_feccrea != value)
            {
               m_audi_feccrea = value;
               OnPropertyChanged("AUDI_FecCrea");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: AUDI_UsrMod.
      /// </summary>
      [DataMember]
      public String AUDI_UsrMod
      {
         get { return m_audi_usrmod; }
         set
         {
            if (m_audi_usrmod != value)
            {
               m_audi_usrmod = value;
               OnPropertyChanged("AUDI_UsrMod");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: AUDI_FecMod.
      /// </summary>
      [DataMember]
      public Nullable<DateTime> AUDI_FecMod
      {
         get { return m_audi_fecmod; }
         set
         {
            if (m_audi_fecmod != value)
            {
               m_audi_fecmod = value;
               OnPropertyChanged("AUDI_FecMod");
            }
         }
      }
      #endregion


   }
}
