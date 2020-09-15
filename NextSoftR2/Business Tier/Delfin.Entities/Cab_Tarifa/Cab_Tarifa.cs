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
	public partial class Cab_Tarifa : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int32 m_ctar_codigo;
		private String m_ctar_numero;
		private String m_ctar_descrip;
		private DateTime m_ctar_fecemi;
		private DateTime m_ctar_fecini;
		private DateTime m_ctar_fecfin;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private DateTime m_audi_fecmod;
		private String m_ctar_tipo;
		private String m_tipo_tabmnd;
		private String m_tipo_codmnd;
		private Nullable<Int32> m_entc_codigo;
		private Nullable<Boolean> m_ctar_agmaritimo;
		private Nullable<Boolean> m_ctar_deptemporal;
		private Nullable<Boolean> m_ctar_depvacio;
		private String m_cons_codreg;
		private String m_cons_tabreg;
		private Nullable<Decimal> m_ctar_profit;
		private Decimal m_ctar_montolnaviera;
		private Decimal m_ctar_montodtemporal;
		private Nullable<Int16> m_tipe_codigo;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Cab_Tarifa.
		/// </summary>
		public Cab_Tarifa()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: CTAR_Codigo.
		/// </summary>
		[DataMember]
		public Int32 CTAR_Codigo
		{
			get { return m_ctar_codigo; }
			set
			{
				if (m_ctar_codigo != value)
				{
					m_ctar_codigo = value;
					OnPropertyChanged("CTAR_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CTAR_Numero.
		/// </summary>
		[DataMember]
		public String CTAR_Numero
		{
			get { return m_ctar_numero; }
			set
			{
				if (m_ctar_numero != value)
				{
					m_ctar_numero = value;
					OnPropertyChanged("CTAR_Numero");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CTAR_Descrip.
		/// </summary>
		[DataMember]
		public String CTAR_Descrip
		{
			get { return m_ctar_descrip; }
			set
			{
				if (m_ctar_descrip != value)
				{
					m_ctar_descrip = value;
					OnPropertyChanged("CTAR_Descrip");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CTAR_FecEmi.
		/// </summary>
		[DataMember]
		public DateTime CTAR_FecEmi
		{
			get { return m_ctar_fecemi; }
			set
			{
				if (m_ctar_fecemi != value)
				{
					m_ctar_fecemi = value;
					OnPropertyChanged("CTAR_FecEmi");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CTAR_FecIni.
		/// </summary>
		[DataMember]
		public DateTime CTAR_FecIni
		{
			get { return m_ctar_fecini; }
			set
			{
				if (m_ctar_fecini != value)
				{
					m_ctar_fecini = value;
					OnPropertyChanged("CTAR_FecIni");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CTAR_FecFin.
		/// </summary>
		[DataMember]
		public DateTime CTAR_FecFin
		{
			get { return m_ctar_fecfin; }
			set
			{
				if (m_ctar_fecfin != value)
				{
					m_ctar_fecfin = value;
					OnPropertyChanged("CTAR_FecFin");
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
		public DateTime AUDI_FecMod
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
		/// Gets or sets el valor de: CTAR_Tipo.
		/// </summary>
		[DataMember]
		public String CTAR_Tipo
		{
			get { return m_ctar_tipo; }
			set
			{
				if (m_ctar_tipo != value)
				{
					m_ctar_tipo = value;
					OnPropertyChanged("CTAR_Tipo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_TabMnd.
		/// </summary>
		[DataMember]
		public String TIPO_TabMnd
		{
			get { return m_tipo_tabmnd; }
			set
			{
				if (m_tipo_tabmnd != value)
				{
					m_tipo_tabmnd = value;
					OnPropertyChanged("TIPO_TabMnd");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodMnd.
		/// </summary>
		[DataMember]
		public String TIPO_CodMnd
		{
			get { return m_tipo_codmnd; }
			set
			{
				if (m_tipo_codmnd != value)
				{
					m_tipo_codmnd = value;
					OnPropertyChanged("TIPO_CodMnd");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_Codigo.
		/// </summary>
		[DataMember]
		public Nullable<Int32> ENTC_Codigo
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
		/// Gets or sets el valor de: CTAR_AgMaritimo.
		/// </summary>
		[DataMember]
		public Nullable<Boolean> CTAR_AgMaritimo
		{
			get { return m_ctar_agmaritimo; }
			set
			{
				if (m_ctar_agmaritimo != value)
				{
					m_ctar_agmaritimo = value;
					OnPropertyChanged("CTAR_AgMaritimo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CTAR_DepTemporal.
		/// </summary>
		[DataMember]
		public Nullable<Boolean> CTAR_DepTemporal
		{
			get { return m_ctar_deptemporal; }
			set
			{
				if (m_ctar_deptemporal != value)
				{
					m_ctar_deptemporal = value;
					OnPropertyChanged("CTAR_DepTemporal");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CTAR_DepVacio.
		/// </summary>
		[DataMember]
		public Nullable<Boolean> CTAR_DepVacio
		{
			get { return m_ctar_depvacio; }
			set
			{
				if (m_ctar_depvacio != value)
				{
					m_ctar_depvacio = value;
					OnPropertyChanged("CTAR_DepVacio");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_CodReg.
		/// </summary>
		[DataMember]
		public String CONS_CodReg
		{
			get { return m_cons_codreg; }
			set
			{
				if (m_cons_codreg != value)
				{
					m_cons_codreg = value;
					OnPropertyChanged("CONS_CodReg");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_TabReg.
		/// </summary>
		[DataMember]
		public String CONS_TabReg
		{
			get { return m_cons_tabreg; }
			set
			{
				if (m_cons_tabreg != value)
				{
					m_cons_tabreg = value;
					OnPropertyChanged("CONS_TabReg");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CTAR_Profit.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> CTAR_Profit
		{
			get { return m_ctar_profit; }
			set
			{
				if (m_ctar_profit != value)
				{
					m_ctar_profit = value;
					OnPropertyChanged("CTAR_Profit");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CTAR_MontoLNaviera.
		/// </summary>
		[DataMember]
		public Decimal CTAR_MontoLNaviera
		{
			get { return m_ctar_montolnaviera; }
			set
			{
				if (m_ctar_montolnaviera != value)
				{
					m_ctar_montolnaviera = value;
					OnPropertyChanged("CTAR_MontoLNaviera");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CTAR_MontoDTemporal.
		/// </summary>
		[DataMember]
		public Decimal CTAR_MontoDTemporal
		{
			get { return m_ctar_montodtemporal; }
			set
			{
				if (m_ctar_montodtemporal != value)
				{
					m_ctar_montodtemporal = value;
					OnPropertyChanged("CTAR_MontoDTemporal");
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
		#endregion

		#region [ CopyTo ]
		public void CopyTo(ref Cab_Tarifa Item)
		{
			try
			{
				if (Item == null) { Item = new Cab_Tarifa(); }
				Item.CTAR_Codigo = this.CTAR_Codigo;
				Item.CTAR_Numero = this.CTAR_Numero;
				Item.CTAR_Descrip = this.CTAR_Descrip;
				Item.CTAR_FecEmi = this.CTAR_FecEmi;
				Item.CTAR_FecIni = this.CTAR_FecIni;
				Item.CTAR_FecFin = this.CTAR_FecFin;
				Item.CTAR_Tipo = this.CTAR_Tipo;
				Item.TIPO_TabMnd = this.TIPO_TabMnd;
				Item.TIPO_CodMnd = this.TIPO_CodMnd;
				Item.ENTC_Codigo = this.ENTC_Codigo;
				Item.CTAR_AgMaritimo = this.CTAR_AgMaritimo;
				Item.CTAR_DepTemporal = this.CTAR_DepTemporal;
				Item.CTAR_DepVacio = this.CTAR_DepVacio;
				Item.CONS_CodReg = this.CONS_CodReg;
				Item.CONS_TabReg = this.CONS_TabReg;
				Item.CTAR_Profit = this.CTAR_Profit;
				Item.CTAR_MontoLNaviera = this.CTAR_MontoLNaviera;
				Item.CTAR_MontoDTemporal = this.CTAR_MontoDTemporal;
				Item.TIPE_Codigo = this.TIPE_Codigo;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
