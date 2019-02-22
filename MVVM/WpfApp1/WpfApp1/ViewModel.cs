using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    class ViewModel:INotifyPropertyChanged
    {
        Model Obj_Model = Model.Instance;
        string name;
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }

        public string textName
        {
            get
            {               
                if(!string.IsNullOrEmpty(name))
                {
                    //MessageBox.Show(name);
                    Obj_Model.m_name = name;
                }
                return name;
            }
            set
            {
                name = value; OnPropertyChanged("textName");
            }
        }
    }
}
