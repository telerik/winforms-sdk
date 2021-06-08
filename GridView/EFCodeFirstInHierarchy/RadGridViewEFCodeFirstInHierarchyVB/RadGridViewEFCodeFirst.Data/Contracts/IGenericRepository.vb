Imports System.Linq.Expressions

Public Interface IGenericRepository(Of T As Class)
    Function All() As IQueryable(Of T)

    Function SearchFor(conditions As Expression(Of Func(Of T, Boolean))) As IQueryable(Of T)

    Sub Add(entity As T)

    Sub Update(entity As T)

    Sub Delete(entity As T)

    Sub Detach(entity As T)
End Interface

