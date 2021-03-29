

namespace Reflection.Models
{

    using System;



    public class Employee
    {
        private Guid _employeeID;
        private string _firstName;
        private string _lastName;
        private string _address;
        private string _gender;
        private string _maritalStatus;
        private DateTime _dateHired;
        private DateTime _dateResigned;
        private DateTime _DateCreated;
        private DateTime _DateModified;
        private Guid _CreatedBy;
        private Guid _ModifiedBy;

        public Employee() { }

        public Guid EmployeeID
        {
            get { return _employeeID; }
            set { _employeeID = value; }
        }
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public string MaritalStatus
        {
            get { return _maritalStatus; }
            set { _maritalStatus = value; }
        }
        public DateTime DateHired
        {
            get { return _dateHired; }
            set { _dateHired = value; }
        }
        public DateTime DateResigned
        {
            get { return _dateResigned; }
            set { _dateResigned = value; }
        }
        public DateTime DateCreated
        {
            get { return _DateCreated; }
            set { _DateCreated = value; }
        }
        public DateTime DateModified
        {
            get { return _DateModified; }
            set { _DateModified = value; }
        }
        public Guid CreatedBy
        {
            get { return _CreatedBy; }
            set { _CreatedBy = value; }
        }
        public Guid ModifiedBy
        {
            get { return _ModifiedBy; }
            set { _ModifiedBy = value; }
        }
    }
}
