using Source.Models;
using Source.Repositories;
using Source.Views;

namespace Source.Presenters;



public class MainPresenter
{
    private readonly IMainView _mainView;
    private readonly IAddUpdateView _addUpdateView;
    private readonly IStudentRepository _repository;

    private readonly BindingSource _bindingSource;


    public MainPresenter(IMainView mainView, IAddUpdateView addUpdateView, IStudentRepository repository)
    {
        _mainView = mainView;
        _addUpdateView = addUpdateView;
        _repository = repository;



        // Binding Source
        _bindingSource = new();
        _bindingSource.DataSource = _repository.GetList();
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

        bool isNullOrWhiteSpace = string.IsNullOrWhiteSpace(searchValue);

        _bindingSource.DataSource = isNullOrWhiteSpace switch
        {
            true => _repository.GetList(),
            false => _repository.GetList(s => 
                            s.FirstName.Contains(searchValue, StringComparison.OrdinalIgnoreCase)
                            ||
                            s.LastName.Contains(searchValue, StringComparison.OrdinalIgnoreCase))
        };
    }


    private void MainView_DeleteEvent(object? sender, EventArgs e)
    {
        var deletedItem = _bindingSource.Current as Student;

        if (deletedItem is null)
        {
            MessageBox.Show("An error occured", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        _repository.Remove(deletedItem);
        _bindingSource.Remove(deletedItem);
        MessageBox.Show("Successfully deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }


    private void MainView_AddEvent(object? sender, EventArgs e)
    {
        if (_addUpdateView.ShowDialog() == DialogResult.Cancel)
            return;

        var student = new Student
        {
            FirstName = _addUpdateView.FirstName,
            LastName = _addUpdateView.LastName,
            DateOfBirth = _addUpdateView.DateOfBirth,
            Score = (float)_addUpdateView.Score
        };


        _repository.Add(student);
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


        _repository.Update(student);
        _bindingSource.ResetCurrentItem();
        MessageBox.Show("Successfully updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

}