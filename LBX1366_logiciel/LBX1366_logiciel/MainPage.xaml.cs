using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace LBX1366_logiciel
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    
    public sealed partial class MainPage : Page
    {
        public string Productname = "";
        public string Vid = "";
        public string Pid_Value = "";
        public string Frimware = "0.0.0";
        public string Link = "Connection";
        public string Pass = "Not";
        public string Appversion_value = "0.0.1";
        public bool Ispassed = false;
        public int IsbuttonA = 0;
        public int IsbuttonB = 0;
        public int IsbuttonX = 0;
        public int IsbuttonY = 0;
        public int IsbuttonLB = 0;
        public int IsbuttonRB = 0;
        public int IsbuttonMenu = 0;
        public int IsbuttonView = 0;
        public int IsbuttonLS = 0;
        public int IsbuttonRS = 0;
        public float LeftStickvalueX = 0;
        public float LeftStickvalueY = 0;
        public float RightStickvalueX = 0;
        public float RightStickvalueY = 0;
        public float LeftTrigger_Value = 0;
        public float RightTrigger_Value = 0;
        public int DpadUp_Value = 0;
        public int DpadUpLeft_Value = 0;
        public int DpadUpRight_Value = 0;
        public int DpadRight_Value = 0;
        public int DpadLeft_Value = 0;
        public int DpadDownLeft_Value = 0;
        public int DpadDownRight_Value = 0;
        public int DpadDown_Value = 0;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void InformationValue()
        {
            var gray = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 136, 104, 104));
            var Green = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 88, 181, 165));
            var Red = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 234, 24, 24));
            var Blue = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 40, 220, 234));

            if (IsbuttonA == 1)
            {
                ButtonA.Foreground = Blue;
                ButtonAshadow.Visibility = Visibility.Visible;
            }
            if (IsbuttonA == 2)
            {
                ButtonA.Foreground = Green;
                ButtonAshadow.Visibility = Visibility.Collapsed;
            }
            if (IsbuttonA == 0)
            {
                ButtonA.Foreground = gray;
                ButtonAshadow.Visibility = Visibility.Collapsed;
            }
            if (IsbuttonB == 1)
            {
                ButtonB.Foreground = Blue;
                ButtonBshadow.Visibility = Visibility.Visible;
            }
            if (IsbuttonB == 2)
            {
                ButtonB.Foreground = Green;
                ButtonBshadow.Visibility = Visibility.Collapsed;
            }
            if (IsbuttonB == 0)
            {
                ButtonB.Foreground = gray;
                ButtonBshadow.Visibility = Visibility.Collapsed;
            }
            if (IsbuttonX == 1)
            {
                ButtonX.Foreground = Blue;
                ButtonXshadow.Visibility = Visibility.Visible;
            }
            if (IsbuttonX == 2)
            {
                ButtonX.Foreground = Green;
                ButtonXshadow.Visibility = Visibility.Collapsed;
            }
            if (IsbuttonX == 0)
            {
                ButtonX.Foreground = gray;
                ButtonXshadow.Visibility = Visibility.Collapsed;
            }
            if (IsbuttonY == 1)
            {
                ButtonY.Foreground = Blue;
                ButtonYshadow.Visibility = Visibility.Visible;
            }
            if (IsbuttonY == 2)
            {
                ButtonY.Foreground = Green;
                ButtonYshadow.Visibility = Visibility.Collapsed;
            }
            if (IsbuttonY == 0)
            {
                ButtonY.Foreground = gray;
                ButtonYshadow.Visibility = Visibility.Collapsed;
            }
            productname.Text = Productname;
            vid.Text = Vid;
            Pid.Text = Pid_Value;
            firmware.Text = Frimware;
            link.Text = Link;
            Passstate.Text = Pass;
            Appversion.Text = Appversion_value;

            if (Ispassed == false)
            {
                Passstate.Foreground = Red;
            }
            if (Ispassed == true)
            {
                Passstate.Foreground = Green;
            }

            Canvas.SetTop(LeftStick, 93 + LeftStickvalueY/255 * 94);
            Canvas.SetLeft(LeftStick, 94 + LeftStickvalueX / 255 * 94);

            Canvas.SetTop(RightStick, 93 + RightStickvalueY / 255 * 94);
            Canvas.SetLeft(RightStick, 94 + RightStickvalueX / 255 * 94);

            if ((LeftStickvalueY / 255) * (LeftStickvalueY / 255) + (LeftStickvalueX / 255) * (LeftStickvalueX / 255) >= 1)
            {
                LeftStickBorder.Fill = Red;
            }
            else
            {
                LeftStickBorder.Fill = gray;
            }

            if ((RightStickvalueY / 255) * (RightStickvalueY / 255) + (RightStickvalueX / 255) * (RightStickvalueX / 255) >= 1)
            {
                RightStickBorder.Fill = Red;
            }
            else
            {
                RightStickBorder.Fill = gray;
            }

            leftStickX.Text = LeftStickvalueX.ToString();
            leftStickY.Text = LeftStickvalueY.ToString();

            RightStickX.Text = RightStickvalueX.ToString();
            RightStickY.Text = RightStickvalueY.ToString();

            LeftTrigger.Text = LeftTrigger_Value.ToString();
            RightTrigger.Text = RightTrigger_Value.ToString();

            LeftTriggerValue.Height = LeftTrigger_Value * 342;
            RightTriggerValue.Height = RightTrigger_Value * 342;

            if (IsbuttonLB == 1)
            {
                ButtonLB.Foreground = Blue;   
            }
            if (IsbuttonLB == 2)
            {
                ButtonLB.Foreground = Green;
            }
            if (IsbuttonLB == 0)
            {
                ButtonLB.Foreground = gray;
            }

            if (IsbuttonRB == 1)
            {
                ButtonRB.Foreground = Blue;
            }
            if (IsbuttonRB == 2)
            {
                ButtonRB.Foreground = Green;
            }
            if (IsbuttonRB == 0)
            {
                ButtonRB.Foreground = gray;
            }

            if (IsbuttonView == 1)
            {
                ButtonViewshadow.Fill = Blue;
            }
            if (IsbuttonView == 2)
            {
                ButtonViewshadow.Fill = Green;
            }
            if (IsbuttonView == 0)
            {
                ButtonViewshadow.Fill = gray;
            }

            if (IsbuttonMenu == 1)
            {
                ButtonMenushadow.Fill = Blue;
            }
            if (IsbuttonMenu == 2)
            {
                ButtonMenushadow.Fill = Green;
            }
            if (IsbuttonMenu == 0)
            {
                ButtonMenushadow.Fill = gray;   
            }



            if (IsbuttonLS == 1)
            {
                ButtonLeftStick.Foreground = Blue;
            }
            if (IsbuttonLS == 2)
            {
                ButtonLeftStick.Foreground = Green;
            }
            if (IsbuttonLS == 0)
            {
                ButtonLeftStick.Foreground = gray;
            }

            if (IsbuttonRS == 1)
            {
                ButtonRightStick.Foreground = Blue;
            }
            if (IsbuttonRS == 2)
            {
                ButtonRightStick.Foreground = Green;
            }
            if (IsbuttonRS == 0)
            {
                ButtonRightStick.Foreground = gray;
            }

            if (DpadUp_Value == 1)
            {
                DpadUp.Foreground = Blue;
            }
            if (DpadUp_Value == 2)
            {
                DpadUp.Foreground = Green;
            }
            if (DpadUp_Value == 0)
            {
                DpadUp.Foreground = gray;
            }

            if (DpadUpLeft_Value == 1)
            {
                DpadUpLeft.Foreground = Blue;
            }
            if (DpadUpLeft_Value == 2)
            {
                DpadUpLeft.Foreground = Green;
            }
            if (DpadUpLeft_Value == 0)
            {
                DpadUpLeft.Foreground = gray;
            }

            if (DpadLeft_Value == 1)
            {
                DpadLeft.Foreground = Blue;
            }
            if (DpadLeft_Value == 2)
            {
                DpadLeft.Foreground = Green;
            }
            if (DpadLeft_Value == 0)
            {
                DpadLeft.Foreground = gray;
            }

            if (DpadDownLeft_Value == 1)
            {
                DpadDownLeft.Foreground = Blue;
            }
            if (DpadDownLeft_Value == 2)
            {
                DpadDownLeft.Foreground = Green;
            }
            if (DpadDownLeft_Value == 0)
            {
                DpadDownLeft.Foreground = gray;
            }


            if (DpadDown_Value == 1)
            {
                DpadDown.Foreground = Blue;
            }
            if (DpadDown_Value == 2)
            {
                DpadDown.Foreground = Green;
            }
            if (DpadDown_Value == 0)
            {
                DpadDown.Foreground = gray;
            }

            if (DpadDownRight_Value == 1)
            {
                DpadDownRight.Foreground = Blue;
            }
            if (DpadDownRight_Value == 2)
            {
                DpadDownRight.Foreground = Green;
            }
            if (DpadDownRight_Value == 0)
            {
                DpadDownRight.Foreground = gray;
            }

            if (DpadRight_Value == 1)
            {
                DpadRight.Foreground = Blue;
            }
            if (DpadRight_Value == 2)
            {
                DpadRight.Foreground = Green;
            }
            if (DpadRight_Value == 0)
            {
                DpadRight.Foreground = gray;
            }

            if (DpadUpRight_Value == 1)
            {
                DpadUpRight.Foreground = Blue;
            }
            if (DpadUpRight_Value == 2)
            {
                DpadUpRight.Foreground = Green;
            }
            if (DpadUpRight_Value == 0)
            {
                DpadUpRight.Foreground = gray;
            }
        }
    }

    
}
