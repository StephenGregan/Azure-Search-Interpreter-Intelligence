// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using ConsoleAppInterpreterIntelligence;
//
//    var welcome = Welcome.FromJson(jsonString);

namespace ConsoleAppInterpreterIntelligence
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Welcome
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("versionValue")]
        public long VersionValue { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("lastModifiedBy")]
        public string LastModifiedBy { get; set; }

        [JsonProperty("lastModifiedDate")]
        public string LastModifiedDate { get; set; }

        [JsonProperty("company.id")]
        public long CompanyId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("salutation")]
        public string Salutation { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("nickName")]
        public string NickName { get; set; }

        [JsonProperty("suffix")]
        public string Suffix { get; set; }

        [JsonProperty("gender.id")]
        public long GenderId { get; set; }

        [JsonProperty("businessUnit.id")]
        public string BusinessUnitId { get; set; }

        [JsonProperty("dateOfBirth")]
        public string DateOfBirth { get; set; }

        [JsonProperty("contactTypes")]
        public Status[] ContactTypes { get; set; }

        [JsonProperty("accountingReference")]
        public string AccountingReference { get; set; }

        [JsonProperty("referenceId")]
        public string ReferenceId { get; set; }

        [JsonProperty("languageMappings")]
        public LanguageMapping[] LanguageMappings { get; set; }

        [JsonProperty("primaryNumber")]
        public Number PrimaryNumber { get; set; }

        [JsonProperty("numbers")]
        public Number[] Numbers { get; set; }

        [JsonProperty("primaryAddress")]
        public Address PrimaryAddress { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }

        [JsonProperty("addresses")]
        public Address[] Addresses { get; set; }

        [JsonProperty("primaryEmail")]
        public Email PrimaryEmail { get; set; }

        [JsonProperty("emails")]
        public Email[] Emails { get; set; }

        [JsonProperty("qualifications")]
        public Eligibility[] Qualifications { get; set; }

        [JsonProperty("eligibilities")]
        public Eligibility[] Eligibilities { get; set; }

        [JsonProperty("criteriaHierarchy")]
        public object[] CriteriaHierarchy { get; set; }

        [JsonProperty("hasTransportation")]
        public bool HasTransportation { get; set; }

        [JsonProperty("hasChildren")]
        public bool HasChildren { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("companyName")]
        public object CompanyName { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("region")]
        public object Region { get; set; }

        [JsonProperty("countryOfOrigin")]
        public string CountryOfOrigin { get; set; }

        [JsonProperty("countryOfResidence")]
        public string CountryOfResidence { get; set; }

        [JsonProperty("countryOfNationality")]
        public object CountryOfNationality { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("activeNote")]
        public string ActiveNote { get; set; }

        [JsonProperty("availability")]
        public string Availability { get; set; }

        [JsonProperty("experience")]
        public string Experience { get; set; }

        [JsonProperty("registeredTaxId")]
        public string RegisteredTaxId { get; set; }

        [JsonProperty("bankAccount")]
        public string BankAccount { get; set; }

        [JsonProperty("sortCode")]
        public string SortCode { get; set; }

        [JsonProperty("iban")]
        public string Iban { get; set; }

        [JsonProperty("swift")]
        public string Swift { get; set; }

        [JsonProperty("eft.id")]
        public string EftId { get; set; }

        [JsonProperty("eft.name")]
        public string EftName { get; set; }

        [JsonProperty("paymentMethod.id")]
        public long PaymentMethodId { get; set; }

        [JsonProperty("paymentMethod.name")]
        public string PaymentMethodName { get; set; }

        [JsonProperty("paymentAccount")]
        public object PaymentAccount { get; set; }

        [JsonProperty("registeredTax")]
        public bool RegisteredTax { get; set; }

        [JsonProperty("registeredTaxIdDescription")]
        public string RegisteredTaxIdDescription { get; set; }

        [JsonProperty("employmentCategory.id")]
        public long EmploymentCategoryId { get; set; }

        [JsonProperty("assignmentTier.id")]
        public long AssignmentTierId { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }

        [JsonProperty("ethnicity")]
        public string Ethnicity { get; set; }

        [JsonProperty("document")]
        public object Document { get; set; }

        [JsonProperty("imagePath")]
        public string ImagePath { get; set; }

        [JsonProperty("outOfOffice")]
        public bool OutOfOffice { get; set; }

        [JsonProperty("disableUpcomingReminder")]
        public bool DisableUpcomingReminder { get; set; }

        [JsonProperty("disableCloseReminder")]
        public bool DisableCloseReminder { get; set; }

        [JsonProperty("disableConfirmReminder")]
        public bool DisableConfirmReminder { get; set; }

        [JsonProperty("bankAccountDescription")]
        public object BankAccountDescription { get; set; }

        [JsonProperty("timeWorked")]
        public string TimeWorked { get; set; }

        [JsonProperty("activationDate")]
        public object ActivationDate { get; set; }

        [JsonProperty("originalStartDate")]
        public object OriginalStartDate { get; set; }

        [JsonProperty("datePhotoSentToPrinter")]
        public object DatePhotoSentToPrinter { get; set; }

        [JsonProperty("datePhotoSentToInterpreter")]
        public object DatePhotoSentToInterpreter { get; set; }

        [JsonProperty("inductionDate")]
        public object InductionDate { get; set; }

        [JsonProperty("reActivationDate")]
        public object ReActivationDate { get; set; }

        [JsonProperty("iolNrcpdNumber")]
        public object IolNrcpdNumber { get; set; }

        [JsonProperty("referralSource")]
        public object ReferralSource { get; set; }

        [JsonProperty("refereeSourceName")]
        public object RefereeSourceName { get; set; }

        [JsonProperty("recruiterName")]
        public object RecruiterName { get; set; }

        [JsonProperty("taleoId")]
        public object TaleoId { get; set; }

        [JsonProperty("bankAccountReference")]
        public object BankAccountReference { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }

        [JsonProperty("disableConfirmationEmails")]
        public bool DisableConfirmationEmails { get; set; }

        [JsonProperty("disableOfferEmails")]
        public bool DisableOfferEmails { get; set; }

        [JsonProperty("disableAutoOffers")]
        public bool DisableAutoOffers { get; set; }

        [JsonProperty("currencyCode.id")]
        public string CurrencyCodeId { get; set; }

        [JsonProperty("currencySymbol")]
        public object CurrencySymbol { get; set; }

        [JsonProperty("bankBranch")]
        public string BankBranch { get; set; }
    }

    public partial class Address
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("client.id")]
        public string ClientId { get; set; }

        [JsonProperty("clientLabel")]
        public object ClientLabel { get; set; }

        [JsonProperty("company.id")]
        public long CompanyId { get; set; }

        [JsonProperty("customer.id")]
        public string CustomerId { get; set; }

        [JsonProperty("customerBilling.id")]
        public string CustomerBillingId { get; set; }

        [JsonProperty("displayLabel")]
        public string DisplayLabel { get; set; }

        [JsonProperty("description")]
        public object Description { get; set; }

        [JsonProperty("notes")]
        public object Notes { get; set; }

        [JsonProperty("addrEntered")]
        public string AddrEntered { get; set; }

        [JsonProperty("addrFormatted")]
        public string AddrFormatted { get; set; }

        [JsonProperty("aptUnit")]
        public object AptUnit { get; set; }

        [JsonProperty("preamble")]
        public object Preamble { get; set; }

        [JsonProperty("street1")]
        public object Street1 { get; set; }

        [JsonProperty("street2")]
        public object Street2 { get; set; }

        [JsonProperty("street3")]
        public object Street3 { get; set; }

        [JsonProperty("cityTown")]
        public object CityTown { get; set; }

        [JsonProperty("stateCounty")]
        public object StateCounty { get; set; }

        [JsonProperty("postalCode")]
        public object PostalCode { get; set; }

        [JsonProperty("country")]
        public object Country { get; set; }

        [JsonProperty("primaryAddress")]
        public bool PrimaryAddress { get; set; }

        [JsonProperty("valid")]
        public bool Valid { get; set; }

        [JsonProperty("validationStatus")]
        public string ValidationStatus { get; set; }

        [JsonProperty("validated")]
        public bool Validated { get; set; }

        [JsonProperty("type.id")]
        public long TypeId { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }

        [JsonProperty("addressPhone")]
        public object AddressPhone { get; set; }

        [JsonProperty("addressFax")]
        public object AddressFax { get; set; }

        [JsonProperty("addressEmail")]
        public object AddressEmail { get; set; }

        [JsonProperty("contactPerson")]
        public object ContactPerson { get; set; }

        [JsonProperty("costCenter")]
        public object CostCenter { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("parent.id")]
        public string ParentId { get; set; }

        [JsonProperty("parent.label")]
        public string ParentLabel { get; set; }

        [JsonProperty("publicNotes")]
        public object PublicNotes { get; set; }

        [JsonProperty("region.id")]
        public string RegionId { get; set; }

        [JsonProperty("billingRegion.id")]
        public string BillingRegionId { get; set; }

        [JsonProperty("costCenterName")]
        public object CostCenterName { get; set; }

        [JsonProperty("timeZone")]
        public object TimeZone { get; set; }
    }

    public partial class Status
    {
        [JsonProperty("class")]
        public Class Class { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("defaultOption")]
        public bool DefaultOption { get; set; }

        [JsonProperty("description")]
        public Description? Description { get; set; }

        [JsonProperty("l10nKey")]
        public object L10NKey { get; set; }

        [JsonProperty("name")]
        public Name Name { get; set; }

        [JsonProperty("nameKey")]
        public NameKey NameKey { get; set; }
    }

    public partial class Eligibility
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("lastModifiedDate")]
        public string LastModifiedDate { get; set; }

        [JsonProperty("lastModifiedBy")]
        public string LastModifiedBy { get; set; }

        [JsonProperty("company.id")]
        public long CompanyId { get; set; }

        [JsonProperty("criteria.id")]
        public long CriteriaId { get; set; }

        [JsonProperty("customerSpecific")]
        public bool? CustomerSpecific { get; set; }

        [JsonProperty("enforcementPolicy")]
        public EnforcementPolicy EnforcementPolicy { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("validated")]
        public bool Validated { get; set; }

        [JsonProperty("validatedStatus")]
        public ValidatedStatus ValidatedStatus { get; set; }

        [JsonProperty("validatedDate")]
        public string ValidatedDate { get; set; }

        [JsonProperty("validatedBy")]
        public string ValidatedBy { get; set; }

        [JsonProperty("validUntil")]
        public ValidUntil ValidUntil { get; set; }

        [JsonProperty("state")]
        public Status State { get; set; }

        [JsonProperty("stateDateSince")]
        public string StateDateSince { get; set; }

        [JsonProperty("stateDateUntil")]
        public StateDateUntil StateDateUntil { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("documents")]
        public object[] Documents { get; set; }

        [JsonProperty("criteriaType")]
        public CriteriaType CriteriaType { get; set; }

        [JsonProperty("language.id")]
        public LanguageId LanguageId { get; set; }

        [JsonProperty("languageLabel")]
        public LanguageId LanguageLabel { get; set; }

        [JsonProperty("languageCode")]
        public LanguageId LanguageCode { get; set; }

        [JsonProperty("supportingInformation")]
        public LanguageId SupportingInformation { get; set; }
    }

    public partial class Email
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("addressVerified")]
        public object AddressVerified { get; set; }

        [JsonProperty("dateVerified")]
        public object DateVerified { get; set; }

        [JsonProperty("primaryEmail")]
        public bool PrimaryEmail { get; set; }

        [JsonProperty("type.id")]
        public long TypeId { get; set; }
    }

    public partial class LanguageMapping
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("contact.id")]
        public long ContactId { get; set; }

        [JsonProperty("language.id")]
        public long LanguageId { get; set; }

        [JsonProperty("language")]
        public Language Language { get; set; }

        [JsonProperty("rating")]
        public string Rating { get; set; }
    }

    public partial class Language
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("alternates")]
        public string Alternates { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("subtag")]
        public string Subtag { get; set; }

        [JsonProperty("iso639_3Tag")]
        public string Iso6393Tag { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("alias")]
        public object Alias { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }

    public partial class Number
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("parsedNumber")]
        public string ParsedNumber { get; set; }

        [JsonProperty("numberFormatted")]
        public object NumberFormatted { get; set; }

        [JsonProperty("countryCode")]
        public object CountryCode { get; set; }

        [JsonProperty("areaCode")]
        public object AreaCode { get; set; }

        [JsonProperty("number")]
        public object NumberNumber { get; set; }

        [JsonProperty("type.id")]
        public long TypeId { get; set; }

        [JsonProperty("primaryNumber")]
        public bool PrimaryNumber { get; set; }
    }

    public enum Class { ComNgsIdModelTypeActiveContactStatus, ComNgsIdModelTypeContactType, ComNgsIdModelTypeEmploymentEligibilityStatus };

    public enum Description { Active, InvalidatedEmploymentEligibility, ValidatedEmploymentEligibility };

    public enum Name { Active, Interpreter, Invalid, Valid };

    public enum NameKey { Active, Interpreter, Invalid, Valid };

    public enum CriteriaType { Criteria, Qualification };

    public enum EnforcementPolicy { Info, Lenient, Strict };

    public enum LanguageId { Empty };

    public enum StateDateUntil { Empty, The190318, The260613, The310315 };

    public enum ValidUntil { Empty, The260613, The310315 };

    public enum ValidatedStatus { Fail, Pass, Warning };

    public partial class Welcome
    {
        public static Welcome FromJson(string json) => JsonConvert.DeserializeObject<Welcome>(json, ConsoleAppInterpreterIntelligence.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Welcome self) => JsonConvert.SerializeObject(self, ConsoleAppInterpreterIntelligence.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                new ValidUntilConverter(),
                new ValidatedStatusConverter(),
                new ClassConverter(),
                new DescriptionConverter(),
                new NameConverter(),
                new NameKeyConverter(),
                new CriteriaTypeConverter(),
                new EnforcementPolicyConverter(),
                new LanguageIdConverter(),
                new StateDateUntilConverter(),
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ValidUntilConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ValidUntil) || t == typeof(ValidUntil?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "":
                    return ValidUntil.Empty;
                case "26/06/13":
                    return ValidUntil.The260613;
                case "31/03/15":
                    return ValidUntil.The310315;
            }
            throw new Exception("Cannot unmarshal type ValidUntil");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ValidUntil)untypedValue;
            switch (value)
            {
                case ValidUntil.Empty:
                    serializer.Serialize(writer, ""); return;
                case ValidUntil.The260613:
                    serializer.Serialize(writer, "26/06/13"); return;
                case ValidUntil.The310315:
                    serializer.Serialize(writer, "31/03/15"); return;
            }
            throw new Exception("Cannot marshal type ValidUntil");
        }
    }

    internal class ValidatedStatusConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ValidatedStatus) || t == typeof(ValidatedStatus?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "fail":
                    return ValidatedStatus.Fail;
                case "pass":
                    return ValidatedStatus.Pass;
                case "warning":
                    return ValidatedStatus.Warning;
            }
            throw new Exception("Cannot unmarshal type ValidatedStatus");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ValidatedStatus)untypedValue;
            switch (value)
            {
                case ValidatedStatus.Fail:
                    serializer.Serialize(writer, "fail"); return;
                case ValidatedStatus.Pass:
                    serializer.Serialize(writer, "pass"); return;
                case ValidatedStatus.Warning:
                    serializer.Serialize(writer, "warning"); return;
            }
            throw new Exception("Cannot marshal type ValidatedStatus");
        }
    }

    internal class ClassConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Class) || t == typeof(Class?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "com.ngs.id.model.type.ActiveContactStatus":
                    return Class.ComNgsIdModelTypeActiveContactStatus;
                case "com.ngs.id.model.type.ContactType":
                    return Class.ComNgsIdModelTypeContactType;
                case "com.ngs.id.model.type.EmploymentEligibilityStatus":
                    return Class.ComNgsIdModelTypeEmploymentEligibilityStatus;
            }
            throw new Exception("Cannot unmarshal type Class");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Class)untypedValue;
            switch (value)
            {
                case Class.ComNgsIdModelTypeActiveContactStatus:
                    serializer.Serialize(writer, "com.ngs.id.model.type.ActiveContactStatus"); return;
                case Class.ComNgsIdModelTypeContactType:
                    serializer.Serialize(writer, "com.ngs.id.model.type.ContactType"); return;
                case Class.ComNgsIdModelTypeEmploymentEligibilityStatus:
                    serializer.Serialize(writer, "com.ngs.id.model.type.EmploymentEligibilityStatus"); return;
            }
            throw new Exception("Cannot marshal type Class");
        }
    }

    internal class DescriptionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Description) || t == typeof(Description?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Active":
                    return Description.Active;
                case "Invalidated employment eligibility":
                    return Description.InvalidatedEmploymentEligibility;
                case "Validated employment eligibility":
                    return Description.ValidatedEmploymentEligibility;
            }
            throw new Exception("Cannot unmarshal type Description");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Description)untypedValue;
            switch (value)
            {
                case Description.Active:
                    serializer.Serialize(writer, "Active"); return;
                case Description.InvalidatedEmploymentEligibility:
                    serializer.Serialize(writer, "Invalidated employment eligibility"); return;
                case Description.ValidatedEmploymentEligibility:
                    serializer.Serialize(writer, "Validated employment eligibility"); return;
            }
            throw new Exception("Cannot marshal type Description");
        }
    }

    internal class NameConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Name) || t == typeof(Name?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Active":
                    return Name.Active;
                case "Interpreter":
                    return Name.Interpreter;
                case "Invalid":
                    return Name.Invalid;
                case "Valid":
                    return Name.Valid;
            }
            throw new Exception("Cannot unmarshal type Name");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Name)untypedValue;
            switch (value)
            {
                case Name.Active:
                    serializer.Serialize(writer, "Active"); return;
                case Name.Interpreter:
                    serializer.Serialize(writer, "Interpreter"); return;
                case Name.Invalid:
                    serializer.Serialize(writer, "Invalid"); return;
                case Name.Valid:
                    serializer.Serialize(writer, "Valid"); return;
            }
            throw new Exception("Cannot marshal type Name");
        }
    }

    internal class NameKeyConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(NameKey) || t == typeof(NameKey?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "active":
                    return NameKey.Active;
                case "interpreter":
                    return NameKey.Interpreter;
                case "invalid":
                    return NameKey.Invalid;
                case "valid":
                    return NameKey.Valid;
            }
            throw new Exception("Cannot unmarshal type NameKey");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (NameKey)untypedValue;
            switch (value)
            {
                case NameKey.Active:
                    serializer.Serialize(writer, "active"); return;
                case NameKey.Interpreter:
                    serializer.Serialize(writer, "interpreter"); return;
                case NameKey.Invalid:
                    serializer.Serialize(writer, "invalid"); return;
                case NameKey.Valid:
                    serializer.Serialize(writer, "valid"); return;
            }
            throw new Exception("Cannot marshal type NameKey");
        }
    }

    internal class CriteriaTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(CriteriaType) || t == typeof(CriteriaType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "criteria":
                    return CriteriaType.Criteria;
                case "qualification":
                    return CriteriaType.Qualification;
            }
            throw new Exception("Cannot unmarshal type CriteriaType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (CriteriaType)untypedValue;
            switch (value)
            {
                case CriteriaType.Criteria:
                    serializer.Serialize(writer, "criteria"); return;
                case CriteriaType.Qualification:
                    serializer.Serialize(writer, "qualification"); return;
            }
            throw new Exception("Cannot marshal type CriteriaType");
        }
    }

    internal class EnforcementPolicyConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(EnforcementPolicy) || t == typeof(EnforcementPolicy?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Info":
                    return EnforcementPolicy.Info;
                case "Lenient":
                    return EnforcementPolicy.Lenient;
                case "Strict":
                    return EnforcementPolicy.Strict;
            }
            throw new Exception("Cannot unmarshal type EnforcementPolicy");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (EnforcementPolicy)untypedValue;
            switch (value)
            {
                case EnforcementPolicy.Info:
                    serializer.Serialize(writer, "Info"); return;
                case EnforcementPolicy.Lenient:
                    serializer.Serialize(writer, "Lenient"); return;
                case EnforcementPolicy.Strict:
                    serializer.Serialize(writer, "Strict"); return;
            }
            throw new Exception("Cannot marshal type EnforcementPolicy");
        }
    }

    internal class LanguageIdConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LanguageId) || t == typeof(LanguageId?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "")
            {
                return LanguageId.Empty;
            }
            throw new Exception("Cannot unmarshal type LanguageId");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (LanguageId)untypedValue;
            if (value == LanguageId.Empty)
            {
                serializer.Serialize(writer, ""); return;
            }
            throw new Exception("Cannot marshal type LanguageId");
        }
    }

    internal class StateDateUntilConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(StateDateUntil) || t == typeof(StateDateUntil?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "":
                    return StateDateUntil.Empty;
                case "19/03/18":
                    return StateDateUntil.The190318;
                case "26/06/13":
                    return StateDateUntil.The260613;
                case "31/03/15":
                    return StateDateUntil.The310315;
            }
            throw new Exception("Cannot unmarshal type StateDateUntil");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (StateDateUntil)untypedValue;
            switch (value)
            {
                case StateDateUntil.Empty:
                    serializer.Serialize(writer, ""); return;
                case StateDateUntil.The190318:
                    serializer.Serialize(writer, "19/03/18"); return;
                case StateDateUntil.The260613:
                    serializer.Serialize(writer, "26/06/13"); return;
                case StateDateUntil.The310315:
                    serializer.Serialize(writer, "31/03/15"); return;
            }
            throw new Exception("Cannot marshal type StateDateUntil");
        }
    }
}
