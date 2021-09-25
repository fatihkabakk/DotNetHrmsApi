# Human Resources API Project

<p align="right"><a href="/README.md">[TR]</a></p>

## _Requirements;_

<hr>

**Req 1: Applicants must be able to register to The System.**

_Accept Conditions:_

- During registration, The User is asked for Name, Surname, T.C. No (Identity No.), Year Of Birth, E-mail, Password, Password Repetition.
- All fields are obligatory. The User is informed.
- Registration is done by doing Mernis Verification.
- If verification is not valid, The User is informed.
- If there are any prior registrations with The Same E-mail or T.C. No, The Registration does not happen. The User is informed.
- E-mail verification is required for The Registration to complete.

**Req 2: Employers must be able to register to The System.**

_Accept Conditions:_

- During registration, The User is asked for Company name, WebSite, E-mail with The Same Domain as The WebSite, Phone Number, Password, Password repeat information. The Purpose here is to prevent non-companies from registering to The System.
- All fields are obligatory. The User is informed.
- Company registrations are verified in 2 ways. E-mail verification is required for The Registration to complete. Approval of HRMS staff (our :)) is required.
- If there are any prior registrations with The Same E-mail, The Registration does not happen. The User is informed.

**Req 3: Job Positions must be able to be added to The system. Ex: Software Developer, Software Architect.**

_Accept Conditions:_

- These positions can not be repeated. The User is warned.

**Req 4: Employers must be able to be listed. (Just The Whole List)**

**Req 5: Applicants must be able to be listed. (Just The Whole List)**

**Req 6: Job Positions must be able to be listed. (Just The Whole List)**

**Req 7: Employers must be able to add job advertisements to The System.**

_In Job Advertisement Form;_

- Job position must be able to be choosen from dropdown box. (Ex: Java Developer) (Obligatory)
- Description must be able to be (Ex: For developers who are proficient in JAVA and C# languages...) (Obligatory)
- City information must be able to be choosen from dropdown box. (Obligatory)
- For the salary range, min-max entry must be possible.(Optional)
- Vacancy count must be able to be added. (Obligatory)
- Application Deadline must be able to be added.

**Req 8: All The Active Job Advertisements in The System must be able to be listed.**

- The List must be in table form.
- The Job Position Name, The Vacany Count, Publishment Date and The Application Deadline informations must be present on The List.

**Req 9: All The Active Job Advertisements in The System must be able to be listed by date.**

- The List must be in table form.
- The Company Name, The Job Position Name, The Vacany Count, Publishment Date and The Application Deadline informations must be present on The List.

**Req 10: All The Active Job Advertisements of a Company in The System must be able to be listed.**

- The List must be in table form.
- The Company Name, The Job Position Name, The Vacany Count, Publishment Date and The Application Deadline informations must be present on The List.

**Req 11: Employers must be able to disable Job Advertisements. (Passive Advertisement)**
