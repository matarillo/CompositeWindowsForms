using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Composite.Modularity;
using Microsoft.Practices.Unity;
using System.Windows.Forms;

namespace CompositeWFModuleLib
{
public class CompositeWFModule : IModule
{
    IUnityContainer m_Container;
    public CompositeWFModule(IUnityContainer container)
    {
        m_Container = container;
    }
    #region IModule Members

    public void Initialize()
    {
        Panel mainRegion = m_Container.Resolve<Panel>("MainRegion");
        ModuleView view = m_Container.Resolve<ModuleView>();
        view.Dock = DockStyle.Fill;
        mainRegion.Controls.Add(view);
    }

    #endregion
}
}
