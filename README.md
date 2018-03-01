# melipayamak-Csharp

<div dir='rtl'>

### معرفی وب سرویس ملی پیامک
ملی پیامک یک وب سرویس کامل برای ارسال و دریافت پیامک و پیامک صوتی و مدیریت کامل خدمات دیگر است که براحتی میتوانید از آن استفاده کنید.

### نصب
<hr>
<p>قبل از نصب نیاز به ثبت نام در سایت ملی پیامک دارید.</p>

[**ثبت نام به همراه 500 پیامک رایگان اولیه تست وبسرویس**](http://www.melipayamak.com/)

پس از ثبت نام، وب سرویس‌های ملی پیامک را از طریق آدرسهای زیر به عنوان **Service Reference** به پروژه خود اضافه کنید.

</div>

<div dir='rtl'>
  
#### وب سرویس ارسال پیام

</div>

> [api.payamak-panel.com/post/Send.asmx](http://api.payamak-panel.com/post/Send.asmx)


<div dir='rtl'>
  
#### وب سرویس دریافت پیام

</div>

> [api.payamak-panel.com/post/receive.asmx](http://api.payamak-panel.com/post/receive.asmx)


<div dir='rtl'>
  
#### وب سرویس مدیریت مخاطبین

</div>

> [api.payamak-panel.com/post/contacts.asmx](http://api.payamak-panel.com/post/contacts.asmx)

> [api.payamak-panel.com/post/Actions.asmx](http://api.payamak-panel.com/post/Actions.asmx)

<div dir='rtl'>
  
#### وب سرویس ارسال زماندار

</div>

> [api.payamak-panel.com/post/Schedule.asmx](http://api.payamak-panel.com/post/Schedule.asmx)


<div dir='rtl'>
  
#### وب سرویس پشتیبانی کاربران

</div>

> [api.payamak-panel.com/post/Tickets.asmx](http://api.payamak-panel.com/post/Tickets.asmx)


<div dir='rtl'>
  
#### وب سرویس مدیریت کاربران

</div>

> [api.payamak-panel.com/post/Users.asmx](http://api.payamak-panel.com/post/Users.asmx)


<div dir='rtl'>
  
#### وب سرویس ارسال صوتی

</div>

> [api.payamak-panel.com/post/Voice.asmx](http://api.payamak-panel.com/post/Voice.asmx)

<div dir='rtl'>
  
#### نحوه استفاده

نمونه کد برای ارسال پیامک

</div>


```js
const string username = "username";
const string password = "password";
const string from = "5000...";
const string to = "09123456789";
const string text = "تست وب سرویس ملی پیامک";
SendSoapClient client = new SendSoapClient();
client.SendSimpleSMS(username, password, new string[] { to }, from, text, false);
```

<div dir='rtl'>

از آنجا که وب سرویس ملی پیامک تنها محدود به ارسال پیامک نیست شما از طریق زیر میتوانید به وب سرویس ها دسترسی کامل داشته باشید:
</div>

```js
// وب سرویس پیامک
SendRestClient restClient = new SendRestClient();
SendSoapClient soapClient = new SendSoapClient();
// وب سرویس تیکت پشتیبانی
TicketsSoapClient ticketClient = new TicketsSoapClient();
// وب سرویس برای مدیریت کامل  ارسال انبوه پیامک
ActionsSoapClient actionClient = new ActionsSoapClient();
//وب سرویس کاربران
UsersSoapClient usersClient = new UsersSoapClient();
//وب سرویس دفترچه تلفن
ContactsSoapClient contactsClient = new ContactsSoapClient();
//وب سرویس زمان بندی
ScheduleSoapClient scheduleClient = new ScheduleSoapClient();
//وب سرویس پیام صوتی
VoiceSoapClient voiceClient = new VoiceSoapClient();
```

<div dir='rtl'>
  
#### تفاوت های وب سرویس پیامک rest و soap

از آنجا که ملی پیامک وب سرویس کاملی رو در اختیار توسعه دهندگان میگزارد برای راحتی کار با وب سرویس پیامک علاوه بر وب سرویس اصلی soap وب سرویس rest رو هم در اختیار توسعه دهندگان گزاشته شده تا راحتتر بتوانند با وب سرویس کار کنند. تفاوت اصلی این دو در تعداد متد هاییست که میتوانید با آن کار کنید. برای کار های پایه میتوان از وب سرویس rest استفاده کرد برای دسترسی بیشتر و استفاده پیشرفته تر نیز باید از وب سرویس باید از وب سرویس soap استفاده کرد. جهت مطالعه بیشتر وب سرویس ها به قسمت وب سرویس پنل خود مراجعه کنید.

<hr/>


###  اطلاعات بیشتر

برای مطالعه بیشتر و دریافت راهنمای وب سرویس ها و آشنایی با پارامتر های ورودی و خروجی وب سرویس به صفحه معرفی
[وب سرویس ملی پیامک](https://github.com/Melipayamak/Webservices)
مراجعه نمایید .


<hr/>


### وب سرویس پیامک

متد های وب سرویس:

</div>

