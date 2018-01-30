using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Entity;
using Service;
using Service.Classes.SAL.BAS;
using Service.Interface.SAL.BAS;

namespace Store.SAL.BAS
{
    public partial class FrmProductGroup : Form
    {
        public FrmProductGroup()
        {
            InitializeComponent();
        }

        private void BuildTreeview(TreeNode node, ProductGroup productGroup)
        {
            foreach (var item in productGroup.Child)
            {
                TreeNode childnode = new TreeNode { Text = item.Name };
                node.Nodes.Add(childnode);
                BuildTreeview(childnode, item);
            }
        }

        private void FrmProductGroup_Load(object sender , EventArgs e)
        {
            var prod = new PruductGroups().ListProductGroups();
            foreach(var source in prod)
            {
                TreeNode node = new TreeNode { Text = source.Name };
                treProductGroups.Nodes.Add(node);
                BuildTreeview(node , source);
            }
            treProductGroups.ExpandAll();   
        }
    }
}
