using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Source.Views;

public partial class MainView : Form, IMainView
{
    public MainView()
    {
        InitializeComponent();
    }

    public string SearchValue => txt_search.Text;

    public void SetStudentListBindingSource(BindingSource source)
        => lBox_students.DataSource = source;




    // Events
    public event EventHandler? SearchEvent;
    public event EventHandler? AddEvent;
    public event EventHandler? UpdateEvent;
    public event EventHandler? DeleteEvent;


    private void btn_search_Click(object sender, EventArgs e)
    {
        // SearchEvent?.Invoke(this, EventArgs.Empty);
        SearchEvent?.Invoke(sender, e);
    }


    private void btn_delete_Click(object sender, EventArgs e) 
        => DeleteEvent?.Invoke(sender, e);


    private void btn_add_Click(object sender, EventArgs e)
        => AddEvent?.Invoke(sender, e);

}