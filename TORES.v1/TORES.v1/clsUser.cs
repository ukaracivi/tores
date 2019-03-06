using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TORES.v1
{
    public class clsUser
    {
        private int _persId;
        private string _persAd;
        private string _persSoyad;

        public int PersID
        {
            get {
                return _persId;
                }

            set {
                _persId = value;
                }
        }

        public string PersAd
        {
            get
            {
                return _persAd;
            }

            set
            {
                _persAd = value;
            }
        }

        public string PersSoyad
        {
            get
            {
                return _persSoyad;
            }

            set
            {
                _persSoyad = value;
            }
        }
    }
}