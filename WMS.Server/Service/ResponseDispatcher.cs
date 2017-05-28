using System.Collections.Generic;
using System.Linq;

using WMS.Common;
using WMS.Domain;

namespace WMS.Server
{
    abstract class ResponseDispatcher
    {
        public virtual List<Response> ResultWork(IEnumerable<Response> responseEntitiesParam)
        {
            DataRepository repository = new DataRepository();

            foreach (Response r in responseEntitiesParam)
            {
                repository.AddAsync( new Data() { SensorId = r.SensorId, Date = r.Date, Time = r.Time, Value = r.Value } );
            }

            return responseEntitiesParam.ToList();
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
            public override List<Response> ResultWork(IEnumerable<Response> responseEntitiesParam)
            {
                return base.ResultWork(responseEntitiesParam);
            }
        }

        class ResponseSaveOnly : ResponseDispatcher
        {
            public override List<Response> ResultWork(IEnumerable<Response> responseEntitiesParam)
            {
                base.ResultWork( responseEntitiesParam );

                return null;
            }
        }

        class ResponseShowOnly : ResponseDispatcher
        {
            public override List<Response> ResultWork(IEnumerable<Response> responseEntitiesParam)
            {
                return responseEntitiesParam.ToList();
            }
        }
    }
}
