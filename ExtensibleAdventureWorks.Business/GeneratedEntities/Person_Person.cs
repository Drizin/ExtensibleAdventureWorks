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

    // Person
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.28.0.0")]
    public partial class Person_Person
    {

        ///<summary>
        /// Primary key for Person records.
        ///</summary>
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key)

        ///<summary>
        /// Primary type of person: SC = Store Contact, IN = Individual (retail) customer, SP = Sales person, EM = Employee (non-sales), VC = Vendor contact, GC = General contact
        ///</summary>
        public string PersonType { get; set; } // PersonType (length: 2)

        ///<summary>
        /// 0 = The data in FirstName and LastName are stored in western style (first name, last name) order.  1 = Eastern style (last name, first name) order.
        ///</summary>
        public bool NameStyle { get; set; } = false; // NameStyle

        ///<summary>
        /// A courtesy title. For example, Mr. or Ms.
        ///</summary>
        public string Title { get; set; } // Title (length: 8)

        ///<summary>
        /// First name of the person.
        ///</summary>
        public string FirstName { get; set; } // FirstName (length: 50)

        ///<summary>
        /// Middle name or middle initial of the person.
        ///</summary>
        public string MiddleName { get; set; } // MiddleName (length: 50)

        ///<summary>
        /// Last name of the person.
        ///</summary>
        public string LastName { get; set; } // LastName (length: 50)

        ///<summary>
        /// Surname suffix. For example, Sr. or Jr.
        ///</summary>
        public string Suffix { get; set; } // Suffix (length: 10)

        ///<summary>
        /// 0 = Contact does not wish to receive e-mail promotions, 1 = Contact does wish to receive e-mail promotions from AdventureWorks, 2 = Contact does wish to receive e-mail promotions from AdventureWorks and selected partners.
        ///</summary>
        public int EmailPromotion { get; set; } = 0; // EmailPromotion

        ///<summary>
        /// Additional contact information about the person stored in xml format.
        ///</summary>
        public string AdditionalContactInfo { get; set; } // AdditionalContactInfo

        ///<summary>
        /// Personal information such as hobbies, and income collected from online shoppers. Used for sales analysis.
        ///</summary>
        public string Demographics { get; set; } // Demographics

        ///<summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        ///</summary>
        public System.Guid Rowguid { get; set; } = System.Guid.NewGuid(); // rowguid

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
        public System.DateTime ModifiedDate { get; set; } = System.DateTime.Now; // ModifiedDate

        // Reverse navigation

        /// <summary>
        /// Parent (One-to-One) Person_Person pointed by [Employee].[BusinessEntityID] (FK_Employee_Person_BusinessEntityID)
        /// </summary>
        public virtual HumanResources_Employee HumanResources_Employee { get; set; } // Employee.FK_Employee_Person_BusinessEntityID
        /// <summary>
        /// Parent (One-to-One) Person_Person pointed by [Password].[BusinessEntityID] (FK_Password_Person_BusinessEntityID)
        /// </summary>
        public virtual Person_Password Person_Password { get; set; } // Password.FK_Password_Person_BusinessEntityID
        /// <summary>
        /// Child Person_BusinessEntityContacts where [BusinessEntityContact].[PersonID] point to this entity (FK_BusinessEntityContact_Person_PersonID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Person_BusinessEntityContact> Person_BusinessEntityContacts { get; set; } = new System.Collections.Generic.List<Person_BusinessEntityContact>(); // BusinessEntityContact.FK_BusinessEntityContact_Person_PersonID
        /// <summary>
        /// Child Person_EmailAddresses where [EmailAddress].[BusinessEntityID] point to this entity (FK_EmailAddress_Person_BusinessEntityID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Person_EmailAddress> Person_EmailAddresses { get; set; } = new System.Collections.Generic.List<Person_EmailAddress>(); // EmailAddress.FK_EmailAddress_Person_BusinessEntityID
        /// <summary>
        /// Child Person_PersonPhones where [PersonPhone].[BusinessEntityID] point to this entity (FK_PersonPhone_Person_BusinessEntityID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Person_PersonPhone> Person_PersonPhones { get; set; } = new System.Collections.Generic.List<Person_PersonPhone>(); // PersonPhone.FK_PersonPhone_Person_BusinessEntityID
        /// <summary>
        /// Child Sales_Customers where [Customer].[PersonID] point to this entity (FK_Customer_Person_PersonID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Sales_Customer> Sales_Customers { get; set; } = new System.Collections.Generic.List<Sales_Customer>(); // Customer.FK_Customer_Person_PersonID
        /// <summary>
        /// Child Sales_PersonCreditCards where [PersonCreditCard].[BusinessEntityID] point to this entity (FK_PersonCreditCard_Person_BusinessEntityID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Sales_PersonCreditCard> Sales_PersonCreditCards { get; set; } = new System.Collections.Generic.List<Sales_PersonCreditCard>(); // PersonCreditCard.FK_PersonCreditCard_Person_BusinessEntityID

        // Foreign keys

        /// <summary>
        /// Parent Person_BusinessEntity pointed by [Person].([BusinessEntityId]) (FK_Person_BusinessEntity_BusinessEntityID)
        /// </summary>
        public virtual Person_BusinessEntity Person_BusinessEntity { get; set; } // FK_Person_BusinessEntity_BusinessEntityID
    }

}
// </auto-generated>