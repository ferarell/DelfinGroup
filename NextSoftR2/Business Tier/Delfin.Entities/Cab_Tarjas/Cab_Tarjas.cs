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
	public partial class Cab_Tarjas : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int32 m_tarj_codigo;
		private String m_tarj_hbl;
		private String m_tarj_numero;
		private Decimal m_tarj_valor;
		private Nullable<Int32> m_entc_cliente;
		private Nullable<Int32> m_entc_deptemporal;
		private String m_tipo_tabmnd;
		private String m_tipo_codmnd;
		private String m_cons_codect;
		private String m_cons_tabect;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Cab_Tarjas.
		/// </summary>
		public Cab_Tarjas()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: TARJ_Codigo.
		/// </summary>
		[DataMember]
		public Int32 TARJ_Codigo
		{
			get { return m_tarj_codigo; }
			set
			{
				if (m_tarj_codigo != value)
				{
					m_tarj_codigo = value;
					OnPropertyChanged("TARJ_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TARJ_HBL.
		/// </summary>
		[DataMember]
		public String TARJ_HBL
		{
			get { return m_tarj_hbl; }
			set
			{
				if (m_tarj_hbl != value)
				{
					m_tarj_hbl = value;
					OnPropertyChanged("TARJ_HBL");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TARJ_Numero.
		/// </summary>
		[DataMember]
		public String TARJ_Numero
		{
			get { return m_tarj_numero; }
			set
			{
				if (m_tarj_numero != value)
				{
					m_tarj_numero = value;
					OnPropertyChanged("TARJ_Numero");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TARJ_Valor.
		/// </summary>
		[DataMember]
		public Decimal TARJ_Valor
		{
			get { return m_tarj_valor; }
			set
			{
				if (m_tarj_valor != value)
				{
					m_tarj_valor = value;
					OnPropertyChanged("TARJ_Valor");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_Cliente.
		/// </summary>
		[DataMember]
		public Nullable<Int32> ENTC_Cliente
		{
			get { return m_entc_cliente; }
			set
			{
				if (m_entc_cliente != value)
				{
					m_entc_cliente = value;
					OnPropertyChanged("ENTC_Cliente");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_DepTemporal.
		/// </summary>
		[DataMember]
		public Nullable<Int32> ENTC_DepTemporal
		{
			get { return m_entc_deptemporal; }
			set
			{
				if (m_entc_deptemporal != value)
				{
					m_entc_deptemporal = value;
					OnPropertyChanged("ENTC_DepTemporal");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_TabMND.
		/// </summary>
		[DataMember]
		public String TIPO_TabMND
		{
			get { return m_tipo_tabmnd; }
			set
			{
				if (m_tipo_tabmnd != value)
				{
					m_tipo_tabmnd = value;
					OnPropertyChanged("TIPO_TabMND");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodMND.
		/// </summary>
		[DataMember]
		public String TIPO_CodMND
		{
			get { return m_tipo_codmnd; }
			set
			{
				if (m_tipo_codmnd != value)
				{
					m_tipo_codmnd = value;
					OnPropertyChanged("TIPO_CodMND");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_CodECT.
		/// </summary>
		[DataMember]
		public String CONS_CodECT
		{
			get { return m_cons_codect; }
			set
			{
				if (m_cons_codect != value)
				{
					m_cons_codect = value;
					OnPropertyChanged("CONS_CodECT");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_TabECT.
		/// </summary>
		[DataMember]
		public String CONS_TabECT
		{
			get { return m_cons_tabect; }
			set
			{
				if (m_cons_tabect != value)
				{
					m_cons_tabect = value;
					OnPropertyChanged("CONS_TabECT");
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
		public void CopyTo(ref Cab_Tarjas Item)
		{
			try
			{
				if (Item == null) { Item = new Cab_Tarjas(); }
				Item.TARJ_Codigo = this.TARJ_Codigo;
				Item.TARJ_HBL = this.TARJ_HBL;
				Item.TARJ_Numero = this.TARJ_Numero;
				Item.TARJ_Valor = this.TARJ_Valor;
				Item.ENTC_Cliente = this.ENTC_Cliente;
				Item.ENTC_DepTemporal = this.ENTC_DepTemporal;
				Item.TIPO_TabMND = this.TIPO_TabMND;
				Item.TIPO_CodMND = this.TIPO_CodMND;
				Item.CONS_CodECT = this.CONS_CodECT;
				Item.CONS_TabECT = this.CONS_TabECT;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
