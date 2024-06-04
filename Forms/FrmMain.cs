using Nesne_2_OGRENCI_TAKIP_1.Forms;

namespace Nesne_2_OGRENCI_TAKIP_1
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
        void OpenForm(Form f)
        {
            panel9.Controls.Clear();
            f.TopLevel = false;
            panel9.Controls.Add(f);
            f.Show();

        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmStudent());
        }

        private void btnLesson_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmLesson());
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmRegister());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
