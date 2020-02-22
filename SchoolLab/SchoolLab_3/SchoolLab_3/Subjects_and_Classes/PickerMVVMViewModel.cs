using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Library;
using Xamarin.Forms;
using System.Linq;
using System.Text;

namespace SchoolLab_3
{
    public class PickerMVVMViewModel : INotifyPropertyChanged
    {
        public List<Mark> MarksList { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        string pickerName = null;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            // pickerName = name;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        // Выбранная оценка.
        private Mark selectedMark;
        public Mark SelectedMark
        {
            get { return selectedMark; }

            set {
                if (selectedMark != value)
                {
                    selectedMark = value;
                    MyMark = selectedMark.Value;
                }
            }
        }

        // Текущая оценка.
        private string myMark = "-";
        public string MyMark
        {
            get {
                myMark = General.marks[0];
                return myMark;
            }

            set {
                if (myMark != value)
                {
                    myMark = value;
                    // General.marks[0] = myMark;
                    OnPropertyChanged();
                }
            }
        }

        public string this[int index1, int index2]
        {
            get {
                return $"index1";
            }
            set {

            }
        }


        public PickerMVVMViewModel()
        {
            MarksList = GetMark();
        }


        /// <summary>
        /// Список оценок для выбора.
        /// </summary>
        public List<Mark> GetMark()
        {
            var marks = new List<Mark>()
            {
                new Mark(){Key = 1, Value = "1"},
                new Mark(){Key = 2, Value = "2"},
                new Mark(){Key = 3, Value = "3"},
                new Mark(){Key = 4, Value = "4"},
                new Mark(){Key = 5, Value = "5"},
                new Mark(){Key = 6, Value = "н"},
            };

            return marks;
        }

        public void GetAndChangeNowPicker(Picker pick)
        {
            string pickName = pick.AutomationId;
            int[] indexes = ParsePickerName(pickName);

            pick.Title = General._8_B_R_marks[indexes[0], indexes[1]];

        }

        public int[] ParsePickerName(string name)
        {
            string[] words = name.Split('_');
            int[] nums = new int[2]
                {
                    int.Parse(words[1]),
                    int.Parse(words[2])
                };
            return nums;
        }
    }

    /// <summary>
    /// Оценка: id и значение.
    /// </summary>
    public class Mark
    {
        public int Key { get; set; }
        public string Value { get; set; }
    }
}
