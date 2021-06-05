using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace checkers_game.ViewModels
{
    public class GameVM
    {   
        
        
            public GameVM()
            {

                string imagePath = "C:\\Users\\Gabi\\Desktop\\Checkers\\WPF-Checkers-master\\checkers_game\\Images\\negru.jpeg";
                this.ImageSource = new BitmapImage(new Uri(imagePath, UriKind.Absolute));
            }


            private BitmapImage _ImageSource;
            public BitmapImage ImageSource
            {
                get { return this._ImageSource; }
                set { this._ImageSource = value; 
                this.OnPropertyChanged("ImageSource"); }
            }

            private void OnPropertyChanged(string v)
            {
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(v));
            }
            public event PropertyChangedEventHandler PropertyChanged;
        }
    }

