using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Web;

namespace AnkoperMuzikDans.Entity
{
    public class DataInitilializer : CreateDatabaseIfNotExists<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            
            var instruments = new List<Instrument>()
            {
                new Instrument(){Name = "Piyano",_image = {new Image(){Name = "1.jpg"}}},
                new Instrument(){Name = "Keman",_image = {new Image(){Name = "1.jpg"}}},
                new Instrument(){Name = "Gitar",_image = {new Image(){Name = "1.jpg"}}},
                new Instrument(){Name = "Klarinet",_image = {new Image(){Name = "1.jpg"}}},
                new Instrument(){Name = "Flüt",_image = {new Image(){Name = "1.jpg"}}}
            };

            foreach (var item in instruments)
            {
                context.Instruments.Add(item);
            }

            context.SaveChanges();

            var lectures = new List<Lecture>()
            {
                new Lecture(){Name = "Ders-1"},
                new Lecture(){Name = "Ders-2"},
                new Lecture(){Name = "Ders-3"}
            };

            foreach (var item in lectures)
            {
                context.Lectures.Add(item);
            }

            context.SaveChanges();

            var instructers = new List<Instructor>()
            {

                new Instructor(){Name = "Mehmet",SurnName = "UĞUR",Description = "mhtuurmhtuurmhtuur",_images={new Image(){Name = "1.jpg"}},InstrumentId = 1},
                new Instructor(){Name = "Deniz",SurnName = "Turkmen",Description = "DenizTurkmenDenizTurkmen",_images={new Image(){Name = "1.jpg"}},InstrumentId = 3},
                new Instructor(){Name = "Ziya",SurnName = "Aktaş",Description = "ZiyaAktaşZiyaAktaşZiyaAktaş",_images={new Image(){Name = "1.jpg"}},InstrumentId = 2},
                new Instructor(){Name = "Mustafa",SurnName = "Sert",Description = "MustafaSert",_images={new Image(){Name = "1.jpg"}},InstrumentId = 1}

            };

            foreach (var item in instructers)
            {
                context.Instructors.Add(item);
            }

            context.SaveChanges();

            base.Seed(context);
        }
    }
}