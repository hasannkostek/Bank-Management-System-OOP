Banka Sistem Projesi Tanıtımı
Bu proje, modern bir banka sisteminin temel işlevlerini gerçekleştiren bir yazılım çözümüdür. Sistem, müşterilerin hesap yönetimi, para transferleri, kredi başvuruları gibi temel bankacılık işlemlerini gerçekleştirmelerine olanak tanır. Aynı zamanda banka personelinin müşteri hesaplarını yönetmesi ve banka yöneticilerinin sistem üzerinden raporlama yapabilmesi için gerekli fonksiyonları içerir.
Sistemin İçereceği İşlevler:

Hesap Yönetimi: Müşterilerin hesap açma, kapatma, bakiye sorgulama işlemleri
Para Transferi: Hesaplar arası para transferi, havale, EFT işlemleri
Kredi Başvurusu: Müşterilerin kredi başvurusu yapması ve takibi
Müşteri Bilgi Yönetimi: Müşteri bilgilerinin eklenmesi, güncellenmesi
Raporlama: Banka yöneticileri için hesap ve işlem raporları oluşturma

Banka Sistem Projesi - Özet
Tasarladığım banka sistemi, modern bir bankanın temel işlevlerini karşılayacak UML diyagramları ile modellenmiştir. Bu sistem aşağıdaki bileşenlerden oluşmaktadır:
Aktörler:

Müşteri: Sistemde hesap işlemleri yapan, para transferi gerçekleştiren ve kredi başvurusu yapabilen kullanıcı.
Banka Personeli: Müşteri bilgilerini yöneten, hesap açan ve kredi değerlendirmesi yapan çalışan.
Banka Yöneticisi: Sistem üzerinden raporlama işlemlerini gerçekleştiren üst düzey kullanıcı.

Use Case'ler (Kullanım Durumları):

Hesap Yönetimi: Hesap açma, kapatma, bakiye sorgulama işlemleri
Para Transferi: Hesaplar arası para transferi, havale, EFT işlemleri
Kredi Başvurusu: Müşterilerin kredi başvurusu yapması ve takibi
Müşteri Bilgi Yönetimi: Müşteri bilgilerinin eklenmesi, güncellenmesi
Raporlama: Banka yöneticileri için hesap ve işlem raporları oluşturma

Temel Sınıflar:

Kullanıcı Sınıfları: Kullanıcı (abstract), Müşteri, BankaPersoneli
Hesap Sınıfları: Hesap (abstract), VadesizHesap, VadeliHesap
İşlem Sınıfları: İşlem, Transfer, Kredi, Rapor

Sıra Diyagramları:
Her bir use case için sıra diyagramı oluşturulmuştur. Bu diyagramlar, aktörler ve sistem bileşenleri arasındaki etkileşimleri detaylı olarak göstermektedir. Örneğin:

Hesap Yönetimi sıra diyagramı
Para Transferi sıra diyagramı
Kredi Başvurusu sıra diyagramı
Müşteri Bilgi Yönetimi sıra diyagramı
Raporlama sıra diyagramı

Sistem İşlevleri:

Hesap Yönetimi: Müşteriler hesaplarını görüntüleyebilir, bakiye sorgulayabilir, para yatırabilir ve çekebilir. Banka personeli ise müşteriler için yeni hesaplar açabilir ve gerektiğinde kapatabilir.
Para Transferi: Sistem, müşterilerin hesaplar arası para transferi yapmalarına olanak tanır. Havale ve EFT gibi farklı transfer türleri desteklenir. Her transfer öncesi kaynak ve hedef hesap kontrolü yapılır.
Kredi Başvurusu: Müşteriler sisteme kredi başvurusu yapabilir. Risk değerlendirmesi sonrası kredi başvurusu onaylanır veya reddedilir. Onaylanan krediler için ödeme planı oluşturulur.
Müşteri Bilgi Yönetimi: Banka personeli, müşterilerin bilgilerini ekleyebilir, güncelleyebilir ve gerektiğinde sorgulayabilir. Müşteri kimlik bilgileri doğrulama servisi aracılığıyla kontrol edilir.
Raporlama: Banka yöneticileri, hesap durumları, işlem geçmişleri ve kredi kullanımları gibi çeşitli raporlar alabilir. Raporlar PDF veya Excel formatında dışa aktarılabilir.


1. Hesap Yönetimi Use Case Diyagramı
Bu diyagram, hesap yönetimi modülünde yapılabilecek işlemleri gösteriyor:

Hesap Açma: Yeni bir hesap oluşturma işlemi (banka personeli tarafından yapılır)
Hesap Kapatma: Var olan bir hesabı kapatma işlemi (banka personeli tarafından yapılır)
Bakiye Sorgulama: Hesap bakiyesini görüntüleme (müşteri ve personel tarafından yapılabilir)
Para Yatırma/Çekme: Hesaba para yatırma veya çekme işlemleri (müşteri tarafından yapılır)

Include ilişkisi, hesap açma işleminin hesap kapatma sürecini içerebileceğini gösteriyor.
2. Para Transferi Use Case Diyagramı
Bu diyagram, para transferi modülündeki işlemleri gösteriyor:

Havale: Aynı banka içindeki hesaplar arası transfer
EFT: Farklı bankalar arasındaki para transferi
Virman: Müşterinin kendi hesapları arasındaki transfer
Transfer İzleme: Transfer durumunu kontrol etme

Include ilişkisi, havale ve EFT işlemlerinin transfer izleme fonksiyonunu içerdiğini gösteriyor.
3. Kredi Başvurusu Use Case Diyagramı
Bu diyagram, kredi başvuru modülündeki işlemleri gösteriyor:

Kredi Başvurusu Yap: Yeni bir kredi başvurusu oluşturma
Evrak Yükle: Kredi başvurusu için gerekli belgeleri sisteme yükleme
Başvuru Değerlendir: Kredi başvurusunun değerlendirilmesi
Ödeme Planı Görüntüle: Onaylanan kredi için ödeme planını görüntüleme

Include ve extend ilişkileri, başvuru sürecinin evrak yüklemeyi içerdiğini ve başvuru onaylanırsa ödeme planının görüntülenebileceğini gösteriyor.
4. Müşteri Bilgi Yönetimi Use Case Diyagramı
Bu diyagram, müşteri bilgilerinin yönetildiği modüldeki işlemleri gösteriyor:

Müşteri Ekleme: Yeni müşteri kaydı oluşturma
Müşteri Bilgisi Güncelleme: Mevcut müşteri bilgilerini güncelleme
Müşteri Bilgisi Görüntüleme: Müşteri bilgilerini görüntüleme
Kimlik Doğrulama: Müşteri kimlik bilgilerinin doğrulanması

Include ilişkisi, müşteri ekleme ve güncelleme işlemlerinin kimlik doğrulama sürecini içerdiğini gösteriyor.
5. Raporlama Use Case Diyagramı
Bu diyagram, raporlama modülündeki işlemleri gösteriyor:

Hesap Raporu Oluştur: Hesaplarla ilgili raporlar oluşturma
İşlem Raporu Oluştur: Yapılan işlemlerle ilgili raporlar oluşturma
Müşteri Raporu Oluştur: Müşterilerle ilgili raporlar oluşturma
Raporu Dışa Aktar: Oluşturulan raporları PDF, Excel gibi formatlarda dışa aktarma