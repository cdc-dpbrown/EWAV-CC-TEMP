﻿using System.ComponentModel;

namespace EWAV
{



    public class UserListInfo : INotifyPropertyChanged
    {
        private string firstName;
        private bool isSelected;
        private string lastName;
        private int userId;
        public UserListInfo(bool isSelected, string firstName, string lastName, int userId)
        {
            this.IsSelected = isSelected;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.UserId = userId;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
                OnPropertyChanged("FirstName");
            }
        }
        public bool IsSelected
        {
            get
            {
                return isSelected;
            }
            set
            {
                isSelected = value;
                OnPropertyChanged("IsSelected");
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
                OnPropertyChanged("LastName");
            }
        }
        public int UserId
        {
            get
            {
                return userId;
            }
            set
            {
                userId = value;
                OnPropertyChanged("UserID");
            }
        }
        private void OnPropertyChanged(string p)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(p));
            }
        }
    }
}