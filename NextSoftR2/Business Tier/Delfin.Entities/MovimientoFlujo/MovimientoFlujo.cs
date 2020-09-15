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
	public partial class MovimientoFlujo : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int16 m_empr_codigo;
		private Int32 m_movi_codigo;
		private Int16 m_mflu_item;
		private String m_fluj_codigo;
		private String m_mflu_flujo;
		private Nullable<Decimal> m_mflu_porcentaje;
		private Nullable<Decimal> m_mflu_monto;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
        private String m_fluj_glosa;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase MovimientoFlujo.
		/// </summary>
		public MovimientoFlujo()
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
		/// Gets or sets el valor de: MOVI_Codigo.
		/// </summary>
		[DataMember]
		public Int32 MOVI_Codigo
		{
			get { return m_movi_codigo; }
			set
			{
				if (m_movi_codigo != value)
				{
					m_movi_codigo = value;
					OnPropertyChanged("MOVI_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: MFLU_Item.
		/// </summary>
		[DataMember]
		public Int16 MFLU_Item
		{
			get { return m_mflu_item; }
			set
			{
				if (m_mflu_item != value)
				{
					m_mflu_item = value;
					OnPropertyChanged("MFLU_Item");
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
		/// Gets or sets el valor de: MFLU_Flujo.
		/// </summary>
		[DataMember]
		public String MFLU_Flujo
		{
			get { return m_mflu_flujo; }
			set
			{
				if (m_mflu_flujo != value)
				{
					m_mflu_flujo = value;
					OnPropertyChanged("MFLU_Flujo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: MFLU_Porcentaje.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> MFLU_Porcentaje
		{
			get { return m_mflu_porcentaje; }
			set
			{
				if (m_mflu_porcentaje != value)
				{
					m_mflu_porcentaje = value;
					OnPropertyChanged("MFLU_Porcentaje");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: MFLU_Monto.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> MFLU_Monto
		{
			get { return m_mflu_monto; }
			set
			{
				if (m_mflu_monto != value)
				{
					m_mflu_monto = value;
					OnPropertyChanged("MFLU_Monto");
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
		#endregion

		#region [ CopyTo ]
		public void CopyTo(ref MovimientoFlujo Item)
		{
			try
			{
				if (Item == null) { Item = new MovimientoFlujo(); }
				Item.EMPR_Codigo = this.EMPR_Codigo;
				Item.MOVI_Codigo = this.MOVI_Codigo;
				Item.MFLU_Item = this.MFLU_Item;
				Item.FLUJ_Codigo = this.FLUJ_Codigo;
				Item.MFLU_Flujo = this.MFLU_Flujo;
				Item.MFLU_Porcentaje = this.MFLU_Porcentaje;
				Item.MFLU_Monto = this.MFLU_Monto;
			    Item.FLUJ_Glosa = this.FLUJ_Glosa;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
