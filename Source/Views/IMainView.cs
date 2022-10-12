namespace Source.Views;

public interface IMainView
{
    string SearchValue { get; }

    event EventHandler SearchEvent;
    event EventHandler AddEvent;
    event EventHandler UpdateEvent;
    event EventHandler DeleteEvent;

    void SetStudentListBindingSource(BindingSource source);
}
