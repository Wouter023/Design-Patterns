namespace assignment1
{
    partial class TrainDisplay
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
            currentStationOutputLabel = new Label();
            railTrackOutputlabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 119);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 0;
            label1.Text = "Current Station:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 151);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 1;
            label2.Text = "Railway Track:";
            // 
            // currentStationOutputLabel
            // 
            currentStationOutputLabel.AutoSize = true;
            currentStationOutputLabel.Location = new Point(240, 119);
            currentStationOutputLabel.Name = "currentStationOutputLabel";
            currentStationOutputLabel.Size = new Size(50, 20);
            currentStationOutputLabel.TabIndex = 2;
            currentStationOutputLabel.Text = "label3";
            // 
            // railTrackOutputlabel
            // 
            railTrackOutputlabel.AutoSize = true;
            railTrackOutputlabel.Location = new Point(240, 151);
            railTrackOutputlabel.Name = "railTrackOutputlabel";
            railTrackOutputlabel.Size = new Size(50, 20);
            railTrackOutputlabel.TabIndex = 3;
            railTrackOutputlabel.Text = "label4";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(railTrackOutputlabel);
            Controls.Add(currentStationOutputLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label currentStationOutputLabel;
        private Label railTrackOutputlabel;
    }
}