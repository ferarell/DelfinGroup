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
	public partial class Movimiento : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int16 m_empr_codigo;
		private Int32 m_movi_codigo;
		private Nullable<Int32> m_movi_codpadre;
		private Int16 m_sucr_codigo;
		private String m_cuba_codigo;
		private String m_plan_tipo;
		private String m_plan_codigo;
		private Nullable<Int32> m_tran_codigo;
		private Nullable<Int16> m_tipe_codigo;
		private Nullable<Int32> m_entc_codigo;
		private String m_tipo_tabmov;
		private String m_tipo_codmov;
		private String m_cons_tabest;
		private String m_cons_codest;
		private String m_tipo_tabdes;
		private String m_tipo_coddes;
		private String m_tipo_tabserie;
		private String m_tipo_codserie;
		private Nullable<Int32> m_movi_docnumero;
		private String m_movi_asientocontable;
		private String m_movi_numero;
		private Nullable<DateTime> m_movi_fecemision;
		private String m_movi_concepto;
		private String m_movi_ordende;
		private Decimal m_movi_montodebe;
		private Nullable<Decimal> m_movi_tipocambio;
		private Decimal m_movi_montohaber;
		private String m_movi_agrupacion;
		private Boolean m_movi_cheque;
		private String m_movi_estadocheque;
		private String m_movi_userentregacheque;
		private Nullable<DateTime> m_movi_fecentregacheque;
		private Nullable<DateTime> m_movi_fecdiferido;
		private Nullable<DateTime> m_movi_fecdiferidoanterior;
		private Nullable<Boolean> m_movi_chequeimpreso;
		private String m_movi_useranulacion;
		private Nullable<DateTime> m_movi_fecanulacion;
		private String m_movi_glosaanulacion;
		private String m_movi_nrooperacion;
		private String m_movi_nrooficina;
		private String m_movi_referencia;
		private Nullable<DateTime> m_movi_fecvigencia;
		private String m_movi_responsable;
		private Nullable<Decimal> m_movi_montolimite;
		private Nullable<Decimal> m_movi_montodescuadre;
		private Nullable<DateTime> m_movi_fecejecutado;
      private Boolean m_movi_nonegociable;
      private Nullable<DateTime> m_movi_fecoperacion;
      private String m_caba_ano;
      private String m_caba_mes;
      private String m_tipo_tabreg;
      private String m_tipo_codreg;
      private String m_caba_nrovoucher;
      private String m_caba_ano_dc;
      private String m_caba_mes_dc;
      private String m_tipo_tabreg_dc;
      private String m_tipo_codreg_dc;
      private String m_caba_nrovoucher_dc;
      private String m_tipo_tabmdp;
      private String m_tipo_codmdp;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
      

		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Movimiento.
		/// </summary>
		public Movimiento()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: EMPR_Codigo.
		/// </summary>
		[DataMember]
		public Int16 EMPR_Codigo
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
		/// Gets or sets el valor de: MOVI_Codigo.
		/// </summary>
		[DataMember]
		public Int32 MOVI_Codigo
		{
			get { return m_movi_codigo; }
			set
			{
				if (m_movi_codigo != value)
				{
					m_movi_codigo = value;
					OnPropertyChanged("MOVI_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: MOVI_CodPadre.
		/// </summary>
		[DataMember]
		public Nullable<Int32> MOVI_CodPadre
		{
			get { return m_movi_codpadre; }
			set
			{
				if (m_movi_codpadre != value)
				{
					m_movi_codpadre = value;
					OnPropertyChanged("MOVI_CodPadre");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SUCR_Codigo.
		/// </summary>
		[DataMember]
		public Int16 SUCR_Codigo
		{
			get { return m_sucr_codigo; }
			set
			{
				if (m_sucr_codigo != value)
				{
					m_sucr_codigo = value;
					OnPropertyChanged("SUCR_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CUBA_Codigo.
		/// </summary>
		[DataMember]
		public String CUBA_Codigo
		{
			get { return m_cuba_codigo; }
			set
			{
				if (m_cuba_codigo != value)
				{
					m_cuba_codigo = value;
					OnPropertyChanged("CUBA_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PLAN_Tipo.
		/// </summary>
		[DataMember]
		public String PLAN_Tipo
		{
			get { return m_plan_tipo; }
			set
			{
				if (m_plan_tipo != value)
				{
					m_plan_tipo = value;
					OnPropertyChanged("PLAN_Tipo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PLAN_Codigo.
		/// </summary>
		[DataMember]
		public String PLAN_Codigo
		{
			get { return m_plan_codigo; }
			set
			{
				if (m_plan_codigo != value)
				{
					m_plan_codigo = value;
					OnPropertyChanged("PLAN_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TRAN_Codigo.
		/// </summary>
		[DataMember]
		public Nullable<Int32> TRAN_Codigo
		{
			get { return m_tran_codigo; }
			set
			{
				if (m_tran_codigo != value)
				{
					m_tran_codigo = value;
					OnPropertyChanged("TRAN_Codigo");
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
		/// Gets or sets el valor de: TIPO_TabMOV.
		/// </summary>
		[DataMember]
		public String TIPO_TabMOV
		{
			get { return m_tipo_tabmov; }
			set
			{
				if (m_tipo_tabmov != value)
				{
					m_tipo_tabmov = value;
					OnPropertyChanged("TIPO_TabMOV");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodMOV.
		/// </summary>
		[DataMember]
		public String TIPO_CodMOV
		{
			get { return m_tipo_codmov; }
			set
			{
				if (m_tipo_codmov != value)
				{
					m_tipo_codmov = value;
					OnPropertyChanged("TIPO_CodMOV");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_TabEST.
		/// </summary>
		[DataMember]
		public String CONS_TabEST
		{
			get { return m_cons_tabest; }
			set
			{
				if (m_cons_tabest != value)
				{
					m_cons_tabest = value;
					OnPropertyChanged("CONS_TabEST");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_CodEST.
		/// </summary>
		[DataMember]
		public String CONS_CodEST
		{
			get { return m_cons_codest; }
			set
			{
				if (m_cons_codest != value)
				{
					m_cons_codest = value;
					OnPropertyChanged("CONS_CodEST");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_TabDES.
		/// </summary>
		[DataMember]
		public String TIPO_TabDES
		{
			get { return m_tipo_tabdes; }
			set
			{
				if (m_tipo_tabdes != value)
				{
					m_tipo_tabdes = value;
					OnPropertyChanged("TIPO_TabDES");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodDES.
		/// </summary>
		[DataMember]
		public String TIPO_CodDES
		{
			get { return m_tipo_coddes; }
			set
			{
				if (m_tipo_coddes != value)
				{
					m_tipo_coddes = value;
					OnPropertyChanged("TIPO_CodDES");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_TabSerie.
		/// </summary>
		[DataMember]
		public String TIPO_TabSerie
		{
			get { return m_tipo_tabserie; }
			set
			{
				if (m_tipo_tabserie != value)
				{
					m_tipo_tabserie = value;
					OnPropertyChanged("TIPO_TabSerie");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodSerie.
		/// </summary>
		[DataMember]
		public String TIPO_CodSerie
		{
			get { return m_tipo_codserie; }
			set
			{
				if (m_tipo_codserie != value)
				{
					m_tipo_codserie = value;
					OnPropertyChanged("TIPO_CodSerie");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: MOVI_DocNumero.
		/// </summary>
		[DataMember]
		public Nullable<Int32> MOVI_DocNumero
		{
			get { return m_movi_docnumero; }
			set
			{
				if (m_movi_docnumero != value)
				{
					m_movi_docnumero = value;
					OnPropertyChanged("MOVI_DocNumero");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: MOVI_AsientoContable.
		/// </summary>
		[DataMember]
		public String MOVI_AsientoContable
		{
			get { return m_movi_asientocontable; }
			set
			{
				if (m_movi_asientocontable != value)
				{
					m_movi_asientocontable = value;
					OnPropertyChanged("MOVI_AsientoContable");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: MOVI_Numero.
		/// </summary>
		[DataMember]
		public String MOVI_Numero
		{
			get { return m_movi_numero; }
			set
			{
				if (m_movi_numero != value)
				{
					m_movi_numero = value;
					OnPropertyChanged("MOVI_Numero");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: MOVI_FecEmision.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> MOVI_FecEmision
		{
			get { return m_movi_fecemision; }
			set
			{
				if (m_movi_fecemision != value)
				{
					m_movi_fecemision = value;
					OnPropertyChanged("MOVI_FecEmision");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: MOVI_Concepto.
		/// </summary>
		[DataMember]
		public String MOVI_Concepto
		{
			get { return m_movi_concepto; }
			set
			{
				if (m_movi_concepto != value)
				{
					m_movi_concepto = value;
					OnPropertyChanged("MOVI_Concepto");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: MOVI_OrdenDe.
		/// </summary>
		[DataMember]
		public String MOVI_OrdenDe
		{
			get { return m_movi_ordende; }
			set
			{
				if (m_movi_ordende != value)
				{
					m_movi_ordende = value;
					OnPropertyChanged("MOVI_OrdenDe");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: MOVI_MontoDebe.
		/// </summary>
		[DataMember]
		public Decimal MOVI_MontoDebe
		{
			get { return m_movi_montodebe; }
			set
			{
				if (m_movi_montodebe != value)
				{
					m_movi_montodebe = value;
					OnPropertyChanged("MOVI_MontoDebe");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: MOVI_TipoCambio.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> MOVI_TipoCambio
		{
			get { return m_movi_tipocambio; }
			set
			{
				if (m_movi_tipocambio != value)
				{
					m_movi_tipocambio = value;
					OnPropertyChanged("MOVI_TipoCambio");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: MOVI_MontoHaber.
		/// </summary>
		[DataMember]
		public Decimal MOVI_MontoHaber
		{
			get { return m_movi_montohaber; }
			set
			{
				if (m_movi_montohaber != value)
				{
					m_movi_montohaber = value;
					OnPropertyChanged("MOVI_MontoHaber");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: MOVI_Agrupacion.
		/// </summary>
		[DataMember]
		public String MOVI_Agrupacion
		{
			get { return m_movi_agrupacion; }
			set
			{
				if (m_movi_agrupacion != value)
				{
					m_movi_agrupacion = value;
					OnPropertyChanged("MOVI_Agrupacion");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: MOVI_Cheque.
		/// </summary>
		[DataMember]
		public Boolean MOVI_Cheque
		{
			get { return m_movi_cheque; }
			set
			{
				if (m_movi_cheque != value)
				{
					m_movi_cheque = value;
					OnPropertyChanged("MOVI_Cheque");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: MOVI_EstadoCheque.
		/// </summary>
		[DataMember]
		public String MOVI_EstadoCheque
		{
			get { return m_movi_estadocheque; }
			set
			{
				if (m_movi_estadocheque != value)
				{
					m_movi_estadocheque = value;
					OnPropertyChanged("MOVI_EstadoCheque");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: MOVI_UserEntregaCheque.
		/// </summary>
		[DataMember]
		public String MOVI_UserEntregaCheque
		{
			get { return m_movi_userentregacheque; }
			set
			{
				if (m_movi_userentregacheque != value)
				{
					m_movi_userentregacheque = value;
					OnPropertyChanged("MOVI_UserEntregaCheque");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: MOVI_FecEntregaCheque.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> MOVI_FecEntregaCheque
		{
			get { return m_movi_fecentregacheque; }
			set
			{
				if (m_movi_fecentregacheque != value)
				{
					m_movi_fecentregacheque = value;
					OnPropertyChanged("MOVI_FecEntregaCheque");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: MOVI_FecDiferido.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> MOVI_FecDiferido
		{
			get { return m_movi_fecdiferido; }
			set
			{
				if (m_movi_fecdiferido != value)
				{
					m_movi_fecdiferido = value;
					OnPropertyChanged("MOVI_FecDiferido");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: MOVI_FecDiferidoAnterior.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> MOVI_FecDiferidoAnterior
		{
			get { return m_movi_fecdiferidoanterior; }
			set
			{
				if (m_movi_fecdiferidoanterior != value)
				{
					m_movi_fecdiferidoanterior = value;
					OnPropertyChanged("MOVI_FecDiferidoAnterior");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: MOVI_ChequeImpreso.
		/// </summary>
		[DataMember]
		public Nullable<Boolean> MOVI_ChequeImpreso
		{
			get { return m_movi_chequeimpreso; }
			set
			{
				if (m_movi_chequeimpreso != value)
				{
					m_movi_chequeimpreso = value;
					OnPropertyChanged("MOVI_ChequeImpreso");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: MOVI_UserAnulacion.
		/// </summary>
		[DataMember]
		public String MOVI_UserAnulacion
		{
			get { return m_movi_useranulacion; }
			set
			{
				if (m_movi_useranulacion != value)
				{
					m_movi_useranulacion = value;
					OnPropertyChanged("MOVI_UserAnulacion");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: MOVI_FecAnulacion.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> MOVI_FecAnulacion
		{
			get { return m_movi_fecanulacion; }
			set
			{
				if (m_movi_fecanulacion != value)
				{
					m_movi_fecanulacion = value;
					OnPropertyChanged("MOVI_FecAnulacion");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: MOVI_GlosaAnulacion.
		/// </summary>
		[DataMember]
		public String MOVI_GlosaAnulacion
		{
			get { return m_movi_glosaanulacion; }
			set
			{
				if (m_movi_glosaanulacion != value)
				{
					m_movi_glosaanulacion = value;
					OnPropertyChanged("MOVI_GlosaAnulacion");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: MOVI_NroOperacion.
		/// </summary>
		[DataMember]
		public String MOVI_NroOperacion
		{
			get { return m_movi_nrooperacion; }
			set
			{
				if (m_movi_nrooperacion != value)
				{
					m_movi_nrooperacion = value;
					OnPropertyChanged("MOVI_NroOperacion");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: MOVI_NroOficina.
		/// </summary>
		[DataMember]
		public String MOVI_NroOficina
		{
			get { return m_movi_nrooficina; }
			set
			{
				if (m_movi_nrooficina != value)
				{
					m_movi_nrooficina = value;
					OnPropertyChanged("MOVI_NroOficina");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: MOVI_Referencia.
		/// </summary>
		[DataMember]
		public String MOVI_Referencia
		{
			get { return m_movi_referencia; }
			set
			{
				if (m_movi_referencia != value)
				{
					m_movi_referencia = value;
					OnPropertyChanged("MOVI_Referencia");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: MOVI_FecVigencia.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> MOVI_FecVigencia
		{
			get { return m_movi_fecvigencia; }
			set
			{
				if (m_movi_fecvigencia != value)
				{
					m_movi_fecvigencia = value;
					OnPropertyChanged("MOVI_FecVigencia");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: MOVI_Responsable.
		/// </summary>
		[DataMember]
		public String MOVI_Responsable
		{
			get { return m_movi_responsable; }
			set
			{
				if (m_movi_responsable != value)
				{
					m_movi_responsable = value;
					OnPropertyChanged("MOVI_Responsable");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: MOVI_MontoLimite.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> MOVI_MontoLimite
		{
			get { return m_movi_montolimite; }
			set
			{
				if (m_movi_montolimite != value)
				{
					m_movi_montolimite = value;
					OnPropertyChanged("MOVI_MontoLimite");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: MOVI_MontoDescuadre.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> MOVI_MontoDescuadre
		{
			get { return m_movi_montodescuadre; }
			set
			{
				if (m_movi_montodescuadre != value)
				{
					m_movi_montodescuadre = value;
					OnPropertyChanged("MOVI_MontoDescuadre");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: MOVI_FecEjecutado.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> MOVI_FecEjecutado
		{
			get { return m_movi_fecejecutado; }
			set
			{
				if (m_movi_fecejecutado != value)
				{
					m_movi_fecejecutado = value;
					OnPropertyChanged("MOVI_FecEjecutado");
				}
			}
		}
      /// <summary>
      /// Gets or sets el valor de: MOVI_NoNegociable.
      /// </summary>
      [DataMember]
      public Boolean MOVI_NoNegociable
      {
         get { return m_movi_nonegociable; }
         set
         {
            if (m_movi_nonegociable != value)
            {
               m_movi_nonegociable = value;
               OnPropertyChanged("MOVI_NoNegociable");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: MOVI_FecOperacion.
      /// </summary>
      [DataMember]
      public Nullable<DateTime> MOVI_FecOperacion
      {
         get { return m_movi_fecoperacion; }
         set
         {
            if (m_movi_fecoperacion != value)
            {
               m_movi_fecoperacion = value;
               OnPropertyChanged("MOVI_FecOperacion");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CABA_Ano.
      /// </summary>
      [DataMember]
      public String CABA_Ano
      {
         get { return m_caba_ano; }
         set
         {
            if (m_caba_ano != value)
            {
               m_caba_ano = value;
               OnPropertyChanged("CABA_Ano");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CABA_Mes.
      /// </summary>
      [DataMember]
      public String CABA_Mes
      {
         get { return m_caba_mes; }
         set
         {
            if (m_caba_mes != value)
            {
               m_caba_mes = value;
               OnPropertyChanged("CABA_Mes");
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
      /// Gets or sets el valor de: CABA_NroVoucher.
      /// </summary>
      [DataMember]
      public String CABA_NroVoucher
      {
         get { return m_caba_nrovoucher; }
         set
         {
            if (m_caba_nrovoucher != value)
            {
               m_caba_nrovoucher = value;
               OnPropertyChanged("CABA_NroVoucher");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CABA_Ano_DC.
      /// </summary>
      [DataMember]
      public String CABA_Ano_DC
      {
         get { return m_caba_ano_dc; }
         set
         {
            if (m_caba_ano_dc != value)
            {
               m_caba_ano_dc = value;
               OnPropertyChanged("CABA_Ano_DC");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CABA_Mes_DC.
      /// </summary>
      [DataMember]
      public String CABA_Mes_DC
      {
         get { return m_caba_mes_dc; }
         set
         {
            if (m_caba_mes_dc != value)
            {
               m_caba_mes_dc = value;
               OnPropertyChanged("CABA_Mes_DC");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: TIPO_TabREG_DC.
      /// </summary>
      [DataMember]
      public String TIPO_TabREG_DC
      {
         get { return m_tipo_tabreg_dc; }
         set
         {
            if (m_tipo_tabreg_dc != value)
            {
               m_tipo_tabreg_dc = value;
               OnPropertyChanged("TIPO_TabREG_DC");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: TIPO_CodREG_DC.
      /// </summary>
      [DataMember]
      public String TIPO_CodREG_DC
      {
         get { return m_tipo_codreg_dc; }
         set
         {
            if (m_tipo_codreg_dc != value)
            {
               m_tipo_codreg_dc = value;
               OnPropertyChanged("TIPO_CodREG_DC");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CABA_NroVoucher_DC.
      /// </summary>
      [DataMember]
      public String CABA_NroVoucher_DC
      {
         get { return m_caba_nrovoucher_dc; }
         set
         {
            if (m_caba_nrovoucher_dc != value)
            {
               m_caba_nrovoucher_dc = value;
               OnPropertyChanged("CABA_NroVoucher_DC");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: TIPO_TabMDP.
      /// </summary>
      [DataMember]
      public String TIPO_TabMDP
      {
         get { return m_tipo_tabmdp; }
         set
         {
            if (m_tipo_tabmdp != value)
            {
               m_tipo_tabmdp = value;
               OnPropertyChanged("TIPO_TabMDP");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: TIPO_CodMDP.
      /// </summary>
      [DataMember]
      public String TIPO_CodMDP
      {
         get { return m_tipo_codmdp; }
         set
         {
            if (m_tipo_codmdp != value)
            {
               m_tipo_codmdp = value;
               OnPropertyChanged("TIPO_CodMDP");
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
		public void CopyTo(ref Movimiento Item)
		{
			try
			{
				if (Item == null) { Item = new Movimiento(); }
				Item.EMPR_Codigo = this.EMPR_Codigo;
				Item.MOVI_Codigo = this.MOVI_Codigo;
				Item.MOVI_CodPadre = this.MOVI_CodPadre;
				Item.SUCR_Codigo = this.SUCR_Codigo;
				Item.CUBA_Codigo = this.CUBA_Codigo;
				Item.PLAN_Tipo = this.PLAN_Tipo;
				Item.PLAN_Codigo = this.PLAN_Codigo;
				Item.TRAN_Codigo = this.TRAN_Codigo;
				Item.TIPE_Codigo = this.TIPE_Codigo;
				Item.ENTC_Codigo = this.ENTC_Codigo;
				Item.TIPO_TabMOV = this.TIPO_TabMOV;
				Item.TIPO_CodMOV = this.TIPO_CodMOV;
				Item.CONS_TabEST = this.CONS_TabEST;
				Item.CONS_CodEST = this.CONS_CodEST;
				Item.TIPO_TabDES = this.TIPO_TabDES;
				Item.TIPO_CodDES = this.TIPO_CodDES;
				Item.TIPO_TabSerie = this.TIPO_TabSerie;
				Item.TIPO_CodSerie = this.TIPO_CodSerie;
				Item.MOVI_DocNumero = this.MOVI_DocNumero;
				Item.MOVI_AsientoContable = this.MOVI_AsientoContable;
				Item.MOVI_Numero = this.MOVI_Numero;
				Item.MOVI_FecEmision = this.MOVI_FecEmision;
				Item.MOVI_Concepto = this.MOVI_Concepto;
				Item.MOVI_OrdenDe = this.MOVI_OrdenDe;
				Item.MOVI_MontoDebe = this.MOVI_MontoDebe;
				Item.MOVI_TipoCambio = this.MOVI_TipoCambio;
				Item.MOVI_MontoHaber = this.MOVI_MontoHaber;
				Item.MOVI_Agrupacion = this.MOVI_Agrupacion;
				Item.MOVI_Cheque = this.MOVI_Cheque;
				Item.MOVI_EstadoCheque = this.MOVI_EstadoCheque;
				Item.MOVI_UserEntregaCheque = this.MOVI_UserEntregaCheque;
				Item.MOVI_FecEntregaCheque = this.MOVI_FecEntregaCheque;
				Item.MOVI_FecDiferido = this.MOVI_FecDiferido;
				Item.MOVI_FecDiferidoAnterior = this.MOVI_FecDiferidoAnterior;
				Item.MOVI_ChequeImpreso = this.MOVI_ChequeImpreso;
				Item.MOVI_UserAnulacion = this.MOVI_UserAnulacion;
				Item.MOVI_FecAnulacion = this.MOVI_FecAnulacion;
				Item.MOVI_GlosaAnulacion = this.MOVI_GlosaAnulacion;
				Item.MOVI_NroOperacion = this.MOVI_NroOperacion;
				Item.MOVI_NroOficina = this.MOVI_NroOficina;
				Item.MOVI_Referencia = this.MOVI_Referencia;
				Item.MOVI_FecVigencia = this.MOVI_FecVigencia;
				Item.MOVI_Responsable = this.MOVI_Responsable;
				Item.MOVI_MontoLimite = this.MOVI_MontoLimite;
				Item.MOVI_MontoDescuadre = this.MOVI_MontoDescuadre;
				Item.MOVI_FecEjecutado = this.MOVI_FecEjecutado;
            Item.MOVI_NoNegociable = this.MOVI_NoNegociable;
            Item.MOVI_FecOperacion = this.MOVI_FecOperacion;
            Item.CABA_Ano = this.CABA_Ano;
            Item.CABA_Mes = this.CABA_Mes;
            Item.TIPO_TabREG = this.TIPO_TabREG;
            Item.TIPO_CodREG = this.TIPO_CodREG;
            Item.CABA_NroVoucher = this.CABA_NroVoucher;
            Item.CABA_Ano_DC = this.CABA_Ano_DC;
            Item.CABA_Mes_DC = this.CABA_Mes_DC;
            Item.TIPO_TabREG_DC = this.TIPO_TabREG_DC;
            Item.TIPO_CodREG_DC = this.TIPO_CodREG_DC;
            Item.CABA_NroVoucher_DC = this.CABA_NroVoucher_DC;
            Item.TIPO_TabMDP = this.TIPO_TabMDP;
            Item.TIPO_CodMDP = this.TIPO_CodMDP;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
