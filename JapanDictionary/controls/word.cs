using NotificationManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JapanDictionary
{
    public partial class word : UserControl
    {
        public Guna.UI.WinForms.GunaLabel front_japan { get => japan; set => japan = value; }
        public Guna.UI.WinForms.GunaLabel front_alternative { get => alternative; set => alternative = value; }
        public Guna.UI.WinForms.GunaLabel front_content { get => content; set => content = value; }

        public word()
        {
            InitializeComponent();
        }

        Manager notify1 = new Manager();

        private void japan_DoubleClick(object sender, EventArgs e)
        {
            notify1.TimerInterval = 3;
            notify1.Alert("Скопировано!", NotificationType.Success);
            Clipboard.SetText(japan.Text);
        }

        private void alternative_DoubleClick(object sender, EventArgs e)
        {
            notify1.TimerInterval = 3;
            notify1.Alert("Скопировано!", NotificationType.Success);
            Clipboard.SetText(alternative.Text);
        }

        private void content_DoubleClick(object sender, EventArgs e)
        {
            notify1.TimerInterval = 3;
            notify1.Alert("Скопировано!", NotificationType.Success);
            Clipboard.SetText(content.Text);
        }
    }
}
