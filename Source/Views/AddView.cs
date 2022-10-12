namespace Source.Views;


public partial class AddView : Form, IAddView
{
    public AddView()
    {
        InitializeComponent();
    }

    public string FirstName => txt_firstName.Text;
    public string LastName => txt_lastName.Text;
    public decimal Score => num_score.Value;

    public DateTime DateOfBirth => monthCalendar.SelectionStart;


    public event EventHandler? SaveEvent;
    public event EventHandler? CancelEvent;


    private void btn_save_Click(object sender, EventArgs e) 
        => SaveEvent?.Invoke(sender, e);

    private void btn_cancel_Click(object sender, EventArgs e)
        => CancelEvent?.Invoke(sender, e);

}
