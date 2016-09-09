using DomainModel.Abstract;
using DomainModel.Entity;
using Presentation.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.ViewFactory.Abstract;

namespace UI.ViewFactory.Client
{
    class View
    {
        private readonly Presenter concretePresenter;
        private readonly IView concreteView;

        private readonly IRepository<Sensor> sensorRepository;
        private readonly IRepository<Data> dataRepository;
        

        public View(Factory factory, IRepository<Sensor> sensorRepositoryParam, IRepository<Data> dataRepoitoryParam)
        {
            sensorRepository = sensorRepositoryParam;
            dataRepository = dataRepoitoryParam;

            concreteView = factory.CreateView();
            concretePresenter = factory.CreatePresenter();
        }

        public void Run()
        {
            concreteView.OwnPresenter = concretePresenter;
            concretePresenter.Run( concreteView, sensorRepository, dataRepository );
        }
    }
}
