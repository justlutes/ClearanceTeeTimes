using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Models.DataContracts
{
    [DataContract]
    public class Money
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Money" /> class.
        /// </summary>
        /// <param name="currencyCode">The currency code of the value.</param>
        /// <param name="value">The value of money.</param>
        public Money(string currencyCode, decimal value)
        {
            CurrencyCode = currencyCode;
            Value = value;
        }

        /// <summary>
        /// Gets or sets the currency code.
        /// </summary>
        /// <value>
        /// The currency code.
        /// </value>
        [DataMember]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or sets the value component.
        /// </summary>
        [DataMember]
        public decimal Value
        {
            get;
            set;
        }

        public static implicit operator decimal(Money instance)
        {
            if (instance != null)
            {
                return instance.Value;
            }
            else
            {
                return 0M;
            }
        }

        public static bool operator ==(Money a, Money b)
        {
            if (object.ReferenceEquals(a, null) ^ object.ReferenceEquals(b, null))
            {
                return false;
            }
            else if (object.ReferenceEquals(a, null) && object.ReferenceEquals(b, null))
            {
                return true;
            }
            else
            {
                return a.Value == b.Value;
            }
        }

        public static bool operator !=(Money a, Money b)
        {
            return !(a == b);
        }

        public override string ToString()
        {
            return this.Value.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj is Money)
            {
                Money _moneyobj = obj as Money;
                return this.Value == _moneyobj.Value;
            }
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return this.Value.GetHashCode();
        }
    }
}
