﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public class Response
    {
        public object Result { get; set; }
        public string Message { get; set; }
        public Exception Exception { get; set; }
    }
}
