# Proje Kurulum ve Çalıştırma Rehberi

Bu proje bir ASP.NET Core MVC web uygulamasıdır.

---

## Gereksinimler

- Visual Studio 2022
- .NET 9.0 SDK
- SQL Server veya LocalDB
- Git (isteğe bağlı)

---

## Proje Oluşturma Adımları

1. Visual Studio 2022'yi aç.
2. "Create a new project" seçeneğine tıkla.
3. "ASP.NET Core Web App (Model-View-Controller)" şablonunu seç.
4. "Next" butonuna bas.
5. Proje adını `WebApp` olarak belirle.
6. Proje konumunu seç.
7. Solution adını onayla veya düzenle.
8. "Next" butonuna bas.
9. .NET versiyonu olarak **.NET 9.0** seç.
10. Authentication Type bölümünü **None** olarak ayarla.
11. HTTPS desteğini aktif bırak.
12. Docker ve OpenAPI seçeneklerini kapalı bırak.
13. "Create" butonuna tıkla.

---

## Dosya Yapılandırması

Boş proje oluştuktan sonra aşağıdaki klasörleri ve dosyaları projeye manuel olarak ekle:

- Controllers
- Models
- Views
- Data
- Program.cs
- appsettings.json

Bu repo, yalnızca sonradan oluşturulan veya düzenlenen dosyaları içerdiği için eksik klasör ve dosyaları sen oluşturacaksın.

---

## Gerekli NuGet Paketleri

Aşağıdaki NuGet paketlerini yükle:

- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools
- Microsoft.AspNetCore.Identity.EntityFrameworkCore

Paketleri yüklemek için:

### Visual Studio Üzerinden:
- Solution'a sağ tıkla > Manage NuGet Packages > Browse sekmesi > Paket isimlerini ara ve yükle.

### Komut Satırı Üzerinden:
- Visual Studio Terminal (Ctrl + `) veya dış terminal açıp proje dizininde şu komutları çalıştır:

```bash
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore
```

---

## Veritabanı Ayarları

`appsettings.json` dosyasını aşağıdaki gibi düzenle:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=WebAppDb;Trusted_Connection=True;"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}
```

---

## Migration ve Veritabanı Oluşturma

1. Visual Studio’da Tools > NuGet Package Manager > Package Manager Console aç.
2. Aşağıdaki komutları sırasıyla çalıştır:

```bash
Add-Migration InitialCreate
Update-Database
```

> Uyarı: `Add-Migration` komutunu çalıştırmadan önce projenin doğru başlatma projesi (Startup Project) olduğundan emin ol.

---

## Projeyi Çalıştırma

### Visual Studio Üzerinden:
- Projeyi aç.
- `Ctrl + F5` (Debugsuz çalıştır) veya `F5` (Debuglu çalıştır) tuşlarına bas.

### Terminal Üzerinden:
- Terminal aç.
- Proje klasörüne gir.
- Aşağıdaki komutu çalıştır:

```bash
dotnet run
```

Tarayıcıyı aç ve şu adrese git:

```
https://localhost:{port}
```

Örnek: `https://localhost:5000`

---

## Olası Hatalar ve Çözümleri

- **CS0246 Hatası (Model bulunamadı)**  
  -> Models klasöründeki tüm gerekli dosyaların mevcut olduğundan emin ol.

- **Veritabanı Bağlantı Hatası**  
  -> Connection string doğru olmalı, SQL Server çalışıyor olmalı.

- **Migration Hatası**  
  -> NuGet paketleri eksiksiz kurulu olmalı, doğru başlangıç projesi seçilmeli.

- **HTTPS Sertifika Sorunu**  
  -> Visual Studio'da sertifika güvenilir değilse yenilemek gerekebilir. (Tools > Options > Trust Development Certificates)

- **Port Çakışması**  
  -> Farklı bir uygulama aynı portu kullanıyorsa launchSettings.json içinden portu değiştir.

---

## Tavsiyeler

- Proje klasörlerini oluşturduktan sonra yapıyı doğru kurduğundan emin ol.
- Migration dosyaları kaybolursa veya veritabanı sıfırlanmak istenirse:
  - Migration klasörünü sil.
  - Veritabanını SQL Server Management Studio üzerinden sil.
  - Tekrar `Add-Migration` ve `Update-Database` komutlarını çalıştır.
- Gereksiz NuGet paketleri yüklemekten kaçın.
- Commit yaparken büyük dosyaları ve `bin`, `obj` klasörlerini `.gitignore` dosyasında belirt.

---

## Proje Akışı

| Adım | Yapılacak İşlem |
|:---|:---|
| 1 | Visual Studio'da boş bir ASP.NET Core MVC proje oluştur |
| 2 | Klasör ve dosya yapısını oluştur |
| 3 | NuGet paketlerini yükle |
| 4 | appsettings.json dosyasını yapılandır |
| 5 | Migration ve veritabanı işlemlerini yap |
| 6 | Projeyi başlat ve localhost üzerinden test et |

---

## İletişim

Herhangi bir sorunla karşılaşırsanız GitHub Issues kısmına bildirebilirsiniz.

---

**Başarılar!**
