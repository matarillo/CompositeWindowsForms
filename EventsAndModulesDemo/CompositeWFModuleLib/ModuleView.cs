using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CompositeWFModuleLib
{
    public partial class ModuleView : UserControl
    {
        ModuleViewPresentationModel m_PresentationModel;
        public ModuleView(ModuleViewPresentationModel presModel)
        {
            m_PresentationModel= presModel;
            InitializeComponent();
            m_ProductsBindingSource.DataSource = m_PresentationModel;
        }

        private void OnSaveSelection(object sender, EventArgs e)
        {
            m_PresentationModel.SaveSelection(m_ProductsBindingSource.Current as Product);
        }
    }
}
