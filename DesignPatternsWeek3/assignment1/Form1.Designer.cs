namespace assignment1
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
            nextStationButton = new Button();
            newDisplayButton = new Button();
            SuspendLayout();
            // 
            // nextStationButton
            // 
            nextStationButton.Location = new Point(302, 157);
            nextStationButton.Name = "nextStationButton";
            nextStationButton.Size = new Size(123, 29);
            nextStationButton.TabIndex = 0;
            nextStationButton.Text = "Next Station";
            nextStationButton.UseVisualStyleBackColor = true;
            nextStationButton.Click += nextStationButton_Click;
            // 
            // newDisplayButton
            // 
            newDisplayButton.Location = new Point(47, 381);
            newDisplayButton.Name = "newDisplayButton";
            newDisplayButton.Size = new Size(118, 29);
            newDisplayButton.TabIndex = 1;
            newDisplayButton.Text = "New display";
            newDisplayButton.UseVisualStyleBackColor = true;
            newDisplayButton.Click += newDisplayButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(newDisplayButton);
            Controls.Add(nextStationButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button nextStationButton;
        private Button newDisplayButton;
    }
}