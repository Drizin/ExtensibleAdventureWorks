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

    // SalesOrderHeader
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.28.0.0")]
    public partial class Sales_SalesOrderHeader
    {

        ///<summary>
        /// Primary key.
        ///</summary>
        public int SalesOrderId { get; set; } // SalesOrderID (Primary key)

        ///<summary>
        /// Incremental number to track changes to the sales order over time.
        ///</summary>
        public byte RevisionNumber { get; set; } = 0; // RevisionNumber

        ///<summary>
        /// Dates the sales order was created.
        ///</summary>
        public System.DateTime OrderDate { get; set; } = System.DateTime.Now; // OrderDate

        ///<summary>
        /// Date the order is due to the customer.
        ///</summary>
        public System.DateTime DueDate { get; set; } // DueDate

        ///<summary>
        /// Date the order was shipped to the customer.
        ///</summary>
        public System.DateTime? ShipDate { get; set; } // ShipDate

        ///<summary>
        /// Order current status. 1 = In process; 2 = Approved; 3 = Backordered; 4 = Rejected; 5 = Shipped; 6 = Cancelled
        ///</summary>
        public byte Status { get; set; } = 1; // Status

        ///<summary>
        /// 0 = Order placed by sales person. 1 = Order placed online by customer.
        ///</summary>
        public bool OnlineOrderFlag { get; set; } = true; // OnlineOrderFlag

        ///<summary>
        /// Unique sales order identification number.
        ///</summary>
        public string SalesOrderNumber { get; private set; } // SalesOrderNumber (length: 25)

        ///<summary>
        /// Customer purchase order number reference.
        ///</summary>
        public string PurchaseOrderNumber { get; set; } // PurchaseOrderNumber (length: 25)

        ///<summary>
        /// Financial accounting number reference.
        ///</summary>
        public string AccountNumber { get; set; } // AccountNumber (length: 15)

        ///<summary>
        /// Customer identification number. Foreign key to Customer.BusinessEntityID.
        ///</summary>
        public int CustomerId { get; set; } // CustomerID

        ///<summary>
        /// Sales person who created the sales order. Foreign key to SalesPerson.BusinessEntityID.
        ///</summary>
        public int? SalesPersonId { get; set; } // SalesPersonID

        ///<summary>
        /// Territory in which the sale was made. Foreign key to SalesTerritory.SalesTerritoryID.
        ///</summary>
        public int? TerritoryId { get; set; } // TerritoryID

        ///<summary>
        /// Customer billing address. Foreign key to Address.AddressID.
        ///</summary>
        public int BillToAddressId { get; set; } // BillToAddressID

        ///<summary>
        /// Customer shipping address. Foreign key to Address.AddressID.
        ///</summary>
        public int ShipToAddressId { get; set; } // ShipToAddressID

        ///<summary>
        /// Shipping method. Foreign key to ShipMethod.ShipMethodID.
        ///</summary>
        public int ShipMethodId { get; set; } // ShipMethodID

        ///<summary>
        /// Credit card identification number. Foreign key to CreditCard.CreditCardID.
        ///</summary>
        public int? CreditCardId { get; set; } // CreditCardID

        ///<summary>
        /// Approval code provided by the credit card company.
        ///</summary>
        public string CreditCardApprovalCode { get; set; } // CreditCardApprovalCode (length: 15)

        ///<summary>
        /// Currency exchange rate used. Foreign key to CurrencyRate.CurrencyRateID.
        ///</summary>
        public int? CurrencyRateId { get; set; } // CurrencyRateID

        ///<summary>
        /// Sales subtotal. Computed as SUM(SalesOrderDetail.LineTotal)for the appropriate SalesOrderID.
        ///</summary>
        public decimal SubTotal { get; set; } = 0.00m; // SubTotal

        ///<summary>
        /// Tax amount.
        ///</summary>
        public decimal TaxAmt { get; set; } = 0.00m; // TaxAmt

        ///<summary>
        /// Shipping cost.
        ///</summary>
        public decimal Freight { get; set; } = 0.00m; // Freight

        ///<summary>
        /// Total due from customer. Computed as Subtotal + TaxAmt + Freight.
        ///</summary>
        public decimal TotalDue { get; private set; } // TotalDue

        ///<summary>
        /// Sales representative comments.
        ///</summary>
        public string Comment { get; set; } // Comment (length: 128)

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
        /// Child Sales_SalesOrderDetails where [SalesOrderDetail].[SalesOrderID] point to this entity (FK_SalesOrderDetail_SalesOrderHeader_SalesOrderID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Sales_SalesOrderDetail> Sales_SalesOrderDetails { get; set; } = new System.Collections.Generic.List<Sales_SalesOrderDetail>(); // SalesOrderDetail.FK_SalesOrderDetail_SalesOrderHeader_SalesOrderID
        /// <summary>
        /// Child Sales_SalesOrderHeaderSalesReasons where [SalesOrderHeaderSalesReason].[SalesOrderID] point to this entity (FK_SalesOrderHeaderSalesReason_SalesOrderHeader_SalesOrderID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Sales_SalesOrderHeaderSalesReason> Sales_SalesOrderHeaderSalesReasons { get; set; } = new System.Collections.Generic.List<Sales_SalesOrderHeaderSalesReason>(); // SalesOrderHeaderSalesReason.FK_SalesOrderHeaderSalesReason_SalesOrderHeader_SalesOrderID

        // Foreign keys

        /// <summary>
        /// Parent Person_Address pointed by [SalesOrderHeader].([BillToAddressId]) (FK_SalesOrderHeader_Address_BillToAddressID)
        /// </summary>
        public virtual Person_Address BillToAddress { get; set; } // FK_SalesOrderHeader_Address_BillToAddressID
        /// <summary>
        /// Parent Person_Address pointed by [SalesOrderHeader].([ShipToAddressId]) (FK_SalesOrderHeader_Address_ShipToAddressID)
        /// </summary>
        public virtual Person_Address ShipToAddress { get; set; } // FK_SalesOrderHeader_Address_ShipToAddressID
        /// <summary>
        /// Parent Purchasing_ShipMethod pointed by [SalesOrderHeader].([ShipMethodId]) (FK_SalesOrderHeader_ShipMethod_ShipMethodID)
        /// </summary>
        public virtual Purchasing_ShipMethod Purchasing_ShipMethod { get; set; } // FK_SalesOrderHeader_ShipMethod_ShipMethodID
        /// <summary>
        /// Parent Sales_CreditCard pointed by [SalesOrderHeader].([CreditCardId]) (FK_SalesOrderHeader_CreditCard_CreditCardID)
        /// </summary>
        public virtual Sales_CreditCard Sales_CreditCard { get; set; } // FK_SalesOrderHeader_CreditCard_CreditCardID
        /// <summary>
        /// Parent Sales_CurrencyRate pointed by [SalesOrderHeader].([CurrencyRateId]) (FK_SalesOrderHeader_CurrencyRate_CurrencyRateID)
        /// </summary>
        public virtual Sales_CurrencyRate Sales_CurrencyRate { get; set; } // FK_SalesOrderHeader_CurrencyRate_CurrencyRateID
        /// <summary>
        /// Parent Sales_Customer pointed by [SalesOrderHeader].([CustomerId]) (FK_SalesOrderHeader_Customer_CustomerID)
        /// </summary>
        public virtual Sales_Customer Sales_Customer { get; set; } // FK_SalesOrderHeader_Customer_CustomerID
        /// <summary>
        /// Parent Sales_SalesPerson pointed by [SalesOrderHeader].([SalesPersonId]) (FK_SalesOrderHeader_SalesPerson_SalesPersonID)
        /// </summary>
        public virtual Sales_SalesPerson Sales_SalesPerson { get; set; } // FK_SalesOrderHeader_SalesPerson_SalesPersonID
        /// <summary>
        /// Parent Sales_SalesTerritory pointed by [SalesOrderHeader].([TerritoryId]) (FK_SalesOrderHeader_SalesTerritory_TerritoryID)
        /// </summary>
        public virtual Sales_SalesTerritory Sales_SalesTerritory { get; set; } // FK_SalesOrderHeader_SalesTerritory_TerritoryID
    }

}
// </auto-generated>