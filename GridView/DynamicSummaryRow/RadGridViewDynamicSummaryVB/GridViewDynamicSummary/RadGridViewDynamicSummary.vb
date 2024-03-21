Imports System.ComponentModel
Imports Telerik.WinControls.UI

Namespace GridView

    Public Class RadGridViewDynamicSummary
        Inherits Telerik.WinControls.UI.RadGridView

        Private m_CurrentColumnTypeSummary As CurrentColumnTypeSummary
        Private m_GroupSummaryDateTimeColumn As GridViewDateTimeColumn
        Private m_GroupSummaryDecimalColumn As GridViewDecimalColumn
        Private m_Summary As GridViewSummaryItem
        Private m_SummaryRowItem As GridViewSummaryRowItem
        Private m_AggregateFunction As AggregateFunction = AggregateFunction.Count
        Private m_SummaryRowPosition As SummaryRowPosition = SummaryRowPosition.Bottom
        Private m_ContextMenu As New RadDropDownMenu()

        Public Event DynamicGroupSummaryChanged As EventHandler(Of DynamicGroupSummaryRowChangedEventArgs)

        Public Sub New()
            MyBase.New()
            Me.ThemeClassName = "Telerik.WinControls.UI.RadGridView"
        End Sub

        ''' <summary>
        ''' Enable (add) a dynamic group summary row for a GridViewDateTimeColumn
        ''' </summary>
        ''' <param name="startingFunction">the starting aggregate function to use. E.g. Count</param>
        ''' <param name="column">The GridViewDateTimeColumn to apply the group summary to</param>
        ''' <param name="summaryRowPosition">specifies the summary row position</param>
        ''' <remarks>Avg and Sum are not allowed on this type</remarks>
        Public Sub EnableDynamicRowSummary(ByVal startingFunction As AggregateFunction, ByVal column As GridViewDateTimeColumn, ByVal summaryRowPosition As SummaryRowPosition)

            If DynamicSummarySupport.GetEnumAllowOnDateTimeColumn(startingFunction) = False Then
                Throw New InvalidEnumArgumentException("This Aggregate Function is not available for this method")
            End If
            Disable()
            m_CurrentColumnTypeSummary = CurrentColumnTypeSummary.DateTime
            Me.m_GroupSummaryDecimalColumn = Nothing
            Me.m_AggregateFunction = startingFunction
            Me.m_GroupSummaryDateTimeColumn = column
            Me.m_SummaryRowPosition = summaryRowPosition
            SetUp()
        End Sub

        ''' <summary>
        ''' Enable (add) a dynamic group summary row for a GridViewDecimalColumn
        ''' </summary>
        ''' <param name="startingFunction">the starting aggregate function to use. E.g. Count</param>
        ''' <param name="column">The GridViewDecimalColumn to apply the group summary to</param>
        ''' <param name="summaryRowPosition">specifies the summary row position</param>
        Public Sub EnableDynamicRowSummary(ByVal startingFunction As AggregateFunction, ByVal column As GridViewDecimalColumn, ByVal summaryRowPosition As SummaryRowPosition)
            Disable()
            m_CurrentColumnTypeSummary = CurrentColumnTypeSummary.Deciaml
            Me.m_GroupSummaryDateTimeColumn = Nothing
            Me.m_AggregateFunction = startingFunction
            Me.m_GroupSummaryDecimalColumn = column
            Me.m_SummaryRowPosition = summaryRowPosition
            SetUp()
        End Sub

        ''' <summary>Disables (removes) the group summary row</summary>
        Public Sub DisableDynamicRowSummary()
            Disable()

            Dim args As New DynamicGroupSummaryRowChangedEventArgs(Nothing, m_SummaryRowPosition, m_AggregateFunction, False)
            RaiseEvent DynamicGroupSummaryChanged(Me, args)
        End Sub

        ''' <summary>Disables (removes) the group summary row</summary>
        ''' <remarks>Private version of DisableDynamicRowSummary so we don't fire the DynamicGroupSummaryChanged when calling internally</remarks>
        Private Sub Disable()
            If Me.m_SummaryRowPosition = SummaryRowPosition.Top Then
                MyBase.SummaryRowsTop.Clear()
            Else
                MyBase.SummaryRowsBottom.Clear()
            End If
            Me.m_ContextMenu.Items.Clear()
        End Sub

        ''' <summary>Sets up the dynamic group summary row and context menus</summary>
        Private Sub SetUp()
            Dim summarytext As String = DynamicSummarySupport.GetEnumDescription(m_AggregateFunction)

            If m_CurrentColumnTypeSummary = CurrentColumnTypeSummary.DateTime Then
                m_Summary = New GridViewSummaryItem(m_GroupSummaryDateTimeColumn.HeaderText, summarytext & "[" & m_GroupSummaryDateTimeColumn.HeaderText & "] is: {0}", DynamicSummarySupport.AggregateFunctionToGridAggregateFunction(m_AggregateFunction))
            Else
                m_Summary = New GridViewSummaryItem(m_GroupSummaryDecimalColumn.HeaderText, summarytext & "[" & m_GroupSummaryDecimalColumn.HeaderText & "] is: {0}", DynamicSummarySupport.AggregateFunctionToGridAggregateFunction(m_AggregateFunction))
            End If

            m_SummaryRowItem = New GridViewSummaryRowItem()
            m_SummaryRowItem.Add(m_Summary)

            If Me.m_SummaryRowPosition = SummaryRowPosition.Top Then
                MyBase.MasterTemplate.SummaryRowsTop.Add(m_SummaryRowItem)
            Else
                MyBase.MasterTemplate.SummaryRowsBottom.Add(m_SummaryRowItem)
            End If

            For Each func As AggregateFunction In [Enum].GetValues(GetType(AggregateFunction))
                Dim menuItem As New RadMenuItem(func.ToString())

                Dim addMenu As Boolean = True
                If m_CurrentColumnTypeSummary = CurrentColumnTypeSummary.DateTime Then
                    addMenu = DynamicSummarySupport.GetEnumAllowOnDateTimeColumn(func)
                End If
                If addMenu Then
                    m_ContextMenu.Items.Add(menuItem)
                    AddHandler menuItem.Click, AddressOf MenuItem_Click
                    menuItem.CheckOnClick = True
                    If String.Equals(m_AggregateFunction.ToString(), func.ToString()) Then
                        menuItem.IsChecked = True
                    End If
                End If
            Next

            Dim args As DynamicGroupSummaryRowChangedEventArgs = Nothing
            If m_CurrentColumnTypeSummary = CurrentColumnTypeSummary.DateTime Then
                args = New DynamicGroupSummaryRowChangedEventArgs(m_GroupSummaryDateTimeColumn, m_SummaryRowPosition, m_AggregateFunction, True)
            Else
                args = New DynamicGroupSummaryRowChangedEventArgs(m_GroupSummaryDecimalColumn, m_SummaryRowPosition, m_AggregateFunction, True)
            End If

            RaiseEvent DynamicGroupSummaryChanged(Me, args)
        End Sub

        ''' <summary>
        ''' Handles the context menu click and changes the group summary accordingly
        ''' </summary>
        ''' <param name="sender">the sender (RadMenuItem)</param>
        ''' <param name="e">The event arguments</param>
        Private Sub MenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)

            Dim menuItem As RadMenuItem = DirectCast(sender, RadMenuItem)
            Dim summarytext As String = ""
            Dim useThisFunction As AggregateFunction
            For Each func As AggregateFunction In [Enum].GetValues(GetType(AggregateFunction))
                If String.Equals(func.ToString(), menuItem.Text) Then
                    Me.m_AggregateFunction = func
                    summarytext = DynamicSummarySupport.GetEnumDescription(func)
                    useThisFunction = func
                End If
            Next

            For Each menu As RadMenuItem In Me.m_ContextMenu.Items
                If Not String.Equals(menu.Text, menuItem.Text) Then
                    menu.IsChecked = False
                End If
            Next
            If Me.m_SummaryRowPosition = SummaryRowPosition.Top Then
                MyBase.SummaryRowsTop.Clear()
            Else
                MyBase.SummaryRowsBottom.Clear()
            End If

            If m_CurrentColumnTypeSummary = CurrentColumnTypeSummary.DateTime Then
                m_Summary = New GridViewSummaryItem(m_GroupSummaryDateTimeColumn.HeaderText, summarytext & "[" & m_GroupSummaryDateTimeColumn.HeaderText & "] is: {0}", DynamicSummarySupport.AggregateFunctionToGridAggregateFunction(m_AggregateFunction))
            Else
                m_Summary = New GridViewSummaryItem(m_GroupSummaryDecimalColumn.HeaderText, summarytext & "[" & m_GroupSummaryDecimalColumn.HeaderText & "] is: {0}", DynamicSummarySupport.AggregateFunctionToGridAggregateFunction(m_AggregateFunction))
            End If

            m_SummaryRowItem = New GridViewSummaryRowItem()
            m_SummaryRowItem.Add(m_Summary)
            If Me.m_SummaryRowPosition = SummaryRowPosition.Top Then
                MyBase.MasterTemplate.SummaryRowsTop.Add(m_SummaryRowItem)
            Else
                MyBase.MasterTemplate.SummaryRowsBottom.Add(m_SummaryRowItem)
            End If

            Dim args As DynamicGroupSummaryRowChangedEventArgs = Nothing
            If m_CurrentColumnTypeSummary = CurrentColumnTypeSummary.DateTime Then
                args = New DynamicGroupSummaryRowChangedEventArgs(m_GroupSummaryDateTimeColumn, m_SummaryRowPosition, useThisFunction, True)
            Else
                args = New DynamicGroupSummaryRowChangedEventArgs(m_GroupSummaryDecimalColumn, m_SummaryRowPosition, useThisFunction, True)
            End If

            RaiseEvent DynamicGroupSummaryChanged(sender, args)
        End Sub

        ''' <summary>Gets the GridViewDecimalColumn that should be used for dynamic group summary</summary>
        <Description("Gets the GridViewDecimalColumn that should be used for dynamic group summary")> _
        <Browsable(True)> _
        <[ReadOnly](True)> _
        Public ReadOnly Property GroupSummaryColumn As Telerik.WinControls.UI.GridViewDataColumn
            Get
                If m_CurrentColumnTypeSummary = CurrentColumnTypeSummary.Deciaml Then
                    Return m_GroupSummaryDecimalColumn
                Else
                    Return m_GroupSummaryDateTimeColumn
                End If
            End Get
        End Property

        ''' <summary>Gets the current aggregate function</summary>
        <Description("gets the current aggregate function")> _
        <Browsable(True)> _
        <[ReadOnly](True)> _
        Public ReadOnly Property CurrentAggregateFunction As AggregateFunction
            Get
                Return m_AggregateFunction
            End Get
        End Property

        ''' <summary>
        ''' Context Menu Opening. Assigns the context mmenu if this is the summary cell
        ''' </summary>
        ''' <param name="sender">the sender</param>
        ''' <param name="e">the event arguments</param>
        Private Sub RadGridView_ContextMenuOpening(ByVal sender As System.Object, ByVal e As Telerik.WinControls.UI.ContextMenuOpeningEventArgs) Handles MyBase.ContextMenuOpening
            If TypeOf e.ContextMenuProvider Is GridSummaryCellElement Then
                e.ContextMenu = m_ContextMenu
            End If
        End Sub

        ''' <summary>the type of column currently being used</summary>
        Private Enum CurrentColumnTypeSummary
            [Deciaml]
            [DateTime]
        End Enum


    End Class

End Namespace


