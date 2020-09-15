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
	public partial class Movimiento
	{
		#region [ Variables ]
		CuentasBancarias m_itemCuentasBancarias;
		ObservableCollection<CuentasBancarias> m_listCuentasBancarias;
		Flujo m_itemFlujo;
		ObservableCollection<Flujo> m_listFlujo;
		Planillas m_itemPlanillas;
		ObservableCollection<Planillas> m_listPlanillas;
		//Transferencia m_itemTransferencia;
		//ObservableCollection<Transferencia> m_listTransferencia;
		Empresa m_itemEmpresa;
		ObservableCollection<Empresa> m_listEmpresa;
		Entidad m_itemEntidad;
		ObservableCollection<Entidad> m_listEntidad;
		Sucursales m_itemSucursales;
		ObservableCollection<Sucursales> m_listSucursales;
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: CuentasBancarias.
		/// </summary>
		[DataMember]
		public CuentasBancarias ItemCuentasBancarias
		{
			get { return  m_itemCuentasBancarias; }
			set {  m_itemCuentasBancarias = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: CuentasBancarias.
		/// </summary>
		[DataMember]
		public ObservableCollection<CuentasBancarias> ListCuentasBancarias
		{
			get { return  m_listCuentasBancarias; }
			set {  m_listCuentasBancarias = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Flujo.
		/// </summary>
		[DataMember]
		public Flujo ItemFlujo
		{
			get { return  m_itemFlujo; }
			set {  m_itemFlujo = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Flujo.
		/// </summary>
		[DataMember]
		public ObservableCollection<Flujo> ListFlujo
		{
			get { return  m_listFlujo; }
			set {  m_listFlujo = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Planillas.
		/// </summary>
		[DataMember]
		public Planillas ItemPlanillas
		{
			get { return  m_itemPlanillas; }
			set {  m_itemPlanillas = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Planillas.
		/// </summary>
		[DataMember]
		public ObservableCollection<Planillas> ListPlanillas
		{
			get { return  m_listPlanillas; }
			set {  m_listPlanillas = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Transferencia.
		/// </summary>
      //[DataMember]
      //public Transferencia ItemTransferencia
      //{
      //   get { return  m_itemTransferencia; }
      //   set {  m_itemTransferencia = value; }
      //}
		/// <summary>
		/// Gets or sets el valor de: Transferencia.
		/// </summary>
      //[DataMember]
      //public ObservableCollection<Transferencia> ListTransferencia
      //{
      //   get { return  m_listTransferencia; }
      //   set {  m_listTransferencia = value; }
      //}
		/// <summary>
		/// Gets or sets el valor de: Empresa.
		/// </summary>
		[DataMember]
		public Empresa ItemEmpresa
		{
			get { return  m_itemEmpresa; }
			set {  m_itemEmpresa = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Empresa.
		/// </summary>
		[DataMember]
		public ObservableCollection<Empresa> ListEmpresa
		{
			get { return  m_listEmpresa; }
			set {  m_listEmpresa = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Entidad.
		/// </summary>
		[DataMember]
		public Entidad ItemEntidad
		{
			get { return  m_itemEntidad; }
			set {  m_itemEntidad = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Entidad.
		/// </summary>
		[DataMember]
		public ObservableCollection<Entidad> ListEntidad
		{
			get { return  m_listEntidad; }
			set {  m_listEntidad = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Sucursales.
		/// </summary>
		[DataMember]
		public Sucursales ItemSucursales
		{
			get { return  m_itemSucursales; }
			set {  m_itemSucursales = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Sucursales.
		/// </summary>
		[DataMember]
		public ObservableCollection<Sucursales> ListSucursales
		{
			get { return  m_listSucursales; }
			set {  m_listSucursales = value; }
		}
		#endregion
	}
}
