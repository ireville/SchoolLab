﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SchoolLab_3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TimetablePage : ContentPage
    {
        public TimetablePage()
        {
            InitializeComponent();

            TimeTablePhoto.Source = ImageSource.FromResource("SchoolLab_3.TimeTablePhoto.jpg");
        }
    }
}