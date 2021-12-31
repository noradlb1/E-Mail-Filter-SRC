Imports System.IO
Imports System.Runtime.InteropServices

Public Class FrmMain

    'DATA/HORA: 19/10/2016 04:52:37 PM
    'CODER: HACKING SOOFT T
    'BLOGGER: SOOFTT.BLOGSPOT.COM

    Sub New()
        InitializeComponent()
        Dim tList As New List(Of TextBox)
        Dim cList As New List(Of String)
        tList.Add(txt_Nome_Filter)
        cList.Add("Ex: @Hotmail.com")
        API.SetCueText(tList, cList)
    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        If txt_Nome_Filter.TextLength < 1 Then
            Exit Sub
        End If

        For Each X As TabPage In TC_Filter.TabPages
            If X.Text.ToLower = txt_Nome_Filter.Text.ToLower Then
                MsgBox("Este Filter já Existe.", MsgBoxStyle.Exclamation, "Informações")
                Exit Sub
            End If
        Next

        Dim NewContext As New ContextMenuStrip
        Dim NewListView As New ListView
        Dim TB As New TabPage

        NewContext.Font = Lv_Emails.Font
        NewContext.Items.Add("Salvar", My.Resources._8, AddressOf Salvar_Click)
        NewContext.Items.Add("Excluir", My.Resources._7, AddressOf Excluir_Click)

        NewListView.ContextMenuStrip = NewContext
        NewListView.GridLines = True
        NewListView.FullRowSelect = True
        NewListView.View = View.Details
        NewListView.Columns.Add("Nome", 387)
        NewListView.Dock = DockStyle.Fill
        NewListView.SmallImageList = GList

        TB.Text = txt_Nome_Filter.Text
        TB.Tag = txt_Nome_Filter.Text
        TB.ImageIndex = 0
        TB.Controls.Add(NewListView)

        TC_Filter.TabPages.Add(TB)
        TC_Filter.SelectedTab = TB

        txt_Nome_Filter.Text = Nothing
        txt_Nome_Filter.Focus()
    End Sub

    Private Sub Salvar_Click(sender As Object, e As EventArgs)
        Dim TAB As TabPage = TC_Filter.SelectedTab
        Dim ListV As ListView = DirectCast(TAB.Controls(0), ListView)
        If ListV.Items.Count < 1 Then
            Exit Sub
        End If
        Dim I As New SaveFileDialog
        I.Title = "SALVAR DOCUMENTO TEXTO"
        I.Filter = "DOCUMENTO TEXTO (*.txt)|*.txt|TODOS ARQUIVOS (*.*)|*.*"
        If I.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim NewFile As New StreamWriter(I.FileName)
            For Each X As ListViewItem In DirectCast(TAB.Controls(0), ListView).Items
                NewFile.Write(X.Text & vbNewLine)
            Next
            NewFile.Close()
            NewFile.Dispose()
            MsgBox(I.FileName, MsgBoxStyle.Information, "Informações")
        End If
    End Sub

    Private Sub Excluir_Click(sender As Object, e As EventArgs)
        Dim TAB As TabPage = TC_Filter.SelectedTab
        Dim ListV As ListView = DirectCast(TAB.Controls(0), ListView)
        ListV.Items.Clear()
        TAB.Text = TAB.Tag
    End Sub

    Private Sub Lv_Emails_DragDrop(sender As Object, e As DragEventArgs) Handles Lv_Emails.DragDrop
        On Error Resume Next
        Lv_Emails.Items.Clear()
        For Each X In e.Data.GetData(DataFormats.FileDrop)
            For Each LINHA In File.ReadLines(X)
                Dim NewItem As New ListViewItem
                NewItem.UseItemStyleForSubItems = False
                NewItem.Text = LINHA
                NewItem.SubItems.Add("Await Filter...").ForeColor = Color.DarkCyan
                NewItem.ImageIndex = 0
                Lv_Emails.Items.Add(NewItem)
            Next
        Next
        LbStatus.Text = Lv_Emails.Items.Count.ToString
        TL_Progress.Maximum = Lv_Emails.Items.Count
    End Sub

    Private Sub Lv_Emails_DragEnter(sender As Object, e As DragEventArgs) Handles Lv_Emails.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub CTX_Iniciar_Click(sender As Object, e As EventArgs) Handles CTX_Iniciar.Click
        On Error Resume Next
        If Lv_Emails.Items.Count < 1 Then
            Exit Sub
        End If

        CTX_Iniciar.Enabled = False
        CTX_Cancel.Enabled = True

        LbStatus.Text = Lv_Emails.Items.Count.ToString
        TL_Progress.Value = 0

        Dim Status As Boolean
        For Each X As ListViewItem In Lv_Emails.Items

            If StatusCancel = True Then
                Exit For
            End If

            If CK_DoEvents.Checked Then
                Application.DoEvents()
            End If

            For Each TABE As TabPage In TC_Filter.TabPages
                If X.Text.ToLower.Contains(TABE.Tag.ToLower) Then
                    Dim ListV As ListView = DirectCast(TABE.Controls(0), ListView)
                    Dim NewItem As New ListViewItem
                    NewItem.Text = X.Text
                    NewItem.ImageIndex = 4
                    ListV.Items.Add(NewItem).EnsureVisible()

                    TABE.Text = TABE.Tag & " (" & ListV.Items.Count.ToString & ")"

                    X.SubItems(1).Text = TABE.Tag
                    X.SubItems(1).ForeColor = Color.Green
                    X.ImageIndex = 1

                    Status = True
                    Exit For
                Else
                    Status = False
                End If
            Next

            If Status = False Then
                Dim NewItem As New ListViewItem
                NewItem.Text = X.Text
                NewItem.ImageIndex = 3
                Lv_Lixeira.Items.Add(NewItem).EnsureVisible()
                TB_Lixeira.Text = TB_Lixeira.Tag & " (" & Lv_Lixeira.Items.Count.ToString & ")"

                X.SubItems(1).Text = "Lixeira"
                X.SubItems(1).ForeColor = Color.Red
                X.ImageIndex = 2
            End If

            X.EnsureVisible()

            TL_Progress.Value += 1
            LbStatus.Text -= 1
        Next

        StatusCancel = False

        CTX_Iniciar.Enabled = True
        CTX_Cancel.Enabled = False

        Dim StrFormt As String = String.Empty
        Dim TabIndex As Integer = 0
        For Each X As TabPage In TC_Filter.TabPages
            StrFormt += X.Tag & " - " & DirectCast(X.Controls(0), ListView).Items.Count.ToString & vbNewLine
        Next

        MsgBox(StrFormt, MsgBoxStyle.Information, "Informações")
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub txt_Nome_Filter_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Nome_Filter.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAdicionar.PerformClick()
        End If
    End Sub

    Private Sub CTX1_Salvar_Click(sender As Object, e As EventArgs) Handles CTX1_Salvar.Click
        If Lv_Lixeira.Items.Count < 1 Then
            Exit Sub
        End If
        Dim I As New SaveFileDialog
        I.Title = "SALVAR DOCUMENTO TEXTO"
        I.Filter = "DOCUMENTO TEXTO (*.txt)|*.txt|TODOS ARQUIVOS (*.*)|*.*"
        If I.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim NewFile As New StreamWriter(I.FileName)
            For Each X As ListViewItem In Lv_Lixeira.Items
                NewFile.Write(X.Text & vbNewLine)
            Next
            NewFile.Close()
            NewFile.Dispose()
            MsgBox(I.FileName, MsgBoxStyle.Information, "Informações")
        End If
    End Sub

    Private Sub CTX1_Excluir_Click(sender As Object, e As EventArgs) Handles CTX1_Excluir.Click
        Lv_Lixeira.Items.Clear()
        TB_Lixeira.Text = "Lixeira"
    End Sub

    Private Sub Lb_Blogger_Click(sender As Object, e As EventArgs) Handles Lb_Blogger.Click
        Process.Start("https://www.youtube.com/channel/UCLF-eRNc52VslhdctpHaAzg/videos", AppWinStyle.NormalFocus)
    End Sub

    Private Sub CTX2_Excluir_Filter_Click(sender As Object, e As EventArgs) Handles CTX2_Excluir_Filter.Click
        On Error Resume Next
        If TC_Filter.TabPages.Count > 1 Then
            If TC_Filter.TabPages(TAB_INDEX).Tag <> "Lixeira" Then
                TC_Filter.TabPages(TAB_INDEX).Dispose()
            End If
        End If
    End Sub

    Dim TAB_INDEX As Integer

    Private Sub TC_Filter_MouseUp(sender As Object, e As MouseEventArgs) Handles TC_Filter.MouseUp
        If e.Button = MouseButtons.Right Then
            For i As Integer = 0 To TC_Filter.TabCount - 1
                Dim r As Rectangle = TC_Filter.GetTabRect(i)
                If r.Contains(e.Location) Then
                    TAB_INDEX = i
                End If
            Next
        End If
    End Sub

    Dim StatusCancel As Boolean

    Private Sub CTX_Cancel_Click(sender As Object, e As EventArgs) Handles CTX_Cancel.Click
        StatusCancel = True
    End Sub

End Class

Module API
    Const EM_SETCUEBANNER As Integer = &H1501
    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Private Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function
    Public Sub SetCueText(ByRef textbox As List(Of TextBox), ByVal CueText As List(Of String))
        For i As Integer = 0 To textbox.Count - 1
            SendMessage(textbox(i).Handle, EM_SETCUEBANNER, 1, CueText(i))
        Next
    End Sub
End Module