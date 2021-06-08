Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Linq.Expressions

Public Class RadGridViewEFCodeFirstRepository(Of T As Class)
    Implements IGenericRepository(Of T)

    Private context As IRadGridViewEFCodeFirstContext
    Private [set] As IDbSet(Of T)

    Public Sub New(context As IRadGridViewEFCodeFirstContext)
        Me.context = context
        Me.[set] = context.[Set](Of T)()
    End Sub

    Public Function All() As IQueryable(Of T) Implements IGenericRepository(Of T).All
        Return Me.[set].AsQueryable()
    End Function

    Public Function SearchFor(conditions As Expression(Of Func(Of T, Boolean))) As IQueryable(Of T) Implements IGenericRepository(Of T).SearchFor
        Return Me.All().Where(conditions)
    End Function

    Public Sub Add(entity As T) Implements IGenericRepository(Of T).Add
        Me.[set].Add(entity)
    End Sub

    Public Sub Update(entity As T) Implements IGenericRepository(Of T).Update
        Dim entry = AttachIfDetached(entity)
        entry.State = EntityState.Modified
    End Sub

    Public Sub Delete(entity As T) Implements IGenericRepository(Of T).Delete
        Dim entry = AttachIfDetached(entity)
        entry.State = EntityState.Deleted
    End Sub

    Public Sub Detach(entity As T) Implements IGenericRepository(Of T).Detach
        Dim entry = Me.context.Entry(entity)
        entry.State = EntityState.Detached
    End Sub

    Private Function AttachIfDetached(entity As T) As DbEntityEntry
        Dim entry = Me.context.Entry(entity)
        If entry.State = EntityState.Detached Then
            Me.[set].Attach(entity)
        End If

        Return entry
    End Function

End Class
