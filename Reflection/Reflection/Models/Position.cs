

namespace Reflection.Models
{


    using System;


    public class Position
    {
        private Guid _positionID;
        private string _title;
        private string _titleDescription;
        private DateTime _DateCreated;
        private DateTime _DateModified;
        private Guid _CreatedBy;
        private Guid _ModifiedBy;

        public Position() { }

        public Guid PositionID
        {
            get { return _positionID; }
            set { _positionID = value; }
        }
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public string TitleDescription
        {
            get { return _titleDescription; }
            set { _titleDescription = value; }
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
