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
	public partial class CabPerfilAsientos : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private String m_cabp_ano;
		private String m_cabp_codigo;
		private String m_cabp_desc;
		private String m_tipo_codreg;
		private String m_tipo_tabreg;
		private Nullable<Decimal> m_cabp_valorref;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase CabPerfilAsientos.
		/// </summary>
		public CabPerfilAsientos()
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
		/// Gets or sets el valor de: CABP_Desc.
		/// </summary>
		[DataMember]
		public String CABP_Desc
		{
			get { return m_cabp_desc; }
			set
			{
				if (m_cabp_desc != value)
				{
					m_cabp_desc = value;
					OnPropertyChanged("CABP_Desc");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodREG.
		/// </summary>
		[DataMember]
		public String TIPO_CodREG
		{
			get { return m_tipo_codreg; }
			set
			{
				if (m_tipo_codreg != value)
				{
					m_tipo_codreg = value;
					OnPropertyChanged("TIPO_CodREG");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_TabREG.
		/// </summary>
		[DataMember]
		public String TIPO_TabREG
		{
			get { return m_tipo_tabreg; }
			set
			{
				if (m_tipo_tabreg != value)
				{
					m_tipo_tabreg = value;
					OnPropertyChanged("TIPO_TabREG");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CABP_ValorRef.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> CABP_ValorRef
		{
			get { return m_cabp_valorref; }
			set
			{
				if (m_cabp_valorref != value)
				{
					m_cabp_valorref = value;
					OnPropertyChanged("CABP_ValorRef");
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
		public void CopyTo(ref CabPerfilAsientos Item)
		{
			try
			{
				if (Item == null) { Item = new CabPerfilAsientos(); }
				Item.CABP_Ano = this.CABP_Ano;
				Item.CABP_Codigo = this.CABP_Codigo;
				Item.CABP_Desc = this.CABP_Desc;
				Item.TIPO_CodREG = this.TIPO_CodREG;
				Item.TIPO_TabREG = this.TIPO_TabREG;
				Item.CABP_ValorRef = this.CABP_ValorRef;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
