namespace VKProfiler
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.autorisationButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.avatarPictureBox = new System.Windows.Forms.PictureBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.friendsCountLabel = new System.Windows.Forms.Label();
            this.followersCountLabel = new System.Windows.Forms.Label();
            this.photoCountLabel = new System.Windows.Forms.Label();
            this.videoCountLabel = new System.Windows.Forms.Label();
            this.audioCountLabel = new System.Windows.Forms.Label();
            this.profilerButton = new System.Windows.Forms.Button();
            this.sexLabel = new System.Windows.Forms.Label();
            this.selfProfilerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // autorisationButton
            // 
            this.autorisationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.autorisationButton.Location = new System.Drawing.Point(608, 12);
            this.autorisationButton.Name = "autorisationButton";
            this.autorisationButton.Size = new System.Drawing.Size(188, 25);
            this.autorisationButton.TabIndex = 1;
            this.autorisationButton.Text = "Авторизация";
            this.autorisationButton.UseVisualStyleBackColor = true;
            this.autorisationButton.Click += new System.EventHandler(this.autorisationButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(24, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(556, 24);
            this.textBox1.TabIndex = 2;
            this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // avatarPictureBox
            // 
            this.avatarPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.avatarPictureBox.Location = new System.Drawing.Point(33, 53);
            this.avatarPictureBox.Name = "avatarPictureBox";
            this.avatarPictureBox.Size = new System.Drawing.Size(200, 200);
            this.avatarPictureBox.TabIndex = 3;
            this.avatarPictureBox.TabStop = false;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(257, 53);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 25);
            this.nameLabel.TabIndex = 4;
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(261, 78);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 13);
            this.statusLabel.TabIndex = 5;
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthdayLabel.Location = new System.Drawing.Point(259, 130);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(0, 16);
            this.birthdayLabel.TabIndex = 6;
            // 
            // cityLabel
            // 
            this.cityLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cityLabel.Location = new System.Drawing.Point(259, 157);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(0, 16);
            this.cityLabel.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.friendsCountLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.followersCountLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.photoCountLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.videoCountLabel, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.audioCountLabel, 4, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(262, 194);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(418, 59);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Друзей";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(57, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Подписчиков";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(146, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Фотографий";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(235, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Видеозаписей";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Location = new System.Drawing.Point(331, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Аудиозаписей";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // friendsCountLabel
            // 
            this.friendsCountLabel.AutoSize = true;
            this.friendsCountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.friendsCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.friendsCountLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.friendsCountLabel.Location = new System.Drawing.Point(3, 29);
            this.friendsCountLabel.Name = "friendsCountLabel";
            this.friendsCountLabel.Size = new System.Drawing.Size(48, 30);
            this.friendsCountLabel.TabIndex = 5;
            this.friendsCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // followersCountLabel
            // 
            this.followersCountLabel.AutoSize = true;
            this.followersCountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.followersCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.followersCountLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.followersCountLabel.Location = new System.Drawing.Point(57, 29);
            this.followersCountLabel.Name = "followersCountLabel";
            this.followersCountLabel.Size = new System.Drawing.Size(83, 30);
            this.followersCountLabel.TabIndex = 6;
            this.followersCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // photoCountLabel
            // 
            this.photoCountLabel.AutoSize = true;
            this.photoCountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.photoCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.photoCountLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.photoCountLabel.Location = new System.Drawing.Point(146, 29);
            this.photoCountLabel.Name = "photoCountLabel";
            this.photoCountLabel.Size = new System.Drawing.Size(83, 30);
            this.photoCountLabel.TabIndex = 7;
            this.photoCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // videoCountLabel
            // 
            this.videoCountLabel.AutoSize = true;
            this.videoCountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.videoCountLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.videoCountLabel.Location = new System.Drawing.Point(235, 29);
            this.videoCountLabel.Name = "videoCountLabel";
            this.videoCountLabel.Size = new System.Drawing.Size(90, 30);
            this.videoCountLabel.TabIndex = 8;
            this.videoCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // audioCountLabel
            // 
            this.audioCountLabel.AutoSize = true;
            this.audioCountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.audioCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.audioCountLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.audioCountLabel.Location = new System.Drawing.Point(331, 29);
            this.audioCountLabel.Name = "audioCountLabel";
            this.audioCountLabel.Size = new System.Drawing.Size(87, 30);
            this.audioCountLabel.TabIndex = 9;
            this.audioCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profilerButton
            // 
            this.profilerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.profilerButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.profilerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profilerButton.Location = new System.Drawing.Point(608, 50);
            this.profilerButton.Name = "profilerButton";
            this.profilerButton.Size = new System.Drawing.Size(188, 37);
            this.profilerButton.TabIndex = 9;
            this.profilerButton.Text = "Показать профиль";
            this.profilerButton.UseVisualStyleBackColor = true;
            this.profilerButton.Click += new System.EventHandler(this.profilerButton_Click);
            // 
            // sexLabel
            // 
            this.sexLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sexLabel.AutoSize = true;
            this.sexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sexLabel.Location = new System.Drawing.Point(261, 103);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(0, 16);
            this.sexLabel.TabIndex = 10;
            // 
            // selfProfilerButton
            // 
            this.selfProfilerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selfProfilerButton.Location = new System.Drawing.Point(608, 94);
            this.selfProfilerButton.Name = "selfProfilerButton";
            this.selfProfilerButton.Size = new System.Drawing.Size(188, 30);
            this.selfProfilerButton.TabIndex = 11;
            this.selfProfilerButton.Text = "Показать свой профиль";
            this.selfProfilerButton.UseVisualStyleBackColor = true;
            this.selfProfilerButton.Click += new System.EventHandler(this.selfProfilerButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 485);
            this.Controls.Add(this.selfProfilerButton);
            this.Controls.Add(this.sexLabel);
            this.Controls.Add(this.profilerButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.birthdayLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.avatarPictureBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.autorisationButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "VKProfiler";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button autorisationButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox avatarPictureBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label friendsCountLabel;
        private System.Windows.Forms.Label followersCountLabel;
        private System.Windows.Forms.Label photoCountLabel;
        private System.Windows.Forms.Label videoCountLabel;
        private System.Windows.Forms.Label audioCountLabel;
        private System.Windows.Forms.Button profilerButton;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.Button selfProfilerButton;
    }
}

