namespace DigitalClockApp
{
    partial class DigitalClock
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
            components = new System.ComponentModel.Container();
            ClockLabel = new Label();
            clockTimer = new System.Windows.Forms.Timer(components);
            greyButton = new Button();
            aquaButton = new Button();
            turqoiseButton = new Button();
            violetButton = new Button();
            indigoButton = new Button();
            styleButton3 = new Button();
            styleButton1 = new Button();
            styleButton2 = new Button();
            SuspendLayout();
            // 
            // ClockLabel
            // 
            ClockLabel.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            ClockLabel.ForeColor = SystemColors.AppWorkspace;
            ClockLabel.Location = new Point(3, 9);
            ClockLabel.Name = "ClockLabel";
            ClockLabel.Size = new Size(785, 382);
            ClockLabel.TabIndex = 0;
            ClockLabel.Text = "Loading...";
            ClockLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // clockTimer
            // 
            clockTimer.Interval = 1000;
            clockTimer.Tick += clockTimer_Tick;
            // 
            // greyButton
            // 
            greyButton.BackColor = SystemColors.AppWorkspace;
            greyButton.Location = new Point(12, 406);
            greyButton.Name = "greyButton";
            greyButton.Size = new Size(35, 32);
            greyButton.TabIndex = 1;
            greyButton.UseVisualStyleBackColor = false;
            greyButton.Click += greyButton_Click;
            // 
            // aquaButton
            // 
            aquaButton.BackColor = Color.Aqua;
            aquaButton.Location = new Point(94, 406);
            aquaButton.Name = "aquaButton";
            aquaButton.Size = new Size(35, 32);
            aquaButton.TabIndex = 2;
            aquaButton.UseVisualStyleBackColor = false;
            aquaButton.Click += aquaButton_Click;
            // 
            // turqoiseButton
            // 
            turqoiseButton.BackColor = Color.PaleTurquoise;
            turqoiseButton.Location = new Point(53, 406);
            turqoiseButton.Name = "turqoiseButton";
            turqoiseButton.Size = new Size(35, 32);
            turqoiseButton.TabIndex = 3;
            turqoiseButton.UseVisualStyleBackColor = false;
            turqoiseButton.Click += turqoiseButton_Click;
            // 
            // violetButton
            // 
            violetButton.BackColor = Color.BlueViolet;
            violetButton.Location = new Point(135, 406);
            violetButton.Name = "violetButton";
            violetButton.Size = new Size(35, 32);
            violetButton.TabIndex = 4;
            violetButton.UseVisualStyleBackColor = false;
            violetButton.Click += violetButton_Click;
            // 
            // indigoButton
            // 
            indigoButton.BackColor = Color.Indigo;
            indigoButton.Location = new Point(176, 406);
            indigoButton.Name = "indigoButton";
            indigoButton.Size = new Size(35, 32);
            indigoButton.TabIndex = 5;
            indigoButton.UseVisualStyleBackColor = false;
            indigoButton.Click += indigoButton_Click;
            // 
            // styleButton3
            // 
            styleButton3.BackColor = SystemColors.ButtonHighlight;
            styleButton3.Font = new Font("Goudy Old Style", 9F, FontStyle.Bold, GraphicsUnit.Point);
            styleButton3.Location = new Point(719, 406);
            styleButton3.Name = "styleButton3";
            styleButton3.Size = new Size(69, 32);
            styleButton3.TabIndex = 6;
            styleButton3.Text = "Style 3";
            styleButton3.UseVisualStyleBackColor = false;
            styleButton3.Click += styleButton3_Click;
            // 
            // styleButton1
            // 
            styleButton1.BackColor = SystemColors.ButtonHighlight;
            styleButton1.Font = new Font("Gill Sans Ultra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            styleButton1.Location = new Point(569, 407);
            styleButton1.Name = "styleButton1";
            styleButton1.Size = new Size(69, 32);
            styleButton1.TabIndex = 7;
            styleButton1.Text = "Style 1";
            styleButton1.UseVisualStyleBackColor = false;
            styleButton1.Click += button1_Click;
            // 
            // styleButton2
            // 
            styleButton2.BackColor = SystemColors.ButtonHighlight;
            styleButton2.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point);
            styleButton2.Location = new Point(644, 406);
            styleButton2.Name = "styleButton2";
            styleButton2.Size = new Size(69, 32);
            styleButton2.TabIndex = 8;
            styleButton2.Text = "Style 2";
            styleButton2.UseVisualStyleBackColor = false;
            styleButton2.Click += styleButton2_Click;
            // 
            // DigitalClock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(styleButton2);
            Controls.Add(styleButton1);
            Controls.Add(styleButton3);
            Controls.Add(indigoButton);
            Controls.Add(violetButton);
            Controls.Add(turqoiseButton);
            Controls.Add(aquaButton);
            Controls.Add(greyButton);
            Controls.Add(ClockLabel);
            Name = "DigitalClock";
            Text = "Digital Clock";
            Load += DigitalClock_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label ClockLabel;
        private System.Windows.Forms.Timer clockTimer;
        private Button greyButton;
        private Button aquaButton;
        private Button turqoiseButton;
        private Button violetButton;
        private Button indigoButton;
        private Button styleButton3;
        private Button styleButton1;
        private Button styleButton2;
    }
}