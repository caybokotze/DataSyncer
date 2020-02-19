using System;
using Jessidatasyncer.Logic;

namespace Jessidatasyncer
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSync sync = new DataSync();
            sync.Sync();
        }
    }
}