Public Class Form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
        If FormWindowState.Minimized = Me.WindowState Then
            mynotifyicon.BalloonTipText = "Aplicação Está Funcionando"
            mynotifyicon.BalloonTipTitle = "Nome da Aplicação"
            mynotifyicon.BalloonTipIcon = ToolTipIcon.Info
            mynotifyicon.Icon = New Icon(SystemIcons.Shield, 40, 40)
            mynotifyicon.Visible = True
            Me.Hide()
        ElseIf FormWindowState.Normal = Me.WindowState Then
            mynotifyicon.Visible = False
        End If
    End Sub
    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click
        Me.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub
    Private Sub FecharToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FecharToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
