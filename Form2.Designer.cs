namespace Kassaapparat_app
{
    partial class Form2
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
            startbutton1 = new Button();
            butikslistabox = new ListBox();
            varukorgslistabox = new ListBox();
            inköpbutton = new Button();
            totalcostlabel1 = new Label();
            tabortbutton1 = new Button();
            sparabutton2 = new Button();
            laddabutton3 = new Button();
            closeButton = new Button();
            budgetlabel1 = new Label();
            SuspendLayout();
            // 
            // startbutton1
            // 
            startbutton1.Font = new Font("Constantia", 16F, FontStyle.Regular, GraphicsUnit.Point);
            startbutton1.ForeColor = SystemColors.Highlight;
            startbutton1.Location = new Point(336, 21);
            startbutton1.Name = "startbutton1";
            startbutton1.Size = new Size(214, 42);
            startbutton1.TabIndex = 0;
            startbutton1.Text = "Start";
            startbutton1.UseVisualStyleBackColor = true;
            startbutton1.Click += startbutton1_Click;
            // 
            // butikslistabox
            // 
            butikslistabox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            butikslistabox.ForeColor = SystemColors.HotTrack;
            butikslistabox.FormattingEnabled = true;
            butikslistabox.ItemHeight = 32;
            butikslistabox.Location = new Point(113, 104);
            butikslistabox.Name = "butikslistabox";
            butikslistabox.Size = new Size(232, 260);
            butikslistabox.TabIndex = 1;
            // 
            // varukorgslistabox
            // 
            varukorgslistabox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            varukorgslistabox.ForeColor = SystemColors.HotTrack;
            varukorgslistabox.FormattingEnabled = true;
            varukorgslistabox.ItemHeight = 32;
            varukorgslistabox.Location = new Point(520, 104);
            varukorgslistabox.Name = "varukorgslistabox";
            varukorgslistabox.Size = new Size(227, 260);
            varukorgslistabox.TabIndex = 24;
            // 
            // inköpbutton
            // 
            inköpbutton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inköpbutton.Location = new Point(370, 322);
            inköpbutton.Name = "inköpbutton";
            inköpbutton.Size = new Size(124, 42);
            inköpbutton.TabIndex = 3;
            inköpbutton.Text = "Inköp";
            inköpbutton.UseVisualStyleBackColor = true;
            inköpbutton.Click += inköpbutton_Click;
            // 
            // totalcostlabel1
            // 
            totalcostlabel1.AutoSize = true;
            totalcostlabel1.Location = new Point(552, 398);
            totalcostlabel1.Name = "totalcostlabel1";
            totalcostlabel1.Size = new Size(99, 25);
            totalcostlabel1.TabIndex = 4;
            totalcostlabel1.Text = "Total Cost :";
            // 
            // tabortbutton1
            // 
            tabortbutton1.Location = new Point(182, 398);
            tabortbutton1.Name = "tabortbutton1";
            tabortbutton1.Size = new Size(112, 34);
            tabortbutton1.TabIndex = 25;
            tabortbutton1.Text = "Tabort";
            tabortbutton1.UseVisualStyleBackColor = true;
            tabortbutton1.Click += tabortbutton1_Click;
            // 
            // sparabutton2
            // 
            sparabutton2.Location = new Point(182, 463);
            sparabutton2.Name = "sparabutton2";
            sparabutton2.Size = new Size(112, 34);
            sparabutton2.TabIndex = 26;
            sparabutton2.Text = "Spara";
            sparabutton2.UseVisualStyleBackColor = true;
            sparabutton2.Click += sparabutton2_Click;
            // 
            // laddabutton3
            // 
            laddabutton3.Location = new Point(552, 453);
            laddabutton3.Name = "laddabutton3";
            laddabutton3.Size = new Size(112, 34);
            laddabutton3.TabIndex = 27;
            laddabutton3.Text = "ladda";
            laddabutton3.UseVisualStyleBackColor = true;
            laddabutton3.Click += laddabutton3_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(1028, 540);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(112, 34);
            closeButton.TabIndex = 28;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // budgetlabel1
            // 
            budgetlabel1.AutoSize = true;
            budgetlabel1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            budgetlabel1.Location = new Point(810, 104);
            budgetlabel1.Name = "budgetlabel1";
            budgetlabel1.Size = new Size(105, 38);
            budgetlabel1.TabIndex = 29;
            budgetlabel1.Text = "Budget";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1226, 606);
            Controls.Add(budgetlabel1);
            Controls.Add(closeButton);
            Controls.Add(laddabutton3);
            Controls.Add(sparabutton2);
            Controls.Add(tabortbutton1);
            Controls.Add(totalcostlabel1);
            Controls.Add(inköpbutton);
            Controls.Add(varukorgslistabox);
            Controls.Add(butikslistabox);
            Controls.Add(startbutton1);
            Location = new Point(80, 150);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startbutton1;
        private ListBox butikslistabox;
        private ListBox varukorgslistabox;
        private Button inköpbutton;
        private Label totalcostlabel1;
        private Button tabortbutton1;
        private Button sparabutton2;
        private Button laddabutton3;
        private Button closeButton;
        private Label budgetlabel1;
    }
}