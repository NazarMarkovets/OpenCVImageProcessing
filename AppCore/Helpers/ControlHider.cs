using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCore.Helpers
{
    public sealed class ControlHider
    {
        private List<UserControl> _controls;
        private string _currentControlName;
        public void InitializeHiderControls(params UserControl[] controls)
        {
            if (controls != null) _controls = new List<UserControl>(controls);
            foreach (var ctr in _controls)
            {
                ctr.VisibleChanged  += ControlVisabilityChanged;
            }
        }

        public void ChangeControlVisability(UserControl control, bool showControl)
        {
            if(control != null)
            {
                var foundControl = _controls.Find(ctr => ctr.Name == control.Name);
                _currentControlName = foundControl.Name;
                foundControl.Visible = showControl;
            }
        }

        private void ControlVisabilityChanged(object sender, EventArgs e)
        {
            if(sender != null && sender is UserControl @control && control.Name == _currentControlName)
            {
                var controlsToHide = _controls.Except(new UserControl[] { control });
                foreach (var ctr in controlsToHide)
                {
                    ctr.Visible = false;
                }
            }
        }
    }
}
