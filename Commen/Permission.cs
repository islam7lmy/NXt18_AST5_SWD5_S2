using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commen
{
    public class Permission
    {
        public static void AddPErmission(ref PermissionItem Current, params PermissionItem[] PermissionToAdd)
        {
            foreach (PermissionItem item in PermissionToAdd)
                Current |= item;
        }
        
        public static void RemovePErmission(ref PermissionItem Current, params PermissionItem[] PermissionToRemove)
        {
            foreach (PermissionItem item in PermissionToRemove)
                Current &= ~item;
        }
        
        public static bool CheckPermission(PermissionItem Current, PermissionItem PermissionToCheck)
        {
            return (Current & PermissionToCheck) == PermissionToCheck;
        }

        
    }


    [Flags] //data annotation (decrator) => learn new behavior to calc
    public enum PermissionItem : byte //0 : 255
    {
        write = 1,
        read = 2,
        update = 4,
        delete = 8,
        execute = 16,
        select = 32,
        select1 = 64,
        select2 = 128
    }
}
