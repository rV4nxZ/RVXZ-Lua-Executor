using WeAreDevs_API;

namespace RVXZ
{
    public partial class RVXZ : Form
    {
        readonly ExploitAPI api = new ExploitAPI();
        public RVXZ()
        {
            InitializeComponent();
        }
        private void BtnAttach_Click(object sender, EventArgs e)
        {
            api.LaunchExploit();
        }

        private void BtnExecute_Click(object sender, EventArgs e)
        {
            string script = scriptInput.Text;
            api.SendLuaScript(script);
        }

        private void CheckAttach()
        {
            if (api.isAPIAttached())
            {
                txtIsAttached.Text = "Is attached: Yes";
            }
            else
            {
                txtIsAttached.Text = "Is Attached: No";
            }
        }

        //Check if the exploit is injected on load
        private void RVXZ_Load(object sender, EventArgs e)
        {
            CheckAttach();
        }

        //Check if the exploit is injected every 3 seconds
        private void timer1_Tick(object sender, EventArgs e)
        {
            CheckAttach();
        }
    }
}