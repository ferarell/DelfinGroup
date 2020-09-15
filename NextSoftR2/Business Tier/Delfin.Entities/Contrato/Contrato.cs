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
   public partial class Contrato : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Nullable<Int32> m_cont_codigo;
		private Nullable<Int16> m_empr_codigo;
		private String m_cont_numero;
		private String m_cont_descrip;
      private Nullable<DateTime> m_cont_fecemi;
      private Nullable<DateTime> m_cont_fecini;
      private Nullable<DateTime> m_cont_fecfin;
      private Boolean m_cont_activo = true;
		private Nullable<Int32> m_entc_codcliente;
		private Nullable<Int32> m_entc_codtransportista;
		private String m_cons_taprgm;
		private String m_cons_codrgm;
		private String m_cons_tapvia;
		private String m_cons_codvia;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;

      private String m_tipo_tabmnd;
      private String m_tipo_codmnd;
      #endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Contrato.
		/// </summary>
		public Contrato()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: CONT_Codigo.
		/// </summary>
		[DataMember]
		public Nullable<Int32> CONT_Codigo
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
		/// Gets or sets el valor de: CONT_Numero.
		/// </summary>
		[DataMember]
		public String CONT_Numero
		{
			get { return m_cont_numero; }
			set
			{
				if (m_cont_numero != value)
				{
					m_cont_numero = value;
					OnPropertyChanged("CONT_Numero");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONT_Descrip.
		/// </summary>
		[DataMember]
		public String CONT_Descrip
		{
			get { return m_cont_descrip; }
			set
			{
				if (m_cont_descrip != value)
				{
					m_cont_descrip = value;
					OnPropertyChanged("CONT_Descrip");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONT_FecEmi.
		/// </summary>
		[DataMember]
      public Nullable<DateTime> CONT_FecEmi
		{
			get { return m_cont_fecemi; }
			set
			{
				if (m_cont_fecemi != value)
				{
					m_cont_fecemi = value;
					OnPropertyChanged("CONT_FecEmi");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONT_FecIni.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> CONT_FecIni
		{
			get { return m_cont_fecini; }
			set
			{
				if (m_cont_fecini != value)
				{
					m_cont_fecini = value;
					OnPropertyChanged("CONT_FecIni");
				}
			}
		}
      /// <summary>
      /// Gets or sets el valor de: CONT_Activo.
      /// </summary>
      [DataMember]
      public Boolean CONT_Activo
      {
         get { return m_cont_activo; }
         set
         {
            if (m_cont_activo != value)
            {
               m_cont_activo = value;
               OnPropertyChanged("CONT_Activo");
            }
         }
      }
		/// <summary>
		/// Gets or sets el valor de: CONT_FecFin.
		/// </summary>
		[DataMember]
      public Nullable<DateTime> CONT_FecFin
		{
			get { return m_cont_fecfin; }
			set
			{
				if (m_cont_fecfin != value)
				{
					m_cont_fecfin = value;
					OnPropertyChanged("CONT_FecFin");
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
		/// Gets or sets el valor de: CONS_TapRGM.
		/// </summary>
		[DataMember]
		public String CONS_TapRGM
		{
			get { return m_cons_taprgm; }
			set
			{
				if (m_cons_taprgm != value)
				{
					m_cons_taprgm = value;
					OnPropertyChanged("CONS_TapRGM");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_CodRGM.
		/// </summary>
		[DataMember]
		public String CONS_CodRGM
		{
			get { return m_cons_codrgm; }
			set
			{
				if (m_cons_codrgm != value)
				{
					m_cons_codrgm = value;
					OnPropertyChanged("CONS_CodRGM");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_TapVia.
		/// </summary>
		[DataMember]
		public String CONS_TapVia
		{
			get { return m_cons_tapvia; }
			set
			{
				if (m_cons_tapvia != value)
				{
					m_cons_tapvia = value;
					OnPropertyChanged("CONS_TapVia");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_CodVia.
		/// </summary>
		[DataMember]
		public String CONS_CodVia
		{
			get { return m_cons_codvia; }
			set
			{
				if (m_cons_codvia != value)
				{
					m_cons_codvia = value;
					OnPropertyChanged("CONS_CodVia");
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
      #endregion

		#region [ CopyTo ]
		public void CopyTo(ref Contrato Item)
		{
			try
			{
				if (Item == null) { Item = new Contrato(); }
				Item.CONT_Codigo = this.CONT_Codigo;
				Item.EMPR_Codigo = this.EMPR_Codigo;
				Item.CONT_Numero = this.CONT_Numero;
				Item.CONT_Descrip = this.CONT_Descrip;
				Item.CONT_FecEmi = this.CONT_FecEmi;
				Item.CONT_FecIni = this.CONT_FecIni;
				Item.CONT_FecFin = this.CONT_FecFin;
				Item.ENTC_CodCliente = this.ENTC_CodCliente;
				Item.ENTC_CodTransportista = this.ENTC_CodTransportista;
				Item.CONS_TapRGM = this.CONS_TapRGM;
				Item.CONS_CodRGM = this.CONS_CodRGM;
				Item.CONS_TapVia = this.CONS_TapVia;
				Item.CONS_CodVia = this.CONS_CodVia;

            Item.TIPO_TabMND = this.TIPO_TabMND;
            Item.TIPO_CodMND = this.TIPO_CodMND;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
