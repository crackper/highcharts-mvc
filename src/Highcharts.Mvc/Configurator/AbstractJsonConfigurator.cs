﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Highcharts.Mvc.Json;

namespace Highcharts.Mvc
{
    public abstract class JsonConfigurator
    {
        private JsonAttribute jsonConfig;
        public JsonConfigurator(string name)
        {
            this.jsonConfig = new JsonAttribute(name);
        }

        protected void Set(JsonAttribute json)
        {
            this.jsonConfig.Set(json);
        }

        protected void SetOptions(JsonAttribute json)
        {
            this.jsonConfig.SetOptions(json);
        }

        internal JsonAttribute ToJson()
        {
            return this.jsonConfig;
        }
    }
}
