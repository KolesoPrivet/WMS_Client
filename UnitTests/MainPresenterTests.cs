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
            Mock<IRepository<Sensor>> mockSensor = new Mock<IRepository<Sensor>>();

            mockSensor.Setup(m => m.Get).Returns(new List<Sensor>
            {
                new Sensor { Id = 1, Name = "Sensor1", SensorType = "Type1", Radius = "5", Lat = 21, Lng = 20 }
            });

            Mock<IRepository<Data>> mockData = new Mock<IRepository<Data>>();

            mockData.Setup(m => m.Get).Returns(new List<Data>
            {
                new Data { Id = 1, SensorId = 1, Date = DateTime.Now.Date, Time = TimeSpan.Zero, Value = 50  },
                 new Data { Id = 2, SensorId = 1, Date = DateTime.Now.Date, Time = TimeSpan.Zero, Value = 150  },
                  new Data { Id = 3, SensorId = 1, Date = DateTime.Now.Date, Time = TimeSpan.Zero, Value = 250  }
            });

            List<Sensor> sensor = (List<Sensor>) MainPresenter.GetSensorsList();

            List<Data> data = (List<Data>) MainPresenter.GetDataList();

            Assert.AreEqual(sensor.Count, 1);
            Assert.AreEqual(data.Count, 3);
        }
    }
}
