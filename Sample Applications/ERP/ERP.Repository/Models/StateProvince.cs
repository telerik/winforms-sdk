namespace ERP.Repository.Service
{
    public partial class StateProvince
    {
        [EntityNotSerializableAttribute]
        public string FullName
        {
            get
            {
                return string.Format("{0} - {1}", this.Name, this.CountryRegion.Name);
            }
        }
    }
}
