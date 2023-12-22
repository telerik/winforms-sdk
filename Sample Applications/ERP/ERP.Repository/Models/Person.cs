namespace ERP.Repository.Service
{
    public partial class Person
    {
        [EntityNotSerializableAttribute]
        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", this.FirstName, this.LastName);
            }
        }

        public override string ToString()
        {
            return this.FullName;
        }
    }
}
