namespace SpotTheDifference
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            buttonimgEasy = new FlowLayoutPanel();
            buttonimgMed = new FlowLayoutPanel();
            buttonimgHard = new FlowLayoutPanel();
            buttonimgVeryHard = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(177, 43);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(448, 73);
            label1.TabIndex = 6;
            label1.Text = "Spot The Difference";
            label1.UseCompatibleTextRendering = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(633, 20);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(56, 20);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(99, 115);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // buttonimgEasy
            // 
            buttonimgEasy.BackColor = Color.Transparent;
            buttonimgEasy.BackgroundImage = (Image)resources.GetObject("buttonimgEasy.BackgroundImage");
            buttonimgEasy.BackgroundImageLayout = ImageLayout.Stretch;
            buttonimgEasy.Location = new Point(66, 320);
            buttonimgEasy.Name = "buttonimgEasy";
            buttonimgEasy.Size = new Size(257, 141);
            buttonimgEasy.TabIndex = 8;
            buttonimgEasy.Click += buttonimgEasy_Click;
            // 
            // buttonimgMed
            // 
            buttonimgMed.BackColor = Color.Transparent;
            buttonimgMed.BackgroundImage = (Image)resources.GetObject("buttonimgMed.BackgroundImage");
            buttonimgMed.BackgroundImageLayout = ImageLayout.Stretch;
            buttonimgMed.Location = new Point(475, 320);
            buttonimgMed.Name = "buttonimgMed";
            buttonimgMed.Size = new Size(257, 141);
            buttonimgMed.TabIndex = 9;
            buttonimgMed.Click += buttonimgMed_Click;
            // 
            // buttonimgHard
            // 
            buttonimgHard.BackColor = Color.Transparent;
            buttonimgHard.BackgroundImage = (Image)resources.GetObject("buttonimgHard.BackgroundImage");
            buttonimgHard.BackgroundImageLayout = ImageLayout.Stretch;
            buttonimgHard.Location = new Point(66, 525);
            buttonimgHard.Name = "buttonimgHard";
            buttonimgHard.Size = new Size(257, 141);
            buttonimgHard.TabIndex = 10;
            buttonimgHard.Click += buttonimgHard_Click;
            // 
            // buttonimgVeryHard
            // 
            buttonimgVeryHard.BackColor = Color.Transparent;
            buttonimgVeryHard.BackgroundImage = (Image)resources.GetObject("buttonimgVeryHard.BackgroundImage");
            buttonimgVeryHard.BackgroundImageLayout = ImageLayout.Stretch;
            buttonimgVeryHard.Location = new Point(475, 525);
            buttonimgVeryHard.Name = "buttonimgVeryHard";
            buttonimgVeryHard.Size = new Size(257, 141);
            buttonimgVeryHard.TabIndex = 11;
            buttonimgVeryHard.Click += buttonimgVeryHard_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(780, 792);
            Controls.Add(buttonimgVeryHard);
            Controls.Add(buttonimgHard);
            Controls.Add(buttonimgMed);
            Controls.Add(buttonimgEasy);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "MainMenu";
            Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private FlowLayoutPanel buttonimgEasy;
        private FlowLayoutPanel buttonimgMed;
        private FlowLayoutPanel buttonimgHard;
        private FlowLayoutPanel buttonimgVeryHard;
    }
}