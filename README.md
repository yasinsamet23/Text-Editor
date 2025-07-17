⚠️ Not:
Eğer proje dosyaları açılırken .resx dosyasında “web işareti” veya güvenlik engeli hatası alıyorsanız, bu sorun Windows güvenlik kısıtlamalarından kaynaklanıyor olabilir.

📌 Çözüm için şu adımları izleyin:

Proje klasörüne sağ tıklayın → Özellikler → Açılan pencerede varsa “Engellemeyi Kaldır” seçeneğini işaretleyin ve Tamam'a basın.

Alternatif olarak, PowerShell veya Komut İstemi’ni açarak proje klasöründe aşağıdaki komutu çalıştırabilirsiniz:

powershell :
Get-ChildItem -Recurse . | Unblock-File
Bu komut, klasördeki tüm dosyalardaki Windows güvenlik engellerini kaldırır ve dosyalarınızı sorunsuz açmanızı sağlar.



Ayrıca git clone yaparak'da indirebilirsiniz.

