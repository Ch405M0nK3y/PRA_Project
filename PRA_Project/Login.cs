using PRA_Project.Dal;
using PRA_Project.Model;
using System.Runtime.CompilerServices;

namespace PRA_Project
{

    public partial class Login : Form
    {

        UserRepository userRepository;
        private IDictionary<int, User> userDictionary;
        User loggedInUser;

        string username;
        string password;

        public Login()
        {
            InitializeComponent();
            Init();
        }
        public IDictionary<int, User> UserDictionary
        {
            get
            {
                if (userDictionary == null)
                {
                    LoadUsers();

                }
                return new Dictionary<int, User>(userDictionary);
            }
        }

        private void LoadUsers()
        {
            userDictionary = new Dictionary<int, User>();
            userDictionary = userRepository.Load();
        }

        private void Login_Load(object sender, EventArgs e)
        {



        }

        private void Init()
        {
            
            userRepository = RepositoryFactory.GetUserRepository();
            lblError.Visible = false;
            LoadUsers();
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                GetCredentials();
                CheckCredentials();
            }
            catch (Exception ex)
            {
                lblError.Visible = true;
            }


            if (loggedInUser != null)
            {

                if (loggedInUser.Admin == true)
                {
                    Thread newThread = new Thread(CreateNewAdminForm);
                    newThread.Start();
                    this.Close();
                }
                else
                {
                    Thread newThread = new Thread(CreateNewLecturerForm);
                    newThread.Start();
                    this.Close();
                }
            }
        }


        private void CreateNewAdminForm()
        {
            Form newForm = new AdminMenu(loggedInUser);

            Application.Run(newForm);
        }
        private void CreateNewLecturerForm()

        {
            //TODO dodaj konstruktor s logged in userom
            Form newForm = new LecturerMenu(); //dodaj parametar koji ti fali ovdje);

            Application.Run(newForm);

        }

        private bool CheckCredentials()
        {
            bool success;

            User user = userDictionary.Values.ToList().Find(u => u.Email.Equals(username));

            if (user != null && user.Password.Equals(password))
            {
                lblError.Visible = false;
                success = true;
                loggedInUser = user;
            }
            else
            {
                lblError.Visible = true;
                success = false;
            }

            return success;
        }

        private void GetCredentials()
        {
            username = tbUsername.Text;
            password = tbPassword.Text;
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}