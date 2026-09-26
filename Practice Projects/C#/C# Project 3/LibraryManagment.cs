namespace maslyanchuk_E_Test_3
{
    //Eric Maslyanchuk
    //CPT-185-A01
    //Test

    public partial class LibraryManagment : Form
    {
        //create a library object
        Library library = new Library();

        public LibraryManagment()
        {
            InitializeComponent();
        }

        private void LibraryManagment_Load(object sender, EventArgs e)
        {
            //loads the files 
            library.LoadBooks("books.txt");
            library.LoadPatron("patrons.txt");
        }

        private void manageBookBtn_Click(object sender, EventArgs e)
        {
            //opens book form and passes library object
            BookForm bookForm = new BookForm(library);
            bookForm.ShowDialog();
        }

        private void managePatronBtn_Click(object sender, EventArgs e)
        {
            //opens patron form and passes library object
            PatronForm patronForm = new PatronForm(library);
            patronForm.ShowDialog();
        }

        private void checkOut_Click(object sender, EventArgs e)
        {
            //opens checkout form and passes library object
            CheckOut checkOutForm = new CheckOut(library);
            checkOutForm.ShowDialog();
        }
        //this MUST be here or NOTHING SAVES
        private void LibraryManagment_FormClosing(object sender, FormClosingEventArgs e)
        {
            library.SaveBooks("books.txt");
            library.SavePatron("patrons.txt");
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }
    }  
}
