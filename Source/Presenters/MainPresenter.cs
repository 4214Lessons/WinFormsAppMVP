using Source.Models;
using Source.Views;

namespace Source.Presenters;



public class MainPresenter
{
    private readonly IMainView _mainView;
    private readonly IAddUpdateView _addUpdateView;

    private readonly BindingSource _bindingSource;
    private readonly List<Student> _students;


    public MainPresenter(IMainView mainView, IAddUpdateView addUpdateView)
    {
        _mainView = mainView;
        _addUpdateView = addUpdateView;


        _students = new List<Student>()
        {
            new Student("Miri", "Huseynzade", new DateTime(2003, 9, 1), 8.3f),
            new Student("Tural", "Haci-nebili", new DateTime(2007, 6, 24), 9.7f),
            new Student("Kamran", "Kerimzade", new DateTime(1999, 3, 27), 10.2f),
        };


        // Binding Source
        _bindingSource = new();
        _bindingSource.DataSource = _students;
        _mainView.SetStudentListBindingSource(_bindingSource);


        // Events
        _mainView.SearchEvent += MainView_SearchEvent;
        _mainView.DeleteEvent += MainView_DeleteEvent;
        _mainView.AddEvent += MainView_AddEvent;
        _mainView.UpdateEvent += MainView_UpdateEvent; ;
    }


    private void MainView_SearchEvent(object? sender, EventArgs e)
    {
        var searchValue = _mainView.SearchValue;

        if (!string.IsNullOrWhiteSpace(searchValue))
            _bindingSource.DataSource = _students
                .Where(s =>
                            s.FirstName
                            .ToLower()
                            .Contains(searchValue.ToLower())
                            ||
                            s.LastName
                            .ToLower()
                            .Contains(searchValue.ToLower()))
                .ToList();
        else
            _bindingSource.DataSource = _students;
    }


    private void MainView_DeleteEvent(object? sender, EventArgs e)
    {
        var deletedItem = _bindingSource.Current;

        if (deletedItem is null)
        {
            MessageBox.Show("An error occured", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }


        _bindingSource.Remove(deletedItem);
        MessageBox.Show("Successfully deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }


    private void MainView_AddEvent(object? sender, EventArgs e)
    {
        var result = _addUpdateView.ShowDialog();

        if (result == DialogResult.Cancel)
            return;

        var student = new Student
        {
            FirstName = _addUpdateView.FirstName,
            LastName = _addUpdateView.LastName,
            DateOfBirth = _addUpdateView.DateOfBirth,
            Score = (float)_addUpdateView.Score
        };


        _bindingSource.Add(student);

        MessageBox.Show("Successfully added", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }


    private void MainView_UpdateEvent(object? sender, EventArgs e)
    {
        var student = _bindingSource.Current as Student;

        if (student is null)
        {
            MessageBox.Show("An error occured", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        _addUpdateView.FirstName = student.FirstName;
        _addUpdateView.LastName = student.LastName;
        _addUpdateView.Score = (decimal)student.Score;
        _addUpdateView.DateOfBirth = student.DateOfBirth;


        if (_addUpdateView.ShowDialog() == DialogResult.Cancel)
            return;


        student.FirstName = _addUpdateView.FirstName;
        student.LastName = _addUpdateView.LastName;
        student.Score = (float)_addUpdateView.Score;
        student.DateOfBirth = _addUpdateView.DateOfBirth;


        _bindingSource.ResetCurrentItem();
        MessageBox.Show("Successfully updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

}