using Source.Presenters;
using Source.Views;

namespace Source;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();


        IAddView addView = new AddView();
        new AddPresenter(addView);

        IMainView mainView = new MainView();
        new MainPresenter(mainView, addView);


        Application.Run((Form)mainView);
    }
}