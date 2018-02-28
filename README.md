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
