using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Kvn.HabrQnaNetSamples.Menu
{
    public partial class RecentForm : Form
    {
        public RecentForm()
        {
            InitializeComponent();

            var recentMenuItem = recentToolStripMenuItem;
            FillInMenu(recentMenuItem);
        }

        private void FillInMenu(ToolStripMenuItem recentMenuItem)
        {
            var names = new List<ToolStripMenuItem>()
            {
                new ToolStripMenuItem("test"),
                new ToolStripMenuItem("test1"),
                new ToolStripMenuItem("test2"),
            };
            recentMenuItem.DropDownItems.AddRange(names.ToArray());
        }
    }
}
