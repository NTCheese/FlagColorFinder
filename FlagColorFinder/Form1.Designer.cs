namespace FlagColorFinder
{
    partial class welcomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(welcomeScreen));
            startButton = new System.Windows.Forms.Button();
            alphabetical = new System.Windows.Forms.Button();
            colorNameLabel = new System.Windows.Forms.Label();
            reverseAlphabetical = new System.Windows.Forms.Button();
            bigSmall = new System.Windows.Forms.Button();
            smallBig = new System.Windows.Forms.Button();
            colorValueLabel = new System.Windows.Forms.Label();
            colorOrder = new System.Windows.Forms.Button();
            reverseColorOrder = new System.Windows.Forms.Button();
            comboBox = new System.Windows.Forms.ComboBox();
            smallestNumInput = new System.Windows.Forms.TextBox();
            smallLabel = new System.Windows.Forms.Label();
            vScrollBar1 = new System.Windows.Forms.VScrollBar();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.Font = new System.Drawing.Font("Comic Sans MS", 20F);
            startButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            startButton.Image = Properties.Resources.Red_button;
            startButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            startButton.Location = new System.Drawing.Point(324, 11);
            startButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            startButton.Name = "startButton";
            startButton.Size = new System.Drawing.Size(236, 189);
            startButton.TabIndex = 0;
            startButton.Text = "Click me to begin! ";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += button1_Click;
            // 
            // alphabetical
            // 
            alphabetical.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            alphabetical.ForeColor = System.Drawing.Color.Black;
            alphabetical.Location = new System.Drawing.Point(51, 41);
            alphabetical.Name = "alphabetical";
            alphabetical.Size = new System.Drawing.Size(189, 32);
            alphabetical.TabIndex = 1;
            alphabetical.Text = "Alphabetical";
            alphabetical.UseVisualStyleBackColor = true;
            alphabetical.Visible = false;
            alphabetical.Click += alphabetical_Click;
            // 
            // colorNameLabel
            // 
            colorNameLabel.AutoSize = true;
            colorNameLabel.ForeColor = System.Drawing.Color.Black;
            colorNameLabel.Location = new System.Drawing.Point(274, 25);
            colorNameLabel.Name = "colorNameLabel";
            colorNameLabel.Size = new System.Drawing.Size(0, 13);
            colorNameLabel.TabIndex = 2;
            colorNameLabel.Visible = false;
            colorNameLabel.Click += label1_Click;
            // 
            // reverseAlphabetical
            // 
            reverseAlphabetical.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            reverseAlphabetical.ForeColor = System.Drawing.Color.Black;
            reverseAlphabetical.Location = new System.Drawing.Point(461, 41);
            reverseAlphabetical.Name = "reverseAlphabetical";
            reverseAlphabetical.Size = new System.Drawing.Size(189, 32);
            reverseAlphabetical.TabIndex = 3;
            reverseAlphabetical.Text = "Reverse Alphabetical";
            reverseAlphabetical.UseVisualStyleBackColor = true;
            reverseAlphabetical.Visible = false;
            reverseAlphabetical.Click += reverseAlphabetical_Click;
            // 
            // bigSmall
            // 
            bigSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            bigSmall.ForeColor = System.Drawing.Color.Black;
            bigSmall.Location = new System.Drawing.Point(461, 124);
            bigSmall.Name = "bigSmall";
            bigSmall.Size = new System.Drawing.Size(189, 32);
            bigSmall.TabIndex = 5;
            bigSmall.Text = "Number of colors ( big > small )";
            bigSmall.UseVisualStyleBackColor = true;
            bigSmall.Visible = false;
            bigSmall.Click += bigSmall_Click;
            // 
            // smallBig
            // 
            smallBig.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            smallBig.ForeColor = System.Drawing.Color.Black;
            smallBig.Location = new System.Drawing.Point(51, 124);
            smallBig.Name = "smallBig";
            smallBig.Size = new System.Drawing.Size(189, 32);
            smallBig.TabIndex = 4;
            smallBig.Text = "Number of colors ( small > big )";
            smallBig.UseVisualStyleBackColor = true;
            smallBig.Visible = false;
            smallBig.Click += smallBig_Click;
            // 
            // colorValueLabel
            // 
            colorValueLabel.AutoSize = true;
            colorValueLabel.ForeColor = System.Drawing.Color.Black;
            colorValueLabel.Location = new System.Drawing.Point(395, 25);
            colorValueLabel.Name = "colorValueLabel";
            colorValueLabel.Size = new System.Drawing.Size(0, 13);
            colorValueLabel.TabIndex = 6;
            colorValueLabel.Visible = false;
            colorValueLabel.Click += label1_Click_1;
            // 
            // colorOrder
            // 
            colorOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            colorOrder.ForeColor = System.Drawing.Color.Black;
            colorOrder.Location = new System.Drawing.Point(51, 82);
            colorOrder.Name = "colorOrder";
            colorOrder.Size = new System.Drawing.Size(189, 32);
            colorOrder.TabIndex = 7;
            colorOrder.Text = "Color Order";
            colorOrder.UseVisualStyleBackColor = true;
            colorOrder.Visible = false;
            colorOrder.Click += colorOrder_Click;
            // 
            // reverseColorOrder
            // 
            reverseColorOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            reverseColorOrder.ForeColor = System.Drawing.Color.Black;
            reverseColorOrder.Location = new System.Drawing.Point(461, 82);
            reverseColorOrder.Name = "reverseColorOrder";
            reverseColorOrder.Size = new System.Drawing.Size(189, 32);
            reverseColorOrder.TabIndex = 8;
            reverseColorOrder.Text = "Reverse Color Order";
            reverseColorOrder.UseVisualStyleBackColor = true;
            reverseColorOrder.Visible = false;
            reverseColorOrder.Click += reverseColor_Click;
            // 
            // comboBox
            // 
            comboBox.FormattingEnabled = true;
            comboBox.Items.AddRange(new object[] { "One Color", "Two Colors" });
            comboBox.Location = new System.Drawing.Point(728, 48);
            comboBox.Name = "comboBox";
            comboBox.Size = new System.Drawing.Size(83, 21);
            comboBox.TabIndex = 10;
            comboBox.Text = "One Color";
            comboBox.Visible = false;
            comboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // smallestNumInput
            // 
            smallestNumInput.Location = new System.Drawing.Point(728, 140);
            smallestNumInput.Name = "smallestNumInput";
            smallestNumInput.Size = new System.Drawing.Size(85, 20);
            smallestNumInput.TabIndex = 11;
            smallestNumInput.Visible = false;
            smallestNumInput.TextChanged += textBox1_TextChanged;
            // 
            // smallLabel
            // 
            smallLabel.AutoSize = true;
            smallLabel.ForeColor = System.Drawing.Color.Black;
            smallLabel.Location = new System.Drawing.Point(708, 124);
            smallLabel.Name = "smallLabel";
            smallLabel.Size = new System.Drawing.Size(122, 13);
            smallLabel.TabIndex = 12;
            smallLabel.Text = "Smallest Number Shown";
            smallLabel.Visible = false;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new System.Drawing.Point(431, 41);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new System.Drawing.Size(17, 120);
            vScrollBar1.TabIndex = 13;
            vScrollBar1.Visible = false;
            vScrollBar1.Scroll += vScrollBar1_Scroll;
            // 
            // welcomeScreen
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(850, 245);
            Controls.Add(vScrollBar1);
            Controls.Add(smallLabel);
            Controls.Add(smallestNumInput);
            Controls.Add(comboBox);
            Controls.Add(reverseColorOrder);
            Controls.Add(colorOrder);
            Controls.Add(colorValueLabel);
            Controls.Add(bigSmall);
            Controls.Add(smallBig);
            Controls.Add(reverseAlphabetical);
            Controls.Add(colorNameLabel);
            Controls.Add(alphabetical);
            Controls.Add(startButton);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            ForeColor = System.Drawing.Color.White;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            Name = "welcomeScreen";
            Text = "FlagColorSorter";
            Load += welcomeScreen_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button alphabetical;
        private System.Windows.Forms.Label colorNameLabel;
        private System.Windows.Forms.Button reverseAlphabetical;
        private System.Windows.Forms.Button bigSmall;
        private System.Windows.Forms.Button smallBig;
        private System.Windows.Forms.Label colorValueLabel;
        private System.Windows.Forms.Button colorOrder;
        private System.Windows.Forms.Button reverseColorOrder;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.TextBox smallestNumInput;
        private System.Windows.Forms.Label smallLabel;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}

