using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrivialBehind;

namespace ScfProjectDesign
{
    public partial class ScfProjectForm: Form
    {
        public ScfProjectForm()
        {
            InitializeComponent();
            // boilerplate starts
            var disposer = TrivialBehinds.CreateBehind(this, new ScfProjectUi
            {
                button1 = button1,
                label1 = label1
            });
            this.FormClosed += (o,e) => 
                disposer.Dispose();
            // boilerplate ends

        }
    }
}
