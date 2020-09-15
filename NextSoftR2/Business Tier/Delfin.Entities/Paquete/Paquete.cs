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
   public partial class Paquete : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int32 m_pack_codigo;
		private String m_pack_desc;
		private String m_pack_descc;
		private String m_tipo_tabpaq;
		private String m_tipo_codpaq;
		private String m_tipo_tabtam;
		private String m_tipo_codtam;
		private String m_tipo_tabcnt;
		private String m_tipo_codcnt;
      private Nullable<Boolean> m_pack_activo;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Paquete.
		/// </summary>
		public Paquete()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: PACK_Codigo.
		/// </summary>
		[DataMember]
		public Int32 PACK_Codigo
		{
			get { return m_pack_codigo; }
			set
			{
				if (m_pack_codigo != value)
				{
					m_pack_codigo = value;
					OnPropertyChanged("PACK_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PACK_Desc.
		/// </summary>
		[DataMember]
		public String PACK_Desc
		{
			get { return m_pack_desc; }
			set
			{
				if (m_pack_desc != value)
				{
					m_pack_desc = value;
					OnPropertyChanged("PACK_Desc");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PACK_DescC.
		/// </summary>
		[DataMember]
		public String PACK_DescC
		{
			get { return m_pack_descc; }
			set
			{
				if (m_pack_descc != value)
				{
					m_pack_descc = value;
					OnPropertyChanged("PACK_DescC");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_TabPAQ.
		/// </summary>
		[DataMember]
		public String TIPO_TabPAQ
		{
			get { return m_tipo_tabpaq; }
			set
			{
				if (m_tipo_tabpaq != value)
				{
					m_tipo_tabpaq = value;
					OnPropertyChanged("TIPO_TabPAQ");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodPAQ.
		/// </summary>
		[DataMember]
		public String TIPO_CodPAQ
		{
			get { return m_tipo_codpaq; }
			set
			{
				if (m_tipo_codpaq != value)
				{
					m_tipo_codpaq = value;
					OnPropertyChanged("TIPO_CodPAQ");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_TabTAM.
		/// </summary>
		[DataMember]
		public String TIPO_TabTAM
		{
			get { return m_tipo_tabtam; }
			set
			{
				if (m_tipo_tabtam != value)
				{
					m_tipo_tabtam = value;
					OnPropertyChanged("TIPO_TabTAM");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodTAM.
		/// </summary>
		[DataMember]
		public String TIPO_CodTAM
		{
			get { return m_tipo_codtam; }
			set
			{
				if (m_tipo_codtam != value)
				{
					m_tipo_codtam = value;
					OnPropertyChanged("TIPO_CodTAM");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_TabCNT.
		/// </summary>
		[DataMember]
		public String TIPO_TabCNT
		{
			get { return m_tipo_tabcnt; }
			set
			{
				if (m_tipo_tabcnt != value)
				{
					m_tipo_tabcnt = value;
					OnPropertyChanged("TIPO_TabCNT");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodCNT.
		/// </summary>
		[DataMember]
		public String TIPO_CodCNT
		{
			get { return m_tipo_codcnt; }
			set
			{
				if (m_tipo_codcnt != value)
				{
					m_tipo_codcnt = value;
					OnPropertyChanged("TIPO_CodCNT");
				}
			}
		}
      /// <summary>
		/// Gets or sets el valor de: PACK_Activo.
		/// </summary>
		[DataMember]
		public Nullable<Boolean> PACK_Activo
		{
			get { return m_pack_activo; }
			set
			{
				if (m_pack_activo != value)
				{
					m_pack_activo = value;
					OnPropertyChanged("PACK_Activo");
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
		public void CopyTo(ref Paquete Item)
		{
			try
			{
				if (Item == null) { Item = new Paquete(); }
				Item.PACK_Codigo = this.PACK_Codigo;
				Item.PACK_Desc = this.PACK_Desc;
				Item.PACK_DescC = this.PACK_DescC;
				Item.TIPO_TabPAQ = this.TIPO_TabPAQ;
				Item.TIPO_CodPAQ = this.TIPO_CodPAQ;
				Item.TIPO_TabTAM = this.TIPO_TabTAM;
				Item.TIPO_CodTAM = this.TIPO_CodTAM;
				Item.TIPO_TabCNT = this.TIPO_TabCNT;
				Item.TIPO_CodCNT = this.TIPO_CodCNT;
            Item.TIPO_Desc1_Pack = this.TIPO_Desc1_Pack;
            Item.TIPO_Desc1_Tam = this.TIPO_Desc1_Tam;
            Item.TIPO_Desc1_Cont = this.TIPO_Desc1_Cont;
				Item.PACK_Activo = this.PACK_Activo;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
