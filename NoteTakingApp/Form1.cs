using System.Data;

namespace NoteTakingApp
{
    public partial class NoteTaker : Form
    {
        DataTable notes = new DataTable();
        bool editing = false;
        private object ex;

        public object PreviouseNotes { get; private set; }

        public NoteTaker()
        {
            InitializeComponent();
        }

        private void NoteTaker_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("Title");
            notes.Columns.Add("Notes");

            PreviousNotes.DataSource = notes;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            TitleBox.Text = notes.Rows[PreviousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            NoteBox.Text = notes.Rows[PreviousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }



        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                notes.Rows[PreviousNotes.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex)
            { Console.WriteLine("Not a Valid Note"); }








        }

        private void NewNoteButton_Click(object sender, EventArgs e)
        {
            TitleBox.Text = "";
            NoteBox.Text = "";

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                notes.Rows[PreviousNotes.CurrentCell.RowIndex]["Title"] = TitleBox.Text;
                notes.Rows[PreviousNotes.CurrentCell.RowIndex]["Note"] = NoteBox.Text;
            }
            else
            {
                notes.Rows.Add(TitleBox.Text, NoteBox.Text);


            }
            TitleBox.Text = "";
            NoteBox.Text = "";
            editing = false;

        }

        private void PreviousNotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TitleBox.Text = notes.Rows[PreviousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            NoteBox.Text = notes.Rows[PreviousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }
    }
}