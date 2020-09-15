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
   public partial class Contrato_Comodity : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int32 m_cont_codigo;
		private String m_tipo_tabcdt;
		private String m_tipo_codcdt;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Contrato_Comodity.
		/// </summary>
		public Contrato_Comodity()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: CONT_Codigo.
		/// </summary>
		[DataMember]
		public Int32 CONT_Codigo
		{
			get { return m_cont_codigo; }
			set
			{
				if (m_cont_codigo != value)
				{
					m_cont_codigo = value;
					OnPropertyChanged("CONT_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_TabCDT.
		/// </summary>
		[DataMember]
		public String TIPO_TabCDT
		{
			get { return m_tipo_tabcdt; }
			set
			{
				if (m_tipo_tabcdt != value)
				{
					m_tipo_tabcdt = value;
					OnPropertyChanged("TIPO_TabCDT");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodCDT.
		/// </summary>
		[DataMember]
		public String TIPO_CodCDT
		{
			get { return m_tipo_codcdt; }
			set
			{
				if (m_tipo_codcdt != value)
				{
					m_tipo_codcdt = value;
					OnPropertyChanged("TIPO_CodCDT");
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
		public void CopyTo(ref Contrato_Comodity Item)
		{
			try
			{
				if (Item == null) { Item = new Contrato_Comodity(); }
				Item.CONT_Codigo = this.CONT_Codigo;
				Item.TIPO_TabCDT = this.TIPO_TabCDT;
				Item.TIPO_CodCDT = this.TIPO_CodCDT;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
