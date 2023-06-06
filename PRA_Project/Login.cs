using PRA_Project.Model;

namespace PRA_Project
{

    public partial class Login : Form
    {
        IDictionary<int, object> userDictionary;
        IDictionary<int, object> subjectDictionary;
        IDictionary<int, object> notificationDictionary;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Init();


        }

        private void Init()
        {
            Administrator admin = new Administrator().CreateDefaultAdmin();
            userDictionary = admin.UserDictionary;
            subjectDictionary = admin.SubjectDictionary;
            notificationDictionary = admin.NotificationDictionary;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load_1(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}