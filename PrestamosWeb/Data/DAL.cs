
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Configuration;

namespace PrestamosWeb.Data
{
    public class DAL : DbContext
    {
        public DAL() : base()
        {

        }
    }
}