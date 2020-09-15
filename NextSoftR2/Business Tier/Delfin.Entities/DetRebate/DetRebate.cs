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
	public partial class DetRebate : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int32 m_pack_codigo;
		private Int32 m_reba_codigo;
		private Decimal m_dreb_valor;
		private Int32 m_dreb_codigo;
		private DateTime m_audi_feccrea;
		private String m_audi_usrcrea;
		private Nullable<DateTime> m_audi_fecmod;
		private String m_audi_usrmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase DetRebate.
		/// </summary>
		public DetRebate()
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
		/// Gets or sets el valor de: REBA_Codigo.
		/// </summary>
		[DataMember]
		public Int32 REBA_Codigo
		{
			get { return m_reba_codigo; }
			set
			{
				if (m_reba_codigo != value)
				{
					m_reba_codigo = value;
					OnPropertyChanged("REBA_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DREB_Valor.
		/// </summary>
		[DataMember]
		public Decimal DREB_Valor
		{
			get { return m_dreb_valor; }
			set
			{
				if (m_dreb_valor != value)
				{
					m_dreb_valor = value;
					OnPropertyChanged("DREB_Valor");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DREB_Codigo.
		/// </summary>
		[DataMember]
		public Int32 DREB_Codigo
		{
			get { return m_dreb_codigo; }
			set
			{
				if (m_dreb_codigo != value)
				{
					m_dreb_codigo = value;
					OnPropertyChanged("DREB_Codigo");
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
		#endregion

		#region [ CopyTo ]
		public void CopyTo(ref DetRebate Item)
		{
			try
			{
				if (Item == null) { Item = new DetRebate(); }
				Item.PACK_Codigo = this.PACK_Codigo;
				Item.REBA_Codigo = this.REBA_Codigo;
				Item.DREB_Valor = this.DREB_Valor;
				Item.DREB_Codigo = this.DREB_Codigo;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
