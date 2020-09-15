using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delfin.BusinessLogic
{
   public interface ICGeneral
   {
      DateTime GetFecha();
      String getNameServer();
      String getNameInstancia();
      String getNameDataBase();
   }
}
