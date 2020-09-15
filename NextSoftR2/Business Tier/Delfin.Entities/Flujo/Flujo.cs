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
	public partial class Flujo : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int16 m_empr_codigo;
		private String m_fluj_codigo;
        private String m_fluj_glosa;
		private String m_fluj_tipoflujo;
		private String m_fluj_tipomovimiento;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
        private String m_fluj_tipoflujo_text;
	    private String m_fluj_tipomovimiento_text;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Flujo.
		/// </summary>
		public Flujo()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: EMPR_Codigo.
		/// </summary>
		[DataMember]
		public Int16 EMPR_Codigo
		{
			get { return m_empr_codigo; }
			set
			{
				if (m_empr_codigo != value)
				{
					m_empr_codigo = value;
					OnPropertyChanged("EMPR_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FLUJ_Codigo.
		/// </summary>
		[DataMember]
		public String FLUJ_Codigo
		{
			get { return m_fluj_codigo; }
			set
			{
				if (m_fluj_codigo != value)
				{
					m_fluj_codigo = value;
					OnPropertyChanged("FLUJ_Codigo");
				}
			}
		}
        /// <summary>
		/// Gets or sets el valor de: FLUJ_Glosa.
		/// </summary>
		[DataMember]
		public String FLUJ_Glosa
		{
			get { return m_fluj_glosa; }
			set
			{
				if (m_fluj_glosa != value)
				{
					m_fluj_glosa = value;
					OnPropertyChanged("FLUJ_Glosa");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FLUJ_TipoFlujo.
		/// </summary>
		[DataMember]
		public String FLUJ_TipoFlujo
		{
			get { return m_fluj_tipoflujo; }
			set
			{
				if (m_fluj_tipoflujo != value)
				{
					m_fluj_tipoflujo = value;
					OnPropertyChanged("FLUJ_TipoFlujo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FLUJ_TipoMovimiento.
		/// </summary>
		[DataMember]
		public String FLUJ_TipoMovimiento
		{
			get { return m_fluj_tipomovimiento; }
			set
			{
				if (m_fluj_tipomovimiento != value)
				{
					m_fluj_tipomovimiento = value;
					OnPropertyChanged("FLUJ_TipoMovimiento");
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
        /// <summary>
        /// Gets or sets el valor de: AUDI_FecMod.
        /// </summary>
        [DataMember]
        public String FLUJ_TipoFlujo_Text
        {
            get { return m_fluj_tipoflujo_text; }
            set
            {
                if (m_fluj_tipoflujo_text != value)
                {
                    m_fluj_tipoflujo_text = value;
                    OnPropertyChanged("FLUJ_TipoFlujo_Text");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: AUDI_FecMod.
        /// </summary>
        [DataMember]
        public String FLUJ_TipoMovimiento_Text
        {
            get { return m_fluj_tipomovimiento_text; }
            set
            {
                if (m_fluj_tipomovimiento_text != value)
                {
                    m_fluj_tipomovimiento_text = value;
                    OnPropertyChanged("FLUJ_TipoMovimiento_Text");
                }
            }
        }
		#endregion

		#region [ CopyTo ]
		public void CopyTo(ref Flujo Item)
		{
			try
			{
				if (Item == null) { Item = new Flujo(); }
				Item.EMPR_Codigo = this.EMPR_Codigo;
				Item.FLUJ_Codigo = this.FLUJ_Codigo;
				Item.FLUJ_Glosa = this.FLUJ_Glosa;
				Item.FLUJ_TipoFlujo = this.FLUJ_TipoFlujo;
				Item.FLUJ_TipoMovimiento = this.FLUJ_TipoMovimiento;
			    Item.FLUJ_TipoFlujo_Text = this.FLUJ_TipoFlujo;
                Item.FLUJ_TipoMovimiento_Text = this.FLUJ_TipoMovimiento_Text;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
