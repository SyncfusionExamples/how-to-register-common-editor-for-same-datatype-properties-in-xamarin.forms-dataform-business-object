using Syncfusion.XForms.DataForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace RegisterCommonEditor
{
    public class DayHours : INotifyPropertyChanged
    {
        private int startHour;
        private int startMinutes;

        [Display(Name = "Start Hour")]
        public int StartHour
        {
            get
            {
                return startHour;
            }
            set
            {
                startHour = value;
                RaisePropertyChanged("StartHour");
            }
        }
        public int StartMinutes
        {
            get
            {
                return startMinutes;
            }
            set
            {
                startMinutes = value;
                RaisePropertyChanged("StartMinutes");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(String Name)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(Name));
        }
    }

}
