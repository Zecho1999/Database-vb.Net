Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'Database1DataSet.tbtrayek' table. You can move, or remove it, as needed.
        Me.TbtrayekTableAdapter.Fill(Me.Database1DataSet.tbtrayek)
        'TODO: This line of code loads data into the 'Database1DataSet.tbpo' table. You can move, or remove it, as needed.
        Me.TbpoTableAdapter.Fill(Me.Database1DataSet.tbpo)
        'TODO: This line of code loads data into the 'Database1DataSet.tbpenumpang' table. You can move, or remove it, as needed.
        Me.TbpenumpangTableAdapter.Fill(Me.Database1DataSet.tbpenumpang)
        'TODO: This line of code loads data into the 'Database1DataSet._tbcrew__' table. You can move, or remove it, as needed.
        Me.Tbcrew__TableAdapter.Fill(Me.Database1DataSet._tbcrew__)
        'TODO: This line of code loads data into the 'Database1DataSet.tbarmada' table. You can move, or remove it, as needed.
        Me.TbarmadaTableAdapter.Fill(Me.Database1DataSet.tbarmada)
        'TODO: This line of code loads data into the 'Database1DataSet._tbcrew__' table. You can move, or remove it, as needed.
        Me.Tbcrew__TableAdapter.Fill(Me.Database1DataSet._tbcrew__)
        'TODO: This line of code loads data into the 'Database1DataSet.tbarmada' table. You can move, or remove it, as needed.
        Me.TbarmadaTableAdapter.Fill(Me.Database1DataSet.tbarmada)
        'TODO: This line of code loads data into the 'Database1DataSet.tbpenjualan' table. You can move, or remove it, as needed.
       

    End Sub

    Private Sub TblaporanjualBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TbarmadaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TbarmadaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub TbarmadaBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles TbarmadaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TbarmadaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub CrewidLabel2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PoidTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BusidTextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub JumlahLabel1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
