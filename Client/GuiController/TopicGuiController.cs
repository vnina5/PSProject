using Client.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.GuiController
{
    public class TopicGuiController
    {
        public TopicGuiController() { }

        public Control CreateUCTopic()
        {
            return new UCTopicView();
        }
    }
}
