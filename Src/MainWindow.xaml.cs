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
            //LoginWindow startup on center of screen
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

    }
}
