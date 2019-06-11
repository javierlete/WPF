using MVVMDemo.Model;
using System;
using System.Collections.ObjectModel;

namespace MVVMDemo.ViewModel
{

    public class StudentViewModel
    {
        private Student _selectedStudent;

        public MyICommand DeleteCommand { get; set; }

        public StudentViewModel()
        {
            LoadStudents();
            DeleteCommand = new MyICommand(OnDelete, CanDelete);
        }

        private bool CanDelete()
        {
            return SelectedStudent != null;
        }

        private void OnDelete()
        {
            Students.Remove(SelectedStudent);
        }

        public ObservableCollection<Student> Students
        {
            get;
            set;
        }

        public Student SelectedStudent
        {
            get { return _selectedStudent; }
            set
            {
                _selectedStudent = value;
                DeleteCommand.RaiseCanExecuteChanged();
            }
        }

        public void LoadStudents()
        {
            ObservableCollection<Student> students = new ObservableCollection<Student>
            {
                new Student { FirstName = "Mark", LastName = "Allain" },
                new Student { FirstName = "Allen", LastName = "Brown" },
                new Student { FirstName = "Linda", LastName = "Hamerski" }
            };

            Students = students;
        }
    }
}