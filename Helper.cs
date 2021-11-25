using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabrica
{
    class Helper
    {
        public static SewingFactoryEntities s_GarmentModel;

        public static SewingFactoryEntities GetContext()
        {
            if(s_GarmentModel == null)
            {
                s_GarmentModel = new SewingFactoryEntities();
            }
            return s_GarmentModel;
        }
    }
}
