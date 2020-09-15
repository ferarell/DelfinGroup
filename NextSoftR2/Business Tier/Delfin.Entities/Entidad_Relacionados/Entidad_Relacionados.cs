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
	public partial class Entidad_Relacionados : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Nullable<Int32> m_rela_codigo;
		private Nullable<Int32> m_entc_codpadre;
		private Nullable<Int32> m_entc_codhijo;
		private String m_cons_tabrgm;
		private String m_cons_codrgm;
		private Boolean m_rela_activo;
		private DateTime m_audi_feccrea;
		private String m_audi_usrcrea;
		private Nullable<DateTime> m_audi_fecmod;
		private String m_audi_usrmod;
		private String m_tipo_tabtrf;
		private String m_tipo_codtrf;
		private String m_rela_tipos;
		private Nullable<Boolean> m_rela_deptemnegociaagente;
		private Nullable<Int16> m_tipe_codpadre;
		private Nullable<Int16> m_tipe_codhijo;
      private String m_rela_observacion;

		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Entidad_Relacionados.
		/// </summary>
		public Entidad_Relacionados()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: RELA_Codigo.
		/// </summary>
		[DataMember]
		public Nullable<Int32> RELA_Codigo
		{
			get { return m_rela_codigo; }
			set
			{
				if (m_rela_codigo != value)
				{
					m_rela_codigo = value;
					OnPropertyChanged("RELA_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_CodPadre.
		/// </summary>
		[DataMember]
		public Nullable<Int32> ENTC_CodPadre
		{
			get { return m_entc_codpadre; }
			set
			{
				if (m_entc_codpadre != value)
				{
					m_entc_codpadre = value;
					OnPropertyChanged("ENTC_CodPadre");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_CodHijo.
		/// </summary>
		[DataMember]
		public Nullable<Int32> ENTC_CodHijo
		{
			get { return m_entc_codhijo; }
			set
			{
				if (m_entc_codhijo != value)
				{
					m_entc_codhijo = value;
					OnPropertyChanged("ENTC_CodHijo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_TabRGM.
		/// </summary>
		[DataMember]
		public String CONS_TabRGM
		{
			get { return m_cons_tabrgm; }
			set
			{
				if (m_cons_tabrgm != value)
				{
					m_cons_tabrgm = value;
					OnPropertyChanged("CONS_TabRGM");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_CodRGM.
		/// </summary>
		[DataMember]
		public String CONS_CodRGM
		{
			get { return m_cons_codrgm; }
			set
			{
				if (m_cons_codrgm != value)
				{
					m_cons_codrgm = value;
					OnPropertyChanged("CONS_CodRGM");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: RELA_Activo.
		/// </summary>
		[DataMember]
		public Boolean RELA_Activo
		{
			get { return m_rela_activo; }
			set
			{
				if (m_rela_activo != value)
				{
					m_rela_activo = value;
					OnPropertyChanged("RELA_Activo");
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
		/// Gets or sets el valor de: TIPO_TabTRF.
		/// </summary>
		[DataMember]
		public String TIPO_TabTRF
		{
			get { return m_tipo_tabtrf; }
			set
			{
				if (m_tipo_tabtrf != value)
				{
					m_tipo_tabtrf = value;
					OnPropertyChanged("TIPO_TabTRF");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodTRF.
		/// </summary>
		[DataMember]
		public String TIPO_CodTRF
		{
			get { return m_tipo_codtrf; }
			set
			{
				if (m_tipo_codtrf != value)
				{
					m_tipo_codtrf = value;
					OnPropertyChanged("TIPO_CodTRF");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: RELA_Tipos.
		/// </summary>
		[DataMember]
		public String RELA_Tipos
		{
			get { return m_rela_tipos; }
			set
			{
				if (m_rela_tipos != value)
				{
					m_rela_tipos = value;
					OnPropertyChanged("RELA_Tipos");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: RELA_DepTemNegociaAgente.
		/// </summary>
		[DataMember]
		public Nullable<Boolean> RELA_DepTemNegociaAgente
		{
			get { return m_rela_deptemnegociaagente; }
			set
			{
				if (m_rela_deptemnegociaagente != value)
				{
					m_rela_deptemnegociaagente = value;
					OnPropertyChanged("RELA_DepTemNegociaAgente");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPE_CodPadre.
		/// </summary>
		[DataMember]
		public Nullable<Int16> TIPE_CodPadre
		{
			get { return m_tipe_codpadre; }
			set
			{
				if (m_tipe_codpadre != value)
				{
					m_tipe_codpadre = value;
					OnPropertyChanged("TIPE_CodPadre");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPE_CodHijo.
		/// </summary>
		[DataMember]
		public Nullable<Int16> TIPE_CodHijo
		{
			get { return m_tipe_codhijo; }
			set
			{
				if (m_tipe_codhijo != value)
				{
					m_tipe_codhijo = value;
					OnPropertyChanged("TIPE_CodHijo");
				}
			}
		}
      /// <summary>
      /// Gets or sets el valor de: RELA_Observacion.
      /// </summary>
      [DataMember]
      public String RELA_Observacion
      {
         get { return m_rela_observacion; }
         set
         {
            if (m_rela_observacion != value)
            {
               m_rela_observacion = value;
               OnPropertyChanged("RELA_Observacion");
            }
         }
      }

		#endregion

		#region [ CopyTo ]
		public void CopyTo(ref Entidad_Relacionados Item)
		{
			try
			{
				if (Item == null) { Item = new Entidad_Relacionados(); }
				Item.RELA_Codigo = this.RELA_Codigo;
				Item.ENTC_CodPadre = this.ENTC_CodPadre;
				Item.ENTC_CodHijo = this.ENTC_CodHijo;
				Item.CONS_TabRGM = this.CONS_TabRGM;
				Item.CONS_CodRGM = this.CONS_CodRGM;
				Item.RELA_Activo = this.RELA_Activo;
				Item.TIPO_TabTRF = this.TIPO_TabTRF;
				Item.TIPO_CodTRF = this.TIPO_CodTRF;
				Item.RELA_Tipos = this.RELA_Tipos;
				Item.RELA_DepTemNegociaAgente = this.RELA_DepTemNegociaAgente;
				Item.TIPE_CodPadre = this.TIPE_CodPadre;
				Item.TIPE_CodHijo = this.TIPE_CodHijo;
            Item.RELA_Observacion = this.RELA_Observacion;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
