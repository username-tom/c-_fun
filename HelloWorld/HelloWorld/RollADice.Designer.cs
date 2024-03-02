namespace HelloWorld
{
    partial class RollADice
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
            BtnPrint = new Button();
            LblOutput = new Label();
            SuspendLayout();
            // 
            // BtnPrint
            // 
            BtnPrint.Anchor = AnchorStyles.Top;
            BtnPrint.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPrint.Location = new Point(28, 128);
            BtnPrint.Name = "BtnPrint";
            BtnPrint.Size = new Size(189, 72);
            BtnPrint.TabIndex = 0;
            BtnPrint.Text = "Roll Dice";
            BtnPrint.UseVisualStyleBackColor = true;
            BtnPrint.Click += BtnPrint_Click;
            // 
            // LblOutput
            // 
            LblOutput.Anchor = AnchorStyles.Top;
            LblOutput.AutoSize = true;
            LblOutput.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblOutput.Location = new Point(94, 37);
            LblOutput.Name = "LblOutput";
            LblOutput.Size = new Size(56, 65);
            LblOutput.TabIndex = 1;
            LblOutput.Text = "6";
            // 
            // RollADice
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(244, 221);
            Controls.Add(LblOutput);
            Controls.Add(BtnPrint);
            Name = "RollADice";
            Text = "Dice Roll";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnPrint;
        private Label LblOutput;
    }
}
