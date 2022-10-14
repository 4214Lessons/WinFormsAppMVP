using Source.Views;
using System.Text;

namespace Source.Presenters;


public class AddUpdatePresenter
{
    private readonly IAddUpdateView _addUpdateView;

    public AddUpdatePresenter(IAddUpdateView addUpdateView)
    {
        _addUpdateView = addUpdateView;

        _addUpdateView.SaveEvent += AddView_SaveEvent;
        _addUpdateView.CancelEvent += AddView_CancelEvent;
    }


    private void AddView_SaveEvent(object? sender, EventArgs e)
    {
        StringBuilder sb = new();

        if (_addUpdateView.FirstName.Length < 3)
            sb.Append($"{nameof(_addUpdateView.FirstName)} is wrong\n");

        if (_addUpdateView.LastName.Length < 3)
            sb.Append($"{nameof(_addUpdateView.LastName)} is wrong\n");

        if (DateTime.Now.Year - _addUpdateView.DateOfBirth.Year < 18)
            sb.Append($"{nameof(_addUpdateView.DateOfBirth)} is wrong\n");


        if(sb.Length > 0)
        {
            MessageBox.Show(sb.ToString(), "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        _addUpdateView.DialogResult = DialogResult.OK;
    }


    private void AddView_CancelEvent(object? sender, EventArgs e)
        => _addUpdateView.DialogResult = DialogResult.Cancel;
}
