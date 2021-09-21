# Human Resources API Project

<p style="float: right"><a href="/blob/master/README.md">[TR]</a></p>
<br />

<p style="font-size: 1.25rem; margin: 5px 0;">
    <b>Requirements;</b>
</p>
<b>Req 1: Applicants must be able to register to The System.</b>

<p style="margin: 4px 0;">Accept Conditions:</p>
<ol style="list-style: circle;">
    <li>During registration, The User is asked for Name, Surname, T.C. No (Identity No.), Year Of Birth, E-mail, Password, Password Repetition.</li>
    <li>All fields are obligatory. The User is informed.</li>
    <li>Registration is done by doing Mernis Verification.</li>
    <li>If verification is not valid, The User is informed.</li>
    <li>If there are any prior registrations with The Same E-mail or T.C. No, The Registration does not happen. The User is informed.</li>
    <li>Email verification is required forTheregistration to complete.</li>
</ol>

<b>Req 2: Employers must be able to register toThesystem.</b>

<p style="margin: 4px 0;">Accept Conditions:</p>

<ol style="list-style: circle;">
    <li>During registration, The User is asked for Company name, WebSite, E-mail withThesame domain as The WebSite, Phone Number, Password, Password repeat information. The Purpose here is to prevent non-companies from registering toThesystem.</li>
    <li>All fields are obligatory. The User is informed.</li>
    <li>Company registrations are verified in 2 ways. Email verification is required forTheregistration to complete. Approval of HRMS staff (our :)) is required.</li>
    <li>If there are any prior registrations withThesame e-mail,Theregistration does not happen. The User is informed.</li>
</ol>

<b>Req 3: Job Positions should be able to be added toThesystem. Ex: Software Developer, Software Architect.</b>

<p style="margin: 4px 0;">Accept Conditions:</p>

<ol style="list-style: circle;">
    <li>These positions can not be repeated. The User is warned.</li>
</ol>
