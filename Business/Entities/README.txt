
Auto-Generated Classes (Code First from Existing Database) are all in single file (.\Entities\Generated\AdventureWorksDB.cs) and contain:
	(1) DbContext (UnitOfWork)
	(2) Abstract POCOs (only database properties) - Partial Classes - Named with a leading underscore
	(3) POCOs Relationships and Mappings (Configuration)
	(4) Derived Concrete POCOS (only empty partial classes)

Behavior (Business Methods) and Calculated Properties (non-persistent) can be defined in partial classes:
	(A) .\Entities\NameOfEntity.cs - Partial class where we can extend Abstract POCOs (2) with application standard behavior
	(B) .\Entities\Custom\NameOfEntity.cs - Partial class where we can extend Concrete POCOs (4) with project-specific behavior
