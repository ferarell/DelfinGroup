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
	public partial class DetNaveViaje : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int32 m_dvia_codigo;
		private Int32 m_nvia_codigo;
		private Nullable<Int32> m_puer_codigo;
		private Nullable<DateTime> m_dvia_feceta_expo_etdmaster_impo;
		private DateTime m_audi_feccrea;
		private String m_audi_usrcrea;
      private String m_audi_usrmod;
      private Nullable<DateTime> m_audi_fecmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase DetNaveViaje.
		/// </summary>
		public DetNaveViaje()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: DVIA_Codigo.
		/// </summary>
		[DataMember]
		public Int32 DVIA_Codigo
		{
			get { return m_dvia_codigo; }
			set
			{
				if (m_dvia_codigo != value)
				{
					m_dvia_codigo = value;
					OnPropertyChanged("DVIA_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: NVIA_Codigo.
		/// </summary>
		[DataMember]
		public Int32 NVIA_Codigo
		{
			get { return m_nvia_codigo; }
			set
			{
				if (m_nvia_codigo != value)
				{
					m_nvia_codigo = value;
					OnPropertyChanged("NVIA_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PUER_Codigo.
		/// </summary>
		[DataMember]
		public Nullable<Int32> PUER_Codigo
		{
			get { return m_puer_codigo; }
			set
			{
				if (m_puer_codigo != value)
				{
					m_puer_codigo = value;
					OnPropertyChanged("PUER_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DVIA_FecETA_EXPO_ETDMaster_IMPO.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> DVIA_FecETA_EXPO_ETDMaster_IMPO
		{
			get { return m_dvia_feceta_expo_etdmaster_impo; }
			set
			{
				if (m_dvia_feceta_expo_etdmaster_impo != value)
				{
					m_dvia_feceta_expo_etdmaster_impo = value;
					OnPropertyChanged("DVIA_FecETA_EXPO_ETDMaster_IMPO");
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

		#region [ CopyTo ]
		public void CopyTo(ref DetNaveViaje Item)
		{
			try
			{
				if (Item == null) { Item = new DetNaveViaje(); }
				Item.DVIA_Codigo = this.DVIA_Codigo;
				Item.NVIA_Codigo = this.NVIA_Codigo;
				Item.PUER_Codigo = this.PUER_Codigo;
				Item.DVIA_FecETA_EXPO_ETDMaster_IMPO = this.DVIA_FecETA_EXPO_ETDMaster_IMPO;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
