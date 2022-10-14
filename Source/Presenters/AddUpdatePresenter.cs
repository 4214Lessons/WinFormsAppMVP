using Source.Views;

namespace Source.Presenters;


public class AddUpdatePresenter
{
    private readonly IAddUpdateView _addUpdateView;

    public AddUpdatePresenter(IAddUpdateView addView)
    {
        _addUpdateView = addView;

        _addUpdateView.SaveEvent += _addView_SaveEvent;
        _addUpdateView.CancelEvent += _addView_CancelEvent;
    }


    private void _addView_SaveEvent(object? sender, EventArgs e)
    {
        if (_addUpdateView.FirstName.Length > 3)
        {
            ((Form)_addUpdateView).DialogResult = DialogResult.OK;
            return;
        }


        MessageBox.Show("Error Messages", "Errors", MessageBoxButtons.OK, MessageBoxIcon.Information);

    }


    private void _addView_CancelEvent(object? sender, EventArgs e)
        => ((Form)_addUpdateView).DialogResult = DialogResult.Cancel;

}
