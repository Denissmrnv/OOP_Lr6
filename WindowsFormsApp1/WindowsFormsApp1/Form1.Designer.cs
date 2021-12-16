
namespace WindowsFormsApp1
{
    partial class Form1 {
        private System.ComponentModel.IContainer components = null;

        System.Windows.Forms.Button[] myBtn = new System.Windows.Forms.Button[10];

        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 
        private void InitializeComponent() {
            int pointButton = 0;
            for (int i = 0; i < 10; i++) {
                this.myBtn[i] = new System.Windows.Forms.Button();
                this.myBtn[i].Location = new System.Drawing.Point(12 + pointButton, 67);
                this.myBtn[i].Name = "button" + (i + 1).ToString();
                this.myBtn[i].Size = new System.Drawing.Size(50, 40);
                this.myBtn[i].TabIndex = 0;
                this.myBtn[i].Text =  (i + 1).ToString();
                this.myBtn[i].UseVisualStyleBackColor = true;
                this.myBtn[i].Click += this.buttonMove;
                pointButton += 75;
            }

            this.SuspendLayout();
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);

            for (int i = 0; i < 10; i++) {
                this.Controls.Add(this.myBtn[i]);
            }

            this.Name = "Form1";
            this.Text = "LR_6";
            this.ResumeLayout(false);
        }
        #endregion
    }
}

