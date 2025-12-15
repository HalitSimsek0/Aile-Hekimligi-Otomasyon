# Aile-Hekimligi-Otomasyon



Bu proje, Türkiye Cumhuriyeti’nde aktif olarak kullanılan bir aile hekimliği otomasyon sistemini temel alarak geliştirilmiş, çok katmanlı mimariye sahip bir masaüstü ve Web API tabanlı otomasyon uygulamasıdır.



Proje, Sağlık Bakanlığı onaylı bir firmada yapılan staj sürecinde, gerçek sistemlerin işleyişi incelenerek ve birebir kullanım senaryoları dikkate alınarak geliştirilmiştir. Ticari bir ürün değildir; eğitim ve yazılım geliştirme amacıyla hazırlanmış bir örnek çalışmadır.



--------------------------------------------------



Projenin Amacı



\- Gerçek hayatta kullanılan aile hekimliği otomasyonlarının işleyiş mantığını birebir modellemek

\- Hasta kabul, sıra sistemi, doktor atama ve yönetim süreçlerini yazılımsal olarak simüle etmek

\- Katmanlı mimari, veri yönetimi ve kullanıcı akışlarını uygulamalı olarak geliştirmek



--------------------------------------------------



Genel Sistem Akışı



Giriş / Kiosk Ekranı



Uygulama ilk açıldığında TC Kimlik Numarası giriş ekranı gelir.  

Kullanıcı TC girerek sisteme giriş yapar.



Kayıtlı Kullanıcı Senaryosu



Kullanıcı sistemde kayıtlıysa:

\- Hoş geldiniz ekranı gösterilir  

&nbsp; Örnek:  

&nbsp; Hoş geldiniz Halit Şimşek – Doktorunuz: Oğuz Aydın

\- Ardından sıra ekranına yönlendirilir.

\- Kullanıcı:

&nbsp; - Kaçıncı sırada olduğunu

&nbsp; - Kendinden önce ve sonra gelenleri

&nbsp; - Bağlı olduğu doktoru

&nbsp; görebilir.



Kayıtsız Kullanıcı (Misafir) Senaryosu



Kullanıcı sistemde kayıtlı değilse:

\- Hoş geldiniz ekranında sadece TC bilgisi gösterilir.

\- Sistem tarafından rastgele bir doktora atanır.

\- Sıra ekranına yönlendirilerek sırası gösterilir.



--------------------------------------------------



Admin / Yönetim Paneli



Giriş ekranında belirli bir alana çift tıklanarak yönetim paneline geçilir.



Admin panelinde bulunan başlıca modüller:



\- Kişi Listesi  

&nbsp; Aile hekimliğinin açıldığı günden itibaren kayıtlı tüm kişiler



\- Kabul Listesi  

&nbsp; Bugün gelen ve kabul sürecinde olan kişiler



\- Misafir Listesi  

&nbsp; Bugün gelen, kayıtlı olmayan kişiler



\- MHRS Listesi  

&nbsp; MHRS üzerinden randevu almış hastalar



\- Hekim Listesi  

&nbsp; Kurumda çalışan doktorların bilgileri



Admin panelinde yapılabilen işlemler:

\- Yeni doktor kaydı

\- Yeni kişi kaydı

\- Tüm tabloları listeleme

\- Tüm verileri temizleme

\- Arama (kişi veya doktor adına göre)

\- Kayıtlı kişi veya doktor silme

\- Giriş ekranına dönüş

\- Uygulamayı (kiosk) kapatma



--------------------------------------------------



Doktor Ekranı



Admin panelinden doktor ekranına geçiş yapılabilir.



Doktor:

\- Kullanıcı adı ve şifre ile giriş yapar

\- Sadece kendisine atanmış hastaları görür

\- Hastaları kabul etme veya reddetme işlemlerini yapabilir



Bu ekran, admin panelinden bağımsız olarak doktorlara özel tasarlanmıştır.



--------------------------------------------------



Kullanılan Teknolojiler



\- C#

\- .NET

\- WinForms (Desktop UI)

\- ASP.NET Web API

\- SQL Server

\- Entity Framework

\- Katmanlı Mimari

&nbsp; Core

&nbsp; Entities

&nbsp; DataAccess

&nbsp; Business

&nbsp; UI

&nbsp; WebAPI



--------------------------------------------------



Proje Yapısı



\- Core: Ortak altyapı ve yardımcı yapılar

\- Entities: Veri modelleri (POCO)

\- DataAccess: Veritabanı erişimi ve repository yapıları

\- Business: İş kuralları ve servis katmanı

\- UI: WinForms arayüzleri

\- WebAPI: REST API katmanı



--------------------------------------------------



Notlar



Bu proje gerçek bir ticari ürün değildir.  

Sağlık Bakanlığı’na ait herhangi bir gizli veri veya kaynak içermemektedir.  

Eğitim, staj ve yazılım mimarisi öğrenimi amacıyla geliştirilmiştir.



--------------------------------------------------



Geliştirici



Halit Şimşek  

Bilgisayar Mühendisliği Öğrencisi



