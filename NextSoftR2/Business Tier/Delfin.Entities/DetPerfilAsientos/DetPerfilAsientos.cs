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
	public partial class DetPerfilAsientos : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private String m_cabp_ano;
		private String m_cabp_codigo;
		private Int16 m_detp_item;
		private String m_cuen_codigo;
		private String m_detp_glosa;
		private String m_cent_codigo;
		private Nullable<Decimal> m_detp_debeporc;
		private Nullable<Decimal> m_detp_haberporc;
		private String m_part_codigo;
		private Nullable<Int32> m_pper_numero;
		private String m_tiga_codigo;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase DetPerfilAsientos.
		/// </summary>
		public DetPerfilAsientos()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: CABP_Ano.
		/// </summary>
		[DataMember]
		public String CABP_Ano
		{
			get { return m_cabp_ano; }
			set
			{
				if (m_cabp_ano != value)
				{
					m_cabp_ano = value;
					OnPropertyChanged("CABP_Ano");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CABP_Codigo.
		/// </summary>
		[DataMember]
		public String CABP_Codigo
		{
			get { return m_cabp_codigo; }
			set
			{
				if (m_cabp_codigo != value)
				{
					m_cabp_codigo = value;
					OnPropertyChanged("CABP_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DETP_Item.
		/// </summary>
		[DataMember]
		public Int16 DETP_Item
		{
			get { return m_detp_item; }
			set
			{
				if (m_detp_item != value)
				{
					m_detp_item = value;
					OnPropertyChanged("DETP_Item");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CUEN_Codigo.
		/// </summary>
		[DataMember]
		public String CUEN_Codigo
		{
			get { return m_cuen_codigo; }
			set
			{
				if (m_cuen_codigo != value)
				{
					m_cuen_codigo = value;
					OnPropertyChanged("CUEN_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DETP_Glosa.
		/// </summary>
		[DataMember]
		public String DETP_Glosa
		{
			get { return m_detp_glosa; }
			set
			{
				if (m_detp_glosa != value)
				{
					m_detp_glosa = value;
					OnPropertyChanged("DETP_Glosa");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CENT_Codigo.
		/// </summary>
		[DataMember]
		public String CENT_Codigo
		{
			get { return m_cent_codigo; }
			set
			{
				if (m_cent_codigo != value)
				{
					m_cent_codigo = value;
					OnPropertyChanged("CENT_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DETP_DebePorc.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> DETP_DebePorc
		{
			get { return m_detp_debeporc; }
			set
			{
				if (m_detp_debeporc != value)
				{
					m_detp_debeporc = value;
					OnPropertyChanged("DETP_DebePorc");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DETP_HaberPorc.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> DETP_HaberPorc
		{
			get { return m_detp_haberporc; }
			set
			{
				if (m_detp_haberporc != value)
				{
					m_detp_haberporc = value;
					OnPropertyChanged("DETP_HaberPorc");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PART_Codigo.
		/// </summary>
		[DataMember]
		public String PART_Codigo
		{
			get { return m_part_codigo; }
			set
			{
				if (m_part_codigo != value)
				{
					m_part_codigo = value;
					OnPropertyChanged("PART_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PPER_Numero.
		/// </summary>
		[DataMember]
		public Nullable<Int32> PPER_Numero
		{
			get { return m_pper_numero; }
			set
			{
				if (m_pper_numero != value)
				{
					m_pper_numero = value;
					OnPropertyChanged("PPER_Numero");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIGA_codigo.
		/// </summary>
		[DataMember]
		public String TIGA_codigo
		{
			get { return m_tiga_codigo; }
			set
			{
				if (m_tiga_codigo != value)
				{
					m_tiga_codigo = value;
					OnPropertyChanged("TIGA_codigo");
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
		public void CopyTo(ref DetPerfilAsientos Item)
		{
			try
			{
				if (Item == null) { Item = new DetPerfilAsientos(); }
				Item.CABP_Ano = this.CABP_Ano;
				Item.CABP_Codigo = this.CABP_Codigo;
				Item.DETP_Item = this.DETP_Item;
				Item.CUEN_Codigo = this.CUEN_Codigo;
				Item.DETP_Glosa = this.DETP_Glosa;
				Item.CENT_Codigo = this.CENT_Codigo;
				Item.DETP_DebePorc = this.DETP_DebePorc;
				Item.DETP_HaberPorc = this.DETP_HaberPorc;
				Item.PART_Codigo = this.PART_Codigo;
				Item.PPER_Numero = this.PPER_Numero;
				Item.TIGA_codigo = this.TIGA_codigo;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
