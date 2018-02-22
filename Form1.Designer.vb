<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarLoan
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
        Me.lblAmountOfLoan = New System.Windows.Forms.Label()
        Me.lblInterestRate = New System.Windows.Forms.Label()
        Me.lblNumberOfYears = New System.Windows.Forms.Label()
        Me.lblMonthlyPayments = New System.Windows.Forms.Label()
        Me.txtAmountOfLoan = New System.Windows.Forms.TextBox()
        Me.txtInterestRate = New System.Windows.Forms.TextBox()
        Me.txtNumberOfYears = New System.Windows.Forms.TextBox()
        Me.txtMonthlyPayments = New System.Windows.Forms.TextBox()
        Me.btnCalculateMonthlyPayments = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblAmountOfLoan
        '
        Me.lblAmountOfLoan.AutoSize = True
        Me.lblAmountOfLoan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountOfLoan.Location = New System.Drawing.Point(11, 22)
        Me.lblAmountOfLoan.Name = "lblAmountOfLoan"
        Me.lblAmountOfLoan.Size = New System.Drawing.Size(95, 15)
        Me.lblAmountOfLoan.TabIndex = 0
        Me.lblAmountOfLoan.Text = "Amount Of Loan"
        '
        'lblInterestRate
        '
        Me.lblInterestRate.AutoSize = True
        Me.lblInterestRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInterestRate.Location = New System.Drawing.Point(11, 57)
        Me.lblInterestRate.Name = "lblInterestRate"
        Me.lblInterestRate.Size = New System.Drawing.Size(76, 15)
        Me.lblInterestRate.TabIndex = 1
        Me.lblInterestRate.Text = "Interest Rate"
        '
        'lblNumberOfYears
        '
        Me.lblNumberOfYears.AutoSize = True
        Me.lblNumberOfYears.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfYears.Location = New System.Drawing.Point(11, 94)
        Me.lblNumberOfYears.Name = "lblNumberOfYears"
        Me.lblNumberOfYears.Size = New System.Drawing.Size(101, 15)
        Me.lblNumberOfYears.TabIndex = 2
        Me.lblNumberOfYears.Text = "Number Of Years"
        '
        'lblMonthlyPayments
        '
        Me.lblMonthlyPayments.AutoSize = True
        Me.lblMonthlyPayments.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthlyPayments.Location = New System.Drawing.Point(11, 177)
        Me.lblMonthlyPayments.Name = "lblMonthlyPayments"
        Me.lblMonthlyPayments.Size = New System.Drawing.Size(107, 15)
        Me.lblMonthlyPayments.TabIndex = 3
        Me.lblMonthlyPayments.Text = "Monthly Payments"
        '
        'txtAmountOfLoan
        '
        Me.txtAmountOfLoan.Location = New System.Drawing.Point(122, 22)
        Me.txtAmountOfLoan.Name = "txtAmountOfLoan"
        Me.txtAmountOfLoan.Size = New System.Drawing.Size(200, 20)
        Me.txtAmountOfLoan.TabIndex = 4
        '
        'txtInterestRate
        '
        Me.txtInterestRate.Location = New System.Drawing.Point(122, 57)
        Me.txtInterestRate.Name = "txtInterestRate"
        Me.txtInterestRate.Size = New System.Drawing.Size(200, 20)
        Me.txtInterestRate.TabIndex = 5
        '
        'txtNumberOfYears
        '
        Me.txtNumberOfYears.Location = New System.Drawing.Point(122, 94)
        Me.txtNumberOfYears.Name = "txtNumberOfYears"
        Me.txtNumberOfYears.Size = New System.Drawing.Size(200, 20)
        Me.txtNumberOfYears.TabIndex = 6
        '
        'txtMonthlyPayments
        '
        Me.txtMonthlyPayments.Location = New System.Drawing.Point(124, 177)
        Me.txtMonthlyPayments.Name = "txtMonthlyPayments"
        Me.txtMonthlyPayments.ReadOnly = True
        Me.txtMonthlyPayments.Size = New System.Drawing.Size(200, 20)
        Me.txtMonthlyPayments.TabIndex = 7
        '
        'btnCalculateMonthlyPayments
        '
        Me.btnCalculateMonthlyPayments.Location = New System.Drawing.Point(14, 135)
        Me.btnCalculateMonthlyPayments.Name = "btnCalculateMonthlyPayments"
        Me.btnCalculateMonthlyPayments.Size = New System.Drawing.Size(308, 23)
        Me.btnCalculateMonthlyPayments.TabIndex = 8
        Me.btnCalculateMonthlyPayments.Text = "Calculate Monthly Payments"
        Me.btnCalculateMonthlyPayments.UseVisualStyleBackColor = True
        '
        'frmCarLoan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 211)
        Me.Controls.Add(Me.btnCalculateMonthlyPayments)
        Me.Controls.Add(Me.txtMonthlyPayments)
        Me.Controls.Add(Me.txtNumberOfYears)
        Me.Controls.Add(Me.txtInterestRate)
        Me.Controls.Add(Me.txtAmountOfLoan)
        Me.Controls.Add(Me.lblMonthlyPayments)
        Me.Controls.Add(Me.lblNumberOfYears)
        Me.Controls.Add(Me.lblInterestRate)
        Me.Controls.Add(Me.lblAmountOfLoan)
        Me.Name = "frmCarLoan"
        Me.Text = "Car Loan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAmountOfLoan As Label
    Friend WithEvents lblInterestRate As Label
    Friend WithEvents lblNumberOfYears As Label
    Friend WithEvents lblMonthlyPayments As Label
    Friend WithEvents txtAmountOfLoan As TextBox
    Friend WithEvents txtInterestRate As TextBox
    Friend WithEvents txtNumberOfYears As TextBox
    Friend WithEvents txtMonthlyPayments As TextBox
    Friend WithEvents btnCalculateMonthlyPayments As Button
End Class
