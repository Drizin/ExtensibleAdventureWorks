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

    // BusinessEntityContact
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.28.0.0")]
    public partial class Person_BusinessEntityContact
    {

        ///<summary>
        /// Primary key. Foreign key to BusinessEntity.BusinessEntityID.
        ///</summary>
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key)

        ///<summary>
        /// Primary key. Foreign key to Person.BusinessEntityID.
        ///</summary>
        public int PersonId { get; set; } // PersonID (Primary key)

        ///<summary>
        /// Primary key.  Foreign key to ContactType.ContactTypeID.
        ///</summary>
        public int ContactTypeId { get; set; } // ContactTypeID (Primary key)

        ///<summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        ///</summary>
        public System.Guid Rowguid { get; set; } = System.Guid.NewGuid(); // rowguid

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
        public System.DateTime ModifiedDate { get; set; } = System.DateTime.Now; // ModifiedDate

        // Foreign keys

        /// <summary>
        /// Parent Person_BusinessEntity pointed by [BusinessEntityContact].([BusinessEntityId]) (FK_BusinessEntityContact_BusinessEntity_BusinessEntityID)
        /// </summary>
        public virtual Person_BusinessEntity Person_BusinessEntity { get; set; } // FK_BusinessEntityContact_BusinessEntity_BusinessEntityID
        /// <summary>
        /// Parent Person_ContactType pointed by [BusinessEntityContact].([ContactTypeId]) (FK_BusinessEntityContact_ContactType_ContactTypeID)
        /// </summary>
        public virtual Person_ContactType Person_ContactType { get; set; } // FK_BusinessEntityContact_ContactType_ContactTypeID
        /// <summary>
        /// Parent Person_Person pointed by [BusinessEntityContact].([PersonId]) (FK_BusinessEntityContact_Person_PersonID)
        /// </summary>
        public virtual Person_Person Person_Person { get; set; } // FK_BusinessEntityContact_Person_PersonID
    }

}
// </auto-generated>