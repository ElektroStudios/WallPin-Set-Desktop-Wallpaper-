Friend NotInheritable Class WallpaperConfig

    Friend ReadOnly WallpaperStyle As String
    Friend ReadOnly TileWallpaper As String

    Private Sub New()
    End Sub

    Friend Sub New(style As String, tile As String)
        Me.WallpaperStyle = style
        Me.TileWallpaper = tile
    End Sub

End Class