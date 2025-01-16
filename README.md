# Proje Adı: Timer ile Sayıcı ve LCD Gösterimi

## Proje Amacı
Bu proje, Tiva C mikrodenetleyicisi kullanarak bir zamanlayıcı (timer) tabanlı sayıcı sistemini geliştirme ve bu sayıcının değerlerini bir LCD ekrana yazdırma üzerine odaklanmaktadır. Kod, zamanı saniye, dakika ve saat olarak hesaplar ve 23:59:59'a ulaştığında sıfırlar.

## Dosya Yapısı
Proje dosyası "main.c" adlı ana kaynak kodunu içermektedir.

## Kullanılan Kütúphaneler
- `stdint.h` ve `stdbool.h`: Standart veri tipleri ve mantıksal değişkenler için.
- TivaWare kütúphaneleri:
  - `hw_memmap.h` ve `hw_types.h`
  - `sysctl.h`: Sistem saatini ayarlamak ve periferik birimleri etkinleştirmek için.
  - `gpio.h`: GPIO portlarını kontrol etmek için.
  - `timer.h`: Timer konfigürasyonu ve kesme işleyicisi.
  - `interrupt.h`: Kesme işlemleri.
- `lcd.h`: LCD ekranı kontrol etmek için. Bu kütüpanenin özelleştirildiği varsayılmaktadır.

## Program Akışı
1. **Sistem Saatinin Ayarlanması:**
   Program, `SysCtlClockSet()` fonksiyonunu kullanarak sistem saatini konfigüre eder.

2. **LCD Ayarları:**
   `LCDIlkayarlar()` fonksiyonu, LCD ekranı çalışır hale getirir.

3. **Timer Konfigürasyonu:**
   - Timer 0 periferik birimi etkinleştirilir.
   - Timer periyodik modda ayarlanır.
   - 1 saniyelik bir zamanlama için `TimerLoadSet()` fonksiyonu kullanılır.
   - Timer kesmesi etkinleştirilir ve `timer0IntHandler` fonksiyonu kesme işleyici olarak kaydedilir.

4. **Kesme İşlemleri:**
   `timer0IntHandler()` fonksiyonu her 1 saniyede bir çalışır ve şu işlemleri yapar:
   - Zaman değerlerini (saniye, dakika, saat) günceller.
   - LCD ekranın ilgili konumlarına bu değerleri yazdırır.
   - 23:59:59 zamanına ulaşıldığında zaman değerlerini sıfırlar.

## Fonksiyonlar
### `main()`
- Programın ana fonksiyonudur.
- Sistem saatini ve periferik ayarları yapar.
- Timer ve LCD konfigürasyonunu tamamlar.
- Sonsuz bir döngüde çalışır.

### `timer0IntHandler()`
- Timer kesmesi işlemini gerçekleştirir.
- Zaman hesaplama ve LCD yazdırma işlemlerini barındırır.

## Nasıl Kullanılır?
1. Proje dosyasını Tiva C geliştirme ortamına (Code Composer Studio veya Keil uVision) aktarın.
2. Donanım Bağlantısı:
   - Tiva C kartının uygun GPIO pinleri LCD ekranına bağlanmalı.
3. Projeyi derleyin ve Tiva C mikrodenetleyicisine yükleyin.
4. Cihazı çalıştırın. LCD ekranda saniye, dakika ve saat bilgisini gözlemleyebilirsiniz.

## Notlar
- LCD kütüpanesi olan `lcd.h` dosyası projede bulunmamaktadır ve bu dosyanın kullanımı proje doğruluğu için önemlidir.
- Kod, zamanı tam olarak hesaplayabilmek için sistem saatine bağlıdır; bu nedenle `SysCtlClockSet` parametreleri doğru ayarlanmalıdır.

## Gelecekteki Geliştirmeler
- Kullanıcı girişleriyle (butonlar vb.) zamanı ayarlama fonksiyonu eklenebilir.
- Daha çok bilgi görüntülemek için LCD ekran içeriği genişletilebilir.
- Zaman verilerini kaydeden bir hafıza modülü entegre edilebilir.

