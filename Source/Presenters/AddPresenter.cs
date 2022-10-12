using Source.Views;

namespace Source.Presenters;

public class AddPresenter
{
    private readonly IAddView _addView;

    public AddPresenter(IAddView addView)
    {
        _addView = addView;

        _addView.SaveEvent += _addView_SaveEvent;
        _addView.CancelEvent += _addView_CancelEvent;
    }


    private void _addView_SaveEvent(object? sender, EventArgs e)
    {
        if (_addView.FirstName.Length > 3)
        {
            ((Form)_addView).DialogResult = DialogResult.OK;
            return;
        }


        MessageBox.Show("Error Messages", "Errors", MessageBoxButtons.OK, MessageBoxIcon.Information);

    }



    private void _addView_CancelEvent(object? sender, EventArgs e)
        => ((Form)_addView).DialogResult = DialogResult.Cancel;

}
