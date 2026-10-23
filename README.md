# Projeyi Çalıştırmak için Gerekenler

UI katmanına **appsettings.json** isimli bir dosya oluşturulmalıdır. İçerisine:

```json
{
  "ConnectionStrings": {
    "DefaultString": "Host=HOST_NAME;Port=PORT_NUMBER;Database=DATABASE_NAME;Username=DATABASE_USERNAME;Password=DATABASE_PASSWORD"
  }
}
```

Dosyanın *Properties* kısmından **Copy to Output Directory** ayarı **Copy if newer** yapılmalıdır.

Aşağıdaki alanlar kendi veritabanı bilgilerinizle doldurulmalıdır:

- `HOST_NAME`
- `PORT_NUMBER`
- `DATABASE_NAME`
- `DATABASE_USERNAME`
- `DATABASE_PASSWORD`
