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
   public partial class ResultGestion : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int16 m_resg_codigo;
		private Nullable<Int16> m_empr_codigo;
		private Nullable<Int16> m_resg_codpadre;
		private String m_resg_desc;
		private String m_resg_descc;
      private Int32 m_resg_positivonegativo;
		private Boolean m_resg_activo;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase ResultGestion.
		/// </summary>
		public ResultGestion()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: RESG_Codigo.
		/// </summary>
		[DataMember]
		public Int16 RESG_Codigo
		{
			get { return m_resg_codigo; }
			set
			{
				if (m_resg_codigo != value)
				{
					m_resg_codigo = value;
					OnPropertyChanged("RESG_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: EMPR_Codigo.
		/// </summary>
		[DataMember]
		public Nullable<Int16> EMPR_Codigo
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
		/// Gets or sets el valor de: RESG_CodPadre.
		/// </summary>
		[DataMember]
		public Nullable<Int16> RESG_CodPadre
		{
			get { return m_resg_codpadre; }
			set
			{
				if (m_resg_codpadre != value)
				{
					m_resg_codpadre = value;
					OnPropertyChanged("RESG_CodPadre");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: RESG_Desc.
		/// </summary>
		[DataMember]
		public String RESG_Desc
		{
			get { return m_resg_desc; }
			set
			{
				if (m_resg_desc != value)
				{
					m_resg_desc = value;
					OnPropertyChanged("RESG_Desc");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: RESG_DescC.
		/// </summary>
		[DataMember]
		public String RESG_DescC
		{
			get { return m_resg_descc; }
			set
			{
				if (m_resg_descc != value)
				{
					m_resg_descc = value;
					OnPropertyChanged("RESG_DescC");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: RESG_PositivoNegativo.
		/// </summary>
		[DataMember]
		public Int32 RESG_PositivoNegativo
		{
			get { return m_resg_positivonegativo; }
			set
			{
				if (m_resg_positivonegativo != value)
				{
					m_resg_positivonegativo = value;
					OnPropertyChanged("RESG_PositivoNegativo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: RESG_Activo.
		/// </summary>
		[DataMember]
		public Boolean RESG_Activo
		{
			get { return m_resg_activo; }
			set
			{
				if (m_resg_activo != value)
				{
					m_resg_activo = value;
					OnPropertyChanged("RESG_Activo");
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
		public void CopyTo(ref ResultGestion Item)
		{
			try
			{
				if (Item == null) { Item = new ResultGestion(); }
				Item.RESG_Codigo = this.RESG_Codigo;
				Item.EMPR_Codigo = this.EMPR_Codigo;
				Item.RESG_CodPadre = this.RESG_CodPadre;
				Item.RESG_Desc = this.RESG_Desc;
				Item.RESG_DescC = this.RESG_DescC;
				Item.RESG_PositivoNegativo = this.RESG_PositivoNegativo;
				Item.RESG_Activo = this.RESG_Activo;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
