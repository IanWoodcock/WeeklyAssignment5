<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblGroupSize = New System.Windows.Forms.Label()
        Me.txtGroupSize = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.gbOptions = New System.Windows.Forms.GroupBox()
        Me.rbtnCSE = New System.Windows.Forms.RadioButton()
        Me.rbtrnCA = New System.Windows.Forms.RadioButton()
        Me.rbtnC = New System.Windows.Forms.RadioButton()
        Me.lblRegCost = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'lblTitle
        '
        resources.ApplyResources(Me.lblTitle, "lblTitle")
        Me.lblTitle.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblTitle.Name = "lblTitle"
        '
        'lblGroupSize
        '
        resources.ApplyResources(Me.lblGroupSize, "lblGroupSize")
        Me.lblGroupSize.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblGroupSize.Name = "lblGroupSize"
        '
        'txtGroupSize
        '
        resources.ApplyResources(Me.txtGroupSize, "txtGroupSize")
        Me.txtGroupSize.ForeColor = System.Drawing.Color.OrangeRed
        Me.txtGroupSize.Name = "txtGroupSize"
        '
        'gbOptions
        '
        Me.gbOptions.BackColor = System.Drawing.Color.LightSkyBlue
        Me.gbOptions.Controls.Add(Me.rbtnC)
        Me.gbOptions.Controls.Add(Me.rbtrnCA)
        Me.gbOptions.Controls.Add(Me.rbtnCSE)
        resources.ApplyResources(Me.gbOptions, "gbOptions")
        Me.gbOptions.ForeColor = System.Drawing.Color.OrangeRed
        Me.gbOptions.Name = "gbOptions"
        Me.gbOptions.TabStop = False
        '
        'rbtnCSE
        '
        resources.ApplyResources(Me.rbtnCSE, "rbtnCSE")
        Me.rbtnCSE.Name = "rbtnCSE"
        Me.rbtnCSE.UseVisualStyleBackColor = True
        '
        'rbtrnCA
        '
        resources.ApplyResources(Me.rbtrnCA, "rbtrnCA")
        Me.rbtrnCA.Name = "rbtrnCA"
        Me.rbtrnCA.UseVisualStyleBackColor = True
        '
        'rbtnC
        '
        resources.ApplyResources(Me.rbtnC, "rbtnC")
        Me.rbtnC.Checked = True
        Me.rbtnC.Name = "rbtnC"
        Me.rbtnC.TabStop = True
        Me.rbtnC.UseVisualStyleBackColor = True
        '
        'lblRegCost
        '
        resources.ApplyResources(Me.lblRegCost, "lblRegCost")
        Me.lblRegCost.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblRegCost.Name = "lblRegCost"
        '
        'lblTotalCost
        '
        resources.ApplyResources(Me.lblTotalCost, "lblTotalCost")
        Me.lblTotalCost.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblTotalCost.Name = "lblTotalCost"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.LightSkyBlue
        resources.ApplyResources(Me.btnCalculate, "btnCalculate")
        Me.btnCalculate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.LightSkyBlue
        resources.ApplyResources(Me.btnClear, "btnClear")
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClear.Name = "btnClear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblRegCost)
        Me.Controls.Add(Me.gbOptions)
        Me.Controls.Add(Me.txtGroupSize)
        Me.Controls.Add(Me.lblGroupSize)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbOptions.ResumeLayout(False)
        Me.gbOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblGroupSize As Label
    Friend WithEvents txtGroupSize As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents gbOptions As GroupBox
    Friend WithEvents rbtnC As RadioButton
    Friend WithEvents rbtrnCA As RadioButton
    Friend WithEvents rbtnCSE As RadioButton
    Friend WithEvents lblRegCost As Label
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
End Class
