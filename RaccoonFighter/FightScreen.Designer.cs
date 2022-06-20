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
            this.battleLabel = new System.Windows.Forms.Label();
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
            // battleLabel
            // 
            this.battleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.battleLabel.Location = new System.Drawing.Point(249, 50);
            this.battleLabel.Name = "battleLabel";
            this.battleLabel.Size = new System.Drawing.Size(272, 24);
            this.battleLabel.TabIndex = 7;
            // 
            // FightScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.battleLabel);
            this.Controls.Add(this.raccoonLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.rhpLabel);
            this.Controls.Add(this.phpLabel);
            this.Controls.Add(this.attackButton);
            this.Controls.Add(this.itemButton);
            this.Controls.Add(this.runButton);
            this.Name = "FightScreen";
            this.Size = new System.Drawing.Size(820, 449);
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
        private System.Windows.Forms.Label battleLabel;
    }
}
