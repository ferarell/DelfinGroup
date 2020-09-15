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
	public partial class Nave : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int16 m_NAVE_codigo;
		private String m_NAVE_nombre;
		private Nullable<Int32> m_entc_codtransportista;
		private DateTime m_audi_feccrea;
		private String m_audi_usrcrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
        private String m_ENTC_NomCompletoTransportista;
        private String m_cons_tabvia;
        private String m_cons_tabentemi;
        private String m_cons_codvia;
        private String m_NAVE_Matricula;
        private String m_NAVE_EntidadEmisora;

		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Nave.
		/// </summary>
		public Nave()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: Nave_Codigo.
		/// </summary>
		[DataMember]
		public Int16 NAVE_Codigo
		{
			get { return m_NAVE_codigo; }
			set
			{
				if (m_NAVE_codigo != value)
				{
					m_NAVE_codigo = value;
					OnPropertyChanged("NAVE_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: NAVE_Nombre.
		/// </summary>
		[DataMember]
		public String NAVE_Nombre
		{
			get { return m_NAVE_nombre; }
			set
			{
				if (m_NAVE_nombre != value)
				{
					m_NAVE_nombre = value;
					OnPropertyChanged("NAVE_Nombre");
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
        /// Gets or sets el valor de: m_ENTC_NomCompletoTransportista.
        /// </summary>
        [DataMember]
        public String ENTC_NomCompletoTransportista
        {
            get { return m_ENTC_NomCompletoTransportista; }
            set
            {
                if (m_ENTC_NomCompletoTransportista != value)
                {
                    m_ENTC_NomCompletoTransportista = value;
                    OnPropertyChanged("ENTC_NomCompletoTransportista");
                }
            }
        }

        /// <summary>
        /// Gets or sets el valor de: CONS_TabVia.
        /// </summary>
        [DataMember]
        public String CONS_TabVia
        {
            get { return m_cons_tabvia; }
            set
            {
                if (m_cons_tabvia != value)
                {
                    m_cons_tabvia = value;
                    OnPropertyChanged("CONS_TabVia");
                }
            }
        }

        /// <summary>
        /// Gets or sets el valor de: CONS_TabVia.
        /// </summary>
        [DataMember]
        public String CONS_TabEntEmi
        {
            get { return m_cons_tabentemi; }
            set
            {
                if (m_cons_tabentemi != value)
                {
                    m_cons_tabentemi = value;
                    OnPropertyChanged("CONS_TabEntEmi");
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
        /// Gets or sets el valor de: NAVE_Matricula.
        /// </summary>
        [DataMember]
        public String NAVE_Matricula
        {
            get { return m_NAVE_Matricula; }
            set
            {
                if (m_NAVE_Matricula != value)
                {
                    m_NAVE_Matricula = value;
                    OnPropertyChanged("NAVE_Matricula");
                }
            }
        }

        /// <summary>
        /// Gets or sets el valor de: NAVE_Matricula.
        /// </summary>
        [DataMember]
        public String NAVE_EntidadEmisora
        {
            get { return m_NAVE_EntidadEmisora; }
            set
            {
                if (m_NAVE_EntidadEmisora != value)
                {
                    m_NAVE_EntidadEmisora = value;
                    OnPropertyChanged("NAVE_EntidadEmisora");
                }
            }
        }     


		#endregion

		#region [ CopyTo ]
		public void CopyTo(ref Nave Item)
		{
			try
			{
				if (Item == null) { Item = new Nave(); }
				Item.NAVE_Codigo = this.NAVE_Codigo;
				Item.NAVE_Nombre = this.NAVE_Nombre;
                Item.NAVE_Matricula = this.NAVE_Matricula;
                Item.NAVE_EntidadEmisora = this.NAVE_EntidadEmisora;
				Item.ENTC_CodTransportista = this.ENTC_CodTransportista;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
