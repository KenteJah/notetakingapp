namespace NoteTakingApp
{
    partial class NoteTaker
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
            TitleBox = new TextBox();
            NoteBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            PreviousNotes = new DataGridView();
            LoadButton = new Button();
            DeleteButton = new Button();
            saveButton = new Button();
            NewNoteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)PreviousNotes).BeginInit();
            SuspendLayout();
            // 
            // TitleBox
            // 
            TitleBox.Location = new Point(399, 27);
            TitleBox.Name = "TitleBox";
            TitleBox.Size = new Size(389, 23);
            TitleBox.TabIndex = 0;
            TitleBox.TextChanged += textBox1_TextChanged;
            // 
            // NoteBox
            // 
            NoteBox.Location = new Point(399, 78);
            NoteBox.Multiline = true;
            NoteBox.Name = "NoteBox";
            NoteBox.Size = new Size(389, 360);
            NoteBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(399, 9);
            label1.Name = "label1";
            label1.Size = new Size(389, 23);
            label1.TabIndex = 2;
            label1.Text = "Title:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(399, 52);
            label2.Name = "label2";
            label2.Size = new Size(389, 23);
            label2.TabIndex = 3;
            label2.Text = "Note:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PreviousNotes
            // 
            PreviousNotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PreviousNotes.BackgroundColor = Color.White;
            PreviousNotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PreviousNotes.Location = new Point(12, 12);
            PreviousNotes.Name = "PreviousNotes";
            PreviousNotes.RowTemplate.Height = 25;
            PreviousNotes.Size = new Size(381, 321);
            PreviousNotes.TabIndex = 4;
            PreviousNotes.CellDoubleClick += PreviousNotes_CellDoubleClick;
            // 
            // LoadButton
            // 
            LoadButton.BackColor = Color.White;
            LoadButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LoadButton.Location = new Point(12, 339);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(182, 44);
            LoadButton.TabIndex = 5;
            LoadButton.Text = "Load";
            LoadButton.UseVisualStyleBackColor = false;
            LoadButton.Click += LoadButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.White;
            DeleteButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteButton.Location = new Point(200, 339);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(193, 44);
            DeleteButton.TabIndex = 6;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.White;
            saveButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            saveButton.Location = new Point(200, 394);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(193, 44);
            saveButton.TabIndex = 7;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // NewNoteButton
            // 
            NewNoteButton.BackColor = Color.White;
            NewNoteButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            NewNoteButton.Location = new Point(12, 394);
            NewNoteButton.Name = "NewNoteButton";
            NewNoteButton.Size = new Size(182, 44);
            NewNoteButton.TabIndex = 8;
            NewNoteButton.Text = "New Note";
            NewNoteButton.UseVisualStyleBackColor = false;
            NewNoteButton.Click += NewNoteButton_Click;
            // 
            // NoteTaker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(NewNoteButton);
            Controls.Add(saveButton);
            Controls.Add(DeleteButton);
            Controls.Add(LoadButton);
            Controls.Add(PreviousNotes);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NoteBox);
            Controls.Add(TitleBox);
            Name = "NoteTaker";
            Text = "NoteTaker";
            Load += NoteTaker_Load;
            ((System.ComponentModel.ISupportInitialize)PreviousNotes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TitleBox;
        private TextBox NoteBox;
        private Label label1;
        private Label label2;
        private DataGridView PreviousNotes;
        private Button LoadButton;
        private Button DeleteButton;
        private Button saveButton;
        private Button NewNoteButton;
    }
}