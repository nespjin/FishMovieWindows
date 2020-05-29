using FishMovie.Core.Windows;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

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
        private const string TAG = "FishMovie.Windows.LoginWindow";
        private bool canMoveWindow = true;

        public LoginWindow()
        {
            InitializeComponent();

            this.Loaded += new RoutedEventHandler(LoginWindow_Loaded);

        }

        public void LoginWindow_Loaded(object sender, EventArgs e)
        {
            InitView();
        }

        private void InitView()
        {
            //Mouse
            this.MouseMove += new MouseEventHandler(LoginWindow_Mouse_Move);
            //Window Button
            Btn_Close.Click += new RoutedEventHandler(Btn_Close_Click);
            Btn_Min.Click += new RoutedEventHandler(Btn_Min_Click);
            //User Input
            Tb_User_Name.AllowDrop = false;
            DependencyPropertyChangedEventHandler dependencyPropertyChangedEventHandler = new DependencyPropertyChangedEventHandler(Input_Box_IsKeyboardFocusedChanged);
            Tb_User_Name.IsKeyboardFocusedChanged += dependencyPropertyChangedEventHandler;
            Pb_User_Password.IsKeyboardFocusedChanged += dependencyPropertyChangedEventHandler;

            //Login Btn
            Btn_Login.Click += new RoutedEventHandler(Btn_Login_Click);


        }

        public void Input_Box_IsKeyboardFocusedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (e.Property.Name.Equals("IsKeyboardFocused") && e.NewValue is Boolean)
            {
                canMoveWindow = !(Boolean)e.NewValue;

            }

        }

        public void LoginWindow_Mouse_Move(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed && canMoveWindow)
            {
                try
                {
                    this.DragMove();

                }
                catch (InvalidOperationException ex)
                {
                    Debugger.Log(0, TAG, "LoginWindow_Mouse_Move:try" + ex.Message);
                }
            }
        }

        public void Btn_Login_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "登录成功", "提示",MessageBoxButton.OK);
        }

        public void Btn_Close_Click(object sender, EventArgs e)
        {
            Close();

        }


        public void Btn_Min_Click(object sender, EventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
    }
}
