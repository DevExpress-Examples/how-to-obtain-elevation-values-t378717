﻿Namespace BingElevation
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.mapControl1 = New DevExpress.XtraMap.MapControl()
            Me.imageLayer1 = New DevExpress.XtraMap.ImageLayer()
            Me.imageDataProvider = New DevExpress.XtraMap.BingMapDataProvider()
            Me.informationLayer = New DevExpress.XtraMap.InformationLayer()
            DirectCast(Me.mapControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' mapControl1
            ' 
            Me.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mapControl1.Layers.Add(Me.imageLayer1)
            Me.mapControl1.Layers.Add(Me.informationLayer)
            Me.mapControl1.Location = New System.Drawing.Point(0, 0)
            Me.mapControl1.Name = "mapControl1"
            Me.mapControl1.Size = New System.Drawing.Size(1264, 681)
            Me.mapControl1.TabIndex = 0
            ' 
            ' imageLayer1
            ' 
            Me.imageLayer1.DataProvider = Me.imageDataProvider
            ' 
            ' imageDataProvider
            ' 
            Me.imageDataProvider.TileSource = Nothing
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1264, 681)
            Me.Controls.Add(Me.mapControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.mapControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private mapControl1 As DevExpress.XtraMap.MapControl
        Private imageLayer1 As DevExpress.XtraMap.ImageLayer
        Private imageDataProvider As DevExpress.XtraMap.BingMapDataProvider
        Private informationLayer As DevExpress.XtraMap.InformationLayer
    End Class
End Namespace

