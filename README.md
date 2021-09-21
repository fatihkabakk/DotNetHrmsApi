# İnsan Kaynakları API Projesi

<p style="float: right"><a href="/blob/master/README-EN.md">[EN]</a></p>
<br />

<p style="font-size: 1.25rem; margin: 5px 0;">
    <b>Gereksinimler;</b>
</p>
<b> Req 1: İş Arayanlar sisteme kayıt olabilmelidir. </b>

<p style="margin: 4px 0;">Kabul Kriterleri:</p>
<ol style="list-style: circle;">
<li>Kayıt sırasında kullanıcıdan Ad, Soyad, T.C. No, Doğum Yılı, E-Posta, Şifre, Şifre Tekrarı bilgileri istenir.</li>
<li>Tüm alanlar zorunludur. Kullanıcı bilgilendirilir.</li>
<li>Mernis doğrulaması yapılarak sisteme kayıt gerçekleştirilir.</li>
<li>Doğrulama geçerli değilse kullanıcı bilgilendirilir.</li>
<li>Daha önce kayıtlı bir E-Posta veya T.C No var ise kayıt gerçekleşmez. Kullanıcı bilgilendirilir.</li>
<li>Kaydın gerçekleşmesi için E-Posta doğrulaması gerekir.</li>
</ol>

<b>Req 2: İş Verenler sisteme kayıt olabilmelidir. </b>

<p style="margin: 4px 0;">Kabul Kriterleri:</p>

<ol style="list-style: circle;">
<li>Kayıt sırasında kullanıcıdan Şirket Adı, Web Sitesi, Web Sitesi ile aynı domaine sahip E-Posta, Telefon Numarası, Şifre, Şifre Tekrarı bilgileri istenir. Burada amaç sisteme şirket olmayanların katılmasını engellemektir.</li>
<li>Tüm alanlar zorunludur. Kullanıcı bilgilendirilir.</li>
<li>Şirket kayıtları iki şekilde doğrulanır. Kaydın gerçekleşmesi için E-Posta doğrulaması gerekir. HRMS personelinin (bizim :)) onayı gerekmektedir.</li>
<li>Daha önce kayıtlı bir E-Posta var ise kayıt gerçekleşmez. Kullanıcı bilgilendirilir.</li>
</ol>

<b>Req 3: Sisteme İş Pozisyonları eklenebilmelidir. Örneğin; Yazılım Geliştirici (Software Developer), Yazılım Mühendisi (Software Architect).</b>

<p style="margin: 4px 0;">Kabul Kriterleri:</p>
<ol style="list-style: circle;">
<li>Bu pozisyonlar tekrar edemez. Kullanıcı uyarılır.</li>
</ol>
