using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using StrawberryShake;
using StrawberryShake.Configuration;
using StrawberryShake.Http;
using StrawberryShake.Http.Subscriptions;
using StrawberryShake.Transport;

namespace DotNetGraphQL.Mobile
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public class GetAllDogsResultParser
        : JsonResultParserBase<IGetAllDogs>
    {
        private readonly IValueSerializer _stringSerializer;
        private readonly IValueSerializer _dateTimeSerializer;

        public GetAllDogsResultParser(IValueSerializerCollection serializerResolver)
        {
            if (serializerResolver is null)
            {
                throw new ArgumentNullException(nameof(serializerResolver));
            }
            _stringSerializer = serializerResolver.Get("String");
            _dateTimeSerializer = serializerResolver.Get("DateTime");
        }

        protected override IGetAllDogs ParserData(JsonElement data)
        {
            return new GetAllDogs
            (
                ParseGetAllDogsDogs(data, "dogs")
            );

        }

        private IReadOnlyList<IDogImage> ParseGetAllDogsDogs(
            JsonElement parent,
            string field)
        {
            JsonElement obj = parent.GetProperty(field);

            int objLength = obj.GetArrayLength();
            var list = new IDogImage[objLength];
            for (int objIndex = 0; objIndex < objLength; objIndex++)
            {
                JsonElement element = obj[objIndex];
                list[objIndex] = new DogImage
                (
                    DeserializeString(element, "avatarUrl"),
                    DeserializeNullableDateTime(element, "birthDate"),
                    DeserializeString(element, "breed"),
                    DeserializeString(element, "coatColor"),
                    DeserializeListOfString(element, "imagesList"),
                    DeserializeString(element, "title"),
                    DeserializeString(element, "websiteUrl")
                );

            }

            return list;
        }

        private string DeserializeString(JsonElement obj, string fieldName)
        {
            JsonElement value = obj.GetProperty(fieldName);
            return (string)_stringSerializer.Deserialize(value.GetString())!;
        }

        private System.DateTimeOffset? DeserializeNullableDateTime(JsonElement obj, string fieldName)
        {
            if (!obj.TryGetProperty(fieldName, out JsonElement value))
            {
                return null;
            }

            if (value.ValueKind == JsonValueKind.Null)
            {
                return null;
            }

            return (System.DateTimeOffset?)_dateTimeSerializer.Deserialize(value.GetString())!;
        }

        private IReadOnlyList<string> DeserializeListOfString(JsonElement obj, string fieldName)
        {
            JsonElement list = obj.GetProperty(fieldName);
            int listLength = list.GetArrayLength();
            var listList = new string[listLength];

            for (int i = 0; i < listLength; i++)
            {
                JsonElement element = list[i];
                listList[i] = (string)_stringSerializer.Deserialize(element.GetString())!;
            }
            return listList;
        }
    }
}
