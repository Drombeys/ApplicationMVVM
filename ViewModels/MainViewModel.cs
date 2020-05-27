using ApplicationMVVM.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace ApplicationMVVM.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<TablePatterns> TablePatterns { get; set; } = new ObservableCollection<TablePatterns>();

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
            TablePatterns.Add(new TablePatterns()
            {
                Name = "MVP",
                Description = "asdasd",
                Author = "asd",
                Released = 2015
            });

        }

        private RelayCommand btnOk;
        public RelayCommand BtnOk => btnOk ??
                    (btnOk = new RelayCommand(obj =>
                    {
                        TablePatterns.Add(new TablePatterns()
                        {
                            Name = Name,
                            Description = Description,
                            Author = Author,
                            Released = Released
                        });
                    }, (obj) => Released > 1940 && !string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(Description)));

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "") => 
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}
