using System;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Collections.Generic;
using GolfNow.Mobile.Models.DataContracts;


namespace GolfNow.Mobile.Business
{
    public abstract class AbstractJsonConverter<T> : JsonConverter
    {
        protected abstract T Create(Type objectType, JObject jObject);

        public override bool CanConvert(Type objectType)
        {
//            return typeof(T).IsAssignableFrom(objectType);
            return true;
        }

        public override object ReadJson(
            JsonReader reader, 
            Type objectType, 
            object existingValue, 
            JsonSerializer serializer)
        {
            var jObject = JObject.Load(reader);

            T target = Create(objectType, jObject);
            serializer.Populate(jObject.CreateReader(), target);

            return target;
        }

        public override void WriteJson(
            JsonWriter writer, 
            object value, 
            JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        protected static bool FieldExists(
            JObject jObject, 
            string name, 
            JTokenType type)
        {
            JToken token;
            return jObject.TryGetValue(name, out token) && token.Type == type;
        }
    }

    public class SavedPaymentConverter : AbstractJsonConverter<SavedPaymentInfo>
    {
        protected override SavedPaymentInfo Create(Type objectType, JObject jObject)
        {
            if (FieldExists(jObject, "MaskedCreditCardNumber", JTokenType.String))
                return new SavedCreditCardInfo();

            if (FieldExists(jObject, "CurrentBalance", JTokenType.Boolean))
                return new AccountBalanceRemaining();

            throw new InvalidOperationException();
        }
    }
}