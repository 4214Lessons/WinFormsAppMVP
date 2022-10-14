namespace Source.Views;


public interface IAddUpdateView
{
    string FirstName { get; set; }
    string LastName { get; set; }
    decimal Score { get; set; }
    DateTime DateOfBirth { get; set; }

    DialogResult DialogResult { get; set; }

    event EventHandler SaveEvent;
    event EventHandler CancelEvent;

    DialogResult ShowDialog();
}