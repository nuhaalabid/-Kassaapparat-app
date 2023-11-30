namespace Kassaapparat_app
{
    partial class KassaRegister
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
            label1 = new Label();
            label2 = new Label();
            kassaregisterNamnBox = new TextBox();
            kassaregisterPassBox = new TextBox();
            kassaregisterbutton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 58);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 0;
            label1.Text = "Namn:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 113);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 1;
            label2.Text = "Lösen:";
            // 
            // kassaregisterNamnBox
            // 
            kassaregisterNamnBox.Location = new Point(178, 58);
            kassaregisterNamnBox.Name = "kassaregisterNamnBox";
            kassaregisterNamnBox.Size = new Size(150, 31);
            kassaregisterNamnBox.TabIndex = 2;
            // 
            // kassaregisterPassBox
            // 
            kassaregisterPassBox.Location = new Point(178, 113);
            kassaregisterPassBox.Name = "kassaregisterPassBox";
            kassaregisterPassBox.Size = new Size(150, 31);
            kassaregisterPassBox.TabIndex = 3;
            // 
            // kassaregisterbutton
            // 
            kassaregisterbutton.Location = new Point(126, 208);
            kassaregisterbutton.Name = "kassaregisterbutton";
            kassaregisterbutton.Size = new Size(112, 34);
            kassaregisterbutton.TabIndex = 4;
            kassaregisterbutton.Text = "Register";
            kassaregisterbutton.UseVisualStyleBackColor = true;
            kassaregisterbutton.Click += kassaregisterbutton_Click;
            // 
            // KassaRegister
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 328);
            Controls.Add(kassaregisterbutton);
            Controls.Add(kassaregisterPassBox);
            Controls.Add(kassaregisterNamnBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "KassaRegister";
            Text = "KassaRegister";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox kassaregisterNamnBox;
        private TextBox kassaregisterPassBox;
        private Button kassaregisterbutton;
    }
}