using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Contacts.Models
{
    public class ContactDbInotializer : DropCreateDatabaseAlways<ContactContext>
    {
        protected override void Seed(ContactContext db)
        {
            db.Contacts.Add(new Contact { FullName = "Иванов Иван", Phone = "+380445555551", Email = "ivano_i@mail.com" });
            db.Contacts.Add(new Contact { FullName = "Петров Иван", Phone = "0445555552", Email = "petrov_i@mail.com" });
            db.Contacts.Add(new Contact { FullName = "Сергеев Иван", Phone = "0445555553", Email = "sergeev_i@mail.com" });
            db.Contacts.Add(new Contact { FullName = "Иванов Сегрей", Phone = "+380445555554", Email = "ivanoe_s@mail.com" });
            db.Contacts.Add(new Contact { FullName = "Петров Сегрей", Phone = "0445555555", Email = "petrov_s@mail.com" });
            db.Contacts.Add(new Contact { FullName = "Сергеев Сергей", Phone = "0445555556", Email = "sergeev_s@mail.com" });
            db.Contacts.Add(new Contact { FullName = "Иванов Петр", Phone = "+380445555557", Email = "ivanoe_p@mail.com" });
            db.Contacts.Add(new Contact { FullName = "Петров Петр", Phone = "0445555558", Email = "petrov_p@mail.com" });
            db.Contacts.Add(new Contact { FullName = "Сергеев Петр", Phone = "0445555559", Email = "sergeev_p@mail.com" });
            db.Contacts.Add(new Contact { FullName = "Иванов Иван1", Phone = "+380445555551", Email = "ivano_i@mail.com" });
            db.Contacts.Add(new Contact { FullName = "Петров Иван1", Phone = "0445555552", Email = "petrov_i@mail.com" });
            db.Contacts.Add(new Contact { FullName = "Сергеев Иван1", Phone = "0445555553", Email = "sergeev_i@mail.com" });
            db.Contacts.Add(new Contact { FullName = "Иванов Сегрей1", Phone = "+380445555554", Email = "ivanoe_s@mail.com" });
            db.Contacts.Add(new Contact { FullName = "Петров Сегрей1", Phone = "0445555555", Email = "petrov_s@mail.com" });
            db.Contacts.Add(new Contact { FullName = "Сергеев Сергей1", Phone = "0445555556", Email = "sergeev_s@mail.com" });
            db.Contacts.Add(new Contact { FullName = "Иванов Петр1", Phone = "+380445555557", Email = "ivanoe_p@mail.com" });
            db.Contacts.Add(new Contact { FullName = "Петров Петр1", Phone = "0445555558", Email = "petrov_p@mail.com" });
            db.Contacts.Add(new Contact { FullName = "Сергеев Петр1", Phone = "0445555559", Email = "sergeev_p@mail.com" });

            base.Seed(db);
        }
    }
}