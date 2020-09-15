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
	public partial class Det_Cotizacion_OV_EventosTareas : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int32 m_ccot_numero;
		private Int16 m_ccot_tipo;
		private Int16 m_even_item;
      private Nullable<DateTime> m_even_fecha;
		private Boolean m_even_cumplida;
		private String m_even_usuario;
		private String m_even_observaciones;
		private String m_tipo_tabeve;
		private String m_tipo_codeve;
		private String m_cons_tabmod;
		private String m_cons_codmod;
      private Boolean m_even_manual;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase DetEventosTareas.
		/// </summary>
		public Det_Cotizacion_OV_EventosTareas()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: CCOT_Numero.
		/// </summary>
		[DataMember]
		public Int32 CCOT_Numero
		{
			get { return m_ccot_numero; }
			set
			{
				if (m_ccot_numero != value)
				{
					m_ccot_numero = value;
					OnPropertyChanged("CCOT_Numero");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CCOT_Tipo.
		/// </summary>
		[DataMember]
		public Int16 CCOT_Tipo
		{
			get { return m_ccot_tipo; }
			set
			{
				if (m_ccot_tipo != value)
				{
					m_ccot_tipo = value;
					OnPropertyChanged("CCOT_Tipo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: EVEN_Item.
		/// </summary>
		[DataMember]
		public Int16 EVEN_Item
		{
			get { return m_even_item; }
			set
			{
				if (m_even_item != value)
				{
					m_even_item = value;
					OnPropertyChanged("EVEN_Item");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: EVEN_Fecha.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> EVEN_Fecha
		{
			get { return m_even_fecha; }
			set
			{
				if (m_even_fecha != value)
				{
					m_even_fecha = value;
					OnPropertyChanged("EVEN_Fecha");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: EVEN_Cumplida.
		/// </summary>
		[DataMember]
		public Boolean EVEN_Cumplida
		{
			get { return m_even_cumplida; }
			set
			{
				if (m_even_cumplida != value)
				{
					m_even_cumplida = value;
					OnPropertyChanged("EVEN_Cumplida");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: EVEN_Usuario.
		/// </summary>
		[DataMember]
		public String EVEN_Usuario
		{
			get { return m_even_usuario; }
			set
			{
				if (m_even_usuario != value)
				{
					m_even_usuario = value;
					OnPropertyChanged("EVEN_Usuario");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: EVEN_Observaciones.
		/// </summary>
		[DataMember]
		public String EVEN_Observaciones
		{
			get { return m_even_observaciones; }
			set
			{
				if (m_even_observaciones != value)
				{
					m_even_observaciones = value;
					OnPropertyChanged("EVEN_Observaciones");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_TabEVE.
		/// </summary>
		[DataMember]
		public String TIPO_TabEVE
		{
			get { return m_tipo_tabeve; }
			set
			{
				if (m_tipo_tabeve != value)
				{
					m_tipo_tabeve = value;
					OnPropertyChanged("TIPO_TabEVE");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodEVE.
		/// </summary>
		[DataMember]
		public String TIPO_CodEVE
		{
			get { return m_tipo_codeve; }
			set
			{
				if (m_tipo_codeve != value)
				{
					m_tipo_codeve = value;
					OnPropertyChanged("TIPO_CodEVE");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_TabMOD.
		/// </summary>
		[DataMember]
		public String CONS_TabMOD
		{
			get { return m_cons_tabmod; }
			set
			{
				if (m_cons_tabmod != value)
				{
					m_cons_tabmod = value;
					OnPropertyChanged("CONS_TabMOD");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_CodMOD.
		/// </summary>
		[DataMember]
		public String CONS_CodMOD
		{
			get { return m_cons_codmod; }
			set
			{
				if (m_cons_codmod != value)
				{
					m_cons_codmod = value;
					OnPropertyChanged("CONS_CodMOD");
				}
			}
		}
      /// <summary>
      /// Gets or sets el valor de: EVEN_Manual.
      /// </summary>
      [DataMember]
      public Boolean EVEN_Manual
      {
         get { return m_even_manual; }
         set
         {
            if (m_even_manual != value)
            {
               m_even_manual = value;
               OnPropertyChanged("EVEN_Manual");
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

		#region [ CopyTo ]
		public void CopyTo(ref Det_Cotizacion_OV_EventosTareas Item)
		{
			try
			{
				if (Item == null) { Item = new Det_Cotizacion_OV_EventosTareas(); }
				Item.CCOT_Numero = this.CCOT_Numero;
				Item.CCOT_Tipo = this.CCOT_Tipo;
				Item.EVEN_Item = this.EVEN_Item;
				Item.EVEN_Fecha = this.EVEN_Fecha;
				Item.EVEN_Cumplida = this.EVEN_Cumplida;
				Item.EVEN_Usuario = this.EVEN_Usuario;
				Item.EVEN_Observaciones = this.EVEN_Observaciones;
				Item.TIPO_TabEVE = this.TIPO_TabEVE;
				Item.TIPO_CodEVE = this.TIPO_CodEVE;
				Item.CONS_TabMOD = this.CONS_TabMOD;
				Item.CONS_CodMOD = this.CONS_CodMOD;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
