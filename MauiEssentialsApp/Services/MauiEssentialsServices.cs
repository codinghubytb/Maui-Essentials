using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiEssentialsApp.Services
{
    public static class MauiEssentialsServices
    {
        public static void CallNumberPhone(string number)
        {
            if (PhoneDialer.Default.IsSupported)
                PhoneDialer.Current.Open(number);
        }
    }
}
