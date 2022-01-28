﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ЗаданиеWpf8
{
    class MyCommand
    {
        public static RoutedUICommand Exit { get; set; }

        static MyCommand()
        {
            InputGestureCollection inputs = new InputGestureCollection();
            inputs.Add(new KeyGesture(Key.T, ModifierKeys.Control, "CTrl+T"));
            Exit = new RoutedUICommand("Выход", "Exit", typeof(MyCommand), inputs);
        }
    }
}
