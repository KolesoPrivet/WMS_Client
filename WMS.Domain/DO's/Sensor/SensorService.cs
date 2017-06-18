using System.Collections.Generic;
using AutoMapper;

using WMS.Common;

namespace WMS.Domain
{
    public class SensorService : Service<Sensor, SensorDto>
    {
        public SensorService()
        {
            _repository = new SensorRepository();
        }

        public override SensorDto Map(Sensor source)
        {
            Mapper.Initialize( cfg => cfg.CreateMap<Sensor, SensorDto>() );
            return Mapper.Map<Sensor, SensorDto>(source);
        }

        public override List<SensorDto> Map(IEnumerable<Sensor> source)
        {
            Mapper.Initialize( cfg => cfg.CreateMap<Sensor, SensorDto>() );
            return Mapper.Map<IEnumerable<Sensor>, List<SensorDto>>( source );
        }
    }
}