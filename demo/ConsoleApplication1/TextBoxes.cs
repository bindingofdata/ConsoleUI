﻿using ConsoleUI;
using System;

namespace ConsoleApplication1
{
    internal static class TextBoxes
    {
        internal static void SetupTextBoxScreens(ScreenCollection screens)
        {
            BasicTextBoxScreen(screens);
            SingleBorderTextBoxScreen(screens);
            DoubleBorderTextBoxScreen(screens);
            MultilineBasicTextBoxScreen(screens);
        }

        private static void BasicTextBoxScreen(ScreenCollection screens)
        {
            var screen = new Screen("Basic Text Boxes");
            
            var control1 = new TextBox();

            control1.Left = 10;
            control1.Top = 0;
            control1.MaxLength = 5;
            control1.Width = control1.MaxLength;
            control1.TreatEnterKeyAsTab = false;

            var control2 = new TextBox();

            control2.Left = 0;
            control2.Top = control1.Top + control1.Height;
            control2.Width = screen.Width;
            control2.TextAlign = TextAlign.Center;

            var control3 = new TextBox();

            control3.Left = 0;
            control3.Top = control2.Top + control2.Height;
            control3.MaxLength = 20;
            control3.Width = control3.MaxLength;
            control3.TextBoxType = TextBoxType.Password;

            var control4 = new TextBox();

            control4.Left = 0;
            control4.Top = control3.Top + control3.Height;
            control4.MaxLength = 20;
            control4.TextAlign = TextAlign.Right;

            screen.Controls.Add(control1);
            screen.Controls.Add(control2);
            screen.Controls.Add(control3);
            screen.Controls.Add(control4);

            screen.Footer.Text = screen.Name + ". Press escape.";

            screens.Add(screen);
        }

        private static void DoubleBorderTextBoxScreen(ScreenCollection screens)
        {
            var screen = new Screen("Double Border Text Boxes");

            var control1 = new TextBox();

            control1.Left = 10;
            control1.Top = 0;
            control1.MaxLength = 6;
            control1.Width = control1.MaxLength + 2;
            control1.BorderStyle = BorderStyle.Double;

            var control2 = new TextBox();

            control2.Left = 0;
            control2.Top = control1.Top + control1.Height;
            control2.Width = screen.Width;
            control2.BorderStyle = BorderStyle.Double;

            var control3 = new TextBox();

            control3.Left = 0;
            control3.Top = control2.Top + control2.Height;
            control3.MaxLength = 20;
            control3.Width = control3.MaxLength;
            control3.BorderStyle = BorderStyle.Double;

            screen.Controls.Add(control1);
            screen.Controls.Add(control2);
            screen.Controls.Add(control3);

            screen.Footer.Text = screen.Name + ". Press escape.";

            screens.Add(screen);
        }

        private static void MultilineBasicTextBoxScreen(ScreenCollection screens)
        {
            var screen = new Screen("Multiline Basic Text Boxes");

            var control1 = new TextBox();

            control1.Left = 35;
            control1.Top = 0;
            control1.Width = control1.MaxLength;
            control1.TreatEnterKeyAsTab = false;
            control1.Height = 15;
            control1.Width = 50;
            control1.TextBoxType = TextBoxType.Multiline;
            control1.Text = "So if on advanced addition absolute received replying throwing he." + Environment.NewLine + Environment.NewLine + "Delighted consisted newspaper of unfeeling as neglected so." + Environment.NewLine + "Tell size come hard mrs and four fond are. Of in commanded earnestly resources it. At quitting in strictly up wandered of relation answered felicity. Side need at in what dear ever upon if. Same down want joy neat ask pain help she. Alone three stuff use law walls fat asked. Near do that he help.";
            control1.BorderStyle = BorderStyle.Double;

            var control2 = new TextBox();

            control2.Left = 0;
            control2.Top = control1.Top + control1.Height + 1;
            control2.Width = screen.Width;
            control2.TextAlign = TextAlign.Center;
            control2.Height = 5;
            control2.Width = 20;
            control2.TextBoxType = TextBoxType.Multiline;
            control2.MaxLength = 150;
            
            var control3 = new TextBox();

            control3.Left = 35;
            control3.Top = control2.Top ;
            control3.Height = 20;
            control3.Width = 50;
            control3.TextBoxType = TextBoxType.Multiline;
            control3.Text = Properties.Resources.LongText;
            control3.BorderStyle = BorderStyle.Double;

            screen.Controls.Add(control1);
            screen.Controls.Add(control2);
            screen.Controls.Add(control3);

            screen.Footer.Text = screen.Name + ". Press escape.";

            screens.Add(screen);
        }

        private static void SingleBorderTextBoxScreen(ScreenCollection screens)
        {
            var screen = new Screen("Single Border Text Boxes");

            var control1 = new TextBox();

            control1.Left = 10;
            control1.Top = 0;
            control1.MaxLength = 5;
            control1.Width = control1.MaxLength;
            control1.BorderStyle = BorderStyle.Single;

            var control2 = new TextBox();

            control2.Left = 0;
            control2.Top = control1.Top + control1.Height;
            control2.Width = screen.Width;
            control2.BorderStyle = BorderStyle.Single;

            var control3 = new TextBox();

            control3.Left = 0;
            control3.Top = control2.Top + control2.Height;
            control3.MaxLength = 20;
            control3.Width = control3.MaxLength;
            control3.BorderStyle = BorderStyle.Single;
            control3.TextAlign = TextAlign.Center;

            screen.Controls.Add(control1);
            screen.Controls.Add(control2);
            screen.Controls.Add(control3);

            screen.Footer.Text = screen.Name + ". Press escape.";

            screens.Add(screen);
        }
    }
}