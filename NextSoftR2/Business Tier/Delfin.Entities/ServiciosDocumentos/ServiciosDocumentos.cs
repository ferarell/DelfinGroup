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
	public partial class ServiciosDocumentos : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int32 m_serv_codigo;
		private String m_tipo_tabtdo;
		private String m_tipo_codtdo;
		private String m_sedo_tipo;
        private Int32 m_sedo_item;

        private Int32 m_sedo_seleccionar;

        private Int32 m_tipe_codigo;



        #endregion

        #region [ Constructores ]
        /// <summary>
        /// Inicializar una nueva instancia de la clase ServiciosDocumentos.
        /// </summary>
        public ServiciosDocumentos()
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
		/// Gets or sets el valor de: SEDO_Tipo.
		/// </summary>
		[DataMember]
		public String SEDO_Tipo
		{
			get { return m_sedo_tipo; }
			set
			{
				if (m_sedo_tipo != value)
				{
					m_sedo_tipo = value;
					OnPropertyChanged("SEDO_Tipo");
				}
			}
		}


        /// <summary>
        /// Gets or sets el valor de: SEDO_Seleccionar.
        /// </summary>
        [DataMember]
        public Int32 SEDO_Seleccionar
        {
            get { return m_sedo_seleccionar; }
            set
            {
                if (m_sedo_seleccionar != value)
                {
                    m_sedo_seleccionar = value;
                    OnPropertyChanged("SEDO_Seleccionar");
                }
            }
        }

        /// <summary>
        /// Gets or sets el valor de: SEDO_Item.
        /// </summary>
        [DataMember]
        public Int32 SEDO_Item
        {
            get { return m_sedo_item; }
            set
            {
                if (m_sedo_item != value)
                {
                    m_sedo_item = value;
                    OnPropertyChanged("SEDO_Item");
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

        #endregion

        #region [ CopyTo ]
        public void CopyTo(ref ServiciosDocumentos Item)
		{
			try
			{
				if (Item == null) { Item = new ServiciosDocumentos(); }
				Item.SERV_Codigo = this.SERV_Codigo;
				Item.TIPO_TabTDO = this.TIPO_TabTDO;
				Item.TIPO_CodTDO = this.TIPO_CodTDO;
				Item.SEDO_Tipo = this.SEDO_Tipo;
                Item.SEDO_Item = this.SEDO_Item;
                Item.TIPE_Codigo = this.TIPE_Codigo;
                Item.SEDO_Seleccionar = this.SEDO_Seleccionar;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
