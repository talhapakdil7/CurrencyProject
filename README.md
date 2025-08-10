
# 💱 CurrencyProject

C# (WinForms) ile yazılmış **basit döviz kuru takip uygulaması**. Uygulama, bir API'den anlık kurları çeker ve ekranda listeler.

---

## 🚀 Özellikler
- Anlık döviz kurları alma (örn. exchangerate.host)
- Basit listeleme/gösterim
- Elle **Yenile** (Refresh) ile güncelleme
- Varsayılan **base** para birimi seçimi (örn. USD)

> Not: Proje küçük ölçekli olduğundan özellik listesi minimum tutulmuştur. İleride genişletilebilir.

---

## 🛠️ Teknolojiler
- **.NET / C#** (WinForms)
- **HttpClient** ile HTTP istekleri
- **Newtonsoft.Json** ile JSON ayrıştırma

---

## 📦 Kurulum
1. Depoyu klonlayın:
   ```bash
   git clone https://github.com/talhapakdil7/CurrencyProject.git
   cd CurrencyProject


2. **Visual Studio** ile `CurrencyProject.sln` dosyasını açın.
3. **NuGet** paketlerini geri yükleyin (örn. `Newtonsoft.Json`).
4. **F5** ile çalıştırın.

---

## ⚙️ Yapılandırma

Basit kullanım için herhangi bir API anahtarı gerekmez.

* **exchangerate.host** örnek çağrı:

  ```text
  https://api.exchangerate.host/latest?base=USD&symbols=TRY,EUR
  ```

İsterseniz `app.config` içine varsayılan **BaseCurrency** ve **ApiUrl** anahtarları ekleyebilirsiniz:

```xml
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
  <appSettings>
    <add key="BaseCurrency" value="USD" />
    <add key="ApiUrl" value="https://api.exchangerate.host/latest" />
  </appSettings>
</configuration>
```

---

## 🧭 Örnek Proje Yapısı

> Dosya/klasör isimleri projedeki gerçek durumunuza göre ufak farklılık gösterebilir.

```
CurrencyProject/
├─ CurrencyProject.sln
└─ CurrencyProject/           # WinForms proje kökü
   ├─ Forms/
   │  └─ MainForm.cs         # Ana ekran
   ├─ Services/
   │  └─ CurrencyService.cs  # API istekleri
   ├─ Models/
   │  └─ RateResponse.cs     # JSON model(ler)
   ├─ Properties/
   └─ App.config
```

---






