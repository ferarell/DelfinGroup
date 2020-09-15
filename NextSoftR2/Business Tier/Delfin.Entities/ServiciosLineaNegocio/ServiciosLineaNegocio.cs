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
	public partial class ServiciosLineaNegocio : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int32 m_serv_codigo;
        private String m_cons_tablng;
        private String m_cons_codlng;
        private String m_slng_remarks;
        private String m_serv_cuentaingreso;
        private String m_serv_cuentacosto;
        private String m_serv_cuentaingresosap;
        private String m_serv_cuentacostosap;
        private String m_serv_codsap;
        private DateTime? m_serv_fecactsap;
        private string m_serv_estactsap;
        private Int32 m_tipe_codigo;
        private Boolean m_serv_afeigv;

        private String m_audi_usrcrea;
		private DateTime? m_audi_feccrea;
		private String m_audi_usrmod;
        private DateTime? m_audi_fecmod;

        //cambio 24704

        private String m_cons_tabrgm;
        private String m_cons_codrgm;
        private String m_cons_tabvia;
        private String m_cons_codvia;

        #endregion

        #region [ Constructores ]
        /// <summary>
        /// Inicializar una nueva instancia de la clase ServiciosDocumentos.
        /// </summary>
        public ServiciosLineaNegocio()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: SERV_Codigo.
		/// </summary>
		[DataMember]
		public Int32 SERV_Codigo
		{
			get { return m_serv_codigo; }
			set
			{
				if (m_serv_codigo != value)
				{
					m_serv_codigo = value;
					OnPropertyChanged("SERV_Codigo");
				}
			}
		}


        /// <summary>
        /// Gets or sets el valor de: CONS_TabRGM.
        /// </summary>
        [DataMember]
        public String CONS_TabRGM
        {
            get { return m_cons_tabrgm; }
            set
            {
                if (m_cons_tabrgm != value)
                {
                    m_cons_tabrgm = value;
                    OnPropertyChanged("CONS_TabRGM");
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
        /// Gets or sets el valor de: CONS_TabVIA.
        /// </summary>
        [DataMember]
        public String CONS_TabVIA
        {
            get { return m_cons_tabvia; }
            set
            {
                if (m_cons_tabvia != value)
                {
                    m_cons_tabvia = value;
                    OnPropertyChanged("CONS_TabVIA");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: CONS_CodVIA.
        /// </summary>
        [DataMember]
        public String CONS_CodVIA
        {
            get { return m_cons_codvia; }
            set
            {
                if (m_cons_codvia != value)
                {
                    m_cons_codvia = value;
                    OnPropertyChanged("CONS_CodVIA");
                }
            }
        }



        /// <summary>
        /// Gets or sets el valor de: CONS_TabLNG.
        /// </summary>
        [DataMember]
		public String CONS_TabLNG
        {
			get { return m_cons_tablng; }
			set
			{
				if (m_cons_tablng != value)
				{
                    m_cons_tablng = value;
					OnPropertyChanged("CONS_TabLNG");
				}
			}
		}
        /// <summary>
        /// Gets or sets el valor de: CONS_CodLNG.
        /// </summary>
        [DataMember]
		public String CONS_CodLNG
        {
			get { return m_cons_codlng; }
			set
			{
				if (m_cons_codlng != value)
				{
                    m_cons_codlng = value;
					OnPropertyChanged("CONS_CodLNG");
				}
			}
		}
        /// <summary>
        /// Gets or sets el valor de: SLNG_Remarks.
        /// </summary>
        [DataMember]
		public String SLNG_Remarks
        {
			get { return m_slng_remarks; }
			set
			{
				if (m_slng_remarks != value)
				{
                    m_slng_remarks = value;
					OnPropertyChanged("SLNG_Remarks");
				}
			}
		}


        /// <summary>
        /// Gets or sets el valor de: SERV_CuentaIngreso.
        /// </summary>
        [DataMember]
        public String SERV_CuentaIngreso
        {
            get { return m_serv_cuentaingreso; }
            set
            {
                if (m_serv_cuentaingreso != value)
                {
                    m_serv_cuentaingreso = value;
                    OnPropertyChanged("SERV_CuentaIngreso");
                }
            }
        }

        /// <summary>
        /// Gets or sets el valor de: SERV_CuentaCosto.
        /// </summary>
        [DataMember]
        public String SERV_CuentaCosto
        {
            get { return m_serv_cuentacosto; }
            set
            {
                if (m_serv_cuentacosto != value)
                {
                    m_serv_cuentacosto = value;
                    OnPropertyChanged("SERV_CuentaCosto");
                }
            }
        }


        /// <summary>
        /// Gets or sets el valor de: SERV_CuentaIngresoSAP.
        /// </summary>
        [DataMember]
        public String SERV_CuentaIngresoSAP
        {
            get { return m_serv_cuentaingresosap; }
            set
            {
                if (m_serv_cuentaingresosap != value)
                {
                    m_serv_cuentaingresosap = value;
                    OnPropertyChanged("SERV_CuentaIngresoSAP");
                }
            }
        }



        /// <summary>
        /// Gets or sets el valor de: SERV_CuentaCostoSAP.
        /// </summary>
        [DataMember]
        public String SERV_CuentaCostoSAP
        {
            get { return m_serv_cuentacostosap; }
            set
            {
                if (m_serv_cuentacostosap != value)
                {
                    m_serv_cuentacostosap = value;
                    OnPropertyChanged("SERV_CuentaCostoSAP");
                }
            }
        }


        /// <summary>
        /// Gets or sets el valor de: SERV_CuentaCostoSAP.
        /// </summary>
        [DataMember]
        public String SERV_CodSAP
        {
            get { return m_serv_codsap; }
            set
            {
                if (m_serv_codsap != value)
                {
                    m_serv_codsap = value;
                    OnPropertyChanged("SERV_CodSAP");
                }
            }
        }

        /// <summary>
        /// Gets or sets el valor de: SERV_CuentaCostoSAP.
        /// </summary>
        [DataMember]
        public DateTime? SERV_FecActSAP
        {
            get { return m_serv_fecactsap; }
            set
            {
                if (m_serv_fecactsap != value)
                {
                    m_serv_fecactsap = value;
                    OnPropertyChanged("SERV_FecActSAP");
                }
            }
        }

        /// <summary>
        /// Gets or sets el valor de: SERV_CuentaCostoSAP.
        /// </summary>
        [DataMember]
        public String SERV_EstActSAP
        {
            get { return m_serv_estactsap; }
            set
            {
                if (m_serv_estactsap != value)
                {
                    m_serv_estactsap = value;
                    OnPropertyChanged("SERV_EstActSAP");
                }
            }
        }


        /// <summary>
		/// Gets or sets el valor de: TIPE_Codigo.
		/// </summary>
		[DataMember]
        public Int32 TIPE_Codigo
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
        /// Gets or sets el valor de: SERV_AfeIgv.
        /// </summary>
        [DataMember]
        public Boolean SERV_AfeIgv
        {
            get { return m_serv_afeigv; }
            set
            {
                if (m_serv_afeigv != value)
                {
                    m_serv_afeigv = value;
                    OnPropertyChanged("SERV_AfeIgv");
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
        public DateTime? AUDI_FecCrea
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
        /// Gets or sets el valor de: AUDI_FecCrea.
        /// </summary>
        [DataMember]
        public DateTime? AUDI_FecMod
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
        public void CopyTo(ref ServiciosLineaNegocio Item)
		{
			try
			{
				if (Item == null) { Item = new ServiciosLineaNegocio(); }
				Item.SERV_Codigo = this.SERV_Codigo;
				Item.m_cons_tablng = this.m_cons_tablng;
				Item.m_cons_codlng = this.m_cons_codlng;
                Item.m_cons_tabrgm = this.m_cons_tabrgm;
                Item.m_cons_codrgm = this.m_cons_codrgm;
                Item.m_cons_tabvia = this.m_cons_tabvia;
                Item.m_cons_codvia = this.m_cons_codvia;
                Item.m_slng_remarks = this.m_slng_remarks;
                Item.m_serv_cuentaingreso = this.m_serv_cuentaingreso;
                Item.m_serv_cuentacosto = this.m_serv_cuentacosto;
                Item.m_serv_cuentaingresosap = this.m_serv_cuentaingresosap;
                Item.m_serv_cuentacostosap = this.m_serv_cuentacostosap;
                Item.m_serv_codsap = this.m_serv_codsap;                
                Item.m_serv_fecactsap = this.m_serv_fecactsap;
                Item.m_serv_estactsap = this.m_serv_estactsap;
                Item.m_tipe_codigo = this.m_tipe_codigo;
                Item.m_serv_afeigv = this.m_serv_afeigv;
                Item.m_audi_usrcrea = this.m_audi_usrcrea;
                Item.m_audi_feccrea = this.m_audi_feccrea;
                Item.m_audi_usrmod = this.m_audi_usrmod;
                Item.m_audi_fecmod = this.m_audi_fecmod;
            }
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
