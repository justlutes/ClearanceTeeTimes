using System.Runtime.Serialization;

//using GolfNow.API.Documentation.Business;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// An abstraction point for optional properties of return contracts.
    /// </summary>
    [DataContract]
    //[Documentable()]
    public class Expandable<T> where T : class
    {
        private T _value;

        public Expandable()
        {
            _value = null;
            Expanded = false;
        }

        /// <summary>
        /// Gets a value indicating whether or not the value property was set.
        /// </summary>
        [DataMember]
        public bool Expanded
        {
            get;
            internal set;
        }

        /// <summary>
        /// Gets the underlying value of the Expandable iff it has been Expanded.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public T Value
        {
            get
            {
                if (Expanded)
                {
                    return _value;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                Expanded = true;
                _value = value;
            }
        }

        //public static FriendlyType CreateFriendlyType()
        //{
        //    FriendlyType ft = FriendlyType.FromType(typeof(T));
        //    return ft;
        //}

        public override string ToString()
        {
            if (!this.Expanded)
            {
                return "Not Expanded";
            }
            else if (this.Value == null)
            {
                return "null";
            }
            else
            {
                return this.Value.ToString();
            }

        }

    }

    /// <summary>
    /// Provides a set of utilities for using the Expandable(of T).
    /// </summary>
    public static class Expandable
    {
        /// <summary>
        /// Creates a new instance of an Expandable(of T) and loads the specified value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Expandable<T> Create<T>(T value) where T : class
        {
            Expandable<T> val = new Expandable<T>();
            val.Value = value;
            return val;
        }
    }
}
