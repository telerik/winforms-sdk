Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Migrations
Imports System.Linq

Namespace Migrations

    Friend NotInheritable Class Configuration 
        Inherits DbMigrationsConfiguration(Of RadGridViewEFCodeFirstContext)

        Public Sub New()
            AutomaticMigrationsEnabled = True
            Me.AutomaticMigrationDataLossAllowed = True
            Me.ContextKey = "RadGridViewEFCodeFirst.Data.RadGridViewEFCodeFirstContext"
        End Sub

        Protected Overrides Sub Seed(context As RadGridViewEFCodeFirstContext)

        End Sub

    End Class

End Namespace
