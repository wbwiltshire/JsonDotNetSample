using System.Runtime.Serialization;

namespace EFDatabaseFirst.Data.POCOState
{
    //Used by the regular POCOs
    [DataContract(Name="StateObject", IsReference = true)]
    public class StateObject
    {
        [DataMember(Order = 0)]
        public ObjectState ObjectState { get; set; }
    }

    //Used by the Base POCOs for Json purposes
    public class BaseStateObject
    {
        [DataMember(Order = 0)]
        public ObjectState ObjectState { get; set; }
    }
}
