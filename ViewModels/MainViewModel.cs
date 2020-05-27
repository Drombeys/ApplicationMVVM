﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ApplicationMVVM.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                OnPropertyChanged("Description");
            }
        }

        private string author;
        public string Author
        {
            get { return author; }
            set
            {
                author = value;
                OnPropertyChanged("Author");
            }
        }

        private int released;
        public int Released
        {
            get { return released; }
            set
            {
                released = value;
                OnPropertyChanged("Released");
            }
        }

        public MainViewModel()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "") => 
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}