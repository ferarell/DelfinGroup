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
	public partial class Det_Operacion
	{
        #region [ Variables Adicionales ]
        private Decimal m_DOPE_Venta20;
        private Decimal m_DOPE_VentaSada20;
        private Decimal m_DOPE_Venta40;
        private Decimal m_DOPE_VentaSada40;
        private Decimal m_DOPE_VentaHBL;
        private Decimal m_DOPE_VentaSadaHBL;

        private Decimal m_DOPE_Costo20;
        private Decimal m_DOPE_CostoSada20;
        private Decimal m_DOPE_Costo40;
        private Decimal m_DOPE_CostoSada40;
        private Decimal m_DOPE_CostoHBL;
        private Decimal m_DOPE_CostoSadaHBL;

        private Int16 m_DOPE_Cantidad20;
        private Int16 m_DOPE_Cantidad40;

        private Boolean m_Trasanct = true;
        private string m_ENTC_RazonSocial;
        private String m_CONS_Desc_SPA;
        private String m_CONS_CodTipo;
        private String m_CONS_CodTipoTipo;
        private String m_TIPE_Descripcion;
        private String m_CONS_Desc_TRA;
        private Boolean m_Validado = false;
        #endregion

        #region [ Propiedades Adicionales ]
        [DataMember]
        public Decimal DOPE_Venta20
        {
            get { return m_DOPE_Venta20; }
            set { m_DOPE_Venta20 = value; }
        }
        [DataMember]
        public Decimal DOPE_VentaSada20
        {
            get { return m_DOPE_VentaSada20; }
            set { m_DOPE_VentaSada20 = value; }
        }
        [DataMember]
        public Decimal DOPE_Venta40
        {
            get { return m_DOPE_Venta40; }
            set { m_DOPE_Venta40 = value; }
        }
        [DataMember]
        public Decimal DOPE_VentaSada40
        {
            get { return m_DOPE_VentaSada40; }
            set { m_DOPE_VentaSada40 = value; }
        }

        [DataMember]
        public Decimal DOPE_Costo20
        {
           get { return m_DOPE_Costo20; }
           set { m_DOPE_Costo20 = value; }
        }
        [DataMember]
        public Decimal DOPE_CostoSada20
        {
           get { return m_DOPE_CostoSada20; }
           set { m_DOPE_CostoSada20 = value; }
        }
        [DataMember]
        public Decimal DOPE_Costo40
        {
           get { return m_DOPE_Costo40; }
           set { m_DOPE_Costo40 = value; }
        }
        [DataMember]
        public Decimal DOPE_CostoSada40
        {
           get { return m_DOPE_CostoSada40; }
           set { m_DOPE_CostoSada40 = value; }
        }

        [DataMember]
        public Decimal DOPE_CostoHBL
        {
           get { return m_DOPE_CostoHBL; }
           set { m_DOPE_CostoHBL = value; }
        }
        [DataMember]
        public Decimal DOPE_CostoSadaHBL
        {
           get { return m_DOPE_CostoSadaHBL; }
           set { m_DOPE_CostoSadaHBL = value; }
        }

        [DataMember]
        public Int16 DOPE_Cantidad20
        {
            get { return m_DOPE_Cantidad20; }
            set { m_DOPE_Cantidad20 = value; }
        }
        [DataMember]
        public Int16 DOPE_Cantidad40
        {
            get { return m_DOPE_Cantidad40; }
            set { m_DOPE_Cantidad40 = value; }
        }

        [DataMember]
        public Decimal DOPE_VentaHBL
        {
            get { return m_DOPE_VentaHBL; }
            set { m_DOPE_VentaHBL = value; }
        }
        [DataMember]
        public Decimal DOPE_VentaSadaHBL
        {
            get { return m_DOPE_VentaSadaHBL; }
            set { m_DOPE_VentaSadaHBL = value; }
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
        public String TIPE_Descripcion
        {
            get { return m_TIPE_Descripcion; }
            set { m_TIPE_Descripcion = value; }
        }
        [DataMember]
        public Int32 DOPE_Fila { get; set; }
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

        [DataMember]
        public Boolean Validado
        {
            get { return m_Validado; }
            set { m_Validado = value; }
        }
        
        [DataMember]
        public Decimal DOPE_PrecioTotVta20 { get; set; }

        [DataMember]
        public Decimal DOPE_PrecioTotVta40 { get; set; }

        [DataMember]
        public String CONS_CodEST { get; set; }

        [DataMember]
        public String CONS_TabEST { get; set; }
        #endregion
    }
}
