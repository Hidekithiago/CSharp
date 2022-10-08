## <a href="https://github.com/Hidekithiago/Automacao/blob/master/README.md">Email</a> <br>
<details>
<details><summary><b>Send Email</b></summary>
  
####  NuGet
  > 
  
####  import
  > using System.Net.Mail;
  ><br>using System.Net;
  
####  Code  
  > public static void sendEmail(String de, String para, String assunto, String corpo, Boolean html, String provedor, String senha)
  ><br>      {
  ><br>            MailAddress from = new MailAddress(de);
  ><br>            MailAddress to = new MailAddress(para);
  ><br>            MailMessage mail = new MailMessage(from, to);
  ><br>          try { mail.To.Add(recebe_email1); } catch { }
  ><br>          mail.CC.Add(cc_email);
  ><br>          mail.CC.Add(cc_email1);
  ><br>          mail.CC.Add(cc_email2);
  ><br>
  ><br>
  ><br>          mail.Subject = assunto;
  ><br>          if (html.Equals(true))
  ><br>          {
  ><br>              mail.IsBodyHtml = true;
  ><br>              mail.BodyEncoding = System.Text.Encoding.UTF8;
  ><br>          }
  ><br>          mail.Body = "";
  ><br>
  ><br>
  ><br>          SmtpClient smtp = new SmtpClient();
  ><br>          if (provedor.Equals("gmail"))
  ><br>          { //SMTP do gmail
  ><br>              smtp.Host = "smtp.gmail.com";
  ><br>              smtp.Port = 587;
  ><br>              smtp.Credentials = new NetworkCredential(de, senha);
  ><br>              smtp.EnableSsl = true;
  ><br>         }
  ><br>          Console.WriteLine("Enviando e-mail...");
  ><br>         smtp.Send(mail);
  ><br>         Console.WriteLine("Email enviado com sucesso");
  ><br>     }
  
</details>
</details>
