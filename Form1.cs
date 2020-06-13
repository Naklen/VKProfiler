using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VKProfiler
{
    public partial class Form1 : Form
    {
        Profiler profiler = new Profiler();
        const string prompt = "Введите VkID";
        string currentStatus = "";

        public Form1()
        {
            InitializeComponent();
            textBox1.SelectionLength = 0;
            textBox1.SelectionStart = 0;
            textBox1.Text = prompt;
            textBox1.ForeColor = SystemColors.WindowFrame;
            tableLayoutPanel1.Hide();
            toolTip1.SetToolTip(statusLabel, "1234");
            MinimumSize = new Size(740, 520);
        }

        private void autorisationButton_Click(object sender, EventArgs e)
        {
            if (profiler.Authorised)
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
            var f = new Form2(profiler.GetAuthoriseURL());
            f.Show();
            await Task.Run(() => profiler.Authorise(f));
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
                if (!profiler.Authorised) 
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
            if (profileData.Status.Length > 44)
                statusLabel.Text = profileData.Status.Substring(0, 40) + "...\"";
            else
                statusLabel.Text = profileData.Status;
            currentStatus = profileData.Status.Substring(9, profileData.Status.Length - 10);
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
            isFriendLabel.Text = profileData.IsFriend ? "Этот профиль является вашим другом" : "";
            tableLayoutPanel1.Show();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            textBox1.Size = new Size(Size.Width - 256 - textBox1.Location.X, textBox1.Size.Height);
            if (avatarPictureBox.Location.X + 385d > (Size.Width / 2))
                avatarPictureBox.Location = new Point((Size.Width / 2) - 385, avatarPictureBox.Location.Y);
            if (avatarPictureBox.Location.X < textBox1.Location.X)
                avatarPictureBox.Location = new Point(textBox1.Location.X, avatarPictureBox.Location.Y);
            statusLabel.Location = new Point(avatarPictureBox.Location.X + 229, statusLabel.Location.Y);
            sexLabel.Location = new Point(avatarPictureBox.Location.X + 228, sexLabel.Location.Y);
            cityLabel.Location = new Point(avatarPictureBox.Location.X + 226, cityLabel.Location.Y);
            birthdayLabel.Location = new Point(avatarPictureBox.Location.X + 226, birthdayLabel.Location.Y);
            tableLayoutPanel1.Location = new Point(avatarPictureBox.Location.X + 229, tableLayoutPanel1.Location.Y);
            deactivatedOrClosedLabel.Location = new Point(avatarPictureBox.Location.X + 3, deactivatedOrClosedLabel.Location.Y);
            nameLabel.Location = new Point(avatarPictureBox.Location.X + 224, nameLabel.Location.Y);
            isFriendLabel.Location = new Point(avatarPictureBox.Location.X + 3, isFriendLabel.Location.Y);
        }

        private void clearIEDataButton_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Вы уверены?", "Внимание!", MessageBoxButtons.YesNo,
                   MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Yes)
            {
                Process pr = Process.Start(new ProcessStartInfo()
                {
                    FileName = "cmd.exe",
                    Arguments = $"/c RunDll32.exe InetCpl.cpl,ClearMyTracksByProcess 255",
                    UseShellExecute = false,
                    CreateNoWindow = true                    
                });
            }
        }

        private void helpClearCacheButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Эта кнопка удалит все данные браузера Internet Explorer, который использовался для авторизации Вконтакте");
        }

        private void statusLabel_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(statusLabel, currentStatus);
        }
    }
}
