Imports System.Linq.Expressions

Public Class ExpressionBuilder
    Private Shared m_instance As ExpressionBuilder
    Private Shared ReadOnly syncRoot As New Object()
    Private optimizationCache As New HashSet(Of Type)()

    Public Shared ReadOnly Property Instance() As ExpressionBuilder
        Get
            SyncLock syncRoot
                If m_instance Is Nothing Then
                    SyncLock syncRoot
                        m_instance = New ExpressionBuilder()
                    End SyncLock
                End If
            End SyncLock

            Return m_instance
        End Get
    End Property

    Public Function Optimize(Of T)(collection As IQueryable(Of T)) As Boolean
        If Me.optimizationCache.Contains(GetType(T)) Then
            Return False
        End If

        Me.optimizationCache.Add(GetType(T))
        collection.ToList()
        Return True
    End Function

    Public Function BuildMethodCallExpression(Of T, TResult)(parameter As String, [property] As String, ownerType As Type, methodName As String, parametersCount As Integer) As Expression(Of Func(Of T, TResult))
        Dim param = Expression.Parameter(GetType(T))
        Dim constant = Expression.Constant(parameter)
        Dim prop = Expression.[Property](param, [property])
        Dim method = ownerType.GetMethods().First(Function(x) x.Name = methodName AndAlso x.GetParameters().Length = parametersCount)
        Dim body = Expression.[Call](prop, method, constant)

        Return Expression.Lambda(Of Func(Of T, TResult))(body, param)
    End Function

    Public Function BuildContainsExpression(Of T)([property] As String, filter As String) As Expression(Of Func(Of T, Boolean))
        Dim dataItemsExp = Me.BuildMethodCallExpression(Of T, Boolean)(filter, [property], GetType([String]), "Contains", 1)
        Return dataItemsExp
    End Function

    Public Function BuildSelectExpression(Of T)([property] As String) As Expression(Of Func(Of T, String))
        Dim param = Expression.Parameter(GetType(T))
        Dim prop = Expression.[Property](param, [property])
        Dim expression__1 = Expression.Lambda(Of Func(Of T, String))(prop, param)
        Return expression__1
    End Function

    Public Function BuildStartsWithExpression(Of T)([property] As String, filter As String) As Expression(Of Func(Of T, Boolean))
        Dim lambda = Me.BuildMethodCallExpression(Of T, Boolean)(filter, [property], GetType([String]), "StartsWith", 1)
        Dim newBody = Expression.[And](lambda.Body, Expression.NotEqual(Expression.[Property](lambda.Parameters.First(), [property]), Expression.Constant(filter)))
        Dim newExpression = Expression.Lambda(Of Func(Of T, Boolean))(newBody, lambda.Parameters)

        Return newExpression
    End Function

End Class
