namespace RaccoonFighter
{
    partial class FightScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FightScreen));
            this.runButton = new System.Windows.Forms.Button();
            this.itemButton = new System.Windows.Forms.Button();
            this.attackButton = new System.Windows.Forms.Button();
            this.phpLabel = new System.Windows.Forms.Label();
            this.rhpLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.raccoonLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.daveLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.playerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // runButton
            // 
            this.runButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.runButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.runButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.runButton.Location = new System.Drawing.Point(20, 402);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(118, 44);
            this.runButton.TabIndex = 0;
            this.runButton.Text = "RUN";
            this.runButton.UseVisualStyleBackColor = false;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // itemButton
            // 
            this.itemButton.BackColor = System.Drawing.Color.Chartreuse;
            this.itemButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.itemButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.itemButton.Location = new System.Drawing.Point(20, 352);
            this.itemButton.Name = "itemButton";
            this.itemButton.Size = new System.Drawing.Size(118, 44);
            this.itemButton.TabIndex = 1;
            this.itemButton.Text = "ITEMS";
            this.itemButton.UseVisualStyleBackColor = false;
            this.itemButton.Click += new System.EventHandler(this.itemButton_Click);
            // 
            // attackButton
            // 
            this.attackButton.BackColor = System.Drawing.Color.Red;
            this.attackButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.attackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attackButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.attackButton.Location = new System.Drawing.Point(144, 352);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(118, 94);
            this.attackButton.TabIndex = 2;
            this.attackButton.Text = "ATTACK";
            this.attackButton.UseVisualStyleBackColor = false;
            this.attackButton.Click += new System.EventHandler(this.attackButton_Click);
            // 
            // phpLabel
            // 
            this.phpLabel.AutoSize = true;
            this.phpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phpLabel.Location = new System.Drawing.Point(72, 50);
            this.phpLabel.Name = "phpLabel";
            this.phpLabel.Size = new System.Drawing.Size(70, 25);
            this.phpLabel.TabIndex = 3;
            this.phpLabel.Text = "label1";
            // 
            // rhpLabel
            // 
            this.rhpLabel.AutoSize = true;
            this.rhpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rhpLabel.Location = new System.Drawing.Point(625, 50);
            this.rhpLabel.Name = "rhpLabel";
            this.rhpLabel.Size = new System.Drawing.Size(70, 25);
            this.rhpLabel.TabIndex = 4;
            this.rhpLabel.Text = "label1";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(72, 324);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(73, 25);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Player";
            // 
            // raccoonLabel
            // 
            this.raccoonLabel.AutoSize = true;
            this.raccoonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raccoonLabel.Location = new System.Drawing.Point(570, 324);
            this.raccoonLabel.Name = "raccoonLabel";
            this.raccoonLabel.Size = new System.Drawing.Size(196, 25);
            this.raccoonLabel.TabIndex = 6;
            this.raccoonLabel.Text = "Dave The Raccoon";
            // 
            // timer1
            // 
            this.timer1.Interval = 60;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // daveLabel
            // 
            this.daveLabel.BackColor = System.Drawing.Color.Transparent;
            this.daveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daveLabel.Location = new System.Drawing.Point(460, 85);
            this.daveLabel.Name = "daveLabel";
            this.daveLabel.Size = new System.Drawing.Size(272, 24);
            this.daveLabel.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(499, 134);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(196, 160);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // playerLabel
            // 
            this.playerLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerLabel.Location = new System.Drawing.Point(15, 85);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(349, 46);
            this.playerLabel.TabIndex = 10;
            // 
            // FightScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.daveLabel);
            this.Controls.Add(this.raccoonLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.rhpLabel);
            this.Controls.Add(this.phpLabel);
            this.Controls.Add(this.attackButton);
            this.Controls.Add(this.itemButton);
            this.Controls.Add(this.runButton);
            this.Name = "FightScreen";
            this.Size = new System.Drawing.Size(820, 449);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button itemButton;
        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.Label phpLabel;
        private System.Windows.Forms.Label rhpLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label raccoonLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label daveLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label playerLabel;
    }
}
