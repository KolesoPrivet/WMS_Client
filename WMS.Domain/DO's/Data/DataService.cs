using System.Collections.Generic;
using AutoMapper;

using WMS.Common;

namespace WMS.Domain
{
    public class DataService : Service<Data, DataDto>
    {
        public DataService()
        {
            _repository = new DataRepository();
        }

        public override DataDto Map(Data source)
        {
            Mapper.Initialize( cfg => cfg.CreateMap<Data, DataDto>() );
            return Mapper.Map<Data, DataDto>( source );
        }

        public override List<DataDto> Map(IEnumerable<Data> source)
        {
            Mapper.Initialize( cfg => cfg.CreateMap<Data, DataDto>() );
            return Mapper.Map<IEnumerable<Data>, List<DataDto>>( source );
        }
    }
}