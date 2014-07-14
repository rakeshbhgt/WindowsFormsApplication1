using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form2 f2 = new Form2();
            f2.Show(dockPanel1, DockState.DockLeft);
            Form3 f3=new Form3();
            f3.Show(dockPanel1,DockState.DockLeft);
            Form4 f4 = new Form4();
            f4.Show(dockPanel1, DockState.DockRight);
        }

        private void panel1_Paint(object sender, PaintEventArgs e) 
        {

        }
    }
}
