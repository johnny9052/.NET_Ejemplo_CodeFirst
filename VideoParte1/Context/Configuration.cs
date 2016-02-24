using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/*Using necesarios*/
using System.Data.Entity.Migrations;

namespace VideoParte1.Context
{
    public class Configuration: DbMigrationsConfiguration<DataBaseContext>
    {

        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

    }
}