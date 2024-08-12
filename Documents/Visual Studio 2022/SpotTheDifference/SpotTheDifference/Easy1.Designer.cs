namespace SpotTheDifference
{
    partial class Easy1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Easy1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxScore = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            button1 = new Button();
            flowLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(257, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(99, 54);
            label1.TabIndex = 9;
            label1.Text = "Easy";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 98);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 10;
            label2.Text = "label2";
            label2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(223, 98);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(92, 38);
            label3.TabIndex = 11;
            label3.Text = "Score:";
            // 
            // textBoxScore
            // 
            textBoxScore.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxScore.Location = new Point(327, 98);
            textBoxScore.Margin = new Padding(4, 5, 4, 5);
            textBoxScore.Name = "textBoxScore";
            textBoxScore.Size = new Size(47, 39);
            textBoxScore.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.BackgroundImage = (Image)resources.GetObject("flowLayoutPanel1.BackgroundImage");
            flowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            flowLayoutPanel1.Location = new Point(327, 175);
            flowLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(197, 230);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.Transparent;
            flowLayoutPanel2.BackgroundImage = (Image)resources.GetObject("flowLayoutPanel2.BackgroundImage");
            flowLayoutPanel2.BackgroundImageLayout = ImageLayout.Stretch;
            flowLayoutPanel2.Location = new Point(327, 435);
            flowLayoutPanel2.Margin = new Padding(4, 5, 4, 5);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(197, 230);
            flowLayoutPanel2.TabIndex = 7;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BackColor = Color.Transparent;
            flowLayoutPanel3.BackgroundImage = (Image)resources.GetObject("flowLayoutPanel3.BackgroundImage");
            flowLayoutPanel3.BackgroundImageLayout = ImageLayout.Stretch;
            flowLayoutPanel3.Location = new Point(91, 435);
            flowLayoutPanel3.Margin = new Padding(4, 5, 4, 5);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(197, 230);
            flowLayoutPanel3.TabIndex = 8;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.BackColor = Color.Transparent;
            flowLayoutPanel4.BackgroundImage = (Image)resources.GetObject("flowLayoutPanel4.BackgroundImage");
            flowLayoutPanel4.BackgroundImageLayout = ImageLayout.Stretch;
            flowLayoutPanel4.Controls.Add(button1);
            flowLayoutPanel4.Location = new Point(91, 175);
            flowLayoutPanel4.Margin = new Padding(4, 5, 4, 5);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(197, 230);
            flowLayoutPanel4.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(4, 5);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(197, 230);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            // 
            // Easy1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(624, 708);
            Controls.Add(flowLayoutPanel4);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(textBoxScore);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Easy1";
            Text = "Easy1";
            flowLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxScore;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel4;
        private Button button1;
    }
}