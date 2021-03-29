


namespace Reflection.Models
{

    using System;

    public class Asset
    {
        private Guid _AssetID;
        private string _Name;
        private string _AssetNo;
        private string _Description;
        private DateTime _DateCreated;
        private DateTime _DateModified;
        private Guid _CreatedBy;
        private Guid _ModifiedBy;

        public Asset() { }

        public Guid AssetID
        {
            get { return _AssetID; }
            set { _AssetID = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string AssetNo
        {
            get { return _AssetNo; }
            set { _AssetNo = value; }
        }
        public string Descriptioin
        {
            get { return _Description; }
            set { _Description = value; }
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
