using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauUI
{
    public class BaseButton : Button
    {
        public BaseButton()
        {
            Font = new Font("Arial", 14, FontStyle.Bold);
        }
    }
}
