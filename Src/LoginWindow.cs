using FishMovie.Core.Windows;
using System.Windows;

namespace FishMovie.Windows
{
    ///<summary>
    ///**************************************************
    /// Version：v1.0.0
    /// Author：NESP_Technology-JinZhaolu
    /// Created Date：2020/5/28 20:45:52
    /// Description：
    ///****************************************************
    ///</summary> 
    public partial class LoginWindow : BaseWindow
    {
        public LoginWindow()
        {
            InitializeComponent();

            this.Loaded += new RoutedEventHandler(LoginWindow_Loaded);

        }

        public void LoginWindow_Loaded(object sender, System.EventArgs e)
        {
            Btn_Close.Click += new RoutedEventHandler(Btn_Close_Click);
            Btn_Min.Click += new RoutedEventHandler(Btn_Min_Click);

        }
        public void Btn_Close_Click(object sender, System.EventArgs e)
        {
            Close();
        }


        public void Btn_Min_Click(object sender, System.EventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
    }
}
