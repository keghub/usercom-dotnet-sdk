using NUnit.Framework;
using UserCom.Model.Users.Requests;

namespace Tests.UserCom.Serialization;

[TestFixture]
public class UpdateOrCreateUserRequestSerializationTests
{
    [TestFixture]
    public class FirstNameSerializationTests : StringValueMaxLengthConverterTestBase<UpdateOrCreateUserRequest>
    {
        protected override string GetJsonStr(string value) => $"{{\"first_name\":\"{value}\"}}";

        protected override int MaxLength => 40;

        protected override string GetValue(UpdateOrCreateUserRequest obj) => obj.FirstName;

        protected override UpdateOrCreateUserRequest CreateObj(string value) => new() { FirstName = value };
    }

    [TestFixture]
    public class LastNameSerializationTests : StringValueMaxLengthConverterTestBase<UpdateOrCreateUserRequest>
    {
        protected override string GetJsonStr(string value) => $"{{\"last_name\":\"{value}\"}}";

        protected override int MaxLength => 40;

        protected override string GetValue(UpdateOrCreateUserRequest obj) => obj.LastName;

        protected override UpdateOrCreateUserRequest CreateObj(string value) => new() { LastName = value };
    }

    [TestFixture]
    public class CitySerializationTests : StringValueMaxLengthConverterTestBase<UpdateOrCreateUserRequest>
    {
        protected override string GetJsonStr(string value) => $"{{\"city\":\"{value}\"}}";

        protected override int MaxLength => 64;

        protected override string GetValue(UpdateOrCreateUserRequest obj) => obj.City;

        protected override UpdateOrCreateUserRequest CreateObj(string value) => new() { City = value };
    }

    [TestFixture]
    public class PhoneNumberSerializationTests : StringValueMaxLengthConverterTestBase<UpdateOrCreateUserRequest>
    {
        protected override string GetJsonStr(string value) => $"{{\"phone_number\":\"{value}\"}}";

        protected override int MaxLength => 64;

        protected override string GetValue(UpdateOrCreateUserRequest obj) => obj.PhoneNumber;

        protected override UpdateOrCreateUserRequest CreateObj(string value) => new() { PhoneNumber = value };
    }
}