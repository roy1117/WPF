using System;
using System.ComponentModel;

namespace Model
{

	public class Person :INotifyPropertyChanged
	{ 
		public event PropertyChangedEventHandler PropertyChanged;

		private string _firstname;
		private string _lastname;
		private string _fullname;

		public string Firstname
		{
			get { return _firstname; }
			set
			{
				_firstname = value;
				Fullname = _firstname + _lastname;
				OnPropertyRaised("Firstname");
			}
		}

		public string Lastname
		{
			get { return _lastname; }
			set
			{
				_lastname = value;
				Fullname = _firstname + _lastname;
				OnPropertyRaised("Lastname");
			}
		}

		public string Fullname
		{
			get 
			{
				return _fullname;
			}

			set
			{
				_fullname = value;
				OnPropertyRaised("Fullname");
			}
		}

		private void OnPropertyRaised(string propertyname)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
			}
		}

		public Person()
		{
		}
	}
}

