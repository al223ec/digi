using System;
using System.Collections.Generic;
using System.Text;

namespace Digitalent.Domain.DbEntities
{
    class Photo
    {
        public int ID { get; set; }
        public int ConsultantID { get; set; }

        public int Width { get; set; }
        public int Height { get; set; }
        public string Url { get; set; }

        public virtual Consultant Consultant { get; set; }
    }
}
