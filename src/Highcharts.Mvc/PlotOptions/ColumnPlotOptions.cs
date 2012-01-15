﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Highcharts.Mvc
{
    public class ColumnPlotOptions : PlotOptionsConfiguration<ColumnPlotOptions>
    {
        public ColumnPlotOptions()
            : base("column")
        {
            this.options = this;
        }
    }
}
