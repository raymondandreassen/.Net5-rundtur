using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo1.Server.Services.enums
{
    internal enum enumSrvErrors : ushort
    {
        DbSaveDepartmentError       = 1001,
        DbSaveUserError             = 1002,
        DbSaveEmployeeError         = 1003,
        DbSaveStudentError          = 1004


    }
}
