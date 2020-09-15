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
   public partial class FuncionEntidad : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int32 m_entc_codigo;
		private Int16 m_tipe_codigo;
		private Boolean m_fent_activo;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
        private Boolean m_fent_extranet;
        private String m_entc_codsap_c;
        private String m_entc_codsap_p;
        private Nullable<DateTime> m_entc_fecactsap;
        private Boolean m_entc_estactsap;
        #endregion

        #region [ Constructores ]
        /// <summary>
        /// Inicializar una nueva instancia de la clase FuncionEntidad.
        /// </summary>
        public FuncionEntidad()
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
		/// Gets or sets el valor de: FENT_Activo.
		/// </summary>
		[DataMember]
		public Boolean FENT_Activo
		{
			get { return m_fent_activo; }
			set
			{
				if (m_fent_activo != value)
				{
					m_fent_activo = value;
					OnPropertyChanged("FENT_Activo");
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
        /// Gets or sets el valor de: FENT_Extranet.
        /// </summary>
        [DataMember]
        public Boolean FENT_Extranet
        {
            get { return m_fent_extranet; }
            set
            {
                if (m_fent_extranet != value)
                {
                    m_fent_extranet = value;
                    OnPropertyChanged("FENT_Extranet");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: ENTC_CodSAP_C.
        /// </summary>
        [DataMember]
        public String ENTC_CodSAP_C
        {
            get { return m_entc_codsap_c; }
            set
            {
                if (m_entc_codsap_c != value)
                {
                    m_entc_codsap_c = value;
                    OnPropertyChanged("ENTC_CodSAP_C");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: ENTC_CodSAP_P.
        /// </summary>
        [DataMember]
        public String ENTC_CodSAP_P
        {
            get { return m_entc_codsap_p; }
            set
            {
                if (m_entc_codsap_p != value)
                {
                    m_entc_codsap_p = value;
                    OnPropertyChanged("ENTC_CodSAP_P");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: AUDI_FecMod.
        /// </summary>
        [DataMember]
        public Nullable<DateTime> ENTC_FecActSAP
        {
            get { return m_entc_fecactsap; }
            set
            {
                if (m_entc_fecactsap != value)
                {
                    m_entc_fecactsap = value;
                    OnPropertyChanged("ENTC_FecActSAP");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: ENTC_EstActSAP.
        /// </summary>
        [DataMember]
        public Boolean ENTC_EstActSAP
        {
            get { return m_entc_estactsap; }
            set
            {
                if (m_entc_estactsap != value)
                {
                    m_entc_estactsap = value;
                    OnPropertyChanged("ENTC_EstActSAP");
                }
            }
        }
        #endregion

        #region [ CopyTo ]
        public void CopyTo(ref FuncionEntidad Item)
		{
			try
			{
				if (Item == null) { Item = new FuncionEntidad(); }
				Item.ENTC_Codigo = this.ENTC_Codigo;
				Item.TIPE_Codigo = this.TIPE_Codigo;
				Item.FENT_Activo = this.FENT_Activo;
                Item.FENT_Extranet = this.FENT_Extranet;
                Item.ENTC_CodSAP_C = this.ENTC_CodSAP_C;
                Item.ENTC_CodSAP_P = this.ENTC_CodSAP_P;
                Item.ENTC_FecActSAP = this.ENTC_FecActSAP;
                Item.ENTC_EstActSAP = this.ENTC_EstActSAP;
            }
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
