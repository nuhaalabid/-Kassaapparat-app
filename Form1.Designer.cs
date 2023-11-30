namespace Kassaapparat_app
{
    partial class Form1
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
            Kassaapparatlabel1 = new Label();
            label1 = new Label();
            label2 = new Label();
            kassaButton1 = new Button();
            kassaButton2 = new Button();
            kassaNameBox = new TextBox();
            kassaPassaBox = new TextBox();
            resultlabel3 = new Label();
            SuspendLayout();
            // 
            // Kassaapparatlabel1
            // 
            Kassaapparatlabel1.AutoSize = true;
            Kassaapparatlabel1.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Kassaapparatlabel1.ForeColor = SystemColors.ActiveCaptionText;
            Kassaapparatlabel1.Location = new Point(114, 25);
            Kassaapparatlabel1.Name = "Kassaapparatlabel1";
            Kassaapparatlabel1.Size = new Size(419, 44);
            Kassaapparatlabel1.TabIndex = 0;
            Kassaapparatlabel1.Text = "Välkommen till online kassa";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(137, 132);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 1;
            label1.Text = "Namn:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(137, 204);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 2;
            label2.Text = "Lösen:";
            // 
            // kassaButton1
            // 
            kassaButton1.Location = new Point(304, 291);
            kassaButton1.Name = "kassaButton1";
            kassaButton1.Size = new Size(112, 34);
            kassaButton1.TabIndex = 3;
            kassaButton1.Text = "Registrera";
            kassaButton1.UseVisualStyleBackColor = true;
            kassaButton1.Click += kassaregisterbutton_Click;
            // 
            // kassaButton2
            // 
            kassaButton2.Location = new Point(137, 291);
            kassaButton2.Name = "kassaButton2";
            kassaButton2.Size = new Size(112, 34);
            kassaButton2.TabIndex = 4;
            kassaButton2.Text = "Logga in";
            kassaButton2.UseVisualStyleBackColor = true;
            kassaButton2.Click += kassaButton2_Click;
            // 
            // kassaNameBox
            // 
            kassaNameBox.Location = new Point(235, 126);
            kassaNameBox.Name = "kassaNameBox";
            kassaNameBox.Size = new Size(150, 31);
            kassaNameBox.TabIndex = 5;
            // 
            // kassaPassaBox
            // 
            kassaPassaBox.Location = new Point(235, 201);
            kassaPassaBox.Name = "kassaPassaBox";
            kassaPassaBox.Size = new Size(150, 31);
            kassaPassaBox.TabIndex = 6;
            // 
            // resultlabel3
            // 
            resultlabel3.AutoSize = true;
            resultlabel3.Location = new Point(249, 383);
            resultlabel3.Name = "resultlabel3";
            resultlabel3.Size = new Size(59, 25);
            resultlabel3.TabIndex = 7;
            resultlabel3.Text = "Result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 478);
            Controls.Add(resultlabel3);
            Controls.Add(kassaPassaBox);
            Controls.Add(kassaNameBox);
            Controls.Add(kassaButton2);
            Controls.Add(kassaButton1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Kassaapparatlabel1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Kassaapparatlabel1;
        private Label label1;
        private Label label2;
        private Button kassaButton1;
        private Button kassaButton2;
        private TextBox kassaNameBox;
        private TextBox kassaPassaBox;
        private Label resultlabel3;
    }
}