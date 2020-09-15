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
	public partial class PreDocsVta : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int32 m_pdoc_codigo;
		private String m_docv_numero;
		private Decimal m_docv_tipocambio;
		private Nullable<DateTime> m_docv_fechaemision;
		private Nullable<DateTime> m_docv_fechavcmto;
		private String m_docv_estado;
		private Decimal m_docv_precvtatotal;
		private Decimal m_docv_precvtatotald;
		private Decimal m_docv_valortotal;
		private Decimal m_docv_valortotald;
		private Decimal m_docv_valorvtatotal;
		private Decimal m_docv_valorvtatotald;
		private Decimal m_docv_descuento;
		private Decimal m_docv_descuentod;
		private String m_docv_observaciones;
		private Decimal m_docv_impuesto1;
		private Decimal m_docv_impuesto1d;
		private Decimal m_docv_impuesto2;
		private Decimal m_docv_impuesto2d;
		private Decimal m_docv_impuesto3;
		private Decimal m_docv_impuesto3d;
		private Decimal m_docv_impuesto4;
		private Decimal m_docv_impuesto4d;
		private Decimal m_docv_porcimp1;
		private Decimal m_docv_porcimp2;
		private Decimal m_docv_porcimp3;
		private Decimal m_docv_porcimp4;
		private String m_docv_notas;
		private String m_docv_serie;
		private String m_tipo_tabfpg;
		private String m_tipo_codfpg;
		private String m_tipo_tabtdo;
		private String m_tipo_codtdo;
		private String m_tipo_tabmnd;
		private String m_tipo_codmnd;
		private String m_cons_codanu;
		private String m_cons_tabanu;
        private Int16 m_tipe_codigo;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase PreDocsVta.
		/// </summary>
		public PreDocsVta()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: PDOC_Codigo.
		/// </summary>
		[DataMember]
		public Int32 PDOC_Codigo
		{
			get { return m_pdoc_codigo; }
			set
			{
				if (m_pdoc_codigo != value)
				{
					m_pdoc_codigo = value;
					OnPropertyChanged("PDOC_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOCV_Numero.
		/// </summary>
		[DataMember]
		public String DOCV_Numero
		{
			get { return m_docv_numero; }
			set
			{
				if (m_docv_numero != value)
				{
					m_docv_numero = value;
					OnPropertyChanged("DOCV_Numero");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOCV_TipoCambio.
		/// </summary>
		[DataMember]
		public Decimal DOCV_TipoCambio
		{
			get { return m_docv_tipocambio; }
			set
			{
				if (m_docv_tipocambio != value)
				{
					m_docv_tipocambio = value;
					OnPropertyChanged("DOCV_TipoCambio");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOCV_FechaEmision.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> DOCV_FechaEmision
		{
			get { return m_docv_fechaemision; }
			set
			{
				if (m_docv_fechaemision != value)
				{
					m_docv_fechaemision = value;
					OnPropertyChanged("DOCV_FechaEmision");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOCV_FechaVcmto.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> DOCV_FechaVcmto
		{
			get { return m_docv_fechavcmto; }
			set
			{
				if (m_docv_fechavcmto != value)
				{
					m_docv_fechavcmto = value;
					OnPropertyChanged("DOCV_FechaVcmto");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOCV_Estado.
		/// </summary>
		[DataMember]
		public String DOCV_Estado
		{
			get { return m_docv_estado; }
			set
			{
				if (m_docv_estado != value)
				{
					m_docv_estado = value;
					OnPropertyChanged("DOCV_Estado");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOCV_PrecVtaTotal.
		/// </summary>
		[DataMember]
		public Decimal DOCV_PrecVtaTotal
		{
			get { return m_docv_precvtatotal; }
			set
			{
				if (m_docv_precvtatotal != value)
				{
					m_docv_precvtatotal = value;
					OnPropertyChanged("DOCV_PrecVtaTotal");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOCV_PrecVtaTotalD.
		/// </summary>
		[DataMember]
		public Decimal DOCV_PrecVtaTotalD
		{
			get { return m_docv_precvtatotald; }
			set
			{
				if (m_docv_precvtatotald != value)
				{
					m_docv_precvtatotald = value;
					OnPropertyChanged("DOCV_PrecVtaTotalD");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOCV_ValorTotal.
		/// </summary>
		[DataMember]
		public Decimal DOCV_ValorTotal
		{
			get { return m_docv_valortotal; }
			set
			{
				if (m_docv_valortotal != value)
				{
					m_docv_valortotal = value;
					OnPropertyChanged("DOCV_ValorTotal");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOCV_ValorTotalD.
		/// </summary>
		[DataMember]
		public Decimal DOCV_ValorTotalD
		{
			get { return m_docv_valortotald; }
			set
			{
				if (m_docv_valortotald != value)
				{
					m_docv_valortotald = value;
					OnPropertyChanged("DOCV_ValorTotalD");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOCV_ValorVtaTotal.
		/// </summary>
		[DataMember]
		public Decimal DOCV_ValorVtaTotal
		{
			get { return m_docv_valorvtatotal; }
			set
			{
				if (m_docv_valorvtatotal != value)
				{
					m_docv_valorvtatotal = value;
					OnPropertyChanged("DOCV_ValorVtaTotal");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOCV_ValorVtaTotalD.
		/// </summary>
		[DataMember]
		public Decimal DOCV_ValorVtaTotalD
		{
			get { return m_docv_valorvtatotald; }
			set
			{
				if (m_docv_valorvtatotald != value)
				{
					m_docv_valorvtatotald = value;
					OnPropertyChanged("DOCV_ValorVtaTotalD");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOCV_Descuento.
		/// </summary>
		[DataMember]
		public Decimal DOCV_Descuento
		{
			get { return m_docv_descuento; }
			set
			{
				if (m_docv_descuento != value)
				{
					m_docv_descuento = value;
					OnPropertyChanged("DOCV_Descuento");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOCV_DescuentoD.
		/// </summary>
		[DataMember]
		public Decimal DOCV_DescuentoD
		{
			get { return m_docv_descuentod; }
			set
			{
				if (m_docv_descuentod != value)
				{
					m_docv_descuentod = value;
					OnPropertyChanged("DOCV_DescuentoD");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOCV_Observaciones.
		/// </summary>
		[DataMember]
		public String DOCV_Observaciones
		{
			get { return m_docv_observaciones; }
			set
			{
				if (m_docv_observaciones != value)
				{
					m_docv_observaciones = value;
					OnPropertyChanged("DOCV_Observaciones");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOCV_Impuesto1.
		/// </summary>
		[DataMember]
		public Decimal DOCV_Impuesto1
		{
			get { return m_docv_impuesto1; }
			set
			{
				if (m_docv_impuesto1 != value)
				{
					m_docv_impuesto1 = value;
					OnPropertyChanged("DOCV_Impuesto1");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOCV_Impuesto1D.
		/// </summary>
		[DataMember]
		public Decimal DOCV_Impuesto1D
		{
			get { return m_docv_impuesto1d; }
			set
			{
				if (m_docv_impuesto1d != value)
				{
					m_docv_impuesto1d = value;
					OnPropertyChanged("DOCV_Impuesto1D");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOCV_Impuesto2.
		/// </summary>
		[DataMember]
		public Decimal DOCV_Impuesto2
		{
			get { return m_docv_impuesto2; }
			set
			{
				if (m_docv_impuesto2 != value)
				{
					m_docv_impuesto2 = value;
					OnPropertyChanged("DOCV_Impuesto2");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOCV_Impuesto2D.
		/// </summary>
		[DataMember]
		public Decimal DOCV_Impuesto2D
		{
			get { return m_docv_impuesto2d; }
			set
			{
				if (m_docv_impuesto2d != value)
				{
					m_docv_impuesto2d = value;
					OnPropertyChanged("DOCV_Impuesto2D");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOCV_Impuesto3.
		/// </summary>
		[DataMember]
		public Decimal DOCV_Impuesto3
		{
			get { return m_docv_impuesto3; }
			set
			{
				if (m_docv_impuesto3 != value)
				{
					m_docv_impuesto3 = value;
					OnPropertyChanged("DOCV_Impuesto3");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOCV_Impuesto3D.
		/// </summary>
		[DataMember]
		public Decimal DOCV_Impuesto3D
		{
			get { return m_docv_impuesto3d; }
			set
			{
				if (m_docv_impuesto3d != value)
				{
					m_docv_impuesto3d = value;
					OnPropertyChanged("DOCV_Impuesto3D");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOCV_Impuesto4.
		/// </summary>
		[DataMember]
		public Decimal DOCV_Impuesto4
		{
			get { return m_docv_impuesto4; }
			set
			{
				if (m_docv_impuesto4 != value)
				{
					m_docv_impuesto4 = value;
					OnPropertyChanged("DOCV_Impuesto4");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOCV_Impuesto4D.
		/// </summary>
		[DataMember]
		public Decimal DOCV_Impuesto4D
		{
			get { return m_docv_impuesto4d; }
			set
			{
				if (m_docv_impuesto4d != value)
				{
					m_docv_impuesto4d = value;
					OnPropertyChanged("DOCV_Impuesto4D");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOCV_PorcImp1.
		/// </summary>
		[DataMember]
		public Decimal DOCV_PorcImp1
		{
			get { return m_docv_porcimp1; }
			set
			{
				if (m_docv_porcimp1 != value)
				{
					m_docv_porcimp1 = value;
					OnPropertyChanged("DOCV_PorcImp1");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOCV_PorcImp2.
		/// </summary>
		[DataMember]
		public Decimal DOCV_PorcImp2
		{
			get { return m_docv_porcimp2; }
			set
			{
				if (m_docv_porcimp2 != value)
				{
					m_docv_porcimp2 = value;
					OnPropertyChanged("DOCV_PorcImp2");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOCV_PorcImp3.
		/// </summary>
		[DataMember]
		public Decimal DOCV_PorcImp3
		{
			get { return m_docv_porcimp3; }
			set
			{
				if (m_docv_porcimp3 != value)
				{
					m_docv_porcimp3 = value;
					OnPropertyChanged("DOCV_PorcImp3");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOCV_PorcImp4.
		/// </summary>
		[DataMember]
		public Decimal DOCV_PorcImp4
		{
			get { return m_docv_porcimp4; }
			set
			{
				if (m_docv_porcimp4 != value)
				{
					m_docv_porcimp4 = value;
					OnPropertyChanged("DOCV_PorcImp4");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOCV_Notas.
		/// </summary>
		[DataMember]
		public String DOCV_Notas
		{
			get { return m_docv_notas; }
			set
			{
				if (m_docv_notas != value)
				{
					m_docv_notas = value;
					OnPropertyChanged("DOCV_Notas");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOCV_Serie.
		/// </summary>
		[DataMember]
		public String DOCV_Serie
		{
			get { return m_docv_serie; }
			set
			{
				if (m_docv_serie != value)
				{
					m_docv_serie = value;
					OnPropertyChanged("DOCV_Serie");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_TabFPG.
		/// </summary>
		[DataMember]
		public String TIPO_TabFPG
		{
			get { return m_tipo_tabfpg; }
			set
			{
				if (m_tipo_tabfpg != value)
				{
					m_tipo_tabfpg = value;
					OnPropertyChanged("TIPO_TabFPG");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodFPG.
		/// </summary>
		[DataMember]
		public String TIPO_CodFPG
		{
			get { return m_tipo_codfpg; }
			set
			{
				if (m_tipo_codfpg != value)
				{
					m_tipo_codfpg = value;
					OnPropertyChanged("TIPO_CodFPG");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_TabTDO.
		/// </summary>
		[DataMember]
		public String TIPO_TabTDO
		{
			get { return m_tipo_tabtdo; }
			set
			{
				if (m_tipo_tabtdo != value)
				{
					m_tipo_tabtdo = value;
					OnPropertyChanged("TIPO_TabTDO");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodTDO.
		/// </summary>
		[DataMember]
		public String TIPO_CodTDO
		{
			get { return m_tipo_codtdo; }
			set
			{
				if (m_tipo_codtdo != value)
				{
					m_tipo_codtdo = value;
					OnPropertyChanged("TIPO_CodTDO");
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
		/// Gets or sets el valor de: CONS_CodANU.
		/// </summary>
		[DataMember]
		public String CONS_CodANU
		{
			get { return m_cons_codanu; }
			set
			{
				if (m_cons_codanu != value)
				{
					m_cons_codanu = value;
					OnPropertyChanged("CONS_CodANU");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_TabANU.
		/// </summary>
		[DataMember]
		public String CONS_TabANU
		{
			get { return m_cons_tabanu; }
			set
			{
				if (m_cons_tabanu != value)
				{
					m_cons_tabanu = value;
					OnPropertyChanged("CONS_TabANU");
				}
			}
		}
        /// <summary>
        /// Gets or sets el valor de: TIPE_Codigo.
        /// </summary>
        [DataMember]
        public Int16 TIPE_Codigo
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
		public void CopyTo(ref PreDocsVta Item)
		{
			try
			{
				if (Item == null) { Item = new PreDocsVta(); }
				Item.PDOC_Codigo = this.PDOC_Codigo;
				Item.DOCV_Numero = this.DOCV_Numero;
				Item.DOCV_TipoCambio = this.DOCV_TipoCambio;
				Item.DOCV_FechaEmision = this.DOCV_FechaEmision;
				Item.DOCV_FechaVcmto = this.DOCV_FechaVcmto;
				Item.DOCV_Estado = this.DOCV_Estado;
				Item.DOCV_PrecVtaTotal = this.DOCV_PrecVtaTotal;
				Item.DOCV_PrecVtaTotalD = this.DOCV_PrecVtaTotalD;
				Item.DOCV_ValorTotal = this.DOCV_ValorTotal;
				Item.DOCV_ValorTotalD = this.DOCV_ValorTotalD;
				Item.DOCV_ValorVtaTotal = this.DOCV_ValorVtaTotal;
				Item.DOCV_ValorVtaTotalD = this.DOCV_ValorVtaTotalD;
				Item.DOCV_Descuento = this.DOCV_Descuento;
				Item.DOCV_DescuentoD = this.DOCV_DescuentoD;
				Item.DOCV_Observaciones = this.DOCV_Observaciones;
				Item.DOCV_Impuesto1 = this.DOCV_Impuesto1;
				Item.DOCV_Impuesto1D = this.DOCV_Impuesto1D;
				Item.DOCV_Impuesto2 = this.DOCV_Impuesto2;
				Item.DOCV_Impuesto2D = this.DOCV_Impuesto2D;
				Item.DOCV_Impuesto3 = this.DOCV_Impuesto3;
				Item.DOCV_Impuesto3D = this.DOCV_Impuesto3D;
				Item.DOCV_Impuesto4 = this.DOCV_Impuesto4;
				Item.DOCV_Impuesto4D = this.DOCV_Impuesto4D;
				Item.DOCV_PorcImp1 = this.DOCV_PorcImp1;
				Item.DOCV_PorcImp2 = this.DOCV_PorcImp2;
				Item.DOCV_PorcImp3 = this.DOCV_PorcImp3;
				Item.DOCV_PorcImp4 = this.DOCV_PorcImp4;
				Item.DOCV_Notas = this.DOCV_Notas;
				Item.DOCV_Serie = this.DOCV_Serie;
				Item.TIPO_TabFPG = this.TIPO_TabFPG;
				Item.TIPO_CodFPG = this.TIPO_CodFPG;
				Item.TIPO_TabTDO = this.TIPO_TabTDO;
				Item.TIPO_CodTDO = this.TIPO_CodTDO;
				Item.TIPO_TabMND = this.TIPO_TabMND;
				Item.TIPO_CodMND = this.TIPO_CodMND;
				Item.CONS_CodANU = this.CONS_CodANU;
				Item.CONS_TabANU = this.CONS_TabANU;
                Item.TIPE_Codigo = this.TIPE_Codigo;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
