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
	public partial class Tarifa
	{
      public void ActualizarPrecios()
      {
         try
         {
            if (this.TARI_Costo.HasValue)
            {
               if (this.TARI_Profit1.HasValue) { this.TARI_PVenta1 = this.TARI_Costo.Value + this.TARI_Profit1.Value; }
               if (this.TARI_Profit2.HasValue) { this.TARI_PVenta2 = this.TARI_Costo.Value + this.TARI_Profit2.Value; }
               if (this.TARI_Profit3.HasValue) { this.TARI_PVenta3 = this.TARI_Costo.Value + this.TARI_Profit3.Value; }
               if (this.TARI_Profit4.HasValue) { this.TARI_PVenta4 = this.TARI_Costo.Value + this.TARI_Profit4.Value; }
            }
         }
         catch (Exception)
         { throw; }
      }
	}
}
