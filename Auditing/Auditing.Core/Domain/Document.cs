﻿using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auditing.Core.Domain
{
    public abstract class Document : IDocument
    {
        public ObjectId Id { get; set; }
    }
}
