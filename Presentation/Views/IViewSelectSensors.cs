﻿using Presentation.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Views
{
    public interface IViewSelectSensors : IView
    {
        DialogResult ShowDialog();
    }
}
