﻿using Gvs.DataAccess.Core.QueryBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gvs.DataAccess.Mysql {

    public class MysqlQueryBuilder<T> : QueryBuilder<T> where T: class, new() {

    }

}
