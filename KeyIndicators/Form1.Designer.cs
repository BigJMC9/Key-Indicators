namespace KeyIndicators
{
    partial class AppKeys
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppKeys));
            this.NumLockImage = new System.Windows.Forms.PictureBox();
            this.KeysLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.NumLockLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.NumLockLabel = new System.Windows.Forms.Label();
            this.CapsLockLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.CapsLockImage = new System.Windows.Forms.PictureBox();
            this.CapsLockLabel = new System.Windows.Forms.Label();
            this.ScrollLockLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.ScrollLockImage = new System.Windows.Forms.PictureBox();
            this.ScrollLockLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MinButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NumLockImage)).BeginInit();
            this.KeysLayout.SuspendLayout();
            this.NumLockLayout.SuspendLayout();
            this.CapsLockLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CapsLockImage)).BeginInit();
            this.ScrollLockLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScrollLockImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NumLockImage
            // 
            this.NumLockImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NumLockImage.Image = ((System.Drawing.Image)(resources.GetObject("NumLockImage.Image")));
            this.NumLockImage.Location = new System.Drawing.Point(8, 3);
            this.NumLockImage.MaximumSize = new System.Drawing.Size(50, 50);
            this.NumLockImage.Name = "NumLockImage";
            this.NumLockImage.Size = new System.Drawing.Size(50, 50);
            this.NumLockImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NumLockImage.TabIndex = 0;
            this.NumLockImage.TabStop = false;
            // 
            // KeysLayout
            // 
            this.KeysLayout.AutoSize = true;
            this.KeysLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.KeysLayout.Controls.Add(this.NumLockLayout);
            this.KeysLayout.Controls.Add(this.CapsLockLayout);
            this.KeysLayout.Controls.Add(this.ScrollLockLayout);
            this.KeysLayout.Location = new System.Drawing.Point(2, 30);
            this.KeysLayout.MinimumSize = new System.Drawing.Size(25, 25);
            this.KeysLayout.Name = "KeysLayout";
            this.KeysLayout.Padding = new System.Windows.Forms.Padding(5);
            this.KeysLayout.Size = new System.Drawing.Size(233, 85);
            this.KeysLayout.TabIndex = 1;
            // 
            // NumLockLayout
            // 
            this.NumLockLayout.AutoSize = true;
            this.NumLockLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NumLockLayout.Controls.Add(this.NumLockImage);
            this.NumLockLayout.Controls.Add(this.NumLockLabel);
            this.NumLockLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.NumLockLayout.Location = new System.Drawing.Point(8, 8);
            this.NumLockLayout.Name = "NumLockLayout";
            this.NumLockLayout.Size = new System.Drawing.Size(66, 69);
            this.NumLockLayout.TabIndex = 2;
            // 
            // NumLockLabel
            // 
            this.NumLockLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NumLockLabel.AutoSize = true;
            this.NumLockLabel.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.NumLockLabel.Location = new System.Drawing.Point(3, 56);
            this.NumLockLabel.Name = "NumLockLabel";
            this.NumLockLabel.Size = new System.Drawing.Size(60, 13);
            this.NumLockLabel.TabIndex = 1;
            this.NumLockLabel.Text = "Num Lock";
            this.NumLockLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // CapsLockLayout
            // 
            this.CapsLockLayout.AutoSize = true;
            this.CapsLockLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CapsLockLayout.Controls.Add(this.CapsLockImage);
            this.CapsLockLayout.Controls.Add(this.CapsLockLabel);
            this.CapsLockLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.CapsLockLayout.Location = new System.Drawing.Point(80, 8);
            this.CapsLockLayout.Name = "CapsLockLayout";
            this.CapsLockLayout.Size = new System.Drawing.Size(67, 69);
            this.CapsLockLayout.TabIndex = 2;
            // 
            // CapsLockImage
            // 
            this.CapsLockImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CapsLockImage.Image = ((System.Drawing.Image)(resources.GetObject("CapsLockImage.Image")));
            this.CapsLockImage.Location = new System.Drawing.Point(8, 3);
            this.CapsLockImage.MaximumSize = new System.Drawing.Size(50, 50);
            this.CapsLockImage.Name = "CapsLockImage";
            this.CapsLockImage.Size = new System.Drawing.Size(50, 50);
            this.CapsLockImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CapsLockImage.TabIndex = 0;
            this.CapsLockImage.TabStop = false;
            // 
            // CapsLockLabel
            // 
            this.CapsLockLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CapsLockLabel.AutoSize = true;
            this.CapsLockLabel.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.CapsLockLabel.Location = new System.Drawing.Point(3, 56);
            this.CapsLockLabel.Name = "CapsLockLabel";
            this.CapsLockLabel.Size = new System.Drawing.Size(61, 13);
            this.CapsLockLabel.TabIndex = 1;
            this.CapsLockLabel.Text = "Caps Lock";
            this.CapsLockLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ScrollLockLayout
            // 
            this.ScrollLockLayout.AutoSize = true;
            this.ScrollLockLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ScrollLockLayout.Controls.Add(this.ScrollLockImage);
            this.ScrollLockLayout.Controls.Add(this.ScrollLockLabel);
            this.ScrollLockLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ScrollLockLayout.Location = new System.Drawing.Point(153, 8);
            this.ScrollLockLayout.Name = "ScrollLockLayout";
            this.ScrollLockLayout.Size = new System.Drawing.Size(72, 69);
            this.ScrollLockLayout.TabIndex = 2;
            // 
            // ScrollLockImage
            // 
            this.ScrollLockImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ScrollLockImage.Image = ((System.Drawing.Image)(resources.GetObject("ScrollLockImage.Image")));
            this.ScrollLockImage.Location = new System.Drawing.Point(11, 3);
            this.ScrollLockImage.MaximumSize = new System.Drawing.Size(50, 50);
            this.ScrollLockImage.Name = "ScrollLockImage";
            this.ScrollLockImage.Size = new System.Drawing.Size(50, 50);
            this.ScrollLockImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ScrollLockImage.TabIndex = 0;
            this.ScrollLockImage.TabStop = false;
            // 
            // ScrollLockLabel
            // 
            this.ScrollLockLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ScrollLockLabel.AutoSize = true;
            this.ScrollLockLabel.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.ScrollLockLabel.Location = new System.Drawing.Point(3, 56);
            this.ScrollLockLabel.Name = "ScrollLockLabel";
            this.ScrollLockLabel.Size = new System.Drawing.Size(66, 13);
            this.ScrollLockLabel.TabIndex = 1;
            this.ScrollLockLabel.Text = "Scroll Lock";
            this.ScrollLockLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.MinButton);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 24);
            this.panel1.TabIndex = 2;
            // 
            // MinButton
            // 
            this.MinButton.BackgroundImage = global::KeyIndicators.Properties.Resources.Minimise_Off;
            this.MinButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.MinButton.FlatAppearance.BorderSize = 0;
            this.MinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinButton.Location = new System.Drawing.Point(171, 0);
            this.MinButton.Name = "MinButton";
            this.MinButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.MinButton.Size = new System.Drawing.Size(30, 23);
            this.MinButton.TabIndex = 0;
            this.MinButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MinButton.UseVisualStyleBackColor = true;
            this.MinButton.Click += new System.EventHandler(this.MinButton_Click);
            this.MinButton.MouseEnter += new System.EventHandler(this.MinButton_MouseEnter);
            this.MinButton.MouseLeave += new System.EventHandler(this.MinButton_MouseLeave);
            // 
            // CloseButton
            // 
            this.CloseButton.BackgroundImage = global::KeyIndicators.Properties.Resources.Exit_Off;
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Location = new System.Drawing.Point(207, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.CloseButton.Size = new System.Drawing.Size(30, 23);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Keyboard Indicators";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // AppKeys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(237, 119);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.KeysLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "AppKeys";
            this.Text = "Keys";
            this.Activated += new System.EventHandler(this.AppKeys_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.NumLockImage)).EndInit();
            this.KeysLayout.ResumeLayout(false);
            this.KeysLayout.PerformLayout();
            this.NumLockLayout.ResumeLayout(false);
            this.NumLockLayout.PerformLayout();
            this.CapsLockLayout.ResumeLayout(false);
            this.CapsLockLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CapsLockImage)).EndInit();
            this.ScrollLockLayout.ResumeLayout(false);
            this.ScrollLockLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScrollLockImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox NumLockImage;
        private System.Windows.Forms.FlowLayoutPanel KeysLayout;
        private System.Windows.Forms.FlowLayoutPanel NumLockLayout;
        private System.Windows.Forms.Label NumLockLabel;
        private System.Windows.Forms.FlowLayoutPanel CapsLockLayout;
        private System.Windows.Forms.PictureBox CapsLockImage;
        private System.Windows.Forms.Label CapsLockLabel;
        private System.Windows.Forms.FlowLayoutPanel ScrollLockLayout;
        private System.Windows.Forms.PictureBox ScrollLockImage;
        private System.Windows.Forms.Label ScrollLockLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button MinButton;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

