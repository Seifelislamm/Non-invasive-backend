# Glucose Monitoring API (Prototype)

## الهدف
API بسيطة لاستقبال بيانات القياسات وإرجاع JSON وهمي.

## Endpoints
- GET /api/measurements/latest → بيانات افتراضية
- POST /api/measurements/add → حفظ بيانات Raw JSON

## تشغيل السيرفر
```bash
dotnet run
