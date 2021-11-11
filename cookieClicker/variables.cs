using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cookieClicker {
    class variables { // class with variables
        private long cookies; // variable for cookies

        public variables(long cookies) { // constructor
            this.cookies = cookies;
        }

        public void setCookies(long cookies) { // set value for cookies
            this.cookies = cookies;
        }

        public long getCookies() { // get value of cookies
            return cookies;
        }
    }
}