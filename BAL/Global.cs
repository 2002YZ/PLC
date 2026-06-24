using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BAL
{
    public class Global
    {
        public static LogHelper LogHelper = LogHelper.Instance;
        public static Config Config = Config.Instance;
        public static VisionPro VisionProInstance = VisionPro.Instance;
        public  static PlcOperator PlcOperatorInstance = PlcOperator.Instance;
    }
}
