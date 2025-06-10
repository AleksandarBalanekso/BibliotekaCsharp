using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace KlijentForma
{
    static class Konekcija
    {

        static ChannelFactory<IBiblioteka> ch = new ChannelFactory<IBiblioteka>(new BasicHttpBinding(),
            new EndpointAddress("http://localhost:8000"));

        static IBiblioteka proxy = null;

        public static IBiblioteka Proxy
        {
            get
            {
                if (proxy == null)
                    proxy = ch.CreateChannel();

                return proxy;
            }
        }
    }
}
