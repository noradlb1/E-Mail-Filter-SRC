<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.Lv_Emails = New System.Windows.Forms.ListView()
        Me.CH_Nome = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CH_Status = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CTX = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CTX_Iniciar = New System.Windows.Forms.ToolStripMenuItem()
        Me.CTX_Cancel = New System.Windows.Forms.ToolStripMenuItem()
        Me.GList = New System.Windows.Forms.ImageList(Me.components)
        Me.TC_Filter = New System.Windows.Forms.TabControl()
        Me.CTX2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CTX2_Excluir_Filter = New System.Windows.Forms.ToolStripMenuItem()
        Me.TB_Lixeira = New System.Windows.Forms.TabPage()
        Me.Lv_Lixeira = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CTX1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CTX1_Salvar = New System.Windows.Forms.ToolStripMenuItem()
        Me.CTX1_Excluir = New System.Windows.Forms.ToolStripMenuItem()
        Me.txt_Nome_Filter = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.CK_DoEvents = New System.Windows.Forms.CheckBox()
        Me.TL = New System.Windows.Forms.ToolStrip()
        Me.Lb_Blogger = New System.Windows.Forms.ToolStripLabel()
        Me.LbTituloStatus = New System.Windows.Forms.ToolStripLabel()
        Me.LbStatus = New System.Windows.Forms.ToolStripLabel()
        Me.TL_Progress = New System.Windows.Forms.ToolStripProgressBar()
        Me.CTX.SuspendLayout()
        Me.TC_Filter.SuspendLayout()
        Me.CTX2.SuspendLayout()
        Me.TB_Lixeira.SuspendLayout()
        Me.CTX1.SuspendLayout()
        Me.TL.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lv_Emails
        '
        Me.Lv_Emails.AllowDrop = True
        Me.Lv_Emails.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CH_Nome, Me.CH_Status})
        Me.Lv_Emails.ContextMenuStrip = Me.CTX
        Me.Lv_Emails.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lv_Emails.ForeColor = System.Drawing.Color.Black
        Me.Lv_Emails.FullRowSelect = True
        Me.Lv_Emails.GridLines = True
        Me.Lv_Emails.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.Lv_Emails.HideSelection = False
        Me.Lv_Emails.Location = New System.Drawing.Point(8, 10)
        Me.Lv_Emails.Name = "Lv_Emails"
        Me.Lv_Emails.Size = New System.Drawing.Size(265, 312)
        Me.Lv_Emails.SmallImageList = Me.GList
        Me.Lv_Emails.TabIndex = 4
        Me.Lv_Emails.UseCompatibleStateImageBehavior = False
        Me.Lv_Emails.View = System.Windows.Forms.View.Details
        '
        'CH_Nome
        '
        Me.CH_Nome.Text = "Nome"
        Me.CH_Nome.Width = 162
        '
        'CH_Status
        '
        Me.CH_Status.Text = "Status"
        Me.CH_Status.Width = 80
        '
        'CTX
        '
        Me.CTX.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CTX.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CTX_Iniciar, Me.CTX_Cancel})
        Me.CTX.Name = "CTX"
        Me.CTX.Size = New System.Drawing.Size(109, 48)
        '
        'CTX_Iniciar
        '
        Me.CTX_Iniciar.Image = CType(resources.GetObject("CTX_Iniciar.Image"), System.Drawing.Image)
        Me.CTX_Iniciar.Name = "CTX_Iniciar"
        Me.CTX_Iniciar.Size = New System.Drawing.Size(108, 22)
        Me.CTX_Iniciar.Text = "Iniciar"
        '
        'CTX_Cancel
        '
        Me.CTX_Cancel.Enabled = False
        Me.CTX_Cancel.Image = CType(resources.GetObject("CTX_Cancel.Image"), System.Drawing.Image)
        Me.CTX_Cancel.Name = "CTX_Cancel"
        Me.CTX_Cancel.Size = New System.Drawing.Size(108, 22)
        Me.CTX_Cancel.Text = "Cancel"
        '
        'GList
        '
        Me.GList.ImageStream = CType(resources.GetObject("GList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.GList.TransparentColor = System.Drawing.Color.Transparent
        Me.GList.Images.SetKeyName(0, "0.png")
        Me.GList.Images.SetKeyName(1, "1.png")
        Me.GList.Images.SetKeyName(2, "2.png")
        Me.GList.Images.SetKeyName(3, "3.png")
        Me.GList.Images.SetKeyName(4, "4.png")
        '
        'TC_Filter
        '
        Me.TC_Filter.ContextMenuStrip = Me.CTX2
        Me.TC_Filter.Controls.Add(Me.TB_Lixeira)
        Me.TC_Filter.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TC_Filter.ImageList = Me.GList
        Me.TC_Filter.Location = New System.Drawing.Point(279, 49)
        Me.TC_Filter.Name = "TC_Filter"
        Me.TC_Filter.SelectedIndex = 0
        Me.TC_Filter.Size = New System.Drawing.Size(423, 273)
        Me.TC_Filter.TabIndex = 5
        '
        'CTX2
        '
        Me.CTX2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CTX2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CTX2_Excluir_Filter})
        Me.CTX2.Name = "CTX2"
        Me.CTX2.Size = New System.Drawing.Size(138, 26)
        '
        'CTX2_Excluir_Filter
        '
        Me.CTX2_Excluir_Filter.Image = CType(resources.GetObject("CTX2_Excluir_Filter.Image"), System.Drawing.Image)
        Me.CTX2_Excluir_Filter.Name = "CTX2_Excluir_Filter"
        Me.CTX2_Excluir_Filter.Size = New System.Drawing.Size(137, 22)
        Me.CTX2_Excluir_Filter.Text = "Excluir Filter"
        '
        'TB_Lixeira
        '
        Me.TB_Lixeira.Controls.Add(Me.Lv_Lixeira)
        Me.TB_Lixeira.ImageIndex = 2
        Me.TB_Lixeira.Location = New System.Drawing.Point(4, 22)
        Me.TB_Lixeira.Name = "TB_Lixeira"
        Me.TB_Lixeira.Size = New System.Drawing.Size(415, 247)
        Me.TB_Lixeira.TabIndex = 1
        Me.TB_Lixeira.Tag = "Lixeira"
        Me.TB_Lixeira.Text = "Lixeira"
        Me.TB_Lixeira.UseVisualStyleBackColor = True
        '
        'Lv_Lixeira
        '
        Me.Lv_Lixeira.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2})
        Me.Lv_Lixeira.ContextMenuStrip = Me.CTX1
        Me.Lv_Lixeira.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lv_Lixeira.ForeColor = System.Drawing.Color.Black
        Me.Lv_Lixeira.FullRowSelect = True
        Me.Lv_Lixeira.GridLines = True
        Me.Lv_Lixeira.HideSelection = False
        Me.Lv_Lixeira.Location = New System.Drawing.Point(0, 0)
        Me.Lv_Lixeira.Name = "Lv_Lixeira"
        Me.Lv_Lixeira.Size = New System.Drawing.Size(415, 247)
        Me.Lv_Lixeira.SmallImageList = Me.GList
        Me.Lv_Lixeira.TabIndex = 1
        Me.Lv_Lixeira.UseCompatibleStateImageBehavior = False
        Me.Lv_Lixeira.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nome"
        Me.ColumnHeader2.Width = 385
        '
        'CTX1
        '
        Me.CTX1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CTX1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CTX1_Salvar, Me.CTX1_Excluir})
        Me.CTX1.Name = "CTX1"
        Me.CTX1.Size = New System.Drawing.Size(109, 48)
        '
        'CTX1_Salvar
        '
        Me.CTX1_Salvar.Image = CType(resources.GetObject("CTX1_Salvar.Image"), System.Drawing.Image)
        Me.CTX1_Salvar.Name = "CTX1_Salvar"
        Me.CTX1_Salvar.Size = New System.Drawing.Size(108, 22)
        Me.CTX1_Salvar.Text = "Salvar"
        '
        'CTX1_Excluir
        '
        Me.CTX1_Excluir.Image = CType(resources.GetObject("CTX1_Excluir.Image"), System.Drawing.Image)
        Me.CTX1_Excluir.Name = "CTX1_Excluir"
        Me.CTX1_Excluir.Size = New System.Drawing.Size(108, 22)
        Me.CTX1_Excluir.Text = "Excluir"
        '
        'txt_Nome_Filter
        '
        Me.txt_Nome_Filter.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Nome_Filter.Location = New System.Drawing.Point(279, 23)
        Me.txt_Nome_Filter.Name = "txt_Nome_Filter"
        Me.txt_Nome_Filter.Size = New System.Drawing.Size(334, 22)
        Me.txt_Nome_Filter.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(276, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Filter"
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdicionar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdicionar.Image = CType(resources.GetObject("btnAdicionar.Image"), System.Drawing.Image)
        Me.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdicionar.Location = New System.Drawing.Point(616, 23)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(86, 23)
        Me.btnAdicionar.TabIndex = 1
        Me.btnAdicionar.Text = "Adicionar "
        Me.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'CK_DoEvents
        '
        Me.CK_DoEvents.AutoSize = True
        Me.CK_DoEvents.BackColor = System.Drawing.Color.Transparent
        Me.CK_DoEvents.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CK_DoEvents.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CK_DoEvents.Location = New System.Drawing.Point(483, 6)
        Me.CK_DoEvents.Name = "CK_DoEvents"
        Me.CK_DoEvents.Size = New System.Drawing.Size(136, 17)
        Me.CK_DoEvents.TabIndex = 2
        Me.CK_DoEvents.Text = "Running in DoEvents"
        Me.CK_DoEvents.UseVisualStyleBackColor = False
        '
        'TL
        '
        Me.TL.AutoSize = False
        Me.TL.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TL.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TL.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.TL.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Lb_Blogger, Me.LbTituloStatus, Me.LbStatus, Me.TL_Progress})
        Me.TL.Location = New System.Drawing.Point(0, 323)
        Me.TL.Name = "TL"
        Me.TL.Size = New System.Drawing.Size(711, 19)
        Me.TL.TabIndex = 7
        '
        'Lb_Blogger
        '
        Me.Lb_Blogger.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Lb_Blogger.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Blogger.Image = CType(resources.GetObject("Lb_Blogger.Image"), System.Drawing.Image)
        Me.Lb_Blogger.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Lb_Blogger.IsLink = True
        Me.Lb_Blogger.LinkVisited = True
        Me.Lb_Blogger.Name = "Lb_Blogger"
        Me.Lb_Blogger.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lb_Blogger.Size = New System.Drawing.Size(67, 16)
        Me.Lb_Blogger.Text = "Youtube"
        '
        'LbTituloStatus
        '
        Me.LbTituloStatus.Name = "LbTituloStatus"
        Me.LbTituloStatus.Size = New System.Drawing.Size(45, 16)
        Me.LbTituloStatus.Text = "Status :"
        '
        'LbStatus
        '
        Me.LbStatus.Name = "LbStatus"
        Me.LbStatus.Size = New System.Drawing.Size(22, 16)
        Me.LbStatus.Text = "OK"
        '
        'TL_Progress
        '
        Me.TL_Progress.AutoSize = False
        Me.TL_Progress.Name = "TL_Progress"
        Me.TL_Progress.Size = New System.Drawing.Size(300, 10)
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 342)
        Me.Controls.Add(Me.txt_Nome_Filter)
        Me.Controls.Add(Me.CK_DoEvents)
        Me.Controls.Add(Me.btnAdicionar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TC_Filter)
        Me.Controls.Add(Me.Lv_Emails)
        Me.Controls.Add(Me.TL)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "E-Mail Filter V0.1 RC"
        Me.CTX.ResumeLayout(False)
        Me.TC_Filter.ResumeLayout(False)
        Me.CTX2.ResumeLayout(False)
        Me.TB_Lixeira.ResumeLayout(False)
        Me.CTX1.ResumeLayout(False)
        Me.TL.ResumeLayout(False)
        Me.TL.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lv_Emails As System.Windows.Forms.ListView
    Friend WithEvents TC_Filter As System.Windows.Forms.TabControl
    Friend WithEvents txt_Nome_Filter As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAdicionar As System.Windows.Forms.Button
    Friend WithEvents CTX As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CTX_Iniciar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CH_Nome As System.Windows.Forms.ColumnHeader
    Friend WithEvents CH_Status As System.Windows.Forms.ColumnHeader
    Friend WithEvents TB_Lixeira As System.Windows.Forms.TabPage
    Friend WithEvents Lv_Lixeira As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents CK_DoEvents As System.Windows.Forms.CheckBox
    Friend WithEvents CTX1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CTX1_Salvar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CTX1_Excluir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GList As System.Windows.Forms.ImageList
    Friend WithEvents TL As System.Windows.Forms.ToolStrip
    Friend WithEvents Lb_Blogger As System.Windows.Forms.ToolStripLabel
    Friend WithEvents LbTituloStatus As System.Windows.Forms.ToolStripLabel
    Friend WithEvents LbStatus As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TL_Progress As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents CTX2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CTX2_Excluir_Filter As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CTX_Cancel As System.Windows.Forms.ToolStripMenuItem

End Class
