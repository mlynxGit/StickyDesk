﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StickyDesk
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StickyDesk))
        Me.panBrowser = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'panBrowser
        '
        Me.panBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panBrowser.Location = New System.Drawing.Point(0, 0)
        Me.panBrowser.Name = "panBrowser"
        Me.panBrowser.Size = New System.Drawing.Size(650, 608)
        Me.panBrowser.TabIndex = 0
        '
        'StickyDesk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 608)
        Me.Controls.Add(Me.panBrowser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "StickyDesk"
        Me.Text = "StickyDesk"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panBrowser As Panel
End Class
