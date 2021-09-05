using EmailServices.Interface;
using EmailServices.Models;
using FluentEmail.Core;
using FluentEmail.Smtp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EmailServices.Sevices
{
    class EmailService : ISentEmail
    {
        private readonly IEmployeeBirthday _birthdayWishes;

        public EmailService(IEmployeeBirthday BirthdayWishes)
        {

            _birthdayWishes = BirthdayWishes;
        }

        public async void Birthdaywishes()
        {
            var employeeBday = await _birthdayWishes.GetEmployeeBirthday();
          
            foreach (var i in employeeBday) //if user json respnd had email
            {
                var sender = new SmtpSender(() => new SmtpClient("local")

          

                { //already configure on NET5
                 EnableSsl = false,

                DeliveryMethod = SmtpDeliveryMethod.Network,
                Port = 25
                //below method can be used to sent to local

                    //DeliveryMethod = SmtpDeliveryMethod.SpecifiedPickupDirectory,
                    //PickupDirectoryLocation = @"C:\Demos"


                });
                StringBuilder Body_Template = new();
                Body_Template.AppendLine("HappyBirthday" + i.name + i.lastname); //sentEmail to employee


                Email.DefaultSender = sender;

                var email = await Email
                     .From("donald@gmail.com")
                     .To("donaldmathekgad@gmail.com") //this should be user email
                     .Subject("Its your Birthday")
                     .Body(Body_Template.ToString())
                     .SendAsync();




            }

       }
    }
    
}
