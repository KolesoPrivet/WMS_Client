using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data.Services.Client;
using System.Linq;
using WMS.Common;
using WMS.Domain;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            WmsContext ctx = new WmsContext();
            var source = ctx.Sensors;

            Mapper.Initialize( cfg => cfg.CreateMap<Sensor, SensorDto>() );
            var dtos = Map(source);

            Console.WriteLine(dtos.FirstOrDefault().Name);
        }

        public static List<SensorDto> Map(IEnumerable<Sensor> source)
        {
            Mapper.Initialize( cfg => cfg.CreateMap<Sensor, SensorDto>() );
            return Mapper.Map<IEnumerable<Sensor>, List<SensorDto>>( source );
        }
    }
}
