using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Composite.Events;
using CompositeWFModuleLib;
using System.Threading;
using System.Diagnostics;
using IDesign.Composite.Events;

namespace CompositeWindowsFormsEventsAndModulesDemo
{
    public partial class Shell : Form
    {
        int m_UIThreadId = Thread.CurrentThread.ManagedThreadId;

        public Shell(IUnityContainer container,IEventAggregator evtAggregator)
        {
            InitializeComponent();
            container.RegisterInstance<Panel>("MainRegion",m_MainRegionPanel);
            evtAggregator.GetEvent<ProductSavedEvent>().Subscribe(OnProductSaved,ThreadOption.SubscriberAffinityThread);
        }

        void OnProductSaved(Product p)
        {
            Debug.Assert(Thread.CurrentThread.ManagedThreadId == m_UIThreadId);
            m_StatusLabel.Text = p.Name + " saved"; 
        }
    }
}
