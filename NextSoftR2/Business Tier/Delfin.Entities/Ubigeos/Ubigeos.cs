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
   public partial class Ubigeos : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private String m_ubig_codigo;
		private String m_tipo_codpais;
		private String m_tipo_tabpais;
		private String m_ubig_desc;
		private String m_ubig_descc;
		private String m_ubig_codpadre;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Ubigeos.
		/// </summary>
		public Ubigeos()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: UBIG_Codigo.
		/// </summary>
		[DataMember]
		public String UBIG_Codigo
		{
			get { return m_ubig_codigo; }
			set
			{
				if (m_ubig_codigo != value)
				{
					m_ubig_codigo = value;
					OnPropertyChanged("UBIG_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodPais.
		/// </summary>
		[DataMember]
		public String TIPO_CodPais
		{
			get { return m_tipo_codpais; }
			set
			{
				if (m_tipo_codpais != value)
				{
					m_tipo_codpais = value;
					OnPropertyChanged("TIPO_CodPais");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_TabPais.
		/// </summary>
		[DataMember]
		public String TIPO_TabPais
		{
			get { return m_tipo_tabpais; }
			set
			{
				if (m_tipo_tabpais != value)
				{
					m_tipo_tabpais = value;
					OnPropertyChanged("TIPO_TabPais");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: UBIG_Desc.
		/// </summary>
		[DataMember]
		public String UBIG_Desc
		{
			get { return m_ubig_desc; }
			set
			{
				if (m_ubig_desc != value)
				{
					m_ubig_desc = value;
					OnPropertyChanged("UBIG_Desc");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: UBIG_DescC.
		/// </summary>
		[DataMember]
		public String UBIG_DescC
		{
			get { return m_ubig_descc; }
			set
			{
				if (m_ubig_descc != value)
				{
					m_ubig_descc = value;
					OnPropertyChanged("UBIG_DescC");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: UBIG_CodPadre.
		/// </summary>
		[DataMember]
		public String UBIG_CodPadre
		{
			get { return m_ubig_codpadre; }
			set
			{
				if (m_ubig_codpadre != value)
				{
					m_ubig_codpadre = value;
					OnPropertyChanged("UBIG_CodPadre");
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
		public void CopyTo(ref Ubigeos Item)
		{
			try
			{
				if (Item == null) { Item = new Ubigeos(); }
				Item.UBIG_Codigo = this.UBIG_Codigo;
				Item.TIPO_CodPais = this.TIPO_CodPais;
				Item.TIPO_TabPais = this.TIPO_TabPais;
				Item.UBIG_Desc = this.UBIG_Desc;
				Item.UBIG_DescC = this.UBIG_DescC;
				Item.UBIG_CodPadre = this.UBIG_CodPadre;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
