using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace RegisterCommonEditor
{
    public class ViewModel : INotifyPropertyChanged
    {
        private DayHours dayHours;
        #region Properties

        public DayHours Hours
        {
            get { return dayHours; }
            set { dayHours = value; }
        }

        #endregion

        #region Constructor

        public ViewModel()
        {
            dayHours = new DayHours();
        }

        #endregion

        #region intreface member

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        #endregion      
    }

}
