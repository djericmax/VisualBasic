<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArquivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnMultiplica = New System.Windows.Forms.Button()
        Me.btnRaiz = New System.Windows.Forms.Button()
        Me.btnSubtrai = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.btnPotencia = New System.Windows.Forms.Button()
        Me.txtValor1 = New System.Windows.Forms.TextBox()
        Me.txtValor2 = New System.Windows.Forms.TextBox()
        Me.btnSoma = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.btnSqlServer = New System.Windows.Forms.Button()
        Me.btnMysql = New System.Windows.Forms.Button()
        Me.mnuMysql = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSqlServer = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLimpar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSair = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArquivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArquivoToolStripMenuItem
        '
        Me.ArquivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMysql, Me.mnuSqlServer, Me.ToolStripMenuItem1, Me.mnuLimpar, Me.ToolStripMenuItem2, Me.mnuSair})
        Me.ArquivoToolStripMenuItem.Name = "ArquivoToolStripMenuItem"
        Me.ArquivoToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ArquivoToolStripMenuItem.Text = "&Arquivo"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(163, 6)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(163, 6)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgvDados)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 334)
        Me.Panel1.TabIndex = 1
        '
        'dgvDados
        '
        Me.dgvDados.BackgroundColor = System.Drawing.Color.White
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDados.Location = New System.Drawing.Point(0, 79)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.Size = New System.Drawing.Size(800, 255)
        Me.dgvDados.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnSair)
        Me.Panel2.Controls.Add(Me.btnLimpar)
        Me.Panel2.Controls.Add(Me.btnSqlServer)
        Me.Panel2.Controls.Add(Me.btnMysql)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 358)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 92)
        Me.Panel2.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lblResult)
        Me.Panel3.Controls.Add(Me.txtValor2)
        Me.Panel3.Controls.Add(Me.txtValor1)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(800, 79)
        Me.Panel3.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Digite o primeiro número:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Digite o segundo número:"
        '
        'lblResult
        '
        Me.lblResult.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(282, 0)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(242, 79)
        Me.lblResult.TabIndex = 2
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel5)
        Me.GroupBox1.Controls.Add(Me.Panel4)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox1.Location = New System.Drawing.Point(524, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(276, 79)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Clique em uma operação"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnMultiplica)
        Me.Panel4.Controls.Add(Me.btnRaiz)
        Me.Panel4.Controls.Add(Me.btnSoma)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(3, 16)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(270, 30)
        Me.Panel4.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnDivide)
        Me.Panel5.Controls.Add(Me.btnPotencia)
        Me.Panel5.Controls.Add(Me.btnSubtrai)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(3, 46)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(270, 30)
        Me.Panel5.TabIndex = 1
        '
        'btnMultiplica
        '
        Me.btnMultiplica.BackgroundImage = Global.ClinicaVeterinaria.My.Resources.Resources.multiplica_fw
        Me.btnMultiplica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMultiplica.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMultiplica.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnMultiplica.FlatAppearance.BorderSize = 0
        Me.btnMultiplica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMultiplica.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiplica.Location = New System.Drawing.Point(90, 0)
        Me.btnMultiplica.Name = "btnMultiplica"
        Me.btnMultiplica.Size = New System.Drawing.Size(90, 30)
        Me.btnMultiplica.TabIndex = 1
        Me.btnMultiplica.UseVisualStyleBackColor = True
        '
        'btnRaiz
        '
        Me.btnRaiz.BackgroundImage = Global.ClinicaVeterinaria.My.Resources.Resources.raiz_fw
        Me.btnRaiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRaiz.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRaiz.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnRaiz.FlatAppearance.BorderSize = 0
        Me.btnRaiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRaiz.Location = New System.Drawing.Point(180, 0)
        Me.btnRaiz.Name = "btnRaiz"
        Me.btnRaiz.Size = New System.Drawing.Size(90, 30)
        Me.btnRaiz.TabIndex = 2
        Me.btnRaiz.UseVisualStyleBackColor = True
        '
        'btnSubtrai
        '
        Me.btnSubtrai.BackgroundImage = Global.ClinicaVeterinaria.My.Resources.Resources.subtrai_fw
        Me.btnSubtrai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSubtrai.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubtrai.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSubtrai.FlatAppearance.BorderSize = 0
        Me.btnSubtrai.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubtrai.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubtrai.Location = New System.Drawing.Point(0, 0)
        Me.btnSubtrai.Name = "btnSubtrai"
        Me.btnSubtrai.Size = New System.Drawing.Size(90, 30)
        Me.btnSubtrai.TabIndex = 0
        Me.btnSubtrai.UseVisualStyleBackColor = True
        '
        'btnDivide
        '
        Me.btnDivide.BackgroundImage = Global.ClinicaVeterinaria.My.Resources.Resources.divide_fw
        Me.btnDivide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnDivide.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDivide.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDivide.FlatAppearance.BorderSize = 0
        Me.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDivide.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivide.Location = New System.Drawing.Point(90, 0)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(90, 30)
        Me.btnDivide.TabIndex = 1
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'btnPotencia
        '
        Me.btnPotencia.BackgroundImage = Global.ClinicaVeterinaria.My.Resources.Resources.exponente_fw
        Me.btnPotencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPotencia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPotencia.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnPotencia.FlatAppearance.BorderSize = 0
        Me.btnPotencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPotencia.Location = New System.Drawing.Point(180, 0)
        Me.btnPotencia.Name = "btnPotencia"
        Me.btnPotencia.Size = New System.Drawing.Size(90, 30)
        Me.btnPotencia.TabIndex = 2
        Me.btnPotencia.UseVisualStyleBackColor = True
        '
        'txtValor1
        '
        Me.txtValor1.Location = New System.Drawing.Point(132, 13)
        Me.txtValor1.Name = "txtValor1"
        Me.txtValor1.Size = New System.Drawing.Size(144, 20)
        Me.txtValor1.TabIndex = 4
        '
        'txtValor2
        '
        Me.txtValor2.Location = New System.Drawing.Point(132, 39)
        Me.txtValor2.Name = "txtValor2"
        Me.txtValor2.Size = New System.Drawing.Size(144, 20)
        Me.txtValor2.TabIndex = 5
        '
        'btnSoma
        '
        Me.btnSoma.BackgroundImage = Global.ClinicaVeterinaria.My.Resources.Resources.soma_fw
        Me.btnSoma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSoma.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSoma.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSoma.FlatAppearance.BorderSize = 0
        Me.btnSoma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSoma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSoma.Location = New System.Drawing.Point(0, 0)
        Me.btnSoma.Name = "btnSoma"
        Me.btnSoma.Size = New System.Drawing.Size(90, 30)
        Me.btnSoma.TabIndex = 0
        Me.btnSoma.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSair.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSair.FlatAppearance.BorderSize = 0
        Me.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSair.Image = Global.ClinicaVeterinaria.My.Resources.Resources.sair
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSair.Location = New System.Drawing.Point(441, 0)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(147, 92)
        Me.btnSair.TabIndex = 3
        Me.btnSair.Text = "&Sair"
        Me.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnLimpar
        '
        Me.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnLimpar.FlatAppearance.BorderSize = 0
        Me.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpar.Image = Global.ClinicaVeterinaria.My.Resources.Resources.limpar
        Me.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLimpar.Location = New System.Drawing.Point(294, 0)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(147, 92)
        Me.btnLimpar.TabIndex = 2
        Me.btnLimpar.Text = "&Limpar"
        Me.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'btnSqlServer
        '
        Me.btnSqlServer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSqlServer.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSqlServer.FlatAppearance.BorderSize = 0
        Me.btnSqlServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSqlServer.Image = Global.ClinicaVeterinaria.My.Resources.Resources.sqlserver
        Me.btnSqlServer.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSqlServer.Location = New System.Drawing.Point(147, 0)
        Me.btnSqlServer.Name = "btnSqlServer"
        Me.btnSqlServer.Size = New System.Drawing.Size(147, 92)
        Me.btnSqlServer.TabIndex = 1
        Me.btnSqlServer.Text = "Dados S&QL Server"
        Me.btnSqlServer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSqlServer.UseVisualStyleBackColor = True
        '
        'btnMysql
        '
        Me.btnMysql.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMysql.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnMysql.FlatAppearance.BorderSize = 0
        Me.btnMysql.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMysql.Image = Global.ClinicaVeterinaria.My.Resources.Resources.mysql
        Me.btnMysql.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMysql.Location = New System.Drawing.Point(0, 0)
        Me.btnMysql.Name = "btnMysql"
        Me.btnMysql.Size = New System.Drawing.Size(147, 92)
        Me.btnMysql.TabIndex = 0
        Me.btnMysql.Text = "Dados &MySQL"
        Me.btnMysql.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnMysql.UseVisualStyleBackColor = True
        '
        'mnuMysql
        '
        Me.mnuMysql.Image = Global.ClinicaVeterinaria.My.Resources.Resources.mysql
        Me.mnuMysql.Name = "mnuMysql"
        Me.mnuMysql.Size = New System.Drawing.Size(166, 22)
        Me.mnuMysql.Text = "Dados &MySQL"
        '
        'mnuSqlServer
        '
        Me.mnuSqlServer.Image = Global.ClinicaVeterinaria.My.Resources.Resources.sqlserver
        Me.mnuSqlServer.Name = "mnuSqlServer"
        Me.mnuSqlServer.Size = New System.Drawing.Size(166, 22)
        Me.mnuSqlServer.Text = "Dados S&QL Server"
        '
        'mnuLimpar
        '
        Me.mnuLimpar.Image = Global.ClinicaVeterinaria.My.Resources.Resources.limpar
        Me.mnuLimpar.Name = "mnuLimpar"
        Me.mnuLimpar.Size = New System.Drawing.Size(166, 22)
        Me.mnuLimpar.Text = "&Limpar Grid"
        '
        'mnuSair
        '
        Me.mnuSair.Image = Global.ClinicaVeterinaria.My.Resources.Resources.sair
        Me.mnuSair.Name = "mnuSair"
        Me.mnuSair.Size = New System.Drawing.Size(166, 22)
        Me.mnuSair.Text = "&Sair"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Projeto VB"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArquivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuMysql As ToolStripMenuItem
    Friend WithEvents mnuSqlServer As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents mnuLimpar As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents mnuSair As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvDados As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnSair As Button
    Friend WithEvents btnLimpar As Button
    Friend WithEvents btnSqlServer As Button
    Friend WithEvents btnMysql As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnDivide As Button
    Friend WithEvents btnPotencia As Button
    Friend WithEvents btnSubtrai As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnMultiplica As Button
    Friend WithEvents btnRaiz As Button
    Friend WithEvents btnSoma As Button
    Friend WithEvents lblResult As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtValor2 As TextBox
    Friend WithEvents txtValor1 As TextBox
End Class
