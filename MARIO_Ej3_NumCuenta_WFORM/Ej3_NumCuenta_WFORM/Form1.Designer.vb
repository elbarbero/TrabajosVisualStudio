<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstBank = New System.Windows.Forms.ListView()
        Me.txtEntidad = New System.Windows.Forms.TextBox()
        Me.txtOficina = New System.Windows.Forms.TextBox()
        Me.txtDC = New System.Windows.Forms.TextBox()
        Me.txtNumCuenta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnValidar = New System.Windows.Forms.Button()
        Me.ColumBanco = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnaCódigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'lstBank
        '
        Me.lstBank.AllowColumnReorder = True
        Me.lstBank.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumBanco, Me.ColumnaCódigo})
        Me.lstBank.Location = New System.Drawing.Point(37, 48)
        Me.lstBank.Name = "lstBank"
        Me.lstBank.Size = New System.Drawing.Size(167, 231)
        Me.lstBank.TabIndex = 0
        Me.lstBank.UseCompatibleStateImageBehavior = False
        Me.lstBank.View = System.Windows.Forms.View.Details
        '
        'txtEntidad
        '
        Me.txtEntidad.Location = New System.Drawing.Point(259, 118)
        Me.txtEntidad.MaxLength = 4
        Me.txtEntidad.Name = "txtEntidad"
        Me.txtEntidad.Size = New System.Drawing.Size(80, 20)
        Me.txtEntidad.TabIndex = 1
        '
        'txtOficina
        '
        Me.txtOficina.Location = New System.Drawing.Point(345, 118)
        Me.txtOficina.MaxLength = 4
        Me.txtOficina.Name = "txtOficina"
        Me.txtOficina.Size = New System.Drawing.Size(61, 20)
        Me.txtOficina.TabIndex = 2
        '
        'txtDC
        '
        Me.txtDC.Location = New System.Drawing.Point(412, 118)
        Me.txtDC.MaxLength = 2
        Me.txtDC.Name = "txtDC"
        Me.txtDC.Size = New System.Drawing.Size(40, 20)
        Me.txtDC.TabIndex = 3
        '
        'txtNumCuenta
        '
        Me.txtNumCuenta.Location = New System.Drawing.Point(458, 118)
        Me.txtNumCuenta.MaxLength = 10
        Me.txtNumCuenta.Name = "txtNumCuenta"
        Me.txtNumCuenta.Size = New System.Drawing.Size(151, 20)
        Me.txtNumCuenta.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(267, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Entidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(353, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Oficina"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(420, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "DC"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(502, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Nº Cuenta"
        '
        'btnValidar
        '
        Me.btnValidar.Location = New System.Drawing.Point(356, 199)
        Me.btnValidar.Name = "btnValidar"
        Me.btnValidar.Size = New System.Drawing.Size(123, 61)
        Me.btnValidar.TabIndex = 9
        Me.btnValidar.Text = "Validar"
        Me.btnValidar.UseVisualStyleBackColor = True
        '
        'ColumBanco
        '
        Me.ColumBanco.Text = "Banco"
        '
        'ColumnaCódigo
        '
        Me.ColumnaCódigo.Text = "Código"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 515)
        Me.Controls.Add(Me.btnValidar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNumCuenta)
        Me.Controls.Add(Me.txtDC)
        Me.Controls.Add(Me.txtOficina)
        Me.Controls.Add(Me.txtEntidad)
        Me.Controls.Add(Me.lstBank)
        Me.Name = "Form1"
        Me.Text = "Validación de Cuenta Corriente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstBank As ListView
    Friend WithEvents txtEntidad As TextBox
    Friend WithEvents txtOficina As TextBox
    Friend WithEvents txtDC As TextBox
    Friend WithEvents txtNumCuenta As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnValidar As Button
    Public WithEvents ColumBanco As ColumnHeader
    Public WithEvents ColumnaCódigo As ColumnHeader
End Class
