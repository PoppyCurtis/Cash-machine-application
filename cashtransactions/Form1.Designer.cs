namespace cashtransactions
{
    public partial class Form1
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
        /// 
       
        private void InitializeComponent()
        {
            this.buttonGiveJoe = new System.Windows.Forms.Button();
            this.buttonReceiveFromBob = new System.Windows.Forms.Button();
            this.joesCashLabel = new System.Windows.Forms.Label();
            this.bobsCashLabel = new System.Windows.Forms.Label();
            this.bankLabel = new System.Windows.Forms.Label();
            this.buttonGiveToBob = new System.Windows.Forms.Button();
            this.buttonBobGiveToJoe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGiveJoe
            // 
            this.buttonGiveJoe.Location = new System.Drawing.Point(31, 148);
            this.buttonGiveJoe.Name = "buttonGiveJoe";
            this.buttonGiveJoe.Size = new System.Drawing.Size(76, 39);
            this.buttonGiveJoe.TabIndex = 0;
            this.buttonGiveJoe.Text = "Give $10 to Joe";
            this.buttonGiveJoe.UseVisualStyleBackColor = true;
            this.buttonGiveJoe.Click += new System.EventHandler(this.buttonGiveJoe_Click);
            // 
            // buttonReceiveFromBob
            // 
            this.buttonReceiveFromBob.Location = new System.Drawing.Point(162, 144);
            this.buttonReceiveFromBob.Name = "buttonReceiveFromBob";
            this.buttonReceiveFromBob.Size = new System.Drawing.Size(82, 43);
            this.buttonReceiveFromBob.TabIndex = 1;
            this.buttonReceiveFromBob.Text = "Receive $5 from Bob";
            this.buttonReceiveFromBob.UseVisualStyleBackColor = true;
            this.buttonReceiveFromBob.Click += new System.EventHandler(this.buttonReceiveFromBob_Click);
            // 
            // joesCashLabel
            // 
            this.joesCashLabel.AutoSize = true;
            this.joesCashLabel.Location = new System.Drawing.Point(25, 24);
            this.joesCashLabel.Name = "joesCashLabel";
            this.joesCashLabel.Size = new System.Drawing.Size(65, 13);
            this.joesCashLabel.TabIndex = 2;
            this.joesCashLabel.Text = "Joe has $50";
            // 
            // bobsCashLabel
            // 
            this.bobsCashLabel.AutoSize = true;
            this.bobsCashLabel.Location = new System.Drawing.Point(28, 66);
            this.bobsCashLabel.Name = "bobsCashLabel";
            this.bobsCashLabel.Size = new System.Drawing.Size(73, 13);
            this.bobsCashLabel.TabIndex = 3;
            this.bobsCashLabel.Text = "Bob has $100";
            // 
            // bankLabel
            // 
            this.bankLabel.AutoSize = true;
            this.bankLabel.Location = new System.Drawing.Point(28, 117);
            this.bankLabel.Name = "bankLabel";
            this.bankLabel.Size = new System.Drawing.Size(100, 13);
            this.bankLabel.TabIndex = 4;
            this.bankLabel.Text = "The bank has $100";
            // 
            // buttonGiveToBob
            // 
            this.buttonGiveToBob.Location = new System.Drawing.Point(31, 207);
            this.buttonGiveToBob.Name = "buttonGiveToBob";
            this.buttonGiveToBob.Size = new System.Drawing.Size(76, 45);
            this.buttonGiveToBob.TabIndex = 5;
            this.buttonGiveToBob.Text = "Joe gives $10 to Bob";
            this.buttonGiveToBob.UseVisualStyleBackColor = true;
            this.buttonGiveToBob.Click += new System.EventHandler(this.buttonGiveToBob_Click);
            // 
            // buttonBobGiveToJoe
            // 
            this.buttonBobGiveToJoe.Location = new System.Drawing.Point(162, 207);
            this.buttonBobGiveToJoe.Name = "buttonBobGiveToJoe";
            this.buttonBobGiveToJoe.Size = new System.Drawing.Size(82, 45);
            this.buttonBobGiveToJoe.TabIndex = 6;
            this.buttonBobGiveToJoe.Text = "Bob gives $5 to Joe";
            this.buttonBobGiveToJoe.UseVisualStyleBackColor = true;
            this.buttonBobGiveToJoe.Click += new System.EventHandler(this.buttonBobGiveToJoe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 279);
            this.Controls.Add(this.buttonBobGiveToJoe);
            this.Controls.Add(this.buttonGiveToBob);
            this.Controls.Add(this.bankLabel);
            this.Controls.Add(this.bobsCashLabel);
            this.Controls.Add(this.joesCashLabel);
            this.Controls.Add(this.buttonReceiveFromBob);
            this.Controls.Add(this.buttonGiveJoe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

  



        #endregion
   
        private System.Windows.Forms.Button buttonGiveJoe;
        private System.Windows.Forms.Button buttonReceiveFromBob;
        private System.Windows.Forms.Label joesCashLabel;
        private System.Windows.Forms.Label bobsCashLabel;
        private System.Windows.Forms.Label bankLabel;
        private System.Windows.Forms.Button buttonGiveToBob;
        private System.Windows.Forms.Button buttonBobGiveToJoe;
    }
}

