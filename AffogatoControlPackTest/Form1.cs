using AffogatoControlPack;
using AffogatoThemes.Themes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AffogatoControlPackTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            listViewEx1.HeaderStyle = ColumnHeaderStyle.Clickable;

            var codes = new List<CommonCode>
            {
                new CommonCode
                {
                    Code = "TST",
                    CodeName = "Test"
                },
                new CommonCode
                {
                    Code = "ACT",
                    CodeName = "Active"
                }
            };

            new BlackPink(this);

            statusStrip1.Renderer = new ToolStripProfessionalRenderer(new AffogatoThemes.Models.AffogatoColorTable());
            toolStrip1.Renderer = new ToolStripProfessionalRenderer(new AffogatoThemes.Models.AffogatoColorTable());
            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new AffogatoThemes.Models.AffogatoColorTable());

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = codes;

            
            
        }

        public class CommonCode
        {
            public string Code { get; set; }
            public string CodeName { get; set; }
        }
    }
}
