using Client.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.GuiController
{
    public class ProjectGuiController
    {
        public ProjectGuiController() { }

        public Control CreateUCProject()
        {
            return new UCProjectView();
        }
    }
}
