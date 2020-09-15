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
	public partial class Det_Tarifa
	{
        #region [ Variables Adicionales ]
        private Decimal m_DTAR_Costo20;
        private Decimal m_DTAR_CostoSada20;
        private Decimal m_DTAR_Costo40;
        private Decimal m_DTAR_CostoSada40;
        private Boolean m_Trasanct = true;
        private string m_ENTC_RazonSocial;
        private String m_CONS_Desc_SPA;
        private String m_CONS_CodTipo;
        private String m_CONS_CodTipoTipo;
        private Decimal m_DTAR_CostoHBL;
        private Decimal m_DTAR_CostoSadaHBL;
        private String m_TIPE_Descripcion;
        private String m_CONS_Desc_TRA;
        #endregion

        #region [ Propiedades Adicionales ]
        [DataMember]
        public Decimal DTAR_Costo20
        {
            get { return m_DTAR_Costo20; }
            set { m_DTAR_Costo20 = value; }
        }
        [DataMember]
        public Decimal DTAR_CostoSada20
        {
            get { return m_DTAR_CostoSada20; }
            set { m_DTAR_CostoSada20 = value; }
        }
        [DataMember]
        public Decimal DTAR_Costo40
        {
            get { return m_DTAR_Costo40; }
            set { m_DTAR_Costo40 = value; }
        }
        [DataMember]
        public Decimal DTAR_CostoSada40
        {
            get { return m_DTAR_CostoSada40; }
            set { m_DTAR_CostoSada40 = value; }
        }
        [DataMember]
        public Boolean Trasanct
        {
            get { return m_Trasanct; }
            set { m_Trasanct = value; }
        }
        [DataMember]
        public string ENTC_RazonSocial
        {
            get { return m_ENTC_RazonSocial; }
            set { m_ENTC_RazonSocial = value; }
        }
        [DataMember]
        public String CONS_Desc_SPA
        {
            get { return m_CONS_Desc_SPA; }
            set { m_CONS_Desc_SPA = value; }
        }
        [DataMember]
        public String CONS_CodTipo
        {
            get { return m_CONS_CodTipo; }
            set { m_CONS_CodTipo = value; }
        }
        [DataMember]
        public String CONS_CodTipoTipo
        {
            get { return m_CONS_CodTipoTipo; }
            set { m_CONS_CodTipoTipo = value; }
        }
        [DataMember]
        public Decimal DTAR_CostoHBL
        {
            get { return m_DTAR_CostoHBL; }
            set { m_DTAR_CostoHBL = value; }
        }
        [DataMember]
        public Decimal DTAR_CostoSadaHBL
        {
            get { return m_DTAR_CostoSadaHBL; }
            set { m_DTAR_CostoSadaHBL = value; }
        }

        [DataMember]
        public String TIPE_Descripcion
        {
            get { return m_TIPE_Descripcion; }
            set { m_TIPE_Descripcion = value; }
        }
        [DataMember]
        public Int32 DTAR_Fila { get; set; }

        [DataMember]
        public String CONS_Desc_TRA
        {
            get { return m_CONS_Desc_TRA; }
            set { m_CONS_Desc_TRA = value; }
        }

        [DataMember]
        public String ORIGEN { get; set; }

        [DataMember]
        public String DESTINO { get; set; }


        
        #endregion
	}
}
