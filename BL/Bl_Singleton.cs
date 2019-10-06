using System;
using System.Collections.Generic;
using System.Text;
using BE;
using Bl;
using DAL;
namespace BL
{
    public class Bl_Singleton
    {
        static IBL instance ;
        public static IBL GetBl()
        {
            if (instance == null)
                instance = new Ibl_imp();
            return instance;
        }

    }
}