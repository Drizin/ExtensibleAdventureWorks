// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.5
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace ExtensibleAdventureWorks.Business.Entities
{

    // vStateProvinceCountryRegion
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.28.0.0")]
    public partial class Person_VStateProvinceCountryRegion
    {
        public int StateProvinceId { get; set; } // StateProvinceID (Primary key)
        public string StateProvinceCode { get; set; } // StateProvinceCode (Primary key) (length: 3)
        public bool IsOnlyStateProvinceFlag { get; set; } // IsOnlyStateProvinceFlag (Primary key)
        public string StateProvinceName { get; set; } // StateProvinceName (Primary key) (length: 50)
        public int TerritoryId { get; set; } // TerritoryID (Primary key)
        public string CountryRegionCode { get; set; } // CountryRegionCode (Primary key) (length: 3)
        public string CountryRegionName { get; set; } // CountryRegionName (Primary key) (length: 50)
    }

}
// </auto-generated>
