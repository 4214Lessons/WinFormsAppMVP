using Source.Presenters;
using Source.Views;

namespace Source;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();


        IAddUpdateView addView = new AddUpdateView();
        new AddUpdatePresenter(addView);
        new AddUpdatePresenter(addView);

        IMainView mainView = new MainView();
        new MainPresenter(mainView, addView);


        Application.Run((Form)mainView);
    }
}