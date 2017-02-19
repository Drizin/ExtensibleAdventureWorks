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

    // PersonPhone
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.28.0.0")]
    public partial class Person_PersonPhone
    {

        ///<summary>
        /// Business entity identification number. Foreign key to Person.BusinessEntityID.
        ///</summary>
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key)

        ///<summary>
        /// Telephone number identification number.
        ///</summary>
        public string PhoneNumber { get; set; } // PhoneNumber (Primary key) (length: 25)

        ///<summary>
        /// Kind of phone number. Foreign key to PhoneNumberType.PhoneNumberTypeID.
        ///</summary>
        public int PhoneNumberTypeId { get; set; } // PhoneNumberTypeID (Primary key)

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
        public System.DateTime ModifiedDate { get; set; } = System.DateTime.Now; // ModifiedDate

        // Foreign keys

        /// <summary>
        /// Parent Person_Person pointed by [PersonPhone].([BusinessEntityId]) (FK_PersonPhone_Person_BusinessEntityID)
        /// </summary>
        public virtual Person_Person Person_Person { get; set; } // FK_PersonPhone_Person_BusinessEntityID
        /// <summary>
        /// Parent Person_PhoneNumberType pointed by [PersonPhone].([PhoneNumberTypeId]) (FK_PersonPhone_PhoneNumberType_PhoneNumberTypeID)
        /// </summary>
        public virtual Person_PhoneNumberType Person_PhoneNumberType { get; set; } // FK_PersonPhone_PhoneNumberType_PhoneNumberTypeID
    }

}
// </auto-generated>