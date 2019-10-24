using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnkoperMuzikDans.Entity
{
    public class Instructor
    {
        public Instructor()
        {
            _instrument = new List<Instrument>();
            _images = new List<Image>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public string SurnName { get; set; }


        public string Description { get; set; }

        public List<Instrument> _instrument;

        public int InstrumentId { get; set; }

        public List<Image> _images { get; set; }



    }
}