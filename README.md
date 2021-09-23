# İnsan Kaynakları API Projesi

<p align="right"><a href="/README-EN.md">[EN]</a></p>

## _Gereksinimler;_

<hr>

**Req 1: İş Arayanlar sisteme kayıt olabilmelidir.**

_Kabul Kriterleri:_

- Kayıt sırasında kullanıcıdan Ad, Soyad, T.C. No, Doğum Yılı, E-Posta, Şifre, Şifre Tekrarı bilgileri istenir.
- Tüm alanlar zorunludur. Kullanıcı bilgilendirilir.
- Mernis doğrulaması yapılarak sisteme kayıt gerçekleştirilir.
- Doğrulama geçerli değilse kullanıcı bilgilendirilir.
- Daha önce kayıtlı bir E-Posta veya T.C No var ise kayıt gerçekleşmez. Kullanıcı bilgilendirilir.
- Kaydın gerçekleşmesi için E-Posta doğrulaması gerekir.

**Req 2: İş Verenler sisteme kayıt olabilmelidir.**

_Kabul Kriterleri:_

- Kayıt sırasında kullanıcıdan Şirket Adı, Web Sitesi, Web Sitesi ile aynı domaine sahip E-Posta, Telefon Numarası, Şifre, Şifre Tekrarı bilgileri istenir. Burada amaç sisteme şirket olmayanların katılmasını engellemektir.
- Tüm alanlar zorunludur. Kullanıcı bilgilendirilir.
- Şirket kayıtları iki şekilde doğrulanır. Kaydın gerçekleşmesi için E-Posta doğrulaması gerekir. HRMS personelinin (bizim :)) onayı gerekmektedir.
- Daha önce kayıtlı bir E-Posta var ise kayıt gerçekleşmez. Kullanıcı bilgilendirilir.

**Req 3: Sisteme İş Pozisyonları eklenebilmelidir. Örneğin; Yazılım Geliştirici (Software Developer), Yazılım Mühendisi (Software Architect).**

_Kabul Kriterleri:_

- Bu pozisyonlar tekrar edemez. Kullanıcı uyarılır.

**Req 4: İş verenler listelenebilmelidir. (Sadece tüm liste)**

**Req 5: İş arayanlar listelenebilmelidir. (Sadece tüm liste)**

**Req 6: İş pozisyonları listelenebilmelidir. (Sadece tüm liste)**
