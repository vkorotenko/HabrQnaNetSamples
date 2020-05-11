#region License
// // Разработано: Коротенко Владимиром Николаевичем (Vladimir N. Korotenko)
// // email: koroten@ya.ru
// // skype:vladimir-korotenko
// // https://vkorotenko.ru
// // Создано:  09.05.2020 8:26
#endregion

using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using Kvn.HabrQnaNetSamples.Code;

namespace Kvn.HabrQnaNetSamples.Controls
{
    public partial class TreeViewBindingForm : Form
    {
        private readonly TreeSource _treeSource;
        private TreeLeaf _currentLeaf;
        private TreeNode _node;
        public TreeViewBindingForm()
        {
            InitializeComponent();
            foreach (Control control in Controls)
            {
                Debug.WriteLine(control.Name);
            }
            _treeSource = new TreeSource();
            _treeSource.LoadData();
            FillInTree(treeView.Nodes, _treeSource.Leaves);
        }

        private static void FillInTree(TreeNodeCollection  nodes, IEnumerable<TreeLeaf> leafs)
        {
            foreach (var leaf in leafs)
            {
                var treeNode = new TreeNode(leaf.Title) {Tag = leaf};
                nodes.Add(treeNode);
                if (leaf.Leaves.Count > 0) FillInTree(treeNode.Nodes, leaf.Leaves);
            }
        }

        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag is TreeLeaf item)
            {
                _node = e.Node;
                _currentLeaf = item;
                titleTextBox.Text = item.Title;
                descriptionTexBox.Text = item.Description;
            }
        }

        private void titleTextBox_TextChanged(object sender, System.EventArgs e)
        {
            if (_node != null)
            {
                _currentLeaf.Title = _node.Text = titleTextBox.Text;
            }
        }

        private void descriptionTexBox_TextChanged(object sender, System.EventArgs e)
        {
            if (_node != null)
            {
                _currentLeaf.Description = descriptionTexBox.Text;
            }
        }
    }
}
