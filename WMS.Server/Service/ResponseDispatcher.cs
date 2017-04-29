using System.Collections.Generic;
using System;

using WMS.Common;

namespace WMS.Server
{
    abstract class ResponseDispatcher
    {
        public virtual IList<Response> ResultWork(IList<Response> responseEntitiesParam)
        {
            WMSEntities context = new WMSEntities( new Uri( "http://localhost:58833/DatabaseService.svc/" ) );

            foreach (Response r in responseEntitiesParam)
            {
                context.AddToData( new Data() { SensorId = r.SensorId, Date = r.Date, Time = r.Time, Value = r.Value } );
            }

            context.SaveChanges();

            return responseEntitiesParam;
        }

        public static ResponseDispatcher GetDispatcher(ResultSettings resultSettingsParam)
        {
            ResponseDispatcher responseDispatcher = null;

            switch (resultSettingsParam)
            {
                case ResultSettings.saveOnly:
                    responseDispatcher = new ResponseSaveOnly();
                    break;

                case ResultSettings.showOnly:
                    responseDispatcher = new ResponseShowOnly();
                    break;

                case ResultSettings.showAndSave:
                    responseDispatcher = new ResponseSaveAndShow();
                    break;
            }

            return responseDispatcher;
        }

        class ResponseSaveAndShow : ResponseDispatcher
        {
            public override IList<Response> ResultWork(IList<Response> responseEntitiesParam)
            {
                return base.ResultWork(responseEntitiesParam);
            }
        }

        class ResponseSaveOnly : ResponseDispatcher
        {
            public override IList<Response> ResultWork(IList<Response> responseEntitiesParam)
            {
                base.ResultWork( responseEntitiesParam );

                return null;
            }
        }

        class ResponseShowOnly : ResponseDispatcher
        {
            public override IList<Response> ResultWork(IList<Response> responseEntitiesParam)
            {
                return responseEntitiesParam;
            }
        }
    }
}
