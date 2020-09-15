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
	public partial class DetMovimiento : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int16 m_empr_codigo;
		private Int32 m_movi_codigo;
		private Int16 m_dmov_item;
		private String m_tipo_tabtgb;
		private String m_tipo_codtgb;
		private Decimal m_dmov_montodebe;
		private Decimal m_dmov_montohaber;
		private String m_dmov_nrooperacion;
		private String m_dmov_flujo;
		private String m_audi_usrcrea;
		private Nullable<DateTime> m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase DetMovimiento.
		/// </summary>
		public DetMovimiento()
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
		/// Gets or sets el valor de: DMOV_Item.
		/// </summary>
		[DataMember]
		public Int16 DMOV_Item
		{
			get { return m_dmov_item; }
			set
			{
				if (m_dmov_item != value)
				{
					m_dmov_item = value;
					OnPropertyChanged("DMOV_Item");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_TabTGB.
		/// </summary>
		[DataMember]
		public String TIPO_TabTGB
		{
			get { return m_tipo_tabtgb; }
			set
			{
				if (m_tipo_tabtgb != value)
				{
					m_tipo_tabtgb = value;
					OnPropertyChanged("TIPO_TabTGB");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodTGB.
		/// </summary>
		[DataMember]
		public String TIPO_CodTGB
		{
			get { return m_tipo_codtgb; }
			set
			{
				if (m_tipo_codtgb != value)
				{
					m_tipo_codtgb = value;
					OnPropertyChanged("TIPO_CodTGB");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DMOV_MontoDebe.
		/// </summary>
		[DataMember]
		public Decimal DMOV_MontoDebe
		{
			get { return m_dmov_montodebe; }
			set
			{
				if (m_dmov_montodebe != value)
				{
					m_dmov_montodebe = value;
					OnPropertyChanged("DMOV_MontoDebe");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DMOV_MontoHaber.
		/// </summary>
		[DataMember]
		public Decimal DMOV_MontoHaber
		{
			get { return m_dmov_montohaber; }
			set
			{
				if (m_dmov_montohaber != value)
				{
					m_dmov_montohaber = value;
					OnPropertyChanged("DMOV_MontoHaber");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DMOV_NroOperacion.
		/// </summary>
		[DataMember]
		public String DMOV_NroOperacion
		{
			get { return m_dmov_nrooperacion; }
			set
			{
				if (m_dmov_nrooperacion != value)
				{
					m_dmov_nrooperacion = value;
					OnPropertyChanged("DMOV_NroOperacion");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DMOV_Flujo.
		/// </summary>
		[DataMember]
		public String DMOV_Flujo
		{
			get { return m_dmov_flujo; }
			set
			{
				if (m_dmov_flujo != value)
				{
					m_dmov_flujo = value;
					OnPropertyChanged("DMOV_Flujo");
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
		public Nullable<DateTime> AUDI_FecCrea
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
		public void CopyTo(ref DetMovimiento Item)
		{
			try
			{
				if (Item == null) { Item = new DetMovimiento(); }
				Item.EMPR_Codigo = this.EMPR_Codigo;
				Item.MOVI_Codigo = this.MOVI_Codigo;
				Item.DMOV_Item = this.DMOV_Item;
				Item.TIPO_TabTGB = this.TIPO_TabTGB;
				Item.TIPO_CodTGB = this.TIPO_CodTGB;
				Item.DMOV_MontoDebe = this.DMOV_MontoDebe;
				Item.DMOV_MontoHaber = this.DMOV_MontoHaber;
				Item.DMOV_NroOperacion = this.DMOV_NroOperacion;
				Item.DMOV_Flujo = this.DMOV_Flujo;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
