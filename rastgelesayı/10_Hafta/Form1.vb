Public Class Form1

    Private Sub ButtonYontem1_Click(sender As Object, e As EventArgs) Handles ButtonYontem1.Click
        Dim sayi As Decimal
        'sayi = Rnd()
        '0 ile 1 arasında ondalık sayı
        'sayi = CInt(Rnd() * 100)'0 ilke 100 arasında sayı üretiyor
        'sayi = CInt(Rnd() * 5) + 5 '5 ile 10 arasında sayı üretir
        sayi = CInt(Rnd() * 1000) Mod 6 + 5 '5 ile 10 arasında sayı üretir
        'Büyük sayıdan küçük sayı çıkart + 1 ekle mod değeri olarak yaz
        ' mod .. + dan sonra küçük sayı
        TextBoxUretme.Text = sayi


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
    End Sub

    Private Sub ButtonYontem2_Click(sender As Object, e As EventArgs) Handles ButtonYontem2.Click
        Dim sayi As Decimal
        Dim Rastgele As New Random
        'sayi = Rastgele.Next'Negatif olmayan integer sayılar üretir
        'sayi = Rastgele.Next(10) '0 ile 10 arasında sayılar üretir
        sayi = Rastgele.Next(10, 20) '10 ile 20 arasında random üretir'
        TextBoxUretme.Text = sayi



    End Sub
End Class
