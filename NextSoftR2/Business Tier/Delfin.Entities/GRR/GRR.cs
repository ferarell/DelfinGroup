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
	public partial class GRR : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private String m_reba_tipo;
		private Int32 m_reba_codigo;
		private Nullable<DateTime> m_reba_fecini;
		private Nullable<DateTime> m_reba_fecfin;
        private Nullable<DateTime> m_reba_feccalc;
        private Decimal m_reba_valor;
		private Nullable<Decimal> m_reba_limitesup;
		private Nullable<Decimal> m_reba_limiteinf;
		private Nullable<Decimal> m_reba_costoflete;
		private Nullable<Decimal> m_reba_costofletedes;
		private Nullable<Int16> m_empr_codigo;
		private Nullable<Int32> m_entc_codtransportista;
		private String m_tipo_tabmnd;
		private String m_tipo_codmnd;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase GRR.
		/// </summary>
		public GRR()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: REBA_Tipo.
		/// </summary>
		[DataMember]
		public String REBA_Tipo
		{
			get { return m_reba_tipo; }
			set
			{
				if (m_reba_tipo != value)
				{
					m_reba_tipo = value;
					OnPropertyChanged("REBA_Tipo");
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
		/// Gets or sets el valor de: REBA_FecIni.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> REBA_FecIni
		{
			get { return m_reba_fecini; }
			set
			{
				if (m_reba_fecini != value)
				{
					m_reba_fecini = value;
					OnPropertyChanged("REBA_FecIni");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: REBA_FecFin.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> REBA_FecFin
		{
			get { return m_reba_fecfin; }
			set
			{
				if (m_reba_fecfin != value)
				{
					m_reba_fecfin = value;
					OnPropertyChanged("REBA_FecFin");
				}
			}
		}
        /// <summary>
        /// Gets or sets el valor de: REBA_FecCalc.
        /// </summary>
        [DataMember]
        public Nullable<DateTime> REBA_FecCalc
        {
            get { return m_reba_feccalc; }
            set
            {
                if (m_reba_feccalc != value)
                {
                    m_reba_feccalc = value;
                    OnPropertyChanged("REBA_FecCalc");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: REBA_Valor.
        /// </summary>
        [DataMember]
		public Decimal REBA_Valor
		{
			get { return m_reba_valor; }
			set
			{
				if (m_reba_valor != value)
				{
					m_reba_valor = value;
					OnPropertyChanged("REBA_Valor");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: REBA_LimiteSup.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> REBA_LimiteSup
		{
			get { return m_reba_limitesup; }
			set
			{
				if (m_reba_limitesup != value)
				{
					m_reba_limitesup = value;
					OnPropertyChanged("REBA_LimiteSup");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: REBA_LimiteInf.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> REBA_LimiteInf
		{
			get { return m_reba_limiteinf; }
			set
			{
				if (m_reba_limiteinf != value)
				{
					m_reba_limiteinf = value;
					OnPropertyChanged("REBA_LimiteInf");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: REBA_CostoFlete.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> REBA_CostoFlete
		{
			get { return m_reba_costoflete; }
			set
			{
				if (m_reba_costoflete != value)
				{
					m_reba_costoflete = value;
					OnPropertyChanged("REBA_CostoFlete");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: REBA_CostoFleteDes.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> REBA_CostoFleteDes
		{
			get { return m_reba_costofletedes; }
			set
			{
				if (m_reba_costofletedes != value)
				{
					m_reba_costofletedes = value;
					OnPropertyChanged("REBA_CostoFleteDes");
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
		/// Gets or sets el valor de: ENTC_CodTransportista.
		/// </summary>
		[DataMember]
		public Nullable<Int32> ENTC_CodTransportista
		{
			get { return m_entc_codtransportista; }
			set
			{
				if (m_entc_codtransportista != value)
				{
					m_entc_codtransportista = value;
					OnPropertyChanged("ENTC_CodTransportista");
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
		public void CopyTo(ref GRR Item)
		{
			try
			{
				if (Item == null) { Item = new GRR(); }
				Item.REBA_Tipo = this.REBA_Tipo;
				Item.REBA_Codigo = this.REBA_Codigo;
				Item.REBA_FecIni = this.REBA_FecIni;
				Item.REBA_FecFin = this.REBA_FecFin;
                Item.REBA_FecCalc = this.REBA_FecCalc;
                Item.REBA_Valor = this.REBA_Valor;
				Item.REBA_LimiteSup = this.REBA_LimiteSup;
				Item.REBA_LimiteInf = this.REBA_LimiteInf;
				Item.REBA_CostoFlete = this.REBA_CostoFlete;
				Item.REBA_CostoFleteDes = this.REBA_CostoFleteDes;
				Item.EMPR_Codigo = this.EMPR_Codigo;
				Item.ENTC_CodTransportista = this.ENTC_CodTransportista;
				Item.TIPO_TabMND = this.TIPO_TabMND;
				Item.TIPO_CodMND = this.TIPO_CodMND;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
