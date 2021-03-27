using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DeleteCatElementWPF.Models
{
    public class CatModel : INotifyPropertyChanged
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value;
                OnPropertyChanged("Id");
            }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value;
                OnPropertyChanged("Name");
            }
        }

        private string _imgUrl;

        public string ImgUrl
        {
            get { return _imgUrl; }
            set { _imgUrl = value;
                OnPropertyChanged("ImgUrl");
            }
        }

        private DateTime _birthday;

        public DateTime Birthday
        {
            get { return _birthday; }
            set { _birthday = value;
                OnPropertyChanged("Birthday");
            }
        }




        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string prop) 
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
