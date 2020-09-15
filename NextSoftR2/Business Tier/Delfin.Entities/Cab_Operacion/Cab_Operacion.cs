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
	public partial class Cab_Operacion : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int32 m_cope_codigo;
		private String m_cope_numdoc;
		private Nullable<DateTime> m_cope_fecemi;
		private String m_cope_observacion;
		private String m_cope_hbl;
		private Nullable<Int32> m_ccot_codigo;
		private Nullable<Int32> m_entc_codcliente;
		private Nullable<Int32> m_entc_codtransporte;
		private Nullable<Int32> m_entc_codagente;
		private String m_cons_codestado;
		private String m_cons_tabestado;
		private Nullable<Boolean> m_cope_excepcion;
		private Decimal m_cope_fob;
		private Decimal m_cope_seguro;
		private Decimal m_cope_flete;
		private Decimal m_cope_cif;
		private Decimal m_cope_partarancelaria;
		private Decimal m_cope_ipm;
		private Decimal m_cope_igv;
		private Decimal m_cope_percepcion;
		private Decimal m_cope_tasadespacho;
		private Decimal m_cope_advalorem;
		private Nullable<Boolean> m_cope_1erembarque;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		private String m_tipo_tabmnd;
		private String m_tipo_codmnd;
		private String m_cons_codcrg;
		private String m_cons_tabcrg;
        private Nullable<Int32> m_CCOT_CodAduana;
        private Nullable<Int32> m_CCOT_CodTransporte;
        private Nullable<Int32> m_CCOT_CodLogistico;
        
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Cab_Operacion.
		/// </summary>
		public Cab_Operacion()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: COPE_Codigo.
		/// </summary>
		[DataMember]
		public Int32 COPE_Codigo
		{
			get { return m_cope_codigo; }
			set
			{
				if (m_cope_codigo != value)
				{
					m_cope_codigo = value;
					OnPropertyChanged("COPE_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: COPE_NumDoc.
		/// </summary>
		[DataMember]
		public String COPE_NumDoc
		{
			get { return m_cope_numdoc; }
			set
			{
				if (m_cope_numdoc != value)
				{
					m_cope_numdoc = value;
					OnPropertyChanged("COPE_NumDoc");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: COPE_FecEmi.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> COPE_FecEmi
		{
			get { return m_cope_fecemi; }
			set
			{
				if (m_cope_fecemi != value)
				{
					m_cope_fecemi = value;
					OnPropertyChanged("COPE_FecEmi");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: COPE_Observacion.
		/// </summary>
		[DataMember]
		public String COPE_Observacion
		{
			get { return m_cope_observacion; }
			set
			{
				if (m_cope_observacion != value)
				{
					m_cope_observacion = value;
					OnPropertyChanged("COPE_Observacion");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: COPE_HBL.
		/// </summary>
		[DataMember]
		public String COPE_HBL
		{
			get { return m_cope_hbl; }
			set
			{
				if (m_cope_hbl != value)
				{
					m_cope_hbl = value;
					OnPropertyChanged("COPE_HBL");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CCOT_Codigo.
		/// </summary>
		[DataMember]
		public Nullable<Int32> CCOT_Codigo
		{
			get { return m_ccot_codigo; }
			set
			{
				if (m_ccot_codigo != value)
				{
					m_ccot_codigo = value;
					OnPropertyChanged("CCOT_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_CodCliente.
		/// </summary>
		[DataMember]
		public Nullable<Int32> ENTC_CodCliente
		{
			get { return m_entc_codcliente; }
			set
			{
				if (m_entc_codcliente != value)
				{
					m_entc_codcliente = value;
					OnPropertyChanged("ENTC_CodCliente");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_CodTransporte.
		/// </summary>
		[DataMember]
		public Nullable<Int32> ENTC_CodTransporte
		{
			get { return m_entc_codtransporte; }
			set
			{
				if (m_entc_codtransporte != value)
				{
					m_entc_codtransporte = value;
					OnPropertyChanged("ENTC_CodTransporte");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_CodAgente.
		/// </summary>
		[DataMember]
		public Nullable<Int32> ENTC_CodAgente
		{
			get { return m_entc_codagente; }
			set
			{
				if (m_entc_codagente != value)
				{
					m_entc_codagente = value;
					OnPropertyChanged("ENTC_CodAgente");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_CodEstado.
		/// </summary>
		[DataMember]
		public String CONS_CodEstado
		{
			get { return m_cons_codestado; }
			set
			{
				if (m_cons_codestado != value)
				{
					m_cons_codestado = value;
					OnPropertyChanged("CONS_CodEstado");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_TabEstado.
		/// </summary>
		[DataMember]
		public String CONS_TabEstado
		{
			get { return m_cons_tabestado; }
			set
			{
				if (m_cons_tabestado != value)
				{
					m_cons_tabestado = value;
					OnPropertyChanged("CONS_TabEstado");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: COPE_Excepcion.
		/// </summary>
		[DataMember]
		public Nullable<Boolean> COPE_Excepcion
		{
			get { return m_cope_excepcion; }
			set
			{
				if (m_cope_excepcion != value)
				{
					m_cope_excepcion = value;
					OnPropertyChanged("COPE_Excepcion");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: COPE_Fob.
		/// </summary>
		[DataMember]
		public Decimal COPE_Fob
		{
			get { return m_cope_fob; }
			set
			{
				if (m_cope_fob != value)
				{
					m_cope_fob = value;
					OnPropertyChanged("COPE_Fob");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: COPE_Seguro.
		/// </summary>
		[DataMember]
		public Decimal COPE_Seguro
		{
			get { return m_cope_seguro; }
			set
			{
				if (m_cope_seguro != value)
				{
					m_cope_seguro = value;
					OnPropertyChanged("COPE_Seguro");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: COPE_Flete.
		/// </summary>
		[DataMember]
		public Decimal COPE_Flete
		{
			get { return m_cope_flete; }
			set
			{
				if (m_cope_flete != value)
				{
					m_cope_flete = value;
					OnPropertyChanged("COPE_Flete");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: COPE_Cif.
		/// </summary>
		[DataMember]
		public Decimal COPE_Cif
		{
			get { return m_cope_cif; }
			set
			{
				if (m_cope_cif != value)
				{
					m_cope_cif = value;
					OnPropertyChanged("COPE_Cif");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: COPE_PartArancelaria.
		/// </summary>
		[DataMember]
		public Decimal COPE_PartArancelaria
		{
			get { return m_cope_partarancelaria; }
			set
			{
				if (m_cope_partarancelaria != value)
				{
					m_cope_partarancelaria = value;
					OnPropertyChanged("COPE_PartArancelaria");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: COPE_Ipm.
		/// </summary>
		[DataMember]
		public Decimal COPE_Ipm
		{
			get { return m_cope_ipm; }
			set
			{
				if (m_cope_ipm != value)
				{
					m_cope_ipm = value;
					OnPropertyChanged("COPE_Ipm");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: COPE_Igv.
		/// </summary>
		[DataMember]
		public Decimal COPE_Igv
		{
			get { return m_cope_igv; }
			set
			{
				if (m_cope_igv != value)
				{
					m_cope_igv = value;
					OnPropertyChanged("COPE_Igv");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: COPE_Percepcion.
		/// </summary>
		[DataMember]
		public Decimal COPE_Percepcion
		{
			get { return m_cope_percepcion; }
			set
			{
				if (m_cope_percepcion != value)
				{
					m_cope_percepcion = value;
					OnPropertyChanged("COPE_Percepcion");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: COPE_TasaDespacho.
		/// </summary>
		[DataMember]
		public Decimal COPE_TasaDespacho
		{
			get { return m_cope_tasadespacho; }
			set
			{
				if (m_cope_tasadespacho != value)
				{
					m_cope_tasadespacho = value;
					OnPropertyChanged("COPE_TasaDespacho");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: COPE_AdValorem.
		/// </summary>
		[DataMember]
		public Decimal COPE_AdValorem
		{
			get { return m_cope_advalorem; }
			set
			{
				if (m_cope_advalorem != value)
				{
					m_cope_advalorem = value;
					OnPropertyChanged("COPE_AdValorem");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: COPE_1erEmbarque.
		/// </summary>
		[DataMember]
		public Nullable<Boolean> COPE_1erEmbarque
		{
			get { return m_cope_1erembarque; }
			set
			{
				if (m_cope_1erembarque != value)
				{
					m_cope_1erembarque = value;
					OnPropertyChanged("COPE_1erEmbarque");
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
		/// Gets or sets el valor de: CONS_CodCRG.
		/// </summary>
		[DataMember]
		public String CONS_CodCRG
		{
			get { return m_cons_codcrg; }
			set
			{
				if (m_cons_codcrg != value)
				{
					m_cons_codcrg = value;
					OnPropertyChanged("CONS_CodCRG");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_TabCRG.
		/// </summary>
		[DataMember]
		public String CONS_TabCRG
		{
			get { return m_cons_tabcrg; }
			set
			{
				if (m_cons_tabcrg != value)
				{
					m_cons_tabcrg = value;
					OnPropertyChanged("CONS_TabCRG");
				}
			}
		}
        [DataMember]
        public Nullable<Int32> CCOT_CodAduana
        {
            get { return m_CCOT_CodAduana; }
            set { m_CCOT_CodAduana = value; }
        }

        [DataMember]
        public Nullable<Int32> CCOT_CodLogistico
        {
            get { return m_CCOT_CodLogistico; }
            set { m_CCOT_CodLogistico = value; }
        }

        [DataMember]
        public Nullable<Int32> CCOT_CodTransporte
        {
            get { return m_CCOT_CodTransporte; }
            set { m_CCOT_CodTransporte = value; }
        }
		#endregion

		#region [ CopyTo ]
		public void CopyTo(ref Cab_Operacion Item)
		{
			try
			{
				if (Item == null) { Item = new Cab_Operacion(); }
				Item.COPE_Codigo = this.COPE_Codigo;
				Item.COPE_NumDoc = this.COPE_NumDoc;
				Item.COPE_FecEmi = this.COPE_FecEmi;
				Item.COPE_Observacion = this.COPE_Observacion;
				Item.COPE_HBL = this.COPE_HBL;
				Item.CCOT_Codigo = this.CCOT_Codigo;
				Item.ENTC_CodCliente = this.ENTC_CodCliente;
				Item.ENTC_CodTransporte = this.ENTC_CodTransporte;
				Item.ENTC_CodAgente = this.ENTC_CodAgente;
				Item.CONS_CodEstado = this.CONS_CodEstado;
				Item.CONS_TabEstado = this.CONS_TabEstado;
				Item.COPE_Excepcion = this.COPE_Excepcion;
				Item.COPE_Fob = this.COPE_Fob;
				Item.COPE_Seguro = this.COPE_Seguro;
				Item.COPE_Flete = this.COPE_Flete;
				Item.COPE_Cif = this.COPE_Cif;
				Item.COPE_PartArancelaria = this.COPE_PartArancelaria;
				Item.COPE_Ipm = this.COPE_Ipm;
				Item.COPE_Igv = this.COPE_Igv;
				Item.COPE_Percepcion = this.COPE_Percepcion;
				Item.COPE_TasaDespacho = this.COPE_TasaDespacho;
				Item.COPE_AdValorem = this.COPE_AdValorem;
				Item.COPE_1erEmbarque = this.COPE_1erEmbarque;
				Item.TIPO_TabMND = this.TIPO_TabMND;
				Item.TIPO_CodMND = this.TIPO_CodMND;
				Item.CONS_CodCRG = this.CONS_CodCRG;
				Item.CONS_TabCRG = this.CONS_TabCRG;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
