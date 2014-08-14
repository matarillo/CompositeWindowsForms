using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Composite.Modularity;
using System.Windows.Forms;
using CompositeWFModuleLib;
using IDesign.Composite.UnityExtensions;

namespace CompositeWindowsFormsEventsAndModulesDemo
{
    internal class Bootstrapper: SimpleUnityBootstrapper
    {
        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
            Shell = Container.Resolve<Shell>();
        }
        protected override IModuleEnumerator GetModuleEnumerator()
        {
            return new StaticModuleEnumerator().AddModule(typeof(CompositeWFModule));
        }

        public Shell Shell { get; private set; }
     
    }
}
