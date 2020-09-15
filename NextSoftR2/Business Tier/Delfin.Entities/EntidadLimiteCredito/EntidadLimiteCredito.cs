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
	public partial class EntidadLimiteCredito : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int32 m_entc_codigo;
		private Int16 m_tipe_codigo;
		private String m_enli_tipos;
		private Int16 m_enli_codigo;
		private Nullable<Decimal> m_enli_monto;
		private Nullable<Int16> m_enli_diasduracion;
		private Nullable<DateTime> m_enli_fecha;
		private String m_enli_notas;
		private Nullable<DateTime> m_enli_fecinicio;
		private Nullable<DateTime> m_enli_fecvencimiento;
		private String m_enli_formapago;
      private String m_enli_tipofecvencimiento;
      private Boolean m_enli_cliautemicheqdiferidos;
      private Boolean m_enli_cliconcredlibre;
      private String m_tipo_tabmnd;
		private String m_tipo_codmnd;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase EntidadLimiteCredito.
		/// </summary>
		public EntidadLimiteCredito()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: ENTC_Codigo.
		/// </summary>
		[DataMember]
		public Int32 ENTC_Codigo
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
		/// Gets or sets el valor de: ENLI_Tipos.
		/// </summary>
		[DataMember]
		public String ENLI_Tipos
		{
			get { return m_enli_tipos; }
			set
			{
				if (m_enli_tipos != value)
				{
					m_enli_tipos = value;
					OnPropertyChanged("ENLI_Tipos");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENLI_Codigo.
		/// </summary>
		[DataMember]
		public Int16 ENLI_Codigo
		{
			get { return m_enli_codigo; }
			set
			{
				if (m_enli_codigo != value)
				{
					m_enli_codigo = value;
					OnPropertyChanged("ENLI_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENLI_Monto.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> ENLI_Monto
		{
			get { return m_enli_monto; }
			set
			{
				if (m_enli_monto != value)
				{
					m_enli_monto = value;
					OnPropertyChanged("ENLI_Monto");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENLI_DiasDuracion.
		/// </summary>
		[DataMember]
		public Nullable<Int16> ENLI_DiasDuracion
		{
			get { return m_enli_diasduracion; }
			set
			{
				if (m_enli_diasduracion != value)
				{
					m_enli_diasduracion = value;
					OnPropertyChanged("ENLI_DiasDuracion");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENLI_Fecha.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> ENLI_Fecha
		{
			get { return m_enli_fecha; }
			set
			{
				if (m_enli_fecha != value)
				{
					m_enli_fecha = value;
					OnPropertyChanged("ENLI_Fecha");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENLI_Notas.
		/// </summary>
		[DataMember]
		public String ENLI_Notas
		{
			get { return m_enli_notas; }
			set
			{
				if (m_enli_notas != value)
				{
					m_enli_notas = value;
					OnPropertyChanged("ENLI_Notas");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENLI_FecInicio.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> ENLI_FecInicio
		{
			get { return m_enli_fecinicio; }
			set
			{
				if (m_enli_fecinicio != value)
				{
					m_enli_fecinicio = value;
					OnPropertyChanged("ENLI_FecInicio");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENLI_FecVencimiento.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> ENLI_FecVencimiento
		{
			get { return m_enli_fecvencimiento; }
			set
			{
				if (m_enli_fecvencimiento != value)
				{
					m_enli_fecvencimiento = value;
					OnPropertyChanged("ENLI_FecVencimiento");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENLI_FormaPago.
		/// </summary>
		[DataMember]
		public String ENLI_FormaPago
		{
			get { return m_enli_formapago; }
			set
			{
				if (m_enli_formapago != value)
				{
					m_enli_formapago = value;
					OnPropertyChanged("ENLI_FormaPago");
				}
			}
		}
      /// <summary>
      /// Gets or sets el valor de: ENLI_TipoFecVencimiento.
      /// </summary>
      [DataMember]
      public String ENLI_TipoFecVencimiento
      {
         get { return m_enli_tipofecvencimiento; }
         set
         {
            if (m_enli_tipofecvencimiento != value)
            {
               m_enli_tipofecvencimiento = value;
               OnPropertyChanged("ENLI_TipoFecVencimiento");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: ENLI_CliAutEmiCheqDiferidos.
      /// </summary>
      [DataMember]
      public Boolean ENLI_CliAutEmiCheqDiferidos
      {
         get { return m_enli_cliautemicheqdiferidos; }
         set
         {
            if (m_enli_cliautemicheqdiferidos != value)
            {
               m_enli_cliautemicheqdiferidos = value;
               OnPropertyChanged("ENLI_CliAutEmiCheqDiferidos");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: ENLI_CliConCredLibre.
      /// </summary>
      [DataMember]
      public Boolean ENLI_CliConCredLibre
      {
         get { return m_enli_cliconcredlibre; }
         set
         {
            if (m_enli_cliconcredlibre != value)
            {
               m_enli_cliconcredlibre = value;
               OnPropertyChanged("ENLI_CliConCredLibre");
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
		public void CopyTo(ref EntidadLimiteCredito Item)
		{
			try
			{
				if (Item == null) { Item = new EntidadLimiteCredito(); }
				Item.ENTC_Codigo = this.ENTC_Codigo;
				Item.TIPE_Codigo = this.TIPE_Codigo;
				Item.ENLI_Tipos = this.ENLI_Tipos;
				Item.ENLI_Codigo = this.ENLI_Codigo;
				Item.ENLI_Monto = this.ENLI_Monto;
				Item.ENLI_DiasDuracion = this.ENLI_DiasDuracion;
				Item.ENLI_Fecha = this.ENLI_Fecha;
				Item.ENLI_Notas = this.ENLI_Notas;
				Item.ENLI_FecInicio = this.ENLI_FecInicio;
				Item.ENLI_FecVencimiento = this.ENLI_FecVencimiento;
            Item.ENLI_TipoFecVencimiento = this.ENLI_TipoFecVencimiento;
            Item.ENLI_FormaPago = this.ENLI_FormaPago;
            Item.ENLI_TipoFecVencimiento = this.ENLI_TipoFecVencimiento;
            Item.ENLI_CliAutEmiCheqDiferidos = this.ENLI_CliAutEmiCheqDiferidos;
            Item.ENLI_CliConCredLibre = this.ENLI_CliConCredLibre;

            Item.ENLI_FormaPago = this.ENLI_FormaPago;
				Item.TIPO_TabMND = this.TIPO_TabMND;
				Item.TIPO_CodMND = this.TIPO_CodMND;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
