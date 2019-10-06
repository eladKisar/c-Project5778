using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public static class Factory_Dal
    {

        public static IDAL GetDal()
        {
            return new Dal_xml();
        }

    }
}
