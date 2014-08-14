using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Composite.Events;
using System.Threading;
using System.Diagnostics;

namespace CompositeWFModuleLib
{
    public class ModuleViewPresentationModel
    {
        IUnityContainer m_Container;
        int m_UIThreadId = Thread.CurrentThread.ManagedThreadId;
        public ModuleViewPresentationModel(IUnityContainer container)
        {
            m_Container = container;
        }

        public List<Product> Products
        {
            get
            {
                return new List<Product>
            {
                new Product{ProductId=1,Name="Cheese"},
                new Product{ProductId=2,Name="Wine"}
            };
            }
        }

        public void SaveSelection(Product product)
        {
            // do async to show the thread marshalling
            Action doIt = delegate()
            {
                Debug.Assert(Thread.CurrentThread.ManagedThreadId != m_UIThreadId);
                IEventAggregator evtAggregator = m_Container.Resolve<IEventAggregator>();
                evtAggregator.GetEvent<ProductSavedEvent>().Publish(product);
            };
            doIt.BeginInvoke(null, null);
        }
    }
}
