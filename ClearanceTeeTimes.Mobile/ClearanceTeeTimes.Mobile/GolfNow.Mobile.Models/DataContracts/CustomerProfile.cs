using System;
using System.Runtime.Serialization;
using GolfNow.Mobile.Models.Enumerations;

namespace GolfNow.Mobile.Models.DataContracts
{
    // TODO: Technical Debt - There is a lot of information in here.  Can some of this be parsed out and moved into a CustomerProfileDetails class?

    /// <summary>
    /// A data contract for a customer profile.
    /// </summary>
    [DataContract]
    [KnownType(typeof(CustomerProfileResponse))]
    public class CustomerProfile
    {
        private PreferredTeeTimeRange[] _preferredteetimes;

        /// <summary>
        /// Gets or sets the customer's email address.
        /// </summary>
        [DataMember]
        public string EMailAddress
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the customer's user name for use with ratings and reviews.
        /// </summary>
        [DataMember]
        public string UserName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the customer's first name.
        /// </summary>
        [DataMember]
        public string FirstName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the customer's last name.
        /// </summary>
        [DataMember]
        public string LastName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the customer's address.
        /// </summary>
        [DataMember]
        public Address Address
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the customer's date of birth.
        /// </summary>
        /// <remarks>
        /// If date is not specified in local time, it is converted to UTC.
        /// </remarks>
        [IgnoreDataMember]
        public DateTime? DateOfBirth
        {
            get;
            set;
        }

        /// <summary>
        /// The formatted date of birth, for serialization purposes
        /// </summary>
        [DataMember(Name = "DateOfBirth")]
        private string DateOfBirthFormatted
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the customer's phone number.
        /// </summary>
        [DataMember]
        public string PhoneNumber
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the customer's experience level.
        /// </summary>
        public UserExperienceLevel? Level
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the integer value of Level used for serialization.
        /// </summary>
        [DataMember(Name = "Level")]
        private int? LevelInt
        {
            get
            {
                return (int?)Level;
            }
            set
            {
                Level = value.HasValue ? (UserExperienceLevel?)value.Value : (UserExperienceLevel?)null;
            }
        }

        /// <summary>
        /// Gets or sets the customer's handicap.
        /// </summary>
        [DataMember]
        public string Handicap1
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the customer's user type.
        /// </summary>
        public UserType[] Type
        {
            get;
            set;
        }



        /// <summary>
        /// Gets or sets the integer value of Type used for serialization.
        /// </summary>
        //[DataMember(Name = "Type")]
        //private int[] TypeInt
        //{
        //    get
        //    {

        //        if (Type != null)
        //        {

        //            foreach (UserType a in Type)
        //            {



        //            }

        //        }
        //        return

        //            Array.ConvertAll<UserType, int>(Type ?? new UserType[] { }, a => (int)a);
        //    }
        //    set
        //    {
        //        Type = Array.ConvertAll<int, UserType>(value ?? new int[] { }, a => (UserType)a.ConvertIntToEnum<UserType>("Type"));
        //    }
        //}


        /// <summary>
        /// Gets or sets the customer's preference for number of holes to play.
        /// </summary>
        [DataMember]
        public int? HolesPreferred
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating if the customer prefers a cart.
        /// </summary>
        public CartPreferred? CartPreferred
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the integer value of cart preferred used for serialization.
        /// </summary>
        [DataMember(Name = "CartPreferred")]
        private int? CartPreferredInt
        {
            get
            {
                return (int?)CartPreferred;
            }
            set
            {
                CartPreferred = value.HasValue ? (CartPreferred?)value.Value : (CartPreferred?)null;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating if the customer prefers to be contacted by email.
        /// </summary>
        [DataMember]
        public bool? EmailPreferred
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the customer's preferred tee times.
        /// </summary>
        [DataMember]
        public PreferredTeeTimeRange[] PreferredTeeTimes
        {
            get
            {
                if (_preferredteetimes == null)
                {
                    _preferredteetimes = new PreferredTeeTimeRange[] { };
                }
                return _preferredteetimes;
            }
            set
            {
                _preferredteetimes = value;
            }
        }

        /// <summary>
        /// Gets or sets the customer's preference for golf balls.
        /// </summary>
        [DataMember]
        public string GolfBalls
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the putter the customer uses.
        /// </summary>
        [DataMember]
        public string Putter
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the customer's preferred shoe brand.
        /// </summary>
        [DataMember]
        public string ShoeBrand
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the customer's preferred shoe size.
        /// </summary>
        [DataMember]
        public string ShoeSize
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the customer's preferred vendor for woods.
        /// </summary>
        [DataMember]
        public string Woods
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the customer's preferred vendor for irons.
        /// </summary>
        [DataMember]
        public string Irons
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating the number of rounds of golf a customer plays in a month.
        /// </summary>
        [DataMember]
        public string RoundsMonth
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the customer's preferred vendor for shirts.
        /// </summary>
        [DataMember]
        public string ShirtBrand
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the customer's shirt size.
        /// </summary>
        [DataMember]
        public string ShirtSize
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the customer's gender.
        /// </summary>
        public Gender? Gender
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the integer value of Gender used for serialization.
        /// </summary>
        [DataMember(Name = "Gender")]
        private int? GenderInt
        {
            get
            {
                return (int?)Gender;
            }
            set
            {
                Gender = value.HasValue ? (Gender?)value.Value : (Gender?)null;
            }
        }

        /// <summary>
        /// Formats the date of birth for serialization
        /// </summary>
        [OnSerializing]
        private void OnSerializing(StreamingContext context)
        {
            if (this.DateOfBirth.HasValue && this.DateOfBirth.Value != DateTime.MinValue)
            {
                this.DateOfBirthFormatted = this.DateOfBirth.Value.ToString("yyyy-MM-ddTHH:mm:ss");
            }
        }

        /// <summary>
        /// Gets the date of birth from the string property and sets the date property after deserialization
        /// </summary>
        [OnDeserialized]
        void OnDeserialized(StreamingContext context)
        {
            this.DateOfBirth = this.DateOfBirthFormatted.ToDateTime();
        }

        public CustomerProfile Clone()
        {
            return new CustomerProfile()
            {
                Address = this.Address,
                CartPreferred = this.CartPreferred,
                EMailAddress = this.EMailAddress,
                DateOfBirth = this.DateOfBirth,
                EmailPreferred = this.EmailPreferred,
                FirstName = this.FirstName,
                Gender = this.Gender,
                GolfBalls = this.GolfBalls,
                Handicap1 = this.Handicap1,
                HolesPreferred = this.HolesPreferred,
                Irons = this.Irons,
                LastName = this.LastName,
                Level = this.Level,
                PhoneNumber = this.PhoneNumber,
                PreferredTeeTimes = this.PreferredTeeTimes,
                Putter = this.Putter,
                RoundsMonth = this.RoundsMonth,
                ShirtBrand = this.ShirtBrand,
                ShirtSize = this.ShirtSize,
                ShoeBrand = this.ShoeBrand,
                Type = this.Type,
                ShoeSize = this.ShoeSize,
                UserName = this.UserName,
                Woods = this.Woods
            };
        }
    }
}
