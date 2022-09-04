using ApplicationCommon.CommonResources;
using ApplicationCommon.CommonTypes;
 
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCommon.CommonServices.CommonResources
{
    class TestCommonResources //: TestingElement
    {
        //protected override void onTest()
        protected void onTest()
        {
            canSaveFileCatalog();
        }

        private void canSaveFileCatalog()
        {
            using (ResourcesDbContext db = new ResourcesDbContext())
            {
                ResourcesService resources = new ResourcesService(db);

                TypeCatalog catalog = new TypeCatalog(
                    @"A:\Wrk\libs\NetCoreApplication\ApplicationCommon\CommonClientApp",
                    "ClienApp");
                catalog.DoBroadcastToChildren<TypeCatalog>((TypeCatalog p) => {
                    Console.WriteLine(p.Name);
                });

                resources.Save(catalog);
            }
        }
    }
}
