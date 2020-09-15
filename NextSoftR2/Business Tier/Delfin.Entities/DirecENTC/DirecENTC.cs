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
   public partial class DirecENTC : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int32 m_entc_codigo;
		private Int16 m_dire_codigo;
		private String m_dire_direccion;
		private Boolean m_dire_facturar;
		private String m_dire_referencia;
		private Boolean m_dire_activo;
		private String m_ubig_codigo;
		private String m_tipo_tabpais;
		private String m_tipo_codpais;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase DirecENTC.
		/// </summary>
		public DirecENTC()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: ENTC_Codigo.
		/// </summary>
		[DataMember]
		public Int32 ENTC_Codigo
		{
			get { return m_entc_codigo; }
			set
			{
				if (m_entc_codigo != value)
				{
					m_entc_codigo = value;
					OnPropertyChanged("ENTC_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DIRE_Codigo.
		/// </summary>
		[DataMember]
		public Int16 DIRE_Codigo
		{
			get { return m_dire_codigo; }
			set
			{
				if (m_dire_codigo != value)
				{
					m_dire_codigo = value;
					OnPropertyChanged("DIRE_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DIRE_Direccion.
		/// </summary>
		[DataMember]
		public String DIRE_Direccion
		{
			get { return m_dire_direccion; }
			set
			{
				if (m_dire_direccion != value)
				{
					m_dire_direccion = value;
					OnPropertyChanged("DIRE_Direccion");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DIRE_Facturar.
		/// </summary>
		[DataMember]
		public Boolean DIRE_Facturar
		{
			get { return m_dire_facturar; }
			set
			{
				if (m_dire_facturar != value)
				{
					m_dire_facturar = value;
					OnPropertyChanged("DIRE_Facturar");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DIRE_Referencia.
		/// </summary>
		[DataMember]
		public String DIRE_Referencia
		{
			get { return m_dire_referencia; }
			set
			{
				if (m_dire_referencia != value)
				{
					m_dire_referencia = value;
					OnPropertyChanged("DIRE_Referencia");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DIRE_Activo.
		/// </summary>
		[DataMember]
		public Boolean DIRE_Activo
		{
			get { return m_dire_activo; }
			set
			{
				if (m_dire_activo != value)
				{
					m_dire_activo = value;
					OnPropertyChanged("DIRE_Activo");
				}
			}
		}
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
		public void CopyTo(ref DirecENTC Item)
		{
			try
			{
				if (Item == null) { Item = new DirecENTC(); }
				Item.ENTC_Codigo = this.ENTC_Codigo;
				Item.DIRE_Codigo = this.DIRE_Codigo;
				Item.DIRE_Direccion = this.DIRE_Direccion;
				Item.DIRE_Facturar = this.DIRE_Facturar;
				Item.DIRE_Referencia = this.DIRE_Referencia;
				Item.DIRE_Activo = this.DIRE_Activo;
				Item.UBIG_Codigo = this.UBIG_Codigo;
				Item.TIPO_TabPais = this.TIPO_TabPais;
				Item.TIPO_CodPais = this.TIPO_CodPais;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
