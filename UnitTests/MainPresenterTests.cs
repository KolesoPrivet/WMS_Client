using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using DomainModel.Abstract;
using System.Collections.Generic;
using DomainModel.Entity;
using Presentation.Presenter;
using Presentation.Common;

namespace UnitTests
{
    [TestClass]
    public class MainPresenterTests
    {
        [TestMethod]
        public void Can_Get_Sensors_and_Data_Async()
        {
            Mock<ISensorRepository> mockSensor = new Mock<ISensorRepository>();

            mockSensor.Setup(m => m.Sensors).Returns(new List<Sensor>
            {
                new Sensor { SensorId = 1, Name = "Sensor1", SensorType = "Type1", Radius = "5", Lat = 21, Lng = 20 }
            });

            Mock<IDataRepository> mockData = new Mock<IDataRepository>();

            mockData.Setup(m => m.Data).Returns(new List<Data>
            {
                new Data { DataId = 1, SensorId = 1, Date = DateTime.Now.Date, Time = TimeSpan.Zero, Value = 50  },
                 new Data { DataId = 2, SensorId = 1, Date = DateTime.Now.Date, Time = TimeSpan.Zero, Value = 150  },
                  new Data { DataId = 3, SensorId = 1, Date = DateTime.Now.Date, Time = TimeSpan.Zero, Value = 250  }
            });

            List<Sensor> sensor = MainPresenter.GetSensorsListAsync(mockSensor.Object);

            List<Data> data = MainPresenter.GetDataListAsync(mockData.Object);

            Assert.AreEqual(sensor.Count, 1);
            Assert.AreEqual(data.Count, 3);
        }
    }
}
