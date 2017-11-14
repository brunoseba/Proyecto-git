Partial Class DataSet1
   
    Partial Class SuperMejorClienteDataTable

        Private Sub SuperMejorClienteDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.ClienteDesdeColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class


End Class

Namespace DataSet1TableAdapters
    
    Partial Public Class AdminUsuariosTableAdapter
    End Class
End Namespace
