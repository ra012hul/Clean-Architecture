﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.DomainLayer.Model
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ISBN { get; set; }
        public string AuthorName { get; set; }
    }
}
