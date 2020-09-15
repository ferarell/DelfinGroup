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
   public partial class Entidad_Acuerdo : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int32 m_acue_codigo;
		private Nullable<Int16> m_tipe_codigo;
		private Int32 m_entc_codigo;
		private Nullable<DateTime> m_acue_fecemi;
		private Nullable<DateTime> m_acue_fecini;
		private Boolean m_acue_activo;
		private Decimal m_acue_valor;
		private String m_cons_tabacu;
		private String m_cons_codacu;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Entidad_Acuerdo.
		/// </summary>
		public Entidad_Acuerdo()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: ACUE_Codigo.
		/// </summary>
		[DataMember]
		public Int32 ACUE_Codigo
		{
			get { return m_acue_codigo; }
			set
			{
				if (m_acue_codigo != value)
				{
					m_acue_codigo = value;
					OnPropertyChanged("ACUE_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPE_Codigo.
		/// </summary>
		[DataMember]
		public Nullable<Int16> TIPE_Codigo
		{
			get { return m_tipe_codigo; }
			set
			{
				if (m_tipe_codigo != value)
				{
					m_tipe_codigo = value;
					OnPropertyChanged("TIPE_Codigo");
				}
			}
		}
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
		/// Gets or sets el valor de: ACUE_FecEmi.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> ACUE_FecEmi
		{
			get { return m_acue_fecemi; }
			set
			{
				if (m_acue_fecemi != value)
				{
					m_acue_fecemi = value;
					OnPropertyChanged("ACUE_FecEmi");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ACUE_FecIni.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> ACUE_FecIni
		{
			get { return m_acue_fecini; }
			set
			{
				if (m_acue_fecini != value)
				{
					m_acue_fecini = value;
					OnPropertyChanged("ACUE_FecIni");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ACUE_Activo.
		/// </summary>
		[DataMember]
		public Boolean ACUE_Activo
		{
			get { return m_acue_activo; }
			set
			{
				if (m_acue_activo != value)
				{
					m_acue_activo = value;
					OnPropertyChanged("ACUE_Activo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ACUE_Valor.
		/// </summary>
		[DataMember]
		public Decimal ACUE_Valor
		{
			get { return m_acue_valor; }
			set
			{
				if (m_acue_valor != value)
				{
					m_acue_valor = value;
					OnPropertyChanged("ACUE_Valor");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_TabACU.
		/// </summary>
		[DataMember]
		public String CONS_TabACU
		{
			get { return m_cons_tabacu; }
			set
			{
				if (m_cons_tabacu != value)
				{
					m_cons_tabacu = value;
					OnPropertyChanged("CONS_TabACU");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_CodACU.
		/// </summary>
		[DataMember]
		public String CONS_CodACU
		{
			get { return m_cons_codacu; }
			set
			{
				if (m_cons_codacu != value)
				{
					m_cons_codacu = value;
					OnPropertyChanged("CONS_CodACU");
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
		public void CopyTo(ref Entidad_Acuerdo Item)
		{
			try
			{
				if (Item == null) { Item = new Entidad_Acuerdo(); }
				Item.ACUE_Codigo = this.ACUE_Codigo;
				Item.TIPE_Codigo = this.TIPE_Codigo;
				Item.ENTC_Codigo = this.ENTC_Codigo;
				Item.ACUE_FecEmi = this.ACUE_FecEmi;
				Item.ACUE_FecIni = this.ACUE_FecIni;
				Item.ACUE_Activo = this.ACUE_Activo;
				Item.ACUE_Valor = this.ACUE_Valor;
				Item.CONS_TabACU = this.CONS_TabACU;
				Item.CONS_CodACU = this.CONS_CodACU;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
