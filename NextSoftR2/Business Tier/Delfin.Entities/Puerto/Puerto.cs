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
   public partial class Puerto : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int32 m_puer_codigo;
		private String m_puer_codestandar;
		private String m_cons_tabvia;
		private String m_cons_codvia;
		private String m_puer_nombre;
		private Boolean m_puer_favorito;
		private String m_tipo_tabpais;
		private String m_tipo_codpais;
		private Nullable<Boolean> m_puer_activo;
        private String m_puer_codaduana;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Puerto.
		/// </summary>
		public Puerto()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: PUER_Codigo.
		/// </summary>
		[DataMember]
      public Int32 PUER_Codigo
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
		/// Gets or sets el valor de: PUER_CodEstandar.
		/// </summary>
		[DataMember]
		public String PUER_CodEstandar
		{
			get { return m_puer_codestandar; }
			set
			{
				if (m_puer_codestandar != value)
				{
					m_puer_codestandar = value;
					OnPropertyChanged("PUER_CodEstandar");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_TabVia.
		/// </summary>
		[DataMember]
		public String CONS_TabVia
		{
			get { return m_cons_tabvia; }
			set
			{
				if (m_cons_tabvia != value)
				{
					m_cons_tabvia = value;
					OnPropertyChanged("CONS_TabVia");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_CodVia.
		/// </summary>
		[DataMember]
		public String CONS_CodVia
		{
			get { return m_cons_codvia; }
			set
			{
				if (m_cons_codvia != value)
				{
					m_cons_codvia = value;
					OnPropertyChanged("CONS_CodVia");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PUER_Nombre.
		/// </summary>
		[DataMember]
		public String PUER_Nombre
		{
			get { return m_puer_nombre; }
			set
			{
				if (m_puer_nombre != value)
				{
					m_puer_nombre = value;
					OnPropertyChanged("PUER_Nombre");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PUER_Favorito.
		/// </summary>
		[DataMember]
		public Boolean PUER_Favorito
		{
			get { return m_puer_favorito; }
			set
			{
				if (m_puer_favorito != value)
				{
					m_puer_favorito = value;
					OnPropertyChanged("PUER_Favorito");
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
		/// Gets or sets el valor de: PUER_Activo.
		/// </summary>
		[DataMember]
		public Nullable<Boolean> PUER_Activo
		{
			get { return m_puer_activo; }
			set
			{
				if (m_puer_activo != value)
				{
					m_puer_activo = value;
					OnPropertyChanged("PUER_Activo");
				}
			}
		}
        /// <summary>
        /// Gets or sets el valor de: PUER_CodAduana.
        /// </summary>
        [DataMember]
        public String PUER_CodAduana
        {
            get { return m_puer_codaduana; }
            set
            {
                if (m_puer_codaduana != value)
                {
                    m_puer_codaduana = value;
                    OnPropertyChanged("PUER_CodAduana");
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
		public void CopyTo(ref Puerto Item)
		{
			try
			{
				if (Item == null) { Item = new Puerto(); }
				Item.PUER_Codigo = this.PUER_Codigo;
				Item.PUER_CodEstandar = this.PUER_CodEstandar;
				Item.CONS_TabVia = this.CONS_TabVia;
				Item.CONS_CodVia = this.CONS_CodVia;
				Item.PUER_Nombre = this.PUER_Nombre;
				Item.PUER_Favorito = this.PUER_Favorito;
				Item.TIPO_TabPais = this.TIPO_TabPais;
				Item.TIPO_CodPais = this.TIPO_CodPais;
				Item.PUER_Activo = this.PUER_Activo;
                Item.PUER_CodAduana = this.PUER_CodAduana;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
