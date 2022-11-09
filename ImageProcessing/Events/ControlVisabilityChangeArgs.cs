using System;
using System.Windows.Forms;

namespace ImageProcessing.Events
{
    public class ControlVisabilityChangeArgs : EventArgs
    {
        public ControlVisabilityChangeArgs(UserControl control)
        {
            Control = control;
        }

        public UserControl Control { get; }
    }
}
