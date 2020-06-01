using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VKProfiler
{
    public partial class Form1 : Form
    {
        Profiler profiler = new Profiler();
        const string prompt = "Введите VkID";

        public Form1()
        {
            InitializeComponent();
            textBox1.SelectionLength = 0;
            textBox1.SelectionStart = 0;
            textBox1.Text = prompt;
            textBox1.ForeColor = SystemColors.WindowFrame;
            tableLayoutPanel1.Hide();
        }

        private void autorisationButton_Click(object sender, EventArgs e)
        {
            if (profiler.Autorized)
            {
                var dialogResult = MessageBox.Show("Вы уже авторизованы\nХотите снова пройти авторизацию?", "Внимание!", MessageBoxButtons.YesNo,
                   MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                if (dialogResult == DialogResult.Yes)
                    StartAutorisation();
            }
            else StartAutorisation();
            
        }

        async void StartAutorisation() 
        {
            var f = new Form2(profiler.GetAutorizeURL());
            f.Show();
            await Task.Run(() => profiler.Autorize(f));
            autorisationButton.Text = "Вы вошли как " + profiler.UserName;
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == prompt)
                textBox1.Text = "";
            textBox1.ForeColor = SystemColors.WindowText;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.ForeColor = SystemColors.WindowFrame;
                textBox1.Text = prompt;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.ForeColor == SystemColors.WindowFrame && textBox1.Text != prompt && textBox1.Text != "")
            {
                textBox1.ForeColor = SystemColors.WindowText;
                textBox1.Text = textBox1.Text[0].ToString();
                textBox1.SelectionStart = 1;
                textBox1.SelectionLength = 0;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                profilerButton_Click(this, EventArgs.Empty);
                e.SuppressKeyPress = true;
            }
        }

        private async void profilerButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != prompt)
            {
                var profileData = await Task.Run(() => profiler.GetProfileData(textBox1.Text));
                ShowProfileData(profileData);
            }
        }

        private async void selfProfilerButton_Click(object sender, EventArgs e)
        {
            var profileData = await Task.Run(() => profiler.GetProfileData(profiler.UserID));
            ShowProfileData(profileData);
        }

        void ShowProfileData(ProfileData profileData)
        {
            if (profileData == null)
            {
                if (!profiler.Autorized) 
                {
                    MessageBox.Show("Вы не авторизованы\nПожалуйса, пройдите авторизацию", "Внимание!", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }
                MessageBox.Show("Введите корректный vkID", "Внимание!", MessageBoxButtons.OK,
                   MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }
            nameLabel.Text = profileData.Name;
            sexLabel.Text = profileData.Sex;
            statusLabel.Text = profileData.Status;
            cityLabel.Text = profileData.City;
            birthdayLabel.Text = profileData.Birthday;
            avatarPictureBox.Image = profileData.Avatar;
            friendsCountLabel.Text = profileData.Counters.FriendsCount;
            followersCountLabel.Text = profileData.Counters.FollowersCount;
            photoCountLabel.Text = profileData.Counters.PhotoCount;
            videoCountLabel.Text = profileData.Counters.VideoCount;
            audioCountLabel.Text = profileData.Counters.AudioCount;
            if (profileData.IsClosed || profileData.Deactiavated) 
            {
                if (profileData.IsClosed)
                    deactivatedOrClosedLabel.Text = "Это закрытый профиль";
                if (profileData.Deactiavated)
                    deactivatedOrClosedLabel.Text = "Этот профиль был заблокирован или удалён"; 
            }
            else
                deactivatedOrClosedLabel.Text = "";
            tableLayoutPanel1.Show();
        }
    }
}
