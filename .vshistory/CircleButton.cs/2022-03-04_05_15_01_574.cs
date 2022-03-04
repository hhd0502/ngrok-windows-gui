using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngrok_Desktop
{
    public partial class CircleButton : Component
    {
        public CircleButton()
        {
            InitializeComponent();
        }

        public CircleButton(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
